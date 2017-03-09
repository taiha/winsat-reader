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

        // Variable
        

        public frmBase()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.UserPaint, true);
        }

        private void frmBase_Load(object sender, EventArgs e)
        {
            fID = new frmInfoData();
            clsSI = new clsSysInfo();

            DataTable dt = new DataTable();
            dt = clsSI.getInfoDt("Win32_OperatingSystem");

            fID.setDt(dt);
            //fID.Show();

            barCheck();
        }

        private void barCheck()
        {
            int width = 0;
            clsBorderPanel cpuBar = new clsBorderPanel();

            /* Column Width: 45%
             * width = tableLayoutPanel.width * (Column.width * 0.01) * Score / Max.Score)
             */
            width = Convert.ToInt32(tblSysScore.Width * (tblSysScore.ColumnStyles[2].Width * 0.01) * (2.2 / 9.9));

            cpuBar.BorderColor = Color.Salmon;
            cpuBar.BackColor = Color.White;
            cpuBar.Width = width;
            cpuBar.Dock = DockStyle.Left;
            cpuBar.Margin = new Padding(0, 15, 0, 15);
            tblSysScore.Controls.Add(cpuBar, 2, 0);

            clsBorderPanel memBar = new clsBorderPanel();

            width = Convert.ToInt32(tblSysScore.Width * (tblSysScore.ColumnStyles[2].Width * 0.01) * (9.9 / 9.9));

            memBar.BorderColor = Color.SandyBrown;
            memBar.BackColor = Color.White;
            memBar.Width = width;
            memBar.Dock = DockStyle.Left;
            memBar.Margin = new Padding(0, 15, 0, 15);
            tblSysScore.Controls.Add(memBar, 2, 1);

            clsBorderPanel gfxBar = new clsBorderPanel();

            width = Convert.ToInt32(tblSysScore.Width * (tblSysScore.ColumnStyles[2].Width * 0.01) * (8.4 / 9.9));
            
            gfxBar.BorderColor = Color.YellowGreen;
            gfxBar.BackColor = Color.White;
            gfxBar.Width = width;
            gfxBar.Dock = DockStyle.Left;
            gfxBar.Margin = new Padding(0, 15, 0, 15);
            tblSysScore.Controls.Add(gfxBar, 2, 2);

        }

        private void valueReset()
        {
            lblOSInfo.Text = "";
            lblMachine.Text = "";
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
