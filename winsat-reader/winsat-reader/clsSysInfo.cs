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
        private string driveModel = "";
        private long driveSize = 0;
        private string mgmtClass = "";
        private ManagementObjectCollection moc = null;
        private DataTable infoDt = null;

        // Category で指定されたClassからデータ取得、"moc" に格納
        public void getSysInfo(string category)
        {
            mgmtClass = category;
            //PropertyDataCollection properties = getSysInfo(info);
            ManagementClass mc = new ManagementClass(category);
            moc = mc.GetInstances();
        }

        // DataTable
        public DataTable getInfoDt(string winclass, bool reload)
        {
            if (mgmtClass != winclass || reload == true)
            {
                getSysInfo(winclass);
            }

            //dt = null;
            infoDt = new DataTable(winclass);
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
            return infoDt;
        }

        // 指定Category内の指定Propertyをreturn（string）
        public string getSysValueStr(string winclass, string property)
        {
            DataRow[] valRows = null;
            string val = "";
            if (mgmtClass != winclass)
            {
                getInfoDt(winclass, false);
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

        // 指定Category内の指定Propertyをreturn（string）, DataTableリロード
        public string getSysValueStrRel(string winclass, string property)
        {
            DataRow[] valRows = null;
            string val = "";
            getInfoDt(winclass, true);

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
                getInfoDt(winclass, false);
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

        // DataTableから指定Propertyの値をreturn（double）, reload
        public double getSysValueDoubleRel(string winclass, string property)
        {
            DataRow[] valRows;
            double val = 0;

            getInfoDt(winclass, true);

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

        // システムディスクのインデックスを取得
        public int getSysDiskIndex()
        {
            int diskIndex = 0;

            getSysInfo("Win32_DiskPartition");
            foreach (ManagementObject mo in moc)
            {
                if (Convert.ToBoolean(mo["Bootable"]))
                {
                    diskIndex = Convert.ToInt32(mo["DiskIndex"]);
                }
            }

            return diskIndex;
        }

        // 取得済みインデックスからシステムディスク情報取得
        public void getSysDiskInfo()
        {
            getSysInfo("Win32_DiskDrive");
            foreach (ManagementObject mo in moc)
            {
                if (Convert.ToInt32(mo["Index"]) == getSysDiskIndex())
                {
                    driveModel = mo["Model"].ToString();
                    driveSize = Convert.ToInt64(mo["Size"]);
                }
            }
        }

        public string driveModelName
        {
            get
            {
                return driveModel;
            }
        }

        public long driveSizeVal
        {
            get
            {
                return driveSize;
            }
        }

        public string getOsBit()
        {
            string osBit = "";
            if (Environment.Is64BitOperatingSystem)
            {
                osBit = "64bit";
            }
            else
            {
                osBit = "32bit";
            }

            return osBit;
        }

        // メモリ フォームファクタ (DIMM, RIMM, SO-DIMM)
        public string getMemForm()
        {
            int formFactor = 0;
            string FormFactorStr = "";

            formFactor = Convert.ToInt32(getSysValueDouble("Win32_PhysicalMemory", "FormFactor"));
            switch (formFactor)
            {
                case 8:
                    FormFactorStr = "DIMM";
                    break;
                case 11:
                    FormFactorStr = "RIMM";
                    break;
                case 12:
                    FormFactorStr = "SO-DIMM";
                    break;
                case 0:
                default:
                    FormFactorStr = "(unknown)";
                    break;
            }

            return FormFactorStr;
        }

        public string getMemType()
        {
            int memType = 0;
            string memTypeStr = "";

            memType = Convert.ToInt32(getSysValueDouble("Win32_PhysicalMemory", "MemoryType"));
            if (memType == 0)
                memType = Convert.ToInt32(getSysValueDouble("Win32_PhysicalMemory", "SMBIOSMemoryType"));

            switch (memType)
            {
                case 20:
                    memTypeStr = "DDR";
                    break;
                case 21:
                case 22:
                    memTypeStr = "DDR2";
                    break;
                case 24:
                    memTypeStr = "DDR3";
                    break;
                case 26:
                    memTypeStr = "DDR4";
                    break;
                default:
                    memTypeStr = "(unknown)";
                    break;
            }

            return memTypeStr;
        }
    }
}
