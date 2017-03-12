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

            valueReset();
            //barCheck();
            setSysInfo();
            setScoreData();
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
            Panel cpuBar = new Panel();
            double cpuScore = clsSI.getSysValueDouble("Win32_WinSAT", "CPUScore");
            width = clsDF.getBarWidth(tblSysScore.Width, tblSysScore.ColumnStyles[2].Width, cpuScore);

            //cpuBar.BorderColor = Color.Salmon;
            cpuBar.BackColor = Color.Salmon;
            cpuBar.Width = width;
            cpuBar.Dock = DockStyle.Left;
            cpuBar.Margin = new Padding(0, 15, 0, 15);
            tblSysScore.Controls.Add(cpuBar, 2, 0);

            Label cpuLbl = new Label();
            cpuLbl.Dock = DockStyle.Right;
            cpuLbl.Width = 70;
            cpuLbl.Margin = new Padding(0);
            cpuLbl.TextAlign = ContentAlignment.MiddleRight;
            cpuLbl.Text = clsDF.conv0_0(cpuScore);
            //cpuLbl.ForeColor = Color.FromArgb(55, 55, 55);
            cpuLbl.ForeColor = Color.White;
            cpuLbl.Font = new Font(new FontFamily("Meiryo"), 20, FontStyle.Bold);
            cpuBar.Controls.Add(cpuLbl);

            // Memory
            //ctlBorderPanel memBar = new ctlBorderPanel();
            Panel memBar = new Panel();
            double memScore = clsSI.getSysValueDouble("Win32_WinSAT", "MemoryScore");
            width = clsDF.getBarWidth(tblSysScore.Width, tblSysScore.ColumnStyles[2].Width, memScore);

            memBar.BackColor = Color.SandyBrown;
            memBar.Width = width;
            memBar.Dock = DockStyle.Left;
            memBar.Margin = new Padding(0, 15, 0, 15);
            tblSysScore.Controls.Add(memBar, 2, 1);

            Label memLbl = new Label();
            memLbl.Dock = DockStyle.Right;
            memLbl.Width = 70;
            memLbl.Margin = new Padding(0);
            memLbl.TextAlign = ContentAlignment.MiddleRight;
            memLbl.Text = clsDF.conv0_0(memScore);
            //memLbl.ForeColor = Color.FromArgb(55, 55, 55);
            memLbl.ForeColor = Color.White;
            memLbl.Font = new Font(new FontFamily("Meiryo"), 20, FontStyle.Bold);
            memBar.Controls.Add(memLbl);

            // Graphics
            Panel gfxBar = new Panel();
            double gfxScore = clsSI.getSysValueDouble("Win32_WinSAT", "GraphicsScore");
            width = clsDF.getBarWidth(tblSysScore.Width, tblSysScore.ColumnStyles[2].Width, gfxScore);

            gfxBar.BackColor = Color.YellowGreen;
            gfxBar.Width = width;
            gfxBar.Dock = DockStyle.Left;
            gfxBar.Margin = new Padding(0, 15, 0, 15);
            tblSysScore.Controls.Add(gfxBar, 2, 2);

            Label gfxLbl = new Label();
            gfxLbl.Dock = DockStyle.Right;
            gfxLbl.Width = 70;
            gfxLbl.Margin = new Padding(0);
            gfxLbl.TextAlign = ContentAlignment.MiddleRight;
            gfxLbl.Text = clsDF.conv0_0(gfxScore);
            //gfxLbl.ForeColor = Color.FromArgb(55, 55, 55);
            gfxLbl.ForeColor = Color.White;
            gfxLbl.Font = new Font(new FontFamily("Meiryo"), 20, FontStyle.Bold);
            gfxBar.Controls.Add(gfxLbl);

            // Game
            Panel gameBar = new Panel();
            double gameScore = clsSI.getSysValueDouble("Win32_WinSAT", "D3DScore");
            width = clsDF.getBarWidth(tblSysScore.Width, tblSysScore.ColumnStyles[2].Width, gameScore);

            gameBar.BackColor = Color.SkyBlue;
            gameBar.Width = width;
            gameBar.Dock = DockStyle.Left;
            gameBar.Margin = new Padding(0, 15, 0, 15);
            tblSysScore.Controls.Add(gameBar, 2, 3);

            Label gameLbl = new Label();
            gameLbl.Dock = DockStyle.Right;
            gameLbl.Width = 70;
            gameLbl.Margin = new Padding(0);
            gameLbl.TextAlign = ContentAlignment.MiddleRight;
            gameLbl.Text = clsDF.conv0_0(gameScore);
            //gameLbl.ForeColor = Color.FromArgb(55, 55, 55);
            gameLbl.ForeColor = Color.White;
            gameLbl.Font = new Font(new FontFamily("Meiryo"), 20, FontStyle.Bold);
            gameBar.Controls.Add(gameLbl);

            // Primary Disk
            Panel diskBar = new Panel();
            double diskScore = clsSI.getSysValueDouble("Win32_WinSAT", "DiskScore");
            width = clsDF.getBarWidth(tblSysScore.Width, tblSysScore.ColumnStyles[2].Width, diskScore);

            diskBar.BackColor = Color.MediumSlateBlue;
            diskBar.Width = width;
            diskBar.Dock = DockStyle.Left;
            diskBar.Margin = new Padding(0, 15, 0, 15);
            tblSysScore.Controls.Add(diskBar, 2, 4);

            Label diskLbl = new Label();
            diskLbl.Dock = DockStyle.Right;
            diskLbl.Width = 70;
            diskLbl.Margin = new Padding(0);
            diskLbl.TextAlign = ContentAlignment.MiddleRight;
            diskLbl.Text = clsDF.conv0_0(diskScore);
            //diskLbl.ForeColor = Color.FromArgb(55, 55, 55);
            diskLbl.ForeColor = Color.White;
            diskLbl.Font = new Font(new FontFamily("Meiryo"), 20, FontStyle.Bold);
            diskBar.Controls.Add(diskLbl);

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

        }
    }
}
