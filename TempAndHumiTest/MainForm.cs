using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Threading;
using System.IO.Ports;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.IO;
using System.Data.SQLite;

namespace TempAndHumiTest
{
    public partial class MainForm : Form
    {
        private delegate void FlushClient();//代理
        //private const int STATUS_DEFAULT = 1;
        //private const int STATUS_FAILURE = 2;
        //private const int STATUS_SUCCESS = 3;

        //private const bool TEST_STATUS = true;

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr SendMessage(IntPtr hwnd, int wMsg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern bool ReleaseCapture();

        private DateTime prvTime = DateTime.MinValue;

        private const int WM_NCHITTEST = 0x0084;
        private const int HT_LEFT = 10;
        private const int HT_RIGHT = 11;
        private const int HT_TOP = 12;
        private const int HT_TOPLEFT = 13;
        private const int HT_TOPRIGHT = 14;
        private const int HT_BOTTOM = 15;
        private const int HT_BOTTOMLEFT = 16;
        private const int HT_BOTTOMRIGHT = 17;
        private const int HT_CAPTION = 2;
        private static int receiveCount = 0;
        private static int catchCount = 0;
        private static int receiveCountMax = 1000;
        private static int receiveCountStatus = 0;
        //private static string TitleName = "温湿度测试软件";
        private static string path = "";
        private static string dbPath = "";
        //private static bool REG_STATUS = false;
        private static bool TestModel_STATUS = false;
        private static bool Threshold_STATUS = false;
        /// <summary>
        /// 温度设定值
        /// </summary>
        private static double TempValue = 25.55;
        /// <summary>
        /// 湿度设定值
        /// </summary>
        private static double HumiValue = 25.55;
        /// <summary>
        /// 温度误差范围
        /// </summary>
        private static double TempMistake = 2.0;
        /// <summary>
        /// 湿度误差范围
        /// </summary>
        private static double HumiMistake = 4.0;
        //private static int[] status;
        /// <summary>
        /// 串口接收的文本信息
        /// </summary>
        private String regMsg = "";
        /// <summary>
        /// 温湿度读数类组
        /// </summary>
        private TempAndHumi[] tandh;
        private bool SelectTestStatus = false;
        private int sts = 0;

        private string AppPath = System.Windows.Forms.Application.StartupPath + "\\config.ini";
        IniPath inipath = new IniPath();


        public MainForm()
        {            
            InitializeComponent();            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //int left = (flowLayoutPanel.Width - 140 * 12) / 2;//110-122
            //int top = (flowLayoutPanel.Height - 145 * 5) / 4;//115-122
            //NamecomboBox.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
            //int left = 0;
            //int top = 0;
            //this.WindowState = FormWindowState.Maximized;
            AutoReSizeForm.SetFormSize(this);
            this.ResizeRedraw = true;
            NamecomboBox.SelectedIndex = 1;
            this.baudcomboBox.SelectedIndex = 9;
            this.ParitycomboBox.SelectedIndex = 0;
            this.DataBitscomboBox.SelectedIndex = 3;
            this.StopBitscomboBox.SelectedIndex = 0;
            this.MouseWheel += FormSample_MouseWheel;
            //对温湿度读数类组进行初始化,一共MOD_TEMPHUMI组
            tandh = new TempAndHumi[Properties.Settings.Default.MOD_TEMPHUMI + 2];

            //自适配分辨率 
            int HW = Screen.PrimaryScreen.Bounds.Width;
            double Width = Math.Abs( (HW - 120)/ Properties.Settings.Default.MOD_COLUMN);
            THlabel.Width = (int)Width;
            THlabel.Height = (int)Width;

            THlabel.Font = new Font(THlabel.Font.FontFamily, Properties.Settings.Default.MOD_FONTSIZE, THlabel.Font.Style);

            //美的版本设置
            //this.settingMenuItem.Visible = false;
            //this.ModeSelectionMenuItem.Visible = false;
            //this.TestModelMenuItem.Visible = false;
            //this.explanationMenuItem.Visible = false;
            //this.label4.Visible = true;
            //this.tBReceiveCount.Visible = true;
            //this.buttonSetting.Visible = true;

            //status = new int[52];
            for (int i = 0; i < tandh.Length; i++)
            {
                tandh[i] = new TempAndHumi(i);
            }
            //if (TEST_STATUS) setTempAndHumi("start({id:1;temp:23.3;humi:78.9}{id:2;temp:23.3;humi:78.9}{id:3;temp:23.3;humi:78.9})end");
            //setStatus(1);
            //初始化模组的文本控件，一共MOD_TEMPHUMI组
            flowLayoutPanel_Load();
            //flowLayoutPanel.Padding = new System.Windows.Forms.Padding(left, top, left, top);
            //string msg = "start({id:1;temp:23.3;humi:78.9}{id:2;temp:23.3;humi:78.9}{id:3;temp:23.3;humi:78.9}{id:4;temp:23.3;humi:78.9}{id:5;temp:23.3;humi:78.9}{id:6;temp:23.3;humi:78.9}{id:7;temp:23.3;humi:78.9}{id:8;temp:23.3;humi:78.9}{id:9;temp:23.3;humi:78.9}{id:11;temp:23.3;humi:78.9}{id:12;temp:23.3;humi:78.9}{id:13;temp:23.3;humi:78.9}{id:14;temp:23.3;humi:78.9}{id:15;temp:23.3;humi:78.9}{id:16;temp:23.3;humi:78.9}{id:17;temp:23.3;humi:78.9}{id:18;temp:23.3;humi:78.9}{id:19;temp:23.3;humi:78.9}{id:21;temp:23.3;humi:78.9}{id:22;temp:23.3;humi:78.9}{id:23;temp:23.3;humi:78.9}{id:24;temp:23.3;humi:78.9}{id:25;temp:33.3;humi:78.9}{id:26;temp:23.3;humi:78.9}{id:27;temp:23.3;humi:78.9}{id:28;temp:23.3;humi:78.9}{id:29;temp:23.3;humi:78.9}{id:31;temp:23.3;humi:78.9}{id:32;temp:23.3;humi:69.9}{id:33;temp:23.3;humi:78.9}{id:34;temp:23.3;humi:78.9}{id:35;temp:23.3;humi:78.9}{id:36;temp:23.3;humi:78.9}{id:37;temp:23.3;humi:78.9}{id:38;temp:23.3;humi:78.9}{id:39;temp:23.3;humi:78.9}{id:41;temp:23.3;humi:78.9}{id:42;temp:23.3;humi:78.9}{id:43;temp:23.3;humi:78.9}{id:44;temp:23.3;humi:78.9}{id:45;temp:23.3;humi:78.9}{id:46;temp:23.3;humi:78.9}{id:47;temp:23.3;humi:78.9}{id:48;temp:23.3;humi:78.9}{id:49;temp:23.3;humi:78.9}{id:10;temp:23.3;humi:78.9}{id:20;temp:23.3;humi:78.9}{id:30;temp:23.3;humi:78.9}{id:40;temp:23.3;humi:78.9}{id:50;temp:23.3;humi:78.9})end";
            //MessageBox.Show(msg.Length.ToString());
            //创建一个线程用来时刻更新UI
            Thread thread = new Thread(CrossThreadFlush);
            thread.IsBackground = true;
            thread.Start();

            this.WindowState = FormWindowState.Maximized;
            path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\TempHumiTest";
            dbPath = path + "\\sql.db3";
            if (Directory.Exists(path) == false)//如果不存在就创建file文件夹
            {
                Directory.CreateDirectory(path);
            }
            inipath.clsIni(path + "\\config.ini");
            path += "\\log.txt";
            if (File.Exists(path))
            {
                //存在文件
                StreamWriter sw = new StreamWriter(path, true);
                sw.WriteLine();
                sw.Close();
            }

            else
            {
                //不存在文件
                File.Create(path);//创建该文件

            }
            
            //如果不存在改数据库文件，则创建该数据库文件 
            if (File.Exists(dbPath))
            {
                SQLiteDBHelper.CreateDB(dbPath);
            }
            SQLiteDBHelper db = new SQLiteDBHelper(dbPath);
            string sql = "CREATE TABLE IF NOT EXISTS  Test3(id integer NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,";
            sql += "Num integer,Temp double,Humi double,Time datetime)";
            db.ExecuteNonQuery(sql, null);
            prvTime = DateTime.Now;
        }

        protected void InsertData(int Num, double Temp, double Humi)
        {
            if (prvTime == DateTime.MinValue)
            {
                prvTime = DateTime.Now;
                InsertData(Num, Temp, Humi, DateTime.Now);
            }else
            {

                if (DateDiff(prvTime, DateTime.Now) > 5)
                {
                    InsertData(Num, Temp, Humi, DateTime.Now);
                }
            }

        }

        protected void InsertData(int Num, double Temp, double Humi, DateTime time)
        {
            string sql = "INSERT INTO Test3(Num,Temp,Humi,Time)values(@Num,@Temp,@Humi,@Time)";
            SQLiteDBHelper db = new SQLiteDBHelper(dbPath);
            SQLiteParameter[] parameters = new SQLiteParameter[]{
                new SQLiteParameter("@Num",Num),
                new SQLiteParameter("@Temp",Temp),
                new SQLiteParameter("@Humi",Humi),
                new SQLiteParameter("@Time",time)
            };
            db.ExecuteNonQuery(sql, parameters);
        }

        /// <summary>
        /// 实现点击任务栏图标正常最小化或还原窗体
        /// </summary>
        protected override CreateParams CreateParams
        {
            get
            {
                const int WS_MINIMIZEBOX = 0x00020000;  // Winuser.h中定义
                CreateParams cp = base.CreateParams;
                cp.Style = cp.Style | WS_MINIMIZEBOX;   // 允许最小化操作
                return cp;
            }
        }
        
        protected override void OnMouseDown(MouseEventArgs e)
        {
            const int WM_NCLBUTTONDOWN = 0x00A1;
            const int HTCAPTION = 2;

            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)  // 按下的是鼠标左键               
            {
                ReleaseCapture();   // 释放捕获                  
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, (IntPtr)HTCAPTION, IntPtr.Zero);    // 拖动窗体               
            }
        }
        private void CrossThreadFlush()
        {
            while (true)
            {
                //将sleep和无限循环放在等待异步的外面
                Thread.Sleep(10);
                ThreadFunction();
            }
        }

