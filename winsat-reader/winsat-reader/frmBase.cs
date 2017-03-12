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

        }

        // toolStrip 評価読み込み
        private void tsLoadEvaluation_Click(object sender, EventArgs e)
        {
            setScoreData();
        }

        // toolStrip バージョン情報
        private void tsVersion_Click(object sender, EventArgs e)
        {
            fV = new frmVersion();
            fV.ShowDialog();
        }
    }
}
