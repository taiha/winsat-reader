using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winsat_reader
{
	partial class frmBase
	{
		private int GetHKLMRegVal(string path, string prop, ref object ret)
		{
			try
			{
				RegistryKey reg = Registry.LocalMachine.OpenSubKey(path);
				ret = reg.GetValue(prop);
				reg.Close();
			}
			catch
			{
				return 1;
			}
			return 0;
		}

		private string CalcDXVer(uint reg)
		{
			uint major = reg >> 12;
			uint minor = reg >> 8 & 0xFu;

			return major.ToString() + "." + minor.ToString();
		}
	}
}
