using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Management;

namespace winsat_reader
{
    class clsSysInfo
    {
        private string mgmtClass = "";
        private DataTable infoDt = null;

        // Category で指定されたClassからデータ取得、DataTableに格納してreturn
        public void getSysInfo(string category)
        {
            mgmtClass = category;
            //PropertyDataCollection properties = getSysInfo(info);
            ManagementClass mc = new ManagementClass(category);
            ManagementObjectCollection moc = mc.GetInstances();

            //dt = null;
            infoDt = new DataTable(category);
            infoDt.Columns.Add("NAME");
            infoDt.Columns.Add("VALUE");

            /*以下2重foreachでプロパティの名前と値を取り出しDataTableに格納する。
             * 参考：How to read ManagementObject Collection in WMI using C# - Stack Overflow
             * URL：http://stackoverflow.com/questions/3523844/how-to-read-managementobject-collection-in-wmi-using-c-sharp
             */
            foreach (ManagementObject mo in moc)
            {
                foreach (PropertyData p in mo.Properties)
                {
                    infoDt.Rows.Add(p.Name, p.Value);
                }
            }
        }

        // DataTableそのまんま取得
        public DataTable getInfoDt(string winclass)
        {
            if (mgmtClass != winclass)
            {
                getSysInfo(winclass);
            }
            return infoDt;
        }

        // 指定Category内の指定Propertyをreturn（string）
        public string getSysValueStr(string winclass, string property)
        {
            DataRow[] valRows;
            string val = "";
            if (mgmtClass != winclass)
            {
                getSysInfo(winclass);
            }

            valRows = infoDt.Select("NAME = '" + property + "'");
            if (valRows != null)
            {
                val = valRows[0][1].ToString();
            }
            else
            {
                val = "unknown";
            }


            return val;
        }

        // DataTableから指定Propertyの値をreturn（double）
        public double getSysValueDouble(string winclass, string property)
        {
            DataRow[] valRows;
            double val = 0;

            if (mgmtClass != winclass)
            {
                getSysInfo(winclass);
            }

            valRows = infoDt.Select("NAME = '" + property + "'");
            if (valRows != null)
            {
                val = Convert.ToDouble(valRows[0][1]);
            }
            else
            {
                val = 0;
            }

            return val;
        }

        // システムメモリ総量return（double）
        public long getMemCap()
        {
            long cap = 0;

            getSysInfo("Win32_PhysicalMemory");
            DataRow[] memRows;

            memRows = infoDt.Select("NAME = 'Capacity'");
            for (int i = 0; i < memRows.Count(); i++)
            {
                cap += Convert.ToInt64(memRows[i][1]);
            }
            return cap;
        }

        // 指定Category内の指定Propety有無
        public bool isPropertyExists(string cat, string property)
        {
            bool isExists = false;

            if (infoDt.Select("NAME = '" + property).Length > 0)
            {
                isExists = true;
            }

            return isExists;
        }
    }
}
