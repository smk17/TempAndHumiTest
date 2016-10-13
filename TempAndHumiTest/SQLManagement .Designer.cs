namespace TempAndHumiTest
{
    partial class SQLManagement
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
            this.SqlListView = new System.Windows.Forms.ListView();
            this.num = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.modsum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.temp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.humi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelEndTime = new System.Windows.Forms.Label();
            this.labelStartTime = new System.Windows.Forms.Label();
            this.labelModNum = new System.Windows.Forms.Label();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelClose = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.dateTimePickerEndTime = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerStartTime = new System.Windows.Forms.DateTimePicker();
            this.comboBoxNum = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SqlListView
            // 
            this.SqlListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.num,
            this.modsum,
            this.temp,
            this.humi,
            this.time});
            this.SqlListView.Location = new System.Drawing.Point(3, 33);
            this.SqlListView.Name = "SqlListView";
            this.SqlListView.Size = new System.Drawing.Size(600, 495);
            this.SqlListView.TabIndex = 0;
            this.SqlListView.UseCompatibleStateImageBehavior = false;
            this.SqlListView.View = System.Windows.Forms.View.Details;
            // 
            // num
            // 
            this.num.Text = "序号";
            this.num.Width = 40;
            // 
            // modsum
            // 
            this.modsum.Text = "模块序号";
            this.modsum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.modsum.Width = 100;
            // 
            // temp
            // 
            this.temp.Text = "温度";
            this.temp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.temp.Width = 100;
            // 
            // humi
            // 
            this.humi.Text = "湿度";
            this.humi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.humi.Width = 100;
            // 
            // time
            // 
            this.time.Text = "时间";
            this.time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.time.Width = 150;
            // 
            // labelEndTime
            // 
            this.labelEndTime.AutoSize = true;
            this.labelEndTime.Location = new System.Drawing.Point(320, 9);
            this.labelEndTime.Name = "labelEndTime";
            this.labelEndTime.Size = new System.Drawing.Size(65, 12);
            this.labelEndTime.TabIndex = 5;
            this.labelEndTime.Text = "结束时间：";
            // 
            // labelStartTime
            // 
            this.labelStartTime.AutoSize = true;
            this.labelStartTime.Location = new System.Drawing.Point(114, 9);
            this.labelStartTime.Name = "labelStartTime";
            this.labelStartTime.Size = new System.Drawing.Size(65, 12);
            this.labelStartTime.TabIndex = 3;
            this.labelStartTime.Text = "起始时间：";
            // 
            // labelModNum
            // 
            this.labelModNum.AutoSize = true;
            this.labelModNum.Location = new System.Drawing.Point(3, 9);
            this.labelModNum.Name = "labelModNum";
            this.labelModNum.Size = new System.Drawing.Size(65, 12);
            this.labelModNum.TabIndex = 2;
            this.labelModNum.Text = "模块序号：";
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
            this.BtnSearch.Location = new System.Drawing.Point(526, 4);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(77, 23);
            this.BtnSearch.TabIndex = 0;
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
            this.labelTitle.Location = new System.Drawing.Point(8, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(94, 20);
            this.labelTitle.TabIndex = 5;
            this.labelTitle.Text = "数据查看器";
            // 
            // labelClose
            // 
            this.labelClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelClose.Location = new System.Drawing.Point(604, 4);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(25, 25);
            this.labelClose.TabIndex = 6;
            this.labelClose.Text = "×";
            this.labelClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelClose.Click += new System.EventHandler(this.labelClose_Click);
            this.labelClose.MouseEnter += new System.EventHandler(this.labelClose_MouseEnter);
            this.labelClose.MouseLeave += new System.EventHandler(this.labelClose_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.buttonPrev);
            this.panel1.Controls.Add(this.buttonNext);
            this.panel1.Controls.Add(this.dateTimePickerEndTime);
            this.panel1.Controls.Add(this.dateTimePickerStartTime);
            this.panel1.Controls.Add(this.comboBoxNum);
            this.panel1.Controls.Add(this.SqlListView);
            this.panel1.Controls.Add(this.labelModNum);
            this.panel1.Controls.Add(this.labelEndTime);
            this.panel1.Controls.Add(this.BtnSearch);
            this.panel1.Controls.Add(this.labelStartTime);
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel1.Location = new System.Drawing.Point(12, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(611, 561);
            this.panel1.TabIndex = 7;
            // 
            // buttonPrev
            // 
            this.buttonPrev.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.buttonPrev.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.buttonPrev.FlatAppearance.BorderSize = 0;
            this.buttonPrev.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.buttonPrev.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrev.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonPrev.Location = new System.Drawing.Point(5, 534);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(77, 23);
            this.buttonPrev.TabIndex = 14;
            this.buttonPrev.Text = "上一页";
            this.buttonPrev.UseVisualStyleBackColor = false;
            this.buttonPrev.Visible = false;
            // 
            // buttonNext
            // 
            this.buttonNext.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.buttonNext.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.buttonNext.FlatAppearance.BorderSize = 0;
            this.buttonNext.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.buttonNext.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNext.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonNext.Location = new System.Drawing.Point(526, 534);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(77, 23);
            this.buttonNext.TabIndex = 13;
            this.buttonNext.Text = "下一页";
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Visible = false;
            // 
            // dateTimePickerEndTime
            // 
            this.dateTimePickerEndTime.Location = new System.Drawing.Point(391, 6);
            this.dateTimePickerEndTime.Name = "dateTimePickerEndTime";
            this.dateTimePickerEndTime.Size = new System.Drawing.Size(129, 21);
            this.dateTimePickerEndTime.TabIndex = 12;
            // 
            // dateTimePickerStartTime
            // 
            this.dateTimePickerStartTime.Location = new System.Drawing.Point(185, 3);
            this.dateTimePickerStartTime.Name = "dateTimePickerStartTime";
            this.dateTimePickerStartTime.Size = new System.Drawing.Size(129, 21);
            this.dateTimePickerStartTime.TabIndex = 11;
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
            this.comboBoxNum.Location = new System.Drawing.Point(74, 6);
            this.comboBoxNum.Name = "comboBoxNum";
            this.comboBoxNum.Size = new System.Drawing.Size(34, 20);
            this.comboBoxNum.TabIndex = 10;
            this.comboBoxNum.Text = "1";
            // 
            // SQLManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(631, 619);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelClose);
            this.Controls.Add(this.labelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SQLManagement";
            this.Text = "SQLManagement";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView SqlListView;
        private System.Windows.Forms.ColumnHeader num;
        private System.Windows.Forms.ColumnHeader modsum;
        private System.Windows.Forms.ColumnHeader temp;
        private System.Windows.Forms.ColumnHeader humi;
        private System.Windows.Forms.ColumnHeader time;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelEndTime;
        private System.Windows.Forms.Label labelStartTime;
        private System.Windows.Forms.Label labelModNum;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxNum;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartTime;
    }
}