using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.Diagnostics;

namespace winsat_reader
{
    public partial class frmBase : Form
    {
        // Form
        frmInfoData fID;
        frmVersion fV;

        // Class
        clsSysCheck clsSC;
        clsSysInfo clsSI;
        clsDataFormat clsDF = new clsDataFormat();

        // Variable


        public frmBase()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.UserPaint, true);
        }

        private void frmBase_Load(object sender, EventArgs e)
        {
            clsSI = new clsSysInfo();
            fV = new frmVersion();

            this.Text += " " + fV.AssemblyVersion;
            valueReset();
            //barCheck();
            setSysInfo();
            //setScoreData();
        }

        // 枠線付きPanel
        /*
        private void barCheck()
        {
            int width = 0;
            ctlBorderPanel cpuBar = new ctlBorderPanel();

            width = clsDF.getBarWidth(tblSysScore.Width, tblSysScore.ColumnStyles[2].Width, 1.1);

            cpuBar.BorderColor = Color.Salmon;
            cpuBar.BackColor = Color.White;
            cpuBar.Width = width;
            cpuBar.Dock = DockStyle.Left;
            cpuBar.Margin = new Padding(0, 15, 0, 15);
            tblSysScore.Controls.Add(cpuBar, 2, 0);
        }
        */

        private void valueReset()
        {
            lblOSInfo.Text = "";
            lblMachineInfo.Text = "";

            lblCpuInfo.Text = "プロセッサ\r\n";
            lblMemInfo.Text = "メモリ (RAM)\r\n";
            lblGfxInfo.Text = "グラフィックス\r\n";
            lblGameInfo.Text = "ゲーム用 グラフィックス\r\n";
            lblDiskInfo.Text = "プライマリ ディスク\r\n";

            pnlCpuScore.Width = 1;
            lblCpuScore.Text = "0.0";
            pnlMemScore.Width = 1;
            lblMemScore.Text = "0.0";
            pnlGfxScore.Width = 1;
            lblGfxScore.Text = "0.0";
            pnlGameScore.Width = 1;
            lblGameScore.Text = "0.0";
            pnlDiskScore.Width = 1;
            lblDiskScore.Text = "0.0";
            pnlTotal5.Width = 1;
            lblTotal5.Text = "0.0";
            pnlTotal4.Width = 1;
            lblTotal4.Text = "0.0";
        }

        private void setSysInfo()
        {
            // OS
            clsSC = new clsSysCheck();
            lblOSInfo.Text = string.Format("{0} {1} ({2})",
                clsSI.getSysValueStr("Win32_OperatingSystem", "Caption"),
                clsSI.getOsBit(),
                clsSI.getSysValueStr("Win32_OperatingSystem", "Version"));

            // PC(or MB)
            if (!clsSC.isOem()) // メーカー製PC
            {
                lblMachineInfo.Text = string.Format("{0}  {1}",
                    clsSI.getSysValueStr("Win32_ComputerSystem", "Manufacturer"),
                    clsSI.getSysValueStr("Win32_ComputerSystem", "Model"));
            }
            else
            {                   // BTO, 自作PC
                lblMachineInfo.Text = string.Format("{0}  {1}",
                    clsSI.getSysValueStr("Win32_BaseBoard", "Manufacturer"),
                    clsSI.getSysValueStr("Win32_BaseBoard", "Product"));
            }

            // CPU
            lblCpuInfo.Text += clsSI.getSysValueStr("Win32_Processor", "Name");

            // Memory
            lblMemInfo.Text += string.Format("{0}-{1} {2}  {3}",
                clsSI.getMemType(),
                clsSI.getSysValueStr("Win32_PhysicalMemory", "Speed"),
                clsSI.getMemForm(),
                clsDF.convCap(clsSI.getMemCap(), 0));

            // Graphics
            lblGfxInfo.Text += string.Format("{0}  VRAM: {1}",
                clsSI.getSysValueStr("Win32_VideoController", "Caption"),
                clsDF.convCap(Convert.ToInt64(clsSI.getSysValueDouble("Win32_VideoController", "AdapterRAM")), 0));

            // Primary Disk
            clsSI.getSysDiskInfo();
            lblDiskInfo.Text += string.Format("{0}  {1}",
                clsSI.driveModelName,
                clsDF.convCap(clsSI.driveSizeVal, 0));
        }

        private void chkRunWinsat()
        {
            // クライアント版Windowsか否か
            if (!clsSC.isClientWindows())
            {
                MessageBox.Show("Windows Server環境にはWinSAT.exeが存在しないため、計測を実行できません。\r\nWindows 7からWindows 10までのいずれかの環境を使用してください。", "実行エラー", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            // 電源接続状態
            if (!clsSC.isACConnected())
            {
                MessageBox.Show("コンピューターがAC電源に接続されていないか、接続状態が不明です。WinSATによる評価を実行するには、AC電源に接続されている必要があります。\r\n\r\n電源に接続されていることを確認し、再度評価を実行してください。", "電源エラー", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            runWinsat();
        }

        private void runWinsat()
        {
            Process proc = new Process();
            proc.StartInfo.FileName = "C:\\Windows\\System32\\WinSAT.exe";
            proc.StartInfo.Verb = "runas";
            proc.StartInfo.RedirectStandardOutput = false;
            proc.StartInfo.Arguments = "formal -restart clean";
            proc.Start();

            proc.WaitForExit();
            proc.Close();
        }

        private void chkReadScoreData()
        {
            double winsatState = clsSI.getSysValueDoubleRel("Win32_WinSAT", "WinSATAssessmentState");
            DialogResult result;
            switch (winsatState)
            {
                case 3:
                    result = MessageBox.Show("評価結果が正常に取得できませんでした。\r\n再度評価を実行しますか？", "実行エラー", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    break;
                case 2:
                    result = MessageBox.Show("前回評価時からハードウェア構成が変更されている、またはその他の理由により再評価が必要です。\r\n再度評価を実行しますか？", "情報", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    break;
                default:
                    result = DialogResult.No;
                    break;
            }
            if (result == DialogResult.Yes)
            {
                chkRunWinsat();
                chkReadScoreData();
                return;
            }
            setScoreData();
        }

        private void setScoreData()
        {
            int width = 0;

            // CPU
            double cpuScore = clsSI.getSysValueDouble("Win32_WinSAT", "CPUScore");
            width = clsDF.getBarWidth(tblSysScore.Width, tblSysScore.ColumnStyles[2].Width, cpuScore);

            pnlCpuScore.Width = width;
            lblCpuScore.Text = clsDF.conv0_0(cpuScore);

            // Memory
            double memScore = clsSI.getSysValueDouble("Win32_WinSAT", "MemoryScore");
            width = clsDF.getBarWidth(tblSysScore.Width, tblSysScore.ColumnStyles[2].Width, memScore);

            pnlMemScore.Width = width;
            lblMemScore.Text = clsDF.conv0_0(memScore);

            // Graphics
            double gfxScore = clsSI.getSysValueDouble("Win32_WinSAT", "GraphicsScore");
            width = clsDF.getBarWidth(tblSysScore.Width, tblSysScore.ColumnStyles[2].Width, gfxScore);

            pnlGfxScore.Width = width;
            lblGfxScore.Text = clsDF.conv0_0(gfxScore);

            // Game
            double gameScore = clsSI.getSysValueDouble("Win32_WinSAT", "D3DScore");
            width = clsDF.getBarWidth(tblSysScore.Width, tblSysScore.ColumnStyles[2].Width, gameScore);

            pnlGameScore.Width = width;
            lblGameScore.Text = clsDF.conv0_0(gameScore);

            // Primary Disk
            double diskScore = clsSI.getSysValueDouble("Win32_WinSAT", "DiskScore");
            width = clsDF.getBarWidth(tblSysScore.Width, tblSysScore.ColumnStyles[2].Width, diskScore);

            pnlDiskScore.Width = width;
            lblDiskScore.Text = clsDF.conv0_0(diskScore);

            // Average (Total)
            double scoreTotal5 =
                cpuScore + memScore + gfxScore + gameScore + diskScore;
            double scoreTotal4 =
                cpuScore + memScore + gfxScore + diskScore;

            pnlTotal5.Width = Convert.ToInt32(tblTotal.Width * (scoreTotal5 / (clsDF.getMaxScore() * 5)));
            pnlTotal4.Width = Convert.ToInt32(tblTotal.Width * (scoreTotal4 / (clsDF.getMaxScore() * 5)));

            lblTotal5.Text = clsDF.conv0_0(scoreTotal5);
            lblTotal4.Text = clsDF.conv0_0(scoreTotal4);
        }

        // toolStrip 終了
        private void tsExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // toolStrip 評価実行
        private void tsRunEvaluation_Click(object sender, EventArgs e)
        {
            chkRunWinsat();
            chkReadScoreData();
        }

        // toolStrip 評価読み込み
        private void tsLoadEvaluation_Click(object sender, EventArgs e)
        {
            chkReadScoreData();
        }

        // toolStrip バージョン情報
        private void tsVersion_Click(object sender, EventArgs e)
        {
            fV = new frmVersion();
            fV.ShowDialog();
        }
    }
}
