using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }

        private void frmBase_Load(object sender, EventArgs e)
        {
            fID = new frmInfoData();
            clsSI = new clsSysInfo();

            DataTable dt = new DataTable();
            dt = clsSI.getInfoDt("Win32_OperatingSystem");

            fID.setDt(dt);
            fID.Show();
        }
    }
}
