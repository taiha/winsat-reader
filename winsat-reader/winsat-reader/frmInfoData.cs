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
    public partial class frmInfoData : Form
    {
        DataTable dt = new DataTable();

        public frmInfoData()
        {
            InitializeComponent();
        }

        private void frmInfoData_Load(object sender, EventArgs e)
        {
            dgvInfo.DataSource = dt;
            string tableName = dt.TableName;
            if (tableName == "") tableName = "unknown";
            txtDtInfo.Text = "Class: " + dt.TableName + ", Rows: " + dgvInfo.Rows.Count;
        }

        public void setDt(DataTable dtIn)
        {
            dt = dtIn;
        }
    }
}
