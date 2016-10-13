using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace TempAndHumiTest
{
    class IniPath
    {
        private string _iniPath;

        //声明读写INI文件的API函数

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

        [DllImport("kernel32")]
        private static extern long GetPrivateProfileString(string section, string key, string def, StringBuilder retval,
            int size, string filePath);

        public void clsIni(string iniPath)
        {
            _iniPath = iniPath;
        }

        /// <summary>
        /// 写INI文件
        /// </summary>
        /// <param name="section"></param>
        /// <param name="key"></param>
        /// <param name="val"></param>
        public void IniWriteValue(string section, string key, string val)
        {
            WritePrivateProfileString(section, key ,val, this._iniPath);
        }

        /// <summary>
        /// 读取INI文件，指定的key的值
        /// </summary>
        /// <param name="section"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public string IniReadValue(string section, string key)
        {
            StringBuilder temp = new StringBuilder(255);
            long i = GetPrivateProfileString(section, key, "", temp, 255, this._iniPath);
            return temp.ToString();
        }
    }

}
