namespace TempAndHumiTest
{
    partial class DataAnalysis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxNum = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.panel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemExport = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemExportAll = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelClose = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "模块序号：";
            // 
            // comboBoxNum
            // 
            this.comboBoxNum.FormattingEnabled = true;
            this.comboBoxNum.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxNum.Location = new System.Drawing.Point(74, 35);
            this.comboBoxNum.Name = "comboBoxNum";
            this.comboBoxNum.Size = new System.Drawing.Size(53, 20);
            this.comboBoxNum.TabIndex = 2;
            this.comboBoxNum.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "时间：";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(171, 34);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(129, 21);
            this.dateTimePicker.TabIndex = 4;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.Control;
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.comboBoxType);
            this.panel.Controls.Add(this.chart);
            this.panel.Controls.Add(this.menu);
            this.panel.Controls.Add(this.BtnSearch);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.dateTimePicker);
            this.panel.Controls.Add(this.comboBoxNum);
            this.panel.Controls.Add(this.label2);
            this.panel.Location = new System.Drawing.Point(12, 32);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(975, 496);
            this.panel.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(806, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "设置类型：";
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "折线图",
            "样条图",
            "快速扫描线图",
            "阶梯线图"});
            this.comboBoxType.Location = new System.Drawing.Point(877, 30);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(84, 20);
            this.comboBoxType.TabIndex = 12;
            this.comboBoxType.Text = "样条图";
            this.comboBoxType.TextChanged += new System.EventHandler(this.comboBoxType_TextChanged);
            // 
            // chart
            // 
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX.MajorTickMark.Interval = 0D;
            chartArea1.AxisX.MajorTickMark.IntervalOffset = 0D;
            chartArea1.AxisX.ScaleBreakStyle.Enabled = true;
            chartArea1.AxisX.Title = "采集时间";
            chartArea1.AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea1.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisY.Title = "温度";
            chartArea1.AxisY.TitleAlignment = System.Drawing.StringAlignment.Near;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.HorizontalCenter;
            chartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.InnerPlotPosition.Auto = false;
            chartArea1.InnerPlotPosition.Height = 80F;
            chartArea1.InnerPlotPosition.Width = 94F;
            chartArea1.InnerPlotPosition.X = 4F;
            chartArea1.InnerPlotPosition.Y = 2F;
            chartArea1.IsSameFontSizeForAllAxes = true;
            chartArea1.Name = "TempChartArea";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 45.5F;
            chartArea1.Position.Width = 82.99178F;
            chartArea1.Position.X = 3F;
            chartArea1.Position.Y = 3F;
            chartArea2.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea2.AxisX.Title = "采集时间";
            chartArea2.AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea2.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea2.AxisY.Title = "湿度";
            chartArea2.AxisY.TitleAlignment = System.Drawing.StringAlignment.Near;
            chartArea2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            chartArea2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.HorizontalCenter;
            chartArea2.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea2.InnerPlotPosition.Auto = false;
            chartArea2.InnerPlotPosition.Height = 80F;
            chartArea2.InnerPlotPosition.Width = 94F;
            chartArea2.InnerPlotPosition.X = 4F;
            chartArea2.InnerPlotPosition.Y = 2F;
            chartArea2.IsSameFontSizeForAllAxes = true;
            chartArea2.Name = "HumiChartArea";
            chartArea2.Position.Auto = false;
            chartArea2.Position.Height = 45.5F;
            chartArea2.Position.Width = 82.99178F;
            chartArea2.Position.X = 3F;
            chartArea2.Position.Y = 51.5F;
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.ChartAreas.Add(chartArea2);
            legend1.Name = "Legend";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(0, 61);
            this.chart.Name = "chart";
            series1.ChartArea = "TempChartArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend";
            series1.MarkerBorderColor = System.Drawing.Color.MistyRose;
            series1.MarkerSize = 0;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series1.Name = "温度 ";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            series1.YValuesPerPoint = 6;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.ChartArea = "HumiChartArea";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend";
            series2.MarkerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            series2.MarkerSize = 0;
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series2.Name = "湿度";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chart.Series.Add(series1);
            this.chart.Series.Add(series2);
            this.chart.Size = new System.Drawing.Size(975, 435);
            this.chart.TabIndex = 10;
            this.chart.Text = "chart1";
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(975, 25);
            this.menu.TabIndex = 9;
            this.menu.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemExport,
            this.MenuItemExportAll});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(58, 21);
            this.文件ToolStripMenuItem.Text = "文件(&F)";
            // 
            // MenuItemExport
            // 
            this.MenuItemExport.Name = "MenuItemExport";
            this.MenuItemExport.Size = new System.Drawing.Size(171, 22);
            this.MenuItemExport.Text = "导出(当前条件)(&E)";
            // 
            // MenuItemExportAll
            // 
            this.MenuItemExportAll.Name = "MenuItemExportAll";
            this.MenuItemExportAll.Size = new System.Drawing.Size(171, 22);
            this.MenuItemExportAll.Text = "导出全部(&A)";
            this.MenuItemExportAll.Click += new System.EventHandler(this.MenuItemExportAll_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.BtnSearch.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.BtnSearch.FlatAppearance.BorderSize = 0;
            this.BtnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.BtnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearch.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnSearch.Location = new System.Drawing.Point(306, 33);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(77, 23);
            this.BtnSearch.TabIndex = 5;
            this.BtnSearch.Text = "搜索";
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTitle.Location = new System.Drawing.Point(12, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(77, 20);
            this.labelTitle.TabIndex = 7;
            this.labelTitle.Text = "数据分析";
            // 
            // labelClose
            // 
            this.labelClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelClose.Location = new System.Drawing.Point(974, 0);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(25, 25);
            this.labelClose.TabIndex = 8;
            this.labelClose.Text = "×";
            this.labelClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelClose.Click += new System.EventHandler(this.labelClose_Click);
            this.labelClose.MouseEnter += new System.EventHandler(this.labelClose_MouseEnter);
            this.labelClose.MouseLeave += new System.EventHandler(this.labelClose_MouseLeave);
            // 
            // DataAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(999, 538);
            this.Controls.Add(this.labelClose);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DataAnalysis";
            this.Text = "DataAnalysis";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItemExport;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.ToolStripMenuItem MenuItemExportAll;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxType;
    }
}