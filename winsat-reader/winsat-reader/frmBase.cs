using System;
using System.Collections.Generic;
using System.Management;
using System.Windows.Forms;
using System.Diagnostics;

namespace winsat_reader
{
	public partial class frmBase : Form
	{
		// Variable
		// ref: https://docs.microsoft.com/en-us/windows/win32/cimwin32prov/win32-physicalmemory
		string[] memform = new string[]{
			"(unknown)", "(other)", "SIP", "DIP", "ZIP",
			"SOJ", "Proprietary", "SIMM", "DIMM", "TSOP",
			"PGA", "RIMM", "SO-DIMM", "SRIMM", "SMD",
			"SSMP", "QFP", "TQFP", "SOIC", "LCC",
			"PLCC", "BGA", "FPGBA", "LGA"
		};
		string[] memtype = new string[]
		{
			"(unknown)", "(other)", "DRAM", "Synchronous DRAM", "Chache DRAM",
			"EDO", "EDRAM", "VRAM", "SRAM", "RAM",
			"ROM", "Flash", "EEPROM", "FEPROM", "EPROM",
			"CDRAM", "3DRAM", "SDRAM", "SGRAM", "RDRAM",
			"DDR", "DDR2", "DDR2 FB-DIMM", "(unknown)", "DDR3",
			"FBD2", "DDR4"
		};
		string[] wsat_state_msg = new string[]
		{
			"システム評価の状態が不明です。\r\n",
			"valid",
			"前回評価時からハードウェア構成が変更されている、またはその他の理由により再評価が必要です。\r\n",
			"利用可能な評価結果はありません。\r\n",
			"評価結果が無効です。\r\n"
		};
		private readonly List<WmiStore> os_wmi = new List<WmiStore>();
		private readonly List<WmiStore> cs_wmi = new List<WmiStore>();
		private readonly List<WmiStore> bb_wmi = new List<WmiStore>();
		private readonly List<WmiStore> proc_wmi = new List<WmiStore>();
		private readonly List<WmiStore> pm_wmi = new List<WmiStore>();
		private readonly List<WmiStore> vc_wmi = new List<WmiStore>();
		private List<WmiStore> wsat_wmi = new List<WmiStore>();

		private List<WmiStore> GetWmiProps(string WmiClass)
		{
			List<WmiStore> ret = new List<WmiStore>();
			ManagementClass mc = new ManagementClass(WmiClass);

			foreach (ManagementObject mo in mc.GetInstances())
				foreach (PropertyData p in mo.Properties)
					ret.Add(new WmiStore() { PropName = p.Name, PropValue = p.Value });

			return ret;
		}

		object GetPropValue(string name, List<WmiStore> wmi)
		{
			return wmi.Find(x => x.PropName == name).PropValue;
		}

		private void ResetValueAll()
		{
			lblOSInfo.Text = "";
			lblMachineInfo.Text = "";

			lblCpuInfo.Text = "プロセッサ\r\n";
			lblMemInfo.Text = "メモリ (RAM)\r\n";
			lblGfxInfo.Text = "グラフィックス\r\n";
			lblGameInfo.Text = "ゲーム用 グラフィックス\r\n";
			lblDiskInfo.Text = "プライマリ ディスク\r\n";

			for (int i = 0; i < elementChart.Series.Count; i++)
			{
				elementChart.Series[i].Points[0].YValues[0] = 0;
			}
			totalChart.Series[0].Points[0].YValues[0] =
				totalChart.Series[1].Points[0].YValues[0] = 0;
		}

		// システムディスク情報取得
		private object[] getSysDiskInfo()
		{
			int diskIndex = 0;

			ManagementClass mc = new ManagementClass("Win32_DiskPartition");
			foreach (ManagementObject mo in mc.GetInstances())
			{
				if (Convert.ToBoolean(mo["Bootable"]))
				{
					diskIndex = Convert.ToInt32(mo["DiskIndex"]);
					break;
				}
			}

			object driveModel = null;
			object driveSize = null;
			mc = new ManagementClass("Win32_DiskDrive");
			foreach (ManagementObject mo in mc.GetInstances())
			{
				if (Convert.ToInt32(mo["Index"]) == diskIndex)
				{
					driveModel = mo["Model"];
					driveSize = mo["Size"];
				}
			}

			return new object[] { driveModel, driveSize };
		}

		private void SetSysInfo()
		{
			// OS
			lblOSInfo.Text = string.Format("{0} {1} ({2})",
				GetPropValue("Caption", os_wmi).ToString(),
				GetPropValue("OSArchitecture", os_wmi).ToString(),
				GetPropValue("Version", os_wmi).ToString());

			// PC(or MB)
			if (GetPropValue("Manufacturer", cs_wmi).ToString().ToLower() == "to be filled by o.e.m.")
				lblMachineInfo.Text = string.Format("{0}  {1}",
					GetPropValue("Manufacturer", bb_wmi).ToString(),
					GetPropValue("Product", bb_wmi).ToString());
			else
				lblMachineInfo.Text = string.Format("{0}  {1}",
					GetPropValue("Manufacturer", cs_wmi).ToString(),
					GetPropValue("Model", cs_wmi).ToString());

			// CPU
			lblCpuInfo.Text += GetPropValue("Name", proc_wmi).ToString();

			// Memory
			long totalMem = 0;
			foreach (WmiStore wmi in pm_wmi)
			{
				if (wmi.PropName == "Capacity")
					totalMem += Convert.ToInt64(wmi.PropValue);
			}
			lblMemInfo.Text += string.Format("{0}-{1} {2}  {3}GB",
				memtype[Convert.ToInt32(GetPropValue("MemoryType", pm_wmi)) != 0 ?
					Convert.ToInt32(GetPropValue("MemoryType", pm_wmi)) :
					Convert.ToInt32(GetPropValue("SMBIOSMemoryType", pm_wmi))],
				GetPropValue("Speed", pm_wmi).ToString(),
				memform[Convert.ToInt32(GetPropValue("FormFactor", pm_wmi))],
				(totalMem / (1024 * 1024 * 1024)).ToString("0.00"));

			// Graphics
			lblGfxInfo.Text += string.Format("{0}  VRAM: {1}",
				GetPropValue("Caption", vc_wmi).ToString(),
				(Convert.ToInt64(GetPropValue("AdapterRAM", vc_wmi)) / (1024 * 1024 * 1024)).ToString("0.00") + "GB");

			// GameGraphics
			object reg = null;
			if (GetHKLMRegVal(@"SOFTWARE\Microsoft\DirectX", "MaxFeatureLevel", ref reg) == 0)
				lblGameInfo.Text += string.Format("DirectX {0} (Feature Level)", CalcDXVer(Convert.ToUInt32(reg)));

			// Primary Disk
			object[] diskInfo = getSysDiskInfo();
			lblDiskInfo.Text += string.Format("{0}  {1}",
				diskInfo[0].ToString(),
				Convert.ToInt64(diskInfo[1]) > (1024L * 1024L * 1024L * 1024L) ?
					(Convert.ToInt64(diskInfo[1]) / (1024L * 1024L * 1024L * 1024L)).ToString() + "TB" :
					(Convert.ToInt64(diskInfo[1]) / (1024 * 1024 * 1024)).ToString() + "GB");
		}

		private void SetScoreData()
		{
			double scoreTotal5 = 0;
			double cpuScore = Convert.ToDouble(GetPropValue("CPUScore", wsat_wmi));
			elementChart.Series["serCpu"].Points[0].YValues = new double[] { cpuScore };
			scoreTotal5 += cpuScore;
			scoreTotal5 += elementChart.Series["serMem"].Points[0].YValues[0]
				= Convert.ToDouble(GetPropValue("MemoryScore", wsat_wmi));
			scoreTotal5 += elementChart.Series["serGfx"].Points[0].YValues[0]
				= Convert.ToDouble(GetPropValue("GraphicsScore", wsat_wmi));
			double scoreTotal4 =
			scoreTotal5 += elementChart.Series["serGame"].Points[0].YValues[0]
				= Convert.ToDouble(GetPropValue("D3DScore", wsat_wmi));
			scoreTotal5 += elementChart.Series["serDisk"].Points[0].YValues[0]
				= Convert.ToDouble(GetPropValue("DiskScore", wsat_wmi));

			totalChart.Series[0].Points[0].YValues = new double[] { scoreTotal5 };
			totalChart.Series[1].Points[0].YValues = new double[] { scoreTotal4 };
		}

