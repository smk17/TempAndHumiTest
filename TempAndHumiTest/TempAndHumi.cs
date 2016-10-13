using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TempAndHumiTest
{
    /// <summary>
    /// 温湿度读数类
    /// </summary>
    class TempAndHumi
    {
        private int _id = 1;
        private double _temp = 0.00;
        private double _humi = 0.00;
        private bool _status = false;
        private bool _teststatus = false;
        private string[] _xunhao = { "A1", "A2", "A3", "A4", "A5", "A6", "A7", "A8", "A9", "A10",
                                     "B1", "B2", "B3", "B4", "B5", "B6", "B7", "B8", "B9", "B10",
                                     "C1", "C2", "C3", "C4", "C5", "C6", "C7", "C8", "C9", "C10",
                                     "D1", "D2", "D3", "D4", "D5", "D6", "D7", "D8", "D9", "D10",
                                     "E1", "E2", "E3", "E4", "E5", "E6", "E7", "E8", "E9", "E10"};

        public TempAndHumi() {}

        public TempAndHumi(int id) { this._id = id; }
        /// <summary>
        /// 创建一个温湿度读数的类
        /// </summary>
        /// <param name="id">编号</param>
        /// <param name="temp">温度读数</param>
        /// <param name="humi">湿度读数</param>
        public TempAndHumi(int id, double temp, double humi) 
        {
            this._id = id;
            this._temp = temp;
            this._humi = humi;
            this._status = true;
        }
        /// <summary>
        /// 编号
        /// </summary>
        public int id
        {
            get { return this._id; }
            set { this._id = value; }
        }
        /// <summary>
        /// 温度读数
        /// </summary>
        public double temp
        {
            get { return this._temp; }
            set { this._temp = value; this._status = true; }
        }
        /// <summary>
        /// 湿度读数
        /// </summary>
        public double humi
        {
            get { return this._humi; }
            set { this._humi = value; this._status = true; }
        }

        /// <summary>
        /// 状态
        /// </summary>
        public bool status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        /// <summary>
        /// 测试状态
        /// </summary>
        public bool teststatus
        {
            get { return this._teststatus; }
            set { this._teststatus = value; }
        }

        private string IdToXunHao()
        {
            //try
            //{
            //    return "(" + _xunhao[id - 1] + ")";
            //}
            //catch (Exception)
            //{
            //    return "";
            //}
            return "      ";
        }

        private string IdToPianHao()
        {
            return "          ";
            //return "编号：";
        }

        /// <summary>
        /// 把该类格式化成字符串
        /// </summary>
        /// <returns>返回一个字符串类型</returns>
        public override String ToString()
        {
            if (this._teststatus)
            {
                return IdToString();
            }
            else
            {
                return StrToString();
            }
        }

        
        private String StrToString()
        {
            if (this._status)
            {
                if (this._humi <= 0)
                {
                    return IdToPianHao() + id + IdToXunHao() + "\n\n\n温度：" + temp.ToString("f1") + "℃";
                }
                else if (this._temp <= -273.15)
                {
                    return IdToPianHao() + id + IdToXunHao() + "\n\n湿度：" + humi.ToString("f1") + "%RH";
                }
                return IdToPianHao() + id + IdToXunHao() + "\n\n温度：" + temp.ToString("f1") + "℃\n\n湿度：" + humi.ToString("f1") + "%RH";
            }
            return IdToPianHao() + id + IdToXunHao() + "\n\n温度：--.--℃\n\n湿度：--.--%RH";            
        }

        private String IdToString()
        {
            return IdToPianHao() + "\n\n" + id + IdToXunHao();
        }

    }
}