        /// <summary>
        /// 子线程，时刻更新UI，根据设置和串口接收数据
        /// </summary>
        private void ThreadFunction()
        {
            try
            {
                
                    

                    //try
                    //{
                    //    List<byte> byteArray = new List<byte>(ConvertHexToBytes(regMsg));
                    //    for (i = 0; i < byteArray.Count; i++)
                    //    {
                    //        if (byteArray[i].Equals((byte)0xfa))
                    //        {
                    //            msgCount++;
                    //        }
                    //    }

                    //    for (i = 0; i < msgCount; i++)
                    //    {
                    //        for (j = 0; j < byteArray.Count; j++)
                    //        {
                    //            if (byteArray[j].Equals((byte)0xfa))
                    //            {
                    //                Index = j + 1;
                    //                break;
                    //            }
                    //        }
                    //        for (j = Index; j < byteArray.Count; j++)
                    //        {
                    //            if (byteArray[j].Equals((byte)0xfb))
                    //            {
                    //                CenterIndex = j + 1;
                    //                break;
                    //            }
                    //        }
                    //        for (j = CenterIndex; j < byteArray.Count; j++)
                    //        {
                    //            if (byteArray[j].Equals((byte)0xff))
                    //            {
                    //                LastIndex = j - 1;
                    //                break;
                    //            }
                    //        }

                    //        if (Index != 0)
                    //        {
                    //            if (LastIndex != 0 && CenterIndex != 0)
                    //            {
                    //                byte[] lenArray = new byte[CenterIndex - Index - 1];
                    //                byte[] msgArray = new byte[LastIndex - CenterIndex + 1];
                    //                byte[] NewRegMsg = new byte[byteArray.Count - LastIndex - 1];
                    //                byteArray.CopyTo(Index, lenArray, 0, CenterIndex - Index - 1);
                    //                byteArray.CopyTo(CenterIndex, msgArray, 0, LastIndex - CenterIndex + 1);
                    //                byteArray.CopyTo(LastIndex, NewRegMsg, 0, byteArray.Count - LastIndex - 1);
                    //                len = int.Parse(Encoding.ASCII.GetString(lenArray));
                    //                receiveCountStatus = 0;
                    //                string msg = Encoding.ASCII.GetString(msgArray);
                    //                if (msg.Length.Equals(len))
                    //                {
                    //                    setTempAndHumi(msg);
                    //                }
                    //                regMsg = ByteToHexStr(NewRegMsg);
                    //            }
                    //        }

                    //    }
                    //}
                    //catch (Exception ex)
                    //{
                    //    //throw ex;
                    //    MessageBox.Show(ex.ToString(), "异常");
                    //    regMsg = "";
                    //    //return;
                    //}
                //比较调用的线程和创建的线程是否为同一线程
                //如果不是，结果为true
                if (statusStrip.InvokeRequired)//等待异步
                {
                    //如果结果为true,则自动通过代理执行else中语句的功能（注意：是else不是IF）
                    //但是执行的功能会始终与else中的指定的功能相同，区别仅是通过代理完成
                    FlushClient fc = new FlushClient(ThreadFunction);
                    this.Invoke(fc);//通过代理调用刷新方法
                }
                else
                {
                    string txt = "";
                    //setTempAndHumi("start({id:1;temp:-23.3;humi:78.9}{id:2;temp:23.3;humi:78.9}{id:3;temp:23.3;humi:78.9})end");
                    //regMsg = "len(44)start({id:1;temp:-23.3;humi:78.9})end";
                    if (regMsg.Equals("")) { }
                    else
                    {
                        int msgCount = 0, Index = 0, LastIndex = 0, CenterIndex = 0, len = 0;
                        try
                        {
                            Index = regMsg.IndexOf("len");
                            if (Index >= 0)
                            {
                                string tmsg = regMsg.Substring(Index).Replace("len", "+len");
                                string[] Msg = tmsg.Split('+');
                                if (Msg.Length > 0)
                                {
                                    string length = "";
                                    string msg = "";                                    
                                    foreach (string rMsg in Msg)
                                    {
                                        CenterIndex = rMsg.IndexOf("start");
                                        LastIndex = rMsg.IndexOf("end");
                                        if (LastIndex > 0 && CenterIndex > 0)
                                        {
                                            LastIndex += 3;                                            
                                            if (LastIndex > CenterIndex)
                                            {
                                                length = rMsg.Substring(0, CenterIndex);
                                                msg = rMsg.Substring(CenterIndex, LastIndex - CenterIndex);
                                                
                                                len = int.Parse(Regex.Replace(length, @"[^\d]*", ""));
                                                msgCount = length.Length + msg.Length;
                                                if (len == msgCount)
                                                {
                                                    setTempAndHumi(msg);
                                                    //receiveCountStatus = 1;
                                                }
                                                regMsg = regMsg.Substring(LastIndex);
                                            }
                                            else
                                            {
                                                StreamWriter sw = new StreamWriter(path, true);
                                                sw.WriteLine(DateTime.Now.ToString() + ":");
                                                sw.Write("LastIndex=" + LastIndex + "CenterIndex=" + CenterIndex);
                                                sw.WriteLine();
                                                sw.Write("RevMsg:" + regMsg);
                                                sw.WriteLine();
                                                sw.Close();
                                            }
                                        }
                                        txt = "LastIndex=" + LastIndex + "CenterIndex=" + CenterIndex;
                                    }


                                
                                    
                                }                                

                            }                            

                        }
                        catch (Exception ex)
                        {
                            catchShow(ex, regMsg);
                            //return;
                        }
                    }
                    txt += "异常计数：" + catchCount + "；";
                    txt += "接收计数：" + receiveCount + "；";
                    txt += "状态计数：" + receiveCountStatus.ToString().PadLeft(receiveCountMax.ToString().Length, '0');
                    txt += "；温度设置值：" + TempValue + "℃；温度误差：±" + TempMistake + "℃；";
                    txt += "湿度设置值：" + HumiValue + "%RH；湿度误差：±" + HumiMistake + "%RH；";
                    txt += "；状态计数最大值：" + receiveCountMax + "；";
                    if (receiveCount == 0)
                    {
                        txt += "宿机已关闭";
                    }
                    else
                    {
                        txt += "宿机已打开";
                        if (receiveCount >= int.MaxValue)
                        {
                            receiveCount = 1;
                        }
                        if (receiveCountStatus >= int.MaxValue)
                        {
                            receiveCountStatus = 1;
                        }
                        
                    }
                    regCountToolStripStatusLabel.Text = txt;                    
                }               
                
                receiveCountStatus++;
                if (receiveCountStatus > receiveCountMax)
                {                    
                    for (int i = 0; i <= Properties.Settings.Default.MOD_TEMPHUMI; i++)
                    {
                        tandh[i].status = false;
                        updataUI(i);
                    }
                    receiveCountStatus = 0;
                    receiveCount = 0;
                }
            }
            catch (System.ObjectDisposedException)
            {
                return;//如果主界面已经退出了，那线程也退出好了。
            }
        }

