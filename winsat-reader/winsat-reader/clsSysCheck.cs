using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winsat_reader
{
    class clsSysCheck
    {
        clsSysInfo clsSI;

        public bool isOem()
        {
            clsSI = new clsSysInfo();
            string computerManuf = "";
            computerManuf = clsSI.getSysValueStr("Win32_ComputerSystem", "Manufacturer");

            if (computerManuf.ToLower() == "to be filled by o.e.m.")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool isACConnected()
        {
            bool isConnected = false;
            PowerLineStatus pwr = SystemInformation.PowerStatus.PowerLineStatus;

            if(pwr == PowerLineStatus.Online)
            {
                isConnected = true;
            }

            return isConnected;
        }

        public int getWinVer()
        {
            clsSI = new clsSysInfo();
            string winNTVerStr = Environment.Version.ToString();
            winNTVerStr = (winNTVerStr.Split('.'))[0] + "." + (winNTVerStr.Split('.'))[1];
            double winNTVer = double.Parse(winNTVerStr);
            int winVer = 0;

            switch (winNTVer)
            {
                case 6.1:
                    winVer = 7;
                    break;
                case 6.2:
                case 6.3:
                    winVer = 8; // Windows 8 / 8.1
                    break;
                case 10.0:
                    winVer = 10;
                    break;
                default:
                    winVer = 0;
                    break;
            }
            //winVer = 7;   //テスト用
            return winVer;
        }
    }
}
