using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winsat_reader
{
    class clsDataFormat
    {
        clsSysCheck clsSC;

        private string unitStr = "";

        public string convCap(long byteCap, int dataType)
        {
            string valStr = "";

            if (dataType == 0)
            {
                valStr = conv0_00(convXB(byteCap)) + "" + unitStr;
            }
            else
            {
                valStr = conv0_00(convXiB(byteCap)) + "" + unitStr;
            }

            return valStr;
        }

        public double convXB(long byteVal)
        {
            double xByte = 0;
            xByte = byteVal / (1000 * 1000 * 1000);

            if (xByte >= 1000)
            {
                xByte = xByte / 1000;
                unitStr = "TB";
            }
            else
            {
                unitStr = "GB";
            }
            return xByte;
        }

        public double convXiB(long byteVal)
        {
            double xibiByte = 0;
            xibiByte = byteVal / (1024 * 1024 * 1024);

            if (xibiByte >= 1000)
            {
                xibiByte = xibiByte / 1024;
                unitStr = "TiB";
            }
            else
            {
                unitStr = "GiB";
            }
            return xibiByte;
        }

        // 容量単位取得
        public string unitString
        {
            get
            {
                return unitStr;
            }
        }

        // 文字列 "x.xx" への変換（容量等）
        public string conv0_00(double val)
        {
            string valStr = "";
            valStr = val.ToString("0.00");

            return valStr;
        }

        // 文字列 "x.x" への変換（スコア）
        public string conv0_0(double val)
        {
            string valStr = "";
            valStr = val.ToString("0.0");

            return valStr;
        }

        // スコア表示バーwidth
        public int getBarWidth(double tblWidth, float columnWidth, double score)
        {
            int barWidth = 0;

            /* Column Width: 45%
            * width = tableLayoutPanel.width * (Column.width * 0.01) * Score / Max.Score)
            */
            barWidth = Convert.ToInt32(tblWidth * (columnWidth * 0.01) * (score / getMaxScore()));

            return barWidth;

        }

        // スコア最大値
        public double getMaxScore()
        {
            clsSC = new clsSysCheck();
            double maxScore = 0;

            switch (clsSC.getWinVer())
            {
                case 7:
                    maxScore = 5.9;
                    break;
                case 8:
                case 10:
                    maxScore = 9.9;
                    break;
                default:
                    maxScore = 9.9;
                    break;
            }

            return maxScore;
        }
    }
}
