using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TempAndHumiTest
{
    public partial class DataAnalysis : Form
    {
        private static string dbPath = "";
        private List<DataTable> DtList = new List<DataTable>();
        private int index = 0;
        public DataAnalysis()
        {
            InitializeComponent();
            this.comboBoxNum.Items.Clear();
            for (int i = 1; i <= Properties.Settings.Default.MOD_TEMPHUMI; i++)
            {
                this.comboBoxNum.Items.Add(i);
            }
            
            dbPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\TempHumiTest" + "\\sql.db3";

            InitializeChart();
            
            this.chart.GetToolTipText += new EventHandler<ToolTipEventArgs>(chart_GetToolTipText);
            //initialChart(int.Parse(this.comboBoxNum.Text), this.dateTimePicker.Value);
        }
        private void InitializeChart()
        {
            chart.ChartAreas.Clear();
            chart.Series.Clear();

            #region 设置图表的属性  
            //图表的背景色  
            chart.BackColor = Color.FromArgb(211, 223, 240);
            //图表背景色的渐变方式  
            chart.BackGradientStyle = GradientStyle.TopBottom;
            //图表的边框颜色、  
            chart.BorderlineColor = Color.FromArgb(26, 59, 105);
            //图表的边框线条样式  
            chart.BorderlineDashStyle = ChartDashStyle.Solid;
            //图表边框线条的宽度  
            chart.BorderlineWidth = 2;
            //图表边框的皮肤  
            chart.BorderSkin.SkinStyle = BorderSkinStyle.Emboss;
            #endregion

            #region 设置图表的标题  
            Title title = new Title();
            //标题内容  
            title.Text = "温湿度折线图";
            //标题的字体  
            title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12, FontStyle.Bold);
            //标题字体颜色  
            title.ForeColor = Color.FromArgb(26, 59, 105);
            //标题阴影颜色  
            title.ShadowColor = Color.FromArgb(32, 0, 0, 0);
            //标题阴影偏移量  
            title.ShadowOffset = 3;
            chart.Titles.Add(title);
            #endregion

            #region 设置图例的属性  
            //注意，需要把原来控件自带的图例删除掉  
            this.chart.Legends.Clear();

            Legend legend = new Legend("Default");
            legend.Alignment = StringAlignment.Center;
            legend.Docking = Docking.Bottom;
            legend.LegendStyle = LegendStyle.Column;
            this.chart.Legends.Add(legend);

            // Add header separator of type line  
            legend.HeaderSeparator = LegendSeparatorStyle.Line;
            legend.HeaderSeparatorColor = Color.Gray;

            LegendCellColumn firstColumn = new LegendCellColumn();
            firstColumn.ColumnType = LegendCellColumnType.SeriesSymbol;
            firstColumn.HeaderText = "Color";
            firstColumn.HeaderBackColor = Color.WhiteSmoke;
            chart.Legends["Default"].CellColumns.Add(firstColumn);

            // Add Legend Text column  
            LegendCellColumn secondColumn = new LegendCellColumn();
            secondColumn.ColumnType = LegendCellColumnType.Text;
            secondColumn.HeaderText = "Name";
            secondColumn.Text = "#LEGENDTEXT";
            secondColumn.HeaderBackColor = Color.WhiteSmoke;
            chart.Legends["Default"].CellColumns.Add(secondColumn);

            // Add AVG cell column  
            LegendCellColumn avgColumn = new LegendCellColumn();
            avgColumn.Text = "#AVG{N2}";
            avgColumn.HeaderText = "Avg";
            avgColumn.Name = "AvgColumn";
            avgColumn.HeaderBackColor = Color.WhiteSmoke;
            chart.Legends["Default"].CellColumns.Add(avgColumn);

            // Add Total cell column  
            LegendCellColumn totalColumn = new LegendCellColumn();
            totalColumn.Text = "#TOTAL{N1}";
            totalColumn.HeaderText = "Total";
            totalColumn.Name = "TotalColumn";
            totalColumn.HeaderBackColor = Color.WhiteSmoke;
            chart.Legends["Default"].CellColumns.Add(totalColumn);

            // Set Min cell column attributes  
            LegendCellColumn minColumn = new LegendCellColumn();
            minColumn.Text = "#MIN{N1}";
            minColumn.HeaderText = "Min";
            minColumn.Name = "MinColumn";
            minColumn.HeaderBackColor = Color.WhiteSmoke;
            chart.Legends["Default"].CellColumns.Add(minColumn);

            // Set Max cell column attributes  
            LegendCellColumn maxColumn = new LegendCellColumn();
            maxColumn.Text = "#MAX{N1}";
            maxColumn.HeaderText = "Max";
            maxColumn.Name = "MaxColumn";
            maxColumn.HeaderBackColor = Color.WhiteSmoke;
            chart.Legends["Default"].CellColumns.Add(maxColumn);

            #endregion

            #region 设置图表区属性  
            ChartArea chartArea = new ChartArea("Default");
            //设置Y轴刻度间隔大小  
            chartArea.AxisY.Interval = 5;
            //设置Y轴的数据类型格式  
            //chartArea.AxisY.LabelStyle.Format = "C";  
            //设置背景色  
            chartArea.BackColor = Color.FromArgb(64, 165, 191, 228);
            //设置背景渐变方式  
            chartArea.BackGradientStyle = GradientStyle.TopBottom;
            //设置渐变和阴影的辅助背景色  
            chartArea.BackSecondaryColor = Color.White;
            //设置边框颜色  
            chartArea.BorderColor = Color.FromArgb(64, 64, 64, 64);
            //设置阴影颜色  
            chartArea.ShadowColor = Color.Transparent;
            //设置X轴和Y轴线条的颜色  
            chartArea.AxisX.LineColor = Color.FromArgb(64, 64, 64, 64);
            chartArea.AxisY.LineColor = Color.FromArgb(64, 64, 64, 64);
            //开启次要Y轴
            chartArea.AxisY2.Enabled = AxisEnabled.True;
            //设置X轴和Y轴线条的宽度  
            chartArea.AxisX.LineWidth = 1;
            chartArea.AxisY.LineWidth = 1;
            chartArea.AxisY2.LineWidth = 1;
            //设置X轴和Y轴的标题  
            chartArea.AxisX.Title = "采集时间";
            chartArea.AxisY.Title = "温度值";
            chartArea.AxisY2.Title = "湿度值";
            //设置图表区网格横纵线条的颜色  
            chartArea.AxisX.MajorGrid.LineColor = Color.FromArgb(64, 64, 64, 64);
            chartArea.AxisY.MajorGrid.LineColor = Color.FromArgb(64, 64, 64, 64);
            chartArea.AxisY2.MajorGrid.LineColor = Color.FromArgb(64, 64, 64, 64);
            //设置图表区网格横纵线条的宽度  
            chartArea.AxisX.MajorGrid.LineWidth = 1;
            chartArea.AxisY.MajorGrid.LineWidth = 1;
            chartArea.AxisY2.MajorGrid.LineWidth = 1;
            //设置坐标轴刻度线不延长出来  
            chartArea.AxisX.MajorTickMark.Enabled = false;
            chartArea.AxisY.MajorTickMark.Enabled = false;
            chartArea.AxisY2.MajorTickMark.Enabled = false;
            //开启下面两句能够隐藏网格线条  
            //chartArea.AxisX.MajorGrid.Enabled = false;  
            //chartArea.AxisY.MajorGrid.Enabled = false;  
            //设置X轴的显示类型及显示方式  
            chartArea.AxisX.Interval = 0; //设置为0表示由控件自动分配  
            chartArea.AxisX.IntervalAutoMode = IntervalAutoMode.VariableCount;
            chartArea.AxisX.IntervalType = DateTimeIntervalType.Minutes;
            chartArea.AxisX.LabelStyle.IsStaggered = true;
            //chartArea.AxisX.MajorGrid.IntervalType = DateTimeIntervalType.Minutes;  
            //chartArea.AxisX.LabelStyle.IntervalType = DateTimeIntervalType.Minutes;  
            chartArea.AxisX.LabelStyle.Format = "yyyy-MM-dd HH:mm:ss";
            //设置文本角度  
            //chartArea.AxisX.LabelStyle.Angle = 45;  
            //设置文本自适应  
            chartArea.AxisX.IsLabelAutoFit = true;
            //设置X轴允许拖动放大  
            chartArea.CursorX.IsUserEnabled = true;
            chartArea.CursorX.IsUserSelectionEnabled = true;
            chartArea.CursorX.Interval = 0;
            chartArea.CursorX.IntervalOffset = 0;
            chartArea.CursorX.IntervalType = DateTimeIntervalType.Minutes;
            chartArea.AxisX.ScaleView.Zoomable = true;
            chartArea.AxisX.ScrollBar.IsPositionedInside = false;

            //设置中短线（还没看到效果）  
            //chartArea.AxisY.ScaleBreakStyle.Enabled = true;  
            //chartArea.AxisY.ScaleBreakStyle.CollapsibleSpaceThreshold = 47;  
            //chartArea.AxisY.ScaleBreakStyle.BreakLineStyle = BreakLineStyle.Wave;  
            //chartArea.AxisY.ScaleBreakStyle.Spacing = 2;  
            //chartArea.AxisY.ScaleBreakStyle.LineColor = Color.Red;  
            //chartArea.AxisY.ScaleBreakStyle.LineWidth = 10;  

            chart.ChartAreas.Add(chartArea);
            #endregion

            //温度线条：主要曲线  
            Series tempSeries = new Series("温度");
            //设置线条类型  
            tempSeries.ChartType = SeriesChartType.Spline;
            //线条宽度  
            tempSeries.BorderWidth = 1;
            //阴影宽度  
            tempSeries.ShadowOffset = 0;
            //是否显示在图例集合Legends  
            tempSeries.IsVisibleInLegend = true;
            //线条上数据点上是否有数据显示  
            //series.IsValueShownAsLabel = true;
            //线条颜色  
            tempSeries.Color = Color.MediumPurple;
            //设置曲线X轴的显示类型  
            tempSeries.XValueType = ChartValueType.DateTime;
            //设置数据点的类型  
            tempSeries.MarkerStyle = MarkerStyle.Circle;
            //线条数据点的大小  
            tempSeries.MarkerSize = 5;
            //绑定到Y主轴
            tempSeries.YAxisType = AxisType.Primary;
            chart.Series.Add(tempSeries);

            //湿度线条：主要曲线  
            Series humiSeries = new Series("湿度");
            //设置线条类型  
            humiSeries.ChartType = SeriesChartType.Spline;
            //线条宽度  
            humiSeries.BorderWidth = 1;
            //阴影宽度  
            humiSeries.ShadowOffset = 0;
            //是否显示在图例集合Legends  
            humiSeries.IsVisibleInLegend = true;
            //线条上数据点上是否有数据显示  
            //series.IsValueShownAsLabel = true;
            //线条颜色  
            humiSeries.Color = Color.Red;
            //设置曲线X轴的显示类型  
            humiSeries.XValueType = ChartValueType.DateTime;
            //设置数据点的类型  
            humiSeries.MarkerStyle = MarkerStyle.Circle;
            //线条数据点的大小  
            humiSeries.MarkerSize = 5;
            //绑定到Y次轴
            humiSeries.YAxisType = AxisType.Secondary;
            chart.Series.Add(humiSeries);

            //手动构造横坐标数据  
            //DataTable dataTable = new DataTable();
            //dataTable.Columns.Add("TheTime", typeof(DateTime)); //注意typeof  
            //dataTable.Columns.Add("TheValue", typeof(double)); //注意typeof  
            //Random random = new Random(); //随机数  
            //DateTime dateTime = System.DateTime.Now;
            //for (int n = 0; n < 3; n++)
            //{
            //    dateTime = dateTime.AddSeconds(10);
            //    DataRow dr = dataTable.NewRow();
            //    dr["TheTime"] = dateTime;
            //    dr["TheValue"] = random.Next(0, 101);
            //    dataTable.Rows.Add(dr);
            //}
            //for (int n = 3; n < 1000; n++)
            //{
            //    dateTime = dateTime.AddSeconds(30);
            //    DataRow dr = dataTable.NewRow();
            //    dr["TheTime"] = dateTime;
            //    dr["TheValue"] = random.Next(0, 101);
            //    dataTable.Rows.Add(dr);
            //}

            //线条1：下限横线  
            //Series seriesMin = new Series("最小值");
            //seriesMin.ChartType = SeriesChartType.Line;
            //seriesMin.BorderWidth = 1;
            //seriesMin.ShadowOffset = 0;
            //seriesMin.IsVisibleInLegend = true;
            //seriesMin.IsValueShownAsLabel = false;
            //seriesMin.Color = Color.Red;
            //seriesMin.XValueType = ChartValueType.DateTime;
            //seriesMin.MarkerStyle = MarkerStyle.None;
            //chart.Series.Add(seriesMin);

            //线条3：上限横线  
            //Series seriesMax = new Series("最大值");
            //seriesMax.ChartType = SeriesChartType.Line;
            //seriesMax.BorderWidth = 1;
            //seriesMax.ShadowOffset = 0;
            //seriesMax.IsVisibleInLegend = true;
            //seriesMax.IsValueShownAsLabel = false;
            //seriesMax.Color = Color.Red;
            //seriesMax.XValueType = ChartValueType.DateTime;
            //seriesMax.MarkerStyle = MarkerStyle.None;
            //chart.Series.Add(seriesMax);

            //设置X轴的最小值为第一个点的X坐标值  
            //chartArea.AxisX.Minimum = Convert.ToDateTime(dataTable.Rows[0]["TheTime"]).ToOADate();

            //开始画线  
            //foreach (DataRow dr in dataTable.Rows)
            //{
            //    tempSeries.Points.AddXY(dr["TheTime"], dr["TheValue"]);

            //    seriesMin.Points.AddXY(dr["TheTime"], 15); //设置下线为15  
            //    seriesMax.Points.AddXY(dr["TheTime"], 30); //设置上限为30  
            //}
        }

        private void chart_GetToolTipText(object sender, ToolTipEventArgs e)
        {
            if (e.HitTestResult.ChartElementType == ChartElementType.DataPoint)
            {
                int i = e.HitTestResult.PointIndex;
                Series series = e.HitTestResult.Series;
                DataPoint dp = series.Points[i];

                switch (series.Name)
                {
                    case "温度":
                        e.Text = string.Format("温度:{0:F1}℃\r\n采集时间:{1} ", dp.YValues[0], DateTime.FromOADate(dp.XValue));
                        break;
                    case "湿度":
                        e.Text = string.Format("湿度:{0:F1}%RH\r\n采集时间:{1} ", dp.YValues[0], DateTime.FromOADate(dp.XValue));
                        break;
                    default:
                        e.Text = string.Format("数值:{0:F1}\r\n采集时间:{1} ", dp.YValues[0], DateTime.FromOADate(dp.XValue));
                        break;
                }

                
            }
        }

        public void initialChart()
        {
            int Num = int.Parse(this.comboBoxNum.Text);
            DateTime Time = this.dateTimePicker.Value;

            DataTable Dt = new DataTable();
            Dt.Columns.Add("温度", typeof(string));
            Dt.Columns.Add("湿度", typeof(string));
            Dt.Columns.Add("时间", typeof(DateTime));

            string sql = "SELECT * FROM Test3 WHERE Num=@Num AND Time>@StartTime AND Time<@EndTime order by id ";
            SQLiteParameter[] parameters = new SQLiteParameter[]{
                new SQLiteParameter("@Num",Num),
                new SQLiteParameter("@StartTime",Time.Date.ToString("yyyy-MM-dd HH:mm:ss")),
                new SQLiteParameter("@EndTime",Time.Date.AddDays(1).ToString("yyyy-MM-dd HH:mm:ss"))
            };
            SQLiteDBHelper db = new SQLiteDBHelper(dbPath);
            SQLiteDataReader reader = db.ExecuteReader(sql, parameters);
            using (reader)
            {
                int i = 0;
                while (reader.Read())
                {
                    i++;
                    Dt.Rows.Add(reader.GetDouble(2).ToString("#0.00"), reader.GetDouble(3).ToString("#0.00"), reader.GetDateTime(4));
                    if (i == 1500)
                    {
                        DtList.Add(Dt);
                        Dt = new DataTable();
                        Dt.Columns.Add("温度", typeof(string));
                        Dt.Columns.Add("湿度", typeof(string));
                        Dt.Columns.Add("时间", typeof(DateTime));
                        i = 0;
                    }
                }
                if (Dt.Rows.Count != 0) DtList.Add(Dt);

                sql = "SELECT min(Temp),max(Temp),min(Humi),max(Humi) FROM Test3 WHERE Num=@Num AND Time>@StartTime AND Time<@EndTime ";
                reader = db.ExecuteReader(sql, parameters);
                using (reader)
                {
                    while (reader.Read())
                    {
                        this.chart.ChartAreas[0].AxisY.Minimum = int.Parse(reader.GetDouble(0).ToString("#0")) - 20;
                        this.chart.ChartAreas[0].AxisY.Maximum = int.Parse(reader.GetDouble(1).ToString("#0")) + 10;

                        this.chart.ChartAreas[0].AxisY2.Minimum = int.Parse(reader.GetDouble(2).ToString("#0")) - 10;
                        this.chart.ChartAreas[0].AxisY2.Maximum = int.Parse(reader.GetDouble(3).ToString("#0")) + 20;
                    }
                }
                while (this.chart.ChartAreas[0].AxisX.ScaleView.IsZoomed)
                {
                    this.chart.ChartAreas[0].AxisX.ScaleView.ZoomReset();
                }
                this.chart.Series["温度"].Points.DataBind(DtList[index].AsEnumerable(), "时间", "温度", "");
                this.chart.Series["湿度"].Points.DataBind(DtList[index].AsEnumerable(), "时间", "湿度", "");
                this.buttonNext.Visible = true;
                this.labelPage.Text = "0/" + (DtList.Count - 1);
                this.labelPage.Visible = true;
            }

            //MessageBox.Show("该条件下没有数据", "提示");
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
            index = 0;
            this.labelPage.Visible = false;
            this.buttonNext.Visible = false;
            this.buttonPrev.Visible = false;
            DtList.Clear();
            initialChart();
        }

        private void MenuItemExportAll_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBoxType_TextChanged(object sender, EventArgs e)
        {
            SeriesChartType type = SeriesChartType.Line;
            switch (comboBoxType.Text)
            {
                case "折线图":
                    type = SeriesChartType.Line;
                    break;
                case "样条图":
                    type = SeriesChartType.Spline;
                    break;
                case "阶梯线图":
                    type = SeriesChartType.StepLine;
                    break;
                case "快速扫描线图":
                    type = SeriesChartType.FastLine;
                    break;
                default:break;
            }
            this.chart.Series["温度"].ChartType = type;
            this.chart.Series["湿度"].ChartType = type;
        }
        
        private void buttonNext_Click(object sender, EventArgs e)
        {
            buttonPrev.Visible = true;
            if (index < DtList.Count - 1)
            {
                index++;
            }
            if(index == DtList.Count - 1)
            {
                buttonNext.Visible = false;
            }
            while (this.chart.ChartAreas[0].AxisX.ScaleView.IsZoomed)
            {
                this.chart.ChartAreas[0].AxisX.ScaleView.ZoomReset();
            }
            this.chart.Series["温度"].Points.Clear();
            this.chart.Series["湿度"].Points.Clear();
            this.chart.Series["温度"].Points.DataBind(DtList[index].AsEnumerable(), "时间", "温度", "");
            this.chart.Series["湿度"].Points.DataBind(DtList[index].AsEnumerable(), "时间", "湿度", "");
            this.labelPage.Text = index + "/" + (DtList.Count-1);
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            buttonNext.Visible = true;
            if (index > 0)
            {
                index--;
            }
            if(index == 0)
            {
                buttonPrev.Visible = false;
            }
            while (this.chart.ChartAreas[0].AxisX.ScaleView.IsZoomed)
            {
                this.chart.ChartAreas[0].AxisX.ScaleView.ZoomReset();
            }
            this.chart.Series["温度"].Points.Clear();
            this.chart.Series["湿度"].Points.Clear();
            this.chart.Series["温度"].Points.DataBind(DtList[index].AsEnumerable(), "时间", "温度", "");
            this.chart.Series["湿度"].Points.DataBind(DtList[index].AsEnumerable(), "时间", "湿度", "");
            this.labelPage.Text = index+"/" + (DtList.Count - 1);
        }
    }
}