        /// <summary>
        /// 把串口接收的文本信息进行解析
        /// 并根据解析内容重新设置温湿度类组的值
        /// </summary>
        /// <param name="msg">串口接收的文本信息</param>
        private void setTempAndHumi(String msg)
        {
            int i = 1;
            int j = 0;
            //msg = "start({id:1;temp:23.3;humi:78.9}{id:2;temp:23.3;humi:78.9}{id:3;temp:23.3;humi:78.9})end";
            msg = msg.Substring(6);
            msg = msg.Substring(0, msg.Length - 4);
            String[] msglist = msg.Split('{');
            for (; i < msglist.Length; i++)
            {
                msglist[i] = msglist[i].Substring(0, msglist[i].Length - 1);
                //msglist[i] = "id:1;temp:23.3;humi:78.9";
                String[] list = msglist[i].Split(';');
                if (list.Length == 3)
                {
                    int index = 0;
                    for (j = 0; j < list.Length; j++)
                    {
                        //list[j] = "id:1";                    
                        String[] thlist = list[j].Split(':');
                        if (thlist.Length > 1)
                        {
                            try
                            {
                                switch (j)
                                {
                                    case 0:
                                        index = int.Parse(thlist[1]);
                                        //int t = tandh[index].id;
                                        break;
                                    case 1:
                                        tandh[index].temp = double.Parse(thlist[1].ToString());
                                        break;
                                    case 2:
                                        tandh[index].humi = double.Parse(thlist[1].ToString());
                                        break;
                                    default:
                                        break;
                                }
                            }
                            catch (Exception ex)
                            {
                                catchShow(ex, msg);
                                //return;
                            }                            
                        }
                        
                    }
                    updataUI(index);
                }
                else
                {                    
                    if (msg.IndexOf("fill") > 0)
                    {
                        String[] thlist = list[0].Split(':');
                        try
                        {
                            int index = int.Parse(thlist[1]);
                            tandh[index].status = false;
                            updataUI(index);
                        }
                        catch (Exception ex)
                        {
                            catchShow(ex, msg);
                            //return;
                        }
                    }                    
                }
                
            }
        }
        /// <summary>
        /// 更新UI
        /// </summary>
        /// <param name="index">编号</param>
        private void updataUI(int index)
        {
            try
            {
                Label lb = (Label)(this.flowLayoutPanel.Controls[index + 2]);
                //比较调用的线程和创建的线程是否为同一线程
                //如果不是，结果为true
                if (lb.InvokeRequired)//等待异步
                {
                    //如果结果为true,则自动通过代理执行else中语句的功能（注意：是else不是IF）
                    //但是执行的功能会始终与else中的指定的功能相同，区别仅是通过代理完成
                    FlushClient fc = new FlushClient(ThreadFunction);
                    this.Invoke(fc);//通过代理调用刷新方法
                }
                else
                {
                    //在这里指定如果是同一个线程需要完成什么功能
                    //如果是不同的线程，系统会自动通过代理实现这里指定的功能
                    //lb.Text = TempAndHumiToString(i - 1);
                    //lb.Text = regMsg;
                    lb.Text = tandh[index].ToString();
                    if (tandh[index].teststatus)
                    {
                        lb.Font = new Font(THlabel.Font.FontFamily, THlabel.Font.Size * 2, THlabel.Font.Style);
                    }
                    else
                    {
                        lb.Font = this.THlabel.Font;
                    }
                        //if (tandh[index].status)
                        //{
                        //    lb.BackColor = Color.LawnGreen;//绿色
                        //}
                        //else
                        //{
                        //    lb.BackColor = SystemColors.HotTrack;  //默认
                        //}
                        if (tandh[index].status)
                    {
                        double tMistake, hMistake;
                        //tMistake = TempMistake - 0.5;
                        //hMistake = HumiMistake - 0.5;
                        if ((TempMistake % 2) == 0)
                        {
                            tMistake = TempMistake - TempMistake * 0.25;
                        }
                        else if ((TempMistake % 5) == 0)
                        {
                            tMistake = TempMistake - TempMistake * 0.2;
                        }
                        else
                        {
                            tMistake = TempMistake - TempMistake * 0.2;
                        }

                        if ((HumiMistake % 2) == 0)
                        {
                            hMistake = HumiMistake - HumiMistake * 0.25;
                        }
                        else if ((HumiMistake % 5) == 0)
                        {
                            hMistake = HumiMistake - HumiMistake * 0.2;
                        }
                        else
                        {
                            hMistake = HumiMistake - HumiMistake * 0.2;
                        }

                        if (tandh[index].humi <= 0)
                        {
                            if (((TempValue + TempMistake) >= tandh[index].temp && tandh[index].temp >= (TempValue - TempMistake)))
                            {
                                if (((TempValue + tMistake) >= tandh[index].temp
                                && tandh[index].temp >= (TempValue - tMistake)))
                                {
                                    lb.BackColor = Color.LawnGreen;//绿色，合格
                                }
                                else
                                {
                                    if (Threshold_STATUS)
                                    {
                                        lb.BackColor = Color.Yellow;//橙色，接近不合格的临界值 
                                    }
                                    else
                                    {
                                        lb.BackColor = Color.LawnGreen;//绿色，合格
                                    }
                                }

                            }
                            else
                            {
                                lb.BackColor = Color.Crimson;//红色，不合格
                            }
                        }
                        else if (tandh[index].temp <= -273.15)
                        {
                            if (((HumiValue + HumiMistake) >= tandh[index].humi && tandh[index].humi >= (HumiValue - HumiMistake)))
                            {
                                if (((HumiValue + hMistake) >= tandh[index].humi
                                && tandh[index].humi >= (HumiValue - hMistake)))
                                {
                                    lb.BackColor = Color.LawnGreen;//绿色，合格
                                }
                                else
                                {
                                    if (Threshold_STATUS)
                                    {
                                        lb.BackColor = Color.Yellow;//橙色，接近不合格的临界值 
                                    }
                                    else
                                    {
                                        lb.BackColor = Color.LawnGreen;//绿色，合格
                                    } 
                                }

                            }
                            else
                            {
                                lb.BackColor = Color.Crimson;//红色，不合格
                            }
                        }
                        else
                        {
                            if (((TempValue + TempMistake) >= tandh[index].temp && tandh[index].temp >= (TempValue - TempMistake))
                            && ((HumiValue + HumiMistake) >= tandh[index].humi && tandh[index].humi >= (HumiValue - HumiMistake)))
                            {
                                if (((TempValue + tMistake) >= tandh[index].temp
                                && tandh[index].temp >= (TempValue - tMistake))
                                && ((HumiValue + hMistake) >= tandh[index].humi
                                && tandh[index].humi >= (HumiValue - hMistake)))
                                {
                                    lb.BackColor = Color.LawnGreen;//绿色，合格
                                }
                                else
                                {
                                    if (Threshold_STATUS)
                                    {
                                        lb.BackColor = Color.Yellow;//橙色，接近不合格的临界值 
                                    }
                                    else
                                    {
                                        lb.BackColor = Color.LawnGreen;//绿色，合格
                                    }
                                }

                            }
                            else
                            {
                                lb.BackColor = Color.Crimson;//红色，不合格
                            }
                        }
                        InsertData(index, tandh[index].temp, tandh[index].humi);
                    }
                    else
                    {
                        lb.BackColor = SystemColors.HotTrack;  //默认
                    }
                    
                }
            }
            catch (Exception ex)
            {
                catchShow(ex, regMsg);
                //return;
            }
            
        }
        
        /// <summary>
        /// 初始化模组的文本控件，一共MOD_TEMPHUMI组
        /// </summary>
        private void flowLayoutPanel_Load()
        {
            int i = 1;
            //this.flowLayoutPanel.Controls.Clear();

            //ArrayList list = new ArrayList();
            for (; i <= Properties.Settings.Default.MOD_TEMPHUMI; i++)
            {
                Label lb = new Label();

                lb.Name = "lb" + i;
                lb.Visible = true;
                lb.AutoSize = this.THlabel.AutoSize;
                lb.Text = tandh[i].ToString();
                lb.TextAlign = this.THlabel.TextAlign;
                lb.Padding = this.THlabel.Padding;
                lb.Margin = this.THlabel.Margin;
                lb.Cursor = this.THlabel.Cursor;
                lb.Size = this.THlabel.Size;
                lb.Font = this.THlabel.Font;
                lb.ForeColor = this.THlabel.ForeColor;
                lb.BackColor = SystemColors.HotTrack;
                
                lb.Click += new EventHandler(THlabel_Click);
                if (i != 0)
                {
                    lb.Anchor = AnchorStyles.Top & AnchorStyles.Bottom;
                }
                //list.Add("温度：--.--℃\n湿度：--.--%RH");
                //list.Add(lb);
                this.flowLayoutPanel.Controls.Add(lb);
            }
        }
        /// <summary>
        /// 模组文本控件的点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void THlabel_Click(object sender, EventArgs e)
        {
            Label lb = (Label)sender;
            int index = 0;
            for (int i = 0; i <= Properties.Settings.Default.MOD_TEMPHUMI; i++)
            {
                if (lb.Text.Equals(tandh[i].ToString()))
                {
                    index = i;
                    tandh[i].teststatus = !tandh[i].teststatus;
                }
                updataUI(i);
            }
            if (SelectTestStatus)
            {
                if (sts == 0)
                {
                    sts = index;
                }
                else
                {
                    int i = 0;
                    int max = 0;
                    if(sts > index)
                    {
                        max = sts;
                        i = index;
                    }
                    else
                    {
                        max = index;
                        i = sts; 
                    }
                    Label lb1 = (Label)(this.flowLayoutPanel.Controls[i + 2]);
                    lb1.BackColor = Color.LightCyan;
                    i++;
                    for (;i < max; i++)
                    {   
                        tandh[i].teststatus = !tandh[i].teststatus;
                        updataUI(i);
                        lb1 = (Label)(this.flowLayoutPanel.Controls[i + 2]);
                        lb1.BackColor = Color.LightCyan;
                    }
                    sts = 0;
                }
            }
            lb.BackColor = Color.LightCyan;
        }
        