		private int ChkWinsatAvailability(ref string err, bool isload)
		{
			// クライアント版Windowsか否か
			if (Convert.ToUInt32(GetPropValue("ProductType", os_wmi)) != 1)
			{
				err = "非クライアント版のWindows環境にはWinSAT.exeが存在しないため、計測を実行できません。\r\n"
					+ "Windows 7からWindows 10までのいずれかの環境を使用してください。";
				return 1;
			}
			// 電源接続状態
			if (!isload && SystemInformation.PowerStatus.PowerLineStatus != PowerLineStatus.Online)
			{
				err = "コンピューターがAC電源に接続されていないか、接続状態が不明です。"
					+ "WinSATによる評価を実行するには、AC電源に接続されている必要があります。\r\n\r\n"
					+ "電源に接続されていることを確認し、再度評価を実行してください。";
				return 1;
			}

			return 0;
		}

		private int RunWinsat()
		{
			int ret;
			Process proc = new Process();
			proc.StartInfo.FileName = "C:\\Windows\\System32\\WinSAT.exe";
			proc.StartInfo.Verb = "runas";
			proc.StartInfo.RedirectStandardOutput = false;
			proc.StartInfo.Arguments = "formal -restart clean";
			proc.Start();

			proc.WaitForExit();
			ret = proc.ExitCode;
			proc.Close();

			return ret;
		}

		private uint ChkWinSATState(ref string err)
		{
			wsat_wmi = GetWmiProps("Win32_WinSAT");
			uint stat = Convert.ToUInt32(GetPropValue("WinSATAssessmentState", wsat_wmi));

			err = wsat_state_msg[stat];

			return stat;
		}

		public frmBase()
		{
			InitializeComponent();

			this.SetStyle(ControlStyles.UserPaint, true);

			os_wmi = GetWmiProps("Win32_OperatingSystem");
			cs_wmi = GetWmiProps("Win32_ComputerSystem");
			bb_wmi = GetWmiProps("Win32_BaseBoard");
			proc_wmi = GetWmiProps("Win32_Processor");
			pm_wmi = GetWmiProps("Win32_PhysicalMemory");
			vc_wmi = GetWmiProps("Win32_VideoController");

			// for Windows 7
			if (Environment.OSVersion.Version < new Version(6, 2))
			{
				for (int i = 0; i < elementChart.ChartAreas.Count; i++)
				{
					elementChart.ChartAreas[i].AxisY.Maximum = 6;
					elementChart.ChartAreas[i].AxisY.MajorGrid.Interval = 1;
				}
				totalChart.ChartAreas[0].AxisY.Maximum = 29.5;
			}

			ResetValueAll();
			SetSysInfo();
		}

		private void frmBase_Load(object sender, EventArgs e)
		{

		}

		// toolStrip 終了
		private void tsExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		// toolStrip 評価実行
		private void tsRunEvaluation_Click(object sender, EventArgs e)
		{
			string err = null;
			if (ChkWinsatAvailability(ref err, false) != 0)
			{
				MessageBox.Show(err, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (RunWinsat() != 0)
			{
				MessageBox.Show("システム評価の実行に失敗しました。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (ChkWinSATState(ref err) != 1)
			{
				MessageBox.Show(err + "システムの評価を再実行してください。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			SetScoreData();
		}

		// toolStrip 評価読み込み
		private void tsLoadEvaluation_Click(object sender, EventArgs e)
		{
			string err = null;
			if (ChkWinsatAvailability(ref err, true) != 0)
			{
				MessageBox.Show(err, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			//chkReadScoreData();
			if (ChkWinSATState(ref err) != 1)
			{
				MessageBox.Show(err + "システムの評価を再実行してください。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			SetScoreData();
		}

		// toolStrip バージョン情報
		private void tsVersion_Click(object sender, EventArgs e)
		{
			frmVersion fV = new frmVersion();
			fV.ShowDialog();
		}
	}
}
