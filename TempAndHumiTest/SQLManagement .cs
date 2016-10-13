using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TempAndHumiTest
{
    public partial class SQLManagement : Form
    {
        private static string dbPath = "";
        public SQLManagement()
        {
            InitializeComponent();
            this.comboBoxNum.Items.Clear();
            for (int i = 1; i <= Properties.Settings.Default.MOD_TEMPHUMI; i++)
            {
                this.comboBoxNum.Items.Add(i);
            }
            
            dbPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\TempHumiTest" + "\\sql.db3";
            SearchSql("SELECT * FROM Test3 Limit 500");
        }

        private void SearchSql()
        {
            string sql = "SELECT * FROM Test3 WHERE Num=@Num AND Time>@StartTime AND Time<@EndTime order by id";
            SQLiteParameter[] parameters = new SQLiteParameter[]{
                new SQLiteParameter("@Num",int.Parse(this.comboBoxNum.Text)),
                new SQLiteParameter("@StartTime",this.dateTimePickerStartTime.Value.Date.ToString("yyyy-MM-dd HH:mm:ss")),
                new SQLiteParameter("@EndTime",dateTimePickerEndTime.Value.Date.AddDays(1).ToString("yyyy-MM-dd HH:mm:ss"))
            };
            SearchSql(sql, parameters);
        }
        private void SearchSql(string sql, SQLiteParameter[] parameters = null)
        {
            SQLiteDBHelper db = new SQLiteDBHelper(dbPath);

            SQLiteDataReader reader = db.ExecuteReader(sql, parameters);

            using (reader)
            {
                this.SqlListView.BeginUpdate();//数据更新，UI暂时挂起，直到EndUpdate绘制控件，可以有效避免闪烁并大大提高加载速度  
                this.SqlListView.Items.Clear();
                while (reader.Read())
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = reader.GetInt64(0).ToString();//ID
                    lvi.SubItems.Add(reader.GetInt64(1).ToString());//Num
                    lvi.SubItems.Add(reader.GetDouble(2).ToString("#0.00"));//Temp
                    lvi.SubItems.Add(reader.GetDouble(3).ToString("#0.00"));//Humi
                    lvi.SubItems.Add(reader.GetDateTime(4).ToString());//Time

                    this.SqlListView.Items.Add(lvi);
                }
                this.SqlListView.EndUpdate();//结束数据处理，UI界面一次性绘制。  
            }
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelClose_MouseEnter(object sender, EventArgs e)
        {
            ((Label)sender).BackColor = Color.Crimson;//红色
        }

        private void labelClose_MouseLeave(object sender, EventArgs e)
        {
            ((Label)sender).BackColor = SystemColors.InactiveCaptionText;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            SearchSql();
        }
    }
}