        /// <summary>
        /// 设置串口参数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SetSerialPortMenuItem_Click(object sender, EventArgs e)
        {
            if (this.groupBox.Visible)
            {
                this.groupBox.Visible = false;
            }
            else
            {                
                String[] portList = SerialPort.GetPortNames();
                if (!(portList.Length == 0))
                {
                    String[] nameList = new string[50];
                    int Index = 0;
                    int i = 0;
                    this.NamecomboBox.Items.CopyTo(nameList, 0);
                    for (; i < portList.Length; i++)
                    {
                        this.NamecomboBox.SelectedItem = portList[i];
                        Index = this.NamecomboBox.SelectedIndex;
                        nameList[Index] = "USB-Serial" + "(" + portList[i] + ")";
                    }                 
                    this.NamecomboBox.Items.Clear();
                    this.NamecomboBox.Items.AddRange(nameList);
                    this.NamecomboBox.SelectedIndex = Index;
                }
                this.groupBox.Visible = true;
                if (this.SettingGroupBox.Visible) this.SettingGroupBox.Visible = false;
            }
        }


        private void BtnOpen_Click(object sender, EventArgs e)
        {
            OpenOrCloseSerialPort(true);
        }

        
        /// <summary>
        /// 将16进制字符串转化为字节数组
        /// </summary>
        /// <param name="value">16进制字符串</param>
        /// <returns>字节数组</returns>
        public static byte[] ConvertHexToBytes(string value)
        {
            int len = value.Length / 2;
            byte[] ret = new byte[len];
            for (int i = 0; i < len; i++)
                ret[i] = (byte)(Convert.ToInt32(value.Substring(i * 2, 2), 16));
            return ret;
        }
        /// <summary>
        /// 函数,字节数组转16进制字符串
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public static string ByteToHexStr(byte[] bytes) 
        {
            string returnStr = "";
            if (bytes != null)
            {
                for (int i = 0; i < bytes.Length; i++)
                {
                    returnStr += bytes[i].ToString("X2");
                }
            }
            return returnStr;
        }
        /// <summary>
        /// 串口接收数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Thread.Sleep(10);
            //MessageBox.Show("serialPort_DataReceived", "Prompting");
            try
            {
                if (this.serialPort.BytesToRead > 0)
                {
                    byte[] buffer = new byte[this.serialPort.BytesToRead];
                    int readCount = this.serialPort.Read(buffer, 0, buffer.Length);
                    if (readCount > 0)
                    {
                        receiveCountStatus = 1;
                        regMsg += Encoding.ASCII.GetString(buffer);
                        //regMsg += ByteToHexStr(buffer);
                        receiveCount++;                        
                    }
                    serialPort.DiscardInBuffer();
                }
            }
            catch (Exception)
            {
                //throw ex;
                return;
            }
            
        }
        /// <summary>
        /// 打开或者关闭设置框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void settingMenuItem_Click(object sender, EventArgs e)
        {
            if (this.SettingGroupBox.Visible)
            {
                this.SettingGroupBox.Visible = false;
            }
            else
            {
                this.textBoxTempValue.Text = TempValue.ToString();
                this.textBoxTempMistake.Text = TempMistake.ToString();
                this.textBoxHumiValue.Text = HumiValue.ToString();
                this.textBoxHumiMistake.Text = HumiMistake.ToString();
                this.textBoxReceiveCount.Text = receiveCountMax.ToString();
                this.SettingGroupBox.Visible = true;
                if (this.groupBox.Visible) this.groupBox.Visible = false;
            }            
        }
        /// <summary>
        /// 设置温湿度等参数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOK_Click(object sender, EventArgs e)
        {
            SetParameterByTempAndHumi(double.Parse(this.textBoxTempValue.Text.ToString()),
                double.Parse(this.textBoxTempMistake.Text.ToString()),
                double.Parse(this.textBoxHumiValue.Text.ToString()),
                double.Parse(this.textBoxHumiMistake.Text.ToString()),
                int.Parse(this.textBoxReceiveCount.Text.ToString()) );
        }        

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (this.groupBox.Visible && !this.SettingGroupBox.Visible)
                {
                    BtnOpen_Click(sender,e);
                }
                if (!this.groupBox.Visible && this.SettingGroupBox.Visible)
                {
                    buttonOK_Click(sender, e);
                }
            }
            else if (e.KeyCode == Keys.ShiftKey)
            {
                SelectTestStatus = true;
                this.TextDataMenuItem.Visible = true;
            }
        }

        private void aboutMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("prvTime:" + prvTime.ToString()+";now:"+DateTime.Now+";"+ DateDiff(DateTime.Now, prvTime));
            
            MessageBox.Show("佛山市川东磁电股份有限公司专用温湿度模块测试软件\r\n作者：张润胜\r\n作者网站：http://smk17.cn/ \r\n公司网站：http://www.cdm21.com/ \r\n", "关于");
        }

        private int DateDiff(DateTime DateTime1, DateTime DateTime2)
        {
            int dateDiff = -1;
            try
            {
                TimeSpan ts1 = new TimeSpan(DateTime1.Ticks);
                TimeSpan ts2 = new TimeSpan(DateTime2.Ticks);
                TimeSpan ts = ts1.Subtract(ts2).Duration();
                dateDiff = (int)ts.TotalSeconds;
                //dateDiff = ts.Days.ToString() + "天"
                //+ ts.Hours.ToString() + "小时"
                //+ ts.Minutes.ToString() + "分钟"
                //+ ts.Seconds.ToString() + "秒";
            }
            catch
            {
            }
            return dateDiff;
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            serialPort.Close();
            this.Close();
        }

        private void labelClose_MouseEnter(object sender, EventArgs e)
        {
            ((Label)sender).BackColor = Color.Crimson;//红色
        }

        private void labelMinimize_Click(object sender, EventArgs e)
        {
            //this.Visible = true;
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void labelMinimize_MouseLeave(object sender, EventArgs e)
        {
            ((Label)sender).BackColor = SystemColors.InactiveCaptionText;
        }

        protected override void WndProc(ref Message Msg)
        {
            if (Msg.Msg == WM_NCHITTEST)
            {
                //获取鼠标位置
                int nPosX = (Msg.LParam.ToInt32() & 65535);
                int nPosY = (Msg.LParam.ToInt32() >> 16);
                //右下角
                if (nPosX >= this.Right - 6 && nPosY >= this.Bottom - 6)
                {
                    Msg.Result = new IntPtr(HT_BOTTOMRIGHT);
                    return;
                }
                //左上角
                else if (nPosX <= this.Left + 6 && nPosY <= this.Top + 6)
                {
                    Msg.Result = new IntPtr(HT_TOPLEFT);
                    return;
                }
                //左下角
                else if (nPosX <= this.Left + 6 && nPosY >= this.Bottom - 6)
                {
                    Msg.Result = new IntPtr(HT_BOTTOMLEFT);
                    return;
                }
                //右上角
                else if (nPosX >= this.Right - 6 && nPosY <= this.Top + 6)
                {
                    Msg.Result = new IntPtr(HT_TOPRIGHT);
                    return;
                }
                else if (nPosX >= this.Right - 2)
                {
                    Msg.Result = new IntPtr(HT_RIGHT);
                    return;
                }
                else if (nPosY >= this.Bottom - 2)
                {
                    Msg.Result = new IntPtr(HT_BOTTOM);
                    return;
                }
                else if (nPosX <= this.Left + 2)
                {
                    Msg.Result = new IntPtr(HT_LEFT);
                    return;
                }
                else if (nPosY <= this.Top + 2)
                {
                    Msg.Result = new IntPtr(HT_TOP);
                    return;
                }
                else
                {
                    Msg.Result = new IntPtr(HT_CAPTION);
                    return;
                }
            }
            base.WndProc(ref Msg);
        }

        public class AutoReSizeForm
        {
            static float SH
            {
                get
                {
                    return (float)Screen.PrimaryScreen.Bounds.Height / Screen.PrimaryScreen.Bounds.Height;
                }
            }
            static float SW
            {
                get
                {
                    return (float)Screen.PrimaryScreen.Bounds.Width / Screen.PrimaryScreen.Bounds.Width;
                }
            }
            public static void SetFormSize(Control fm)
            {
                fm.Location = new Point((int)(fm.Location.X * SW), (int)(fm.Location.Y * SH));
                fm.Size = new Size((int)(fm.Size.Width * SW), (int)(fm.Size.Height * SH));
                fm.Font = new Font(fm.Font.Name, fm.Font.Size * SH, fm.Font.Style, fm.Font.Unit, fm.Font.GdiCharSet, fm.Font.GdiVerticalFont);

                if (fm.Controls.Count != 0)
                {
                    SetControlSize(fm);
                }

            }

            private static void SetControlSize(Control InitC)
            {
                foreach (Control c in InitC.Controls)
                {
                    c.Location = new Point((int)(c.Location.X * SW), (int)(c.Location.Y * SH));
                    c.Size = new Size((int)(c.Size.Width * SW), (int)(c.Size.Height * SH));
                    c.Font = new Font(c.Font.Name, c.Font.Size * SH, c.Font.Style, c.Font.Unit, c.Font.GdiCharSet, c.Font.GdiVerticalFont);
                    if (c.Controls.Count != 0)
                    {
                        SetControlSize(c);
                    }
                }
            }
        }

        /// <summary>
        /// 滚动方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void FormSample_MouseWheel(object sender, MouseEventArgs e)
        {
            //获取光标位置
            Point mousePoint = new Point(e.X, e.Y);
            //换算成相对本窗体的位置
            mousePoint.Offset(this.Location.X, this.Location.Y);
            //判断是否在panel内
            if (flowLayoutPanel.RectangleToScreen(flowLayoutPanel.DisplayRectangle).Contains(mousePoint))
            {
                //滚动
                flowLayoutPanel.AutoScrollPosition = new Point(0, flowLayoutPanel.VerticalScroll.Value - e.Delta);
            }
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (this.Width >= 1360)
            {
                flowLayoutPanel.AutoScroll = false;
                //this.VScroll = false;
                //flowLayoutPanel.VerticalScroll.Visible = false;
            }
            else
            {
                flowLayoutPanel.AutoScroll = true;
                //flowLayoutPanel.VerticalScroll.Minimum = 100;
            }
            this.Refresh();
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {
            //labelTitle.Text = TitleName;
            //labelTitle.Cursor = Cursors.Default;
        }

        private void catchShow(Exception ex,String msg)
        {
            //throw ex;
            //MessageBox.Show(ex.ToString(), "异常");
            catchCount++;
            //labelTitle.Text = TitleName + "---异常:" + ex.ToString();
            //labelTitle.Cursor = Cursors.Hand;
            StreamWriter sw = new StreamWriter(path, true);
            sw.WriteLine(DateTime.Now.ToString() + ":");
            sw.Write("---异常:" + ex.ToString());
            sw.WriteLine();
            sw.Write("---RevMsg:" + msg);
            sw.WriteLine();
            sw.Close();
            regMsg = "";
        }
               

        private void lookLogMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo info = new System.Diagnostics.ProcessStartInfo();
            //info.WorkingDirectory = Application.StartupPath;
            info.FileName = path;
            info.Arguments = "";
            try
            {
                System.Diagnostics.Process.Start(info);
            }
            catch (System.ComponentModel.Win32Exception we)
            {
                MessageBox.Show(this, we.Message);
                return;
            }
        }

        private void ClearLogMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(path);
            sw.WriteLine();
            sw.Close();
        }

        private void TestModelMenuItem_Click(object sender, EventArgs e)
        {
            Label lb = null;
            int i = 1;
            if (TestModel_STATUS)
            {//关闭
                TestModelMenuItem.Text = "开启测试模式(&R)";
                for (; i <= Properties.Settings.Default.MOD_TEMPHUMI; i++)
                {
                    tandh[i].teststatus = false;
                    lb = (Label)(this.flowLayoutPanel.Controls[i + 2]);
                    lb.Text = tandh[i].ToString();
                    lb.Font = this.THlabel.Font;
                }
                //flowLayoutPanel.VerticalScroll.Visible = false;
            }
            else
            {//开启
                TestModelMenuItem.Text = "关闭测试模式(&R)";
                for (; i <= Properties.Settings.Default.MOD_TEMPHUMI; i++)
                {
                    tandh[i].teststatus = true;
                    lb = (Label)(this.flowLayoutPanel.Controls[i + 2]);
                    lb.Text = tandh[i].ToString();
                    lb.Font = new Font(THlabel.Font.FontFamily, 18, THlabel.Font.Style);
                }
                //flowLayoutPanel.VerticalScroll.Visible = true;
            }
            TestModel_STATUS = !TestModel_STATUS;
        }

        private void labelMaximum_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void explanationMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("开启只测试温度模式：\r\n湿度设置值小于或等于0\r\n\r\n开启只测试湿度模式：\r\n温度设置值小于或等于 -273.15 \r\n", "使用说明");
            MessageBox.Show("开启只测试温度模式：\r\n湿度设置值小于或等于0\r\n\r\n开启只测试湿度模式：\r\n温度设置值小于或等于 -273.15 \r\n", "使用说明");
        }

        /// <summary>
        /// 设置温湿度等参数
        /// </summary>
        /// <param name="tempValue">温度值</param>
        /// <param name="tempMistake">温度误差</param>
        /// <param name="humiValue">湿度值</param>
        /// <param name="humiMistake">湿度误差</param>
        /// <param name="countMax">状态计数最大值</param>
        private void SetParameterByTempAndHumi(double tempValue, double tempMistake,
            double humiValue, double humiMistake, int countMax)
        {
            try
            {
                TempValue = tempValue;
                TempMistake = tempMistake;
                HumiValue = humiValue;
                HumiMistake = humiMistake;
                receiveCountMax = countMax;
            }
            catch (Exception ex)
            {
                catchShow(ex, regMsg);
                //return;
            }
            //if (TEST_STATUS) setTempAndHumi("start({id:1;temp:23.3;humi:78.9}{id:2;temp:23.3;humi:78.9}{id:3;status:fill})end");
            this.SettingGroupBox.Visible = false;
            for (int i = 0; i <= Properties.Settings.Default.MOD_TEMPHUMI; i++)
            {
                updataUI(i);
            }
        }

        private void Mode55RHMenuItem_Click(object sender, EventArgs e)
        {
            SetParameterByTempAndHumi(25, 2, 55, 4, 800);
        }

        private void Mode70RHMenuItem_Click(object sender, EventArgs e)
        {
            SetParameterByTempAndHumi(25, 2, 70, 4, 800);
        }

        private void SerialPortMenuItem_Click(object sender, EventArgs e)
        {          
            OpenOrCloseSerialPort(false);
        }

        /// <summary>
        /// 打开（关闭）串口
        /// </summary>
        private void OpenOrCloseSerialPort(bool saveByINI)
        {
            String[] portList = SerialPort.GetPortNames();
            receiveCount = 0;
            //MessageBox.Show(portList[0], "Prompting");
            if (!(portList.Length == 0))
            {
                if (!serialPort.IsOpen)
                {

                    if (saveByINI)
                    {
                        this.serialPort.PortName = this.NamecomboBox.Text.ToString().Substring(11, 4);
                        this.serialPort.BaudRate = int.Parse(this.baudcomboBox.Text);
                        this.serialPort.Parity = (Parity)Enum.Parse(typeof(Parity), this.ParitycomboBox.Text);
                        this.serialPort.DataBits = int.Parse(this.DataBitscomboBox.Text);
                        this.serialPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), this.StopBitscomboBox.Text);
                        inipath.IniWriteValue("serialPort", "PortName", this.serialPort.PortName);
                        inipath.IniWriteValue("serialPort", "BaudRate", this.baudcomboBox.Text);
                        inipath.IniWriteValue("serialPort", "Parity", this.ParitycomboBox.Text);
                        inipath.IniWriteValue("serialPort", "DataBits", this.DataBitscomboBox.Text);
                        inipath.IniWriteValue("serialPort", "StopBits", this.StopBitscomboBox.Text);
                    }
                    else
                    {
                        string PortName = inipath.IniReadValue("serialPort", "PortName");
                        string BaudRate = inipath.IniReadValue("serialPort", "BaudRate");
                        string Parity = inipath.IniReadValue("serialPort", "Parity");
                        string DataBits = inipath.IniReadValue("serialPort", "DataBits");
                        string StopBits = inipath.IniReadValue("serialPort", "StopBits");
                        if (isNoBlankAndNoNull(PortName, BaudRate, Parity, DataBits, StopBits))
                        {
                            this.serialPort.PortName = PortName;
                            this.serialPort.BaudRate = int.Parse(BaudRate);
                            this.serialPort.Parity = (Parity)Enum.Parse(typeof(Parity), Parity);
                            this.serialPort.DataBits = int.Parse(DataBits);
                            this.serialPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), StopBits);
                        }
                        else
                        {
                            MessageBox.Show("第一次打开串口请先设置串口参数", "提示");
                            return;
                        }
                    }
                    try
                    {
                        serialPort.Open();
                        this.BtnOpen.Text = "关闭";
                        this.SerialPortMenuItem.Text = "关闭串口(&C)";

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Prompting");
                        //MessageBox.Show("Port Access is failure，Reset The Serial Basic Information", "Prompting");
                    }
                }
                else
                {
                    serialPort.Close();
                    regMsg = "";
                    for (int i = 0; i <= Properties.Settings.Default.MOD_TEMPHUMI; i++)
                    {
                        tandh[i].status = false;
                        updataUI(i);
                    }
                    this.BtnOpen.Text = "保存并打开";
                    this.SerialPortMenuItem.Text = "打开串口(&C)";
                }
            }
            else
            {
                MessageBox.Show("未检测出串口！", "提示");
            }
            this.groupBox.Visible = false;
        }

        public static bool isNoBlankAndNoNull(String strParm)
        {
            return !((strParm == null) || (strParm == ""));
        }

        public static bool isNoBlankAndNoNull(params string[] strParm)
        {
            int size = strParm.Length;
            for (int i = 0; i < size; i++)
            {
                if (!isNoBlankAndNoNull(strParm[i]))
                    return false;
            }
            return true;
        }

        private void buttonSetting_Click(object sender, EventArgs e)
        {
            try
            {
                receiveCountMax = int.Parse(tBReceiveCount.Text.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "输入错误");
                //MessageBox.Show("Port Access is failure，Reset The Serial Basic Information", "Prompting");
            }
            
        }

        private void ThresholdMenuItem_Click(object sender, EventArgs e)
        {
            Threshold_STATUS = !Threshold_STATUS;
            if (Threshold_STATUS)
            {
                ThresholdMenuItem.Text = "关闭临界值(&V)";
            }
            else
            {
                ThresholdMenuItem.Text = "显示临界值(&V)";
            }
        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ShiftKey)
            {
                SelectTestStatus = false;
                sts = 0;
                this.TextDataMenuItem.Visible = false;
            }
        }

        private void DataSeeMenuItem_Click(object sender, EventArgs e)
        {
            SQLManagement s = new SQLManagement();
            //s.MdiParent = this;
            s.StartPosition = FormStartPosition.CenterScreen;
            s.Show();
        }

        private void WipeDataMenuItem_Click(object sender, EventArgs e)
        {
            SQLiteDBHelper db = new SQLiteDBHelper(dbPath);
            string sql = "UPDATE sqlite_sequence SET seq = 0 ";
            db.ExecuteNonQuery(sql, null);
            sql = "DELETE FROM Test3";
            db.ExecuteNonQuery(sql, null);
        }

        private void DataAnalysisMenuItem_Click(object sender, EventArgs e)
        {
            DataAnalysis s = new DataAnalysis();
            //s.MdiParent = this;
            s.StartPosition = FormStartPosition.CenterScreen;
            s.Show();
        }

        private void TextDataMenuItem_Click(object sender, EventArgs e)
        {
            
            DateTime dt = new DateTime(2016,10,8,6,0,0);
            Random ro = new Random();
            int tempUp = 25;
            int tempDown = 20;
            int humiUp = 85;
            int humiDown = 80;
            int j = 0;
            for(int i = 1; i<= Properties.Settings.Default.MOD_TEMPHUMI; i++)
            {
                tempUp++;
                tempDown++;
                humiUp--;
                humiDown--;
                for (j = 0; j < 600; j++)
                {
                    j++;
                    InsertData(i, (ro.Next(tempDown, tempUp) + ro.NextDouble()), (ro.Next(humiDown, humiUp) + ro.NextDouble()), dt.AddMinutes(j));
                }
            }
            
        }
    }
}
