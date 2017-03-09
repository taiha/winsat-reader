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
            barCheck();
        }

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

            lblCpuInfo.Text = "CPU\r\n";
            lblMemInfo.Text = "メモリ (RAM)\r\n";
            lblGfxInfo.Text = "グラフィックス\r\n";
            lblGameInfo.Text = "ゲーム用 グラフィックス\r\n";
            lblDiskInfo.Text = "プライマリ ディスク\r\n";
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
