namespace TempAndHumiTest
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.settingMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ModeSelectionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Mode55RHMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Mode70RHMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SetSerialPortMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SerialPortMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ThresholdMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TestModelMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lookLogMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearLogMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SQLManagementMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DataSeeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DataAnalysisMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WipeDataMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TextDataMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.explanationMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SettingGroupBox = new System.Windows.Forms.GroupBox();
            this.textBoxReceiveCount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelHumiUnit = new System.Windows.Forms.Label();
            this.labelTempUnit = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.textBoxHumiMistake = new System.Windows.Forms.TextBox();
            this.textBoxHumiValue = new System.Windows.Forms.TextBox();
            this.textBoxTempMistake = new System.Windows.Forms.TextBox();
            this.textBoxTempValue = new System.Windows.Forms.TextBox();
            this.labelHumiMistake = new System.Windows.Forms.Label();
            this.labelHumiValue = new System.Windows.Forms.Label();
            this.labelTempMistake = new System.Windows.Forms.Label();
            this.labelTempValue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.ParitycomboBox = new System.Windows.Forms.ComboBox();
            this.StopBitscomboBox = new System.Windows.Forms.ComboBox();
            this.DataBitscomboBox = new System.Windows.Forms.ComboBox();
            this.StopBitslabel = new System.Windows.Forms.Label();
            this.DataBitslabel = new System.Windows.Forms.Label();
            this.Paritylabel = new System.Windows.Forms.Label();
            this.baudcomboBox = new System.Windows.Forms.ComboBox();
            this.baudlabel = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.NamecomboBox = new System.Windows.Forms.ComboBox();
            this.BtnOpen = new System.Windows.Forms.Button();
            this.THlabel = new System.Windows.Forms.Label();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelClose = new System.Windows.Forms.Label();
            this.labelMinimize = new System.Windows.Forms.Label();
            this.regCountToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.labelMaximum = new System.Windows.Forms.Label();
            this.tBReceiveCount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonSetting = new System.Windows.Forms.Button();
            this.menu.SuspendLayout();
            this.flowLayoutPanel.SuspendLayout();
            this.SettingGroupBox.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.Control;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingMenuItem,
            this.ModeSelectionMenuItem,
            this.SetSerialPortMenuItem,
            this.SerialPortMenuItem,
            this.ThresholdMenuItem,
            this.TestModelMenuItem,
            this.lookLogMenuItem,
            this.ClearLogMenuItem,
            this.SQLManagementMenuItem,
            this.aboutMenuItem,
            this.explanationMenuItem});
            this.menu.Location = new System.Drawing.Point(10, 30);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1420, 25);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            // 
            // settingMenuItem
            // 
            this.settingMenuItem.Name = "settingMenuItem";
            this.settingMenuItem.Size = new System.Drawing.Size(59, 21);
            this.settingMenuItem.Text = "设置(&S)";
            this.settingMenuItem.Click += new System.EventHandler(this.settingMenuItem_Click);
            // 
            // ModeSelectionMenuItem
            // 
            this.ModeSelectionMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mode55RHMenuItem,
            this.Mode70RHMenuItem});
            this.ModeSelectionMenuItem.Name = "ModeSelectionMenuItem";
            this.ModeSelectionMenuItem.Size = new System.Drawing.Size(84, 21);
            this.ModeSelectionMenuItem.Text = "模式选择(&X)";
            // 
            // Mode55RHMenuItem
            // 
            this.Mode55RHMenuItem.Name = "Mode55RHMenuItem";
            this.Mode55RHMenuItem.Size = new System.Drawing.Size(140, 22);
            this.Mode55RHMenuItem.Text = "模式1(55%)";
            this.Mode55RHMenuItem.Click += new System.EventHandler(this.Mode55RHMenuItem_Click);
            // 
            // Mode70RHMenuItem
            // 
            this.Mode70RHMenuItem.Name = "Mode70RHMenuItem";
            this.Mode70RHMenuItem.Size = new System.Drawing.Size(140, 22);
            this.Mode70RHMenuItem.Text = "模式2(70%)";
            this.Mode70RHMenuItem.Click += new System.EventHandler(this.Mode70RHMenuItem_Click);
            // 
            // SetSerialPortMenuItem
            // 
            this.SetSerialPortMenuItem.Name = "SetSerialPortMenuItem";
            this.SetSerialPortMenuItem.Size = new System.Drawing.Size(110, 21);
            this.SetSerialPortMenuItem.Text = "设定串口参数(&O)";
            this.SetSerialPortMenuItem.Click += new System.EventHandler(this.SetSerialPortMenuItem_Click);
            // 
            // SerialPortMenuItem
            // 
            this.SerialPortMenuItem.Name = "SerialPortMenuItem";
            this.SerialPortMenuItem.Size = new System.Drawing.Size(84, 21);
            this.SerialPortMenuItem.Text = "打开串口(&C)";
            this.SerialPortMenuItem.Click += new System.EventHandler(this.SerialPortMenuItem_Click);
            // 
            // ThresholdMenuItem
            // 
            this.ThresholdMenuItem.Name = "ThresholdMenuItem";
            this.ThresholdMenuItem.Size = new System.Drawing.Size(96, 21);
            this.ThresholdMenuItem.Text = "显示临界值(&V)";
            this.ThresholdMenuItem.Click += new System.EventHandler(this.ThresholdMenuItem_Click);
            // 
            // TestModelMenuItem
            // 
            this.TestModelMenuItem.Name = "TestModelMenuItem";
            this.TestModelMenuItem.Size = new System.Drawing.Size(108, 21);
            this.TestModelMenuItem.Text = "开启测试模式(&R)";
            this.TestModelMenuItem.Click += new System.EventHandler(this.TestModelMenuItem_Click);
            // 
            // lookLogMenuItem
            // 
            this.lookLogMenuItem.Name = "lookLogMenuItem";
            this.lookLogMenuItem.Size = new System.Drawing.Size(108, 21);
            this.lookLogMenuItem.Text = "查看历史记录(&C)";
            this.lookLogMenuItem.Click += new System.EventHandler(this.lookLogMenuItem_Click);
            // 
            // ClearLogMenuItem
            // 
            this.ClearLogMenuItem.Name = "ClearLogMenuItem";
            this.ClearLogMenuItem.Size = new System.Drawing.Size(110, 21);
            this.ClearLogMenuItem.Text = "清空历史记录(&Q)";
            this.ClearLogMenuItem.Click += new System.EventHandler(this.ClearLogMenuItem_Click);
            // 
            // SQLManagementMenuItem
            // 
            this.SQLManagementMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DataSeeMenuItem,
            this.DataAnalysisMenuItem,
            this.WipeDataMenuItem,
            this.TextDataMenuItem});
            this.SQLManagementMenuItem.Name = "SQLManagementMenuItem";
            this.SQLManagementMenuItem.Size = new System.Drawing.Size(68, 21);
            this.SQLManagementMenuItem.Text = "数据管理";
            // 
            // DataSeeMenuItem
            // 
            this.DataSeeMenuItem.Name = "DataSeeMenuItem";
            this.DataSeeMenuItem.Size = new System.Drawing.Size(148, 22);
            this.DataSeeMenuItem.Text = "数据查看器";
            this.DataSeeMenuItem.Click += new System.EventHandler(this.DataSeeMenuItem_Click);
            // 
            // DataAnalysisMenuItem
            // 
            this.DataAnalysisMenuItem.Name = "DataAnalysisMenuItem";
            this.DataAnalysisMenuItem.Size = new System.Drawing.Size(148, 22);
            this.DataAnalysisMenuItem.Text = "数据图表分析";
            this.DataAnalysisMenuItem.Click += new System.EventHandler(this.DataAnalysisMenuItem_Click);
            // 
            // WipeDataMenuItem
            // 
            this.WipeDataMenuItem.Name = "WipeDataMenuItem";
            this.WipeDataMenuItem.Size = new System.Drawing.Size(148, 22);
            this.WipeDataMenuItem.Text = "清空数据";
            this.WipeDataMenuItem.Click += new System.EventHandler(this.WipeDataMenuItem_Click);
            // 
            // TextDataMenuItem
            // 
            this.TextDataMenuItem.Name = "TextDataMenuItem";
            this.TextDataMenuItem.Size = new System.Drawing.Size(148, 22);
            this.TextDataMenuItem.Text = "插入测试数据";
            this.TextDataMenuItem.Visible = false;
            this.TextDataMenuItem.Click += new System.EventHandler(this.TextDataMenuItem_Click);
            // 
            // aboutMenuItem
            // 
            this.aboutMenuItem.Name = "aboutMenuItem";
            this.aboutMenuItem.Size = new System.Drawing.Size(60, 21);
            this.aboutMenuItem.Text = "关于(&A)";
            this.aboutMenuItem.Click += new System.EventHandler(this.aboutMenuItem_Click);
            // 
            // explanationMenuItem
            // 
            this.explanationMenuItem.Name = "explanationMenuItem";
            this.explanationMenuItem.Size = new System.Drawing.Size(82, 21);
            this.explanationMenuItem.Text = "使用说明(&F)";
            this.explanationMenuItem.Click += new System.EventHandler(this.explanationMenuItem_Click);
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel.Controls.Add(this.SettingGroupBox);
            this.flowLayoutPanel.Controls.Add(this.groupBox);
            this.flowLayoutPanel.Controls.Add(this.THlabel);
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel.Location = new System.Drawing.Point(10, 55);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.flowLayoutPanel.Size = new System.Drawing.Size(1420, 813);
            this.flowLayoutPanel.TabIndex = 2;
            // 
            // SettingGroupBox
            // 
            this.SettingGroupBox.Controls.Add(this.textBoxReceiveCount);
            this.SettingGroupBox.Controls.Add(this.label2);
            this.SettingGroupBox.Controls.Add(this.label1);
            this.SettingGroupBox.Controls.Add(this.labelHumiUnit);
            this.SettingGroupBox.Controls.Add(this.labelTempUnit);
            this.SettingGroupBox.Controls.Add(this.buttonOK);
            this.SettingGroupBox.Controls.Add(this.textBoxHumiMistake);
            this.SettingGroupBox.Controls.Add(this.textBoxHumiValue);
            this.SettingGroupBox.Controls.Add(this.textBoxTempMistake);
            this.SettingGroupBox.Controls.Add(this.textBoxTempValue);
            this.SettingGroupBox.Controls.Add(this.labelHumiMistake);
            this.SettingGroupBox.Controls.Add(this.labelHumiValue);
            this.SettingGroupBox.Controls.Add(this.labelTempMistake);
            this.SettingGroupBox.Controls.Add(this.labelTempValue);
            this.SettingGroupBox.Controls.Add(this.label3);
            this.SettingGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingGroupBox.Location = new System.Drawing.Point(5, 15);
            this.SettingGroupBox.Margin = new System.Windows.Forms.Padding(5);
            this.SettingGroupBox.Name = "SettingGroupBox";
            this.SettingGroupBox.Padding = new System.Windows.Forms.Padding(10);
            this.SettingGroupBox.Size = new System.Drawing.Size(350, 122);
            this.SettingGroupBox.TabIndex = 2;
            this.SettingGroupBox.TabStop = false;
            this.SettingGroupBox.Text = "设置";
            this.SettingGroupBox.Visible = false;
            // 
            // textBoxReceiveCount
            // 
            this.textBoxReceiveCount.Location = new System.Drawing.Point(85, 81);
            this.textBoxReceiveCount.Name = "textBoxReceiveCount";
            this.textBoxReceiveCount.Size = new System.Drawing.Size(43, 21);
            this.textBoxReceiveCount.TabIndex = 13;
            this.textBoxReceiveCount.Text = "500";
            this.textBoxReceiveCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxReceiveCount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "%RH";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "℃";
            // 
            // labelHumiUnit
            // 
            this.labelHumiUnit.AutoSize = true;
            this.labelHumiUnit.Location = new System.Drawing.Point(287, 28);
            this.labelHumiUnit.Name = "labelHumiUnit";
            this.labelHumiUnit.Size = new System.Drawing.Size(23, 12);
            this.labelHumiUnit.TabIndex = 10;
            this.labelHumiUnit.Text = "%RH";
            // 
            // labelTempUnit
            // 
            this.labelTempUnit.AutoSize = true;
            this.labelTempUnit.Location = new System.Drawing.Point(131, 29);
            this.labelTempUnit.Name = "labelTempUnit";
            this.labelTempUnit.Size = new System.Drawing.Size(17, 12);
            this.labelTempUnit.TabIndex = 9;
            this.labelTempUnit.Text = "℃";
            // 
            // buttonOK
            // 
            this.buttonOK.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.buttonOK.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.buttonOK.FlatAppearance.BorderSize = 0;
            this.buttonOK.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.buttonOK.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOK.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonOK.Location = new System.Drawing.Point(241, 81);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 8;
            this.buttonOK.Text = "确定";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // textBoxHumiMistake
            // 
            this.textBoxHumiMistake.Location = new System.Drawing.Point(241, 50);
            this.textBoxHumiMistake.Name = "textBoxHumiMistake";
            this.textBoxHumiMistake.Size = new System.Drawing.Size(43, 21);
            this.textBoxHumiMistake.TabIndex = 7;
            this.textBoxHumiMistake.Text = "3";
            this.textBoxHumiMistake.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxHumiMistake.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            // 
            // textBoxHumiValue
            // 
            this.textBoxHumiValue.Location = new System.Drawing.Point(241, 23);
            this.textBoxHumiValue.Name = "textBoxHumiValue";
            this.textBoxHumiValue.Size = new System.Drawing.Size(43, 21);
            this.textBoxHumiValue.TabIndex = 6;
            this.textBoxHumiValue.Text = "25.55";
            this.textBoxHumiValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxHumiValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            // 
            // textBoxTempMistake
            // 
            this.textBoxTempMistake.Location = new System.Drawing.Point(85, 54);
            this.textBoxTempMistake.Name = "textBoxTempMistake";
            this.textBoxTempMistake.Size = new System.Drawing.Size(43, 21);
            this.textBoxTempMistake.TabIndex = 5;
            this.textBoxTempMistake.Text = "3";
            this.textBoxTempMistake.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxTempMistake.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            // 
            // textBoxTempValue
            // 
            this.textBoxTempValue.Location = new System.Drawing.Point(85, 24);
            this.textBoxTempValue.Name = "textBoxTempValue";
            this.textBoxTempValue.Size = new System.Drawing.Size(43, 21);
            this.textBoxTempValue.TabIndex = 4;
            this.textBoxTempValue.Text = "25.55";
            this.textBoxTempValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxTempValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            // 
            // labelHumiMistake
            // 
            this.labelHumiMistake.AutoSize = true;
            this.labelHumiMistake.Location = new System.Drawing.Point(171, 57);
            this.labelHumiMistake.Name = "labelHumiMistake";
            this.labelHumiMistake.Size = new System.Drawing.Size(77, 12);
            this.labelHumiMistake.TabIndex = 3;
            this.labelHumiMistake.Text = "湿度误差：±";
            // 
            // labelHumiValue
            // 
            this.labelHumiValue.AutoSize = true;
            this.labelHumiValue.Location = new System.Drawing.Point(171, 27);
            this.labelHumiValue.Name = "labelHumiValue";
            this.labelHumiValue.Size = new System.Drawing.Size(77, 12);
            this.labelHumiValue.TabIndex = 2;
            this.labelHumiValue.Text = "湿度设置值：";
            // 
            // labelTempMistake
            // 
            this.labelTempMistake.AutoSize = true;
            this.labelTempMistake.Location = new System.Drawing.Point(15, 59);
            this.labelTempMistake.Name = "labelTempMistake";
            this.labelTempMistake.Size = new System.Drawing.Size(77, 12);
            this.labelTempMistake.TabIndex = 1;
            this.labelTempMistake.Text = "温度误差：±";
            // 
            // labelTempValue
            // 
            this.labelTempValue.AutoSize = true;
            this.labelTempValue.Location = new System.Drawing.Point(13, 27);
            this.labelTempValue.Name = "labelTempValue";
            this.labelTempValue.Size = new System.Drawing.Size(77, 12);
            this.labelTempValue.TabIndex = 0;
            this.labelTempValue.Text = "温度设置值：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "状态计数值：";
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.ParitycomboBox);
            this.groupBox.Controls.Add(this.StopBitscomboBox);
            this.groupBox.Controls.Add(this.DataBitscomboBox);
            this.groupBox.Controls.Add(this.StopBitslabel);
            this.groupBox.Controls.Add(this.DataBitslabel);
            this.groupBox.Controls.Add(this.Paritylabel);
            this.groupBox.Controls.Add(this.baudcomboBox);
            this.groupBox.Controls.Add(this.baudlabel);
            this.groupBox.Controls.Add(this.labelName);
            this.groupBox.Controls.Add(this.NamecomboBox);
            this.groupBox.Controls.Add(this.BtnOpen);
            this.groupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox.Location = new System.Drawing.Point(365, 15);
            this.groupBox.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox.Name = "groupBox";
            this.groupBox.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox.Size = new System.Drawing.Size(350, 122);
            this.groupBox.TabIndex = 1;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "设定串口参数";
            this.groupBox.Visible = false;
            // 
            // ParitycomboBox
            // 
            this.ParitycomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ParitycomboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ParitycomboBox.FormattingEnabled = true;
            this.ParitycomboBox.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Space",
            "Mark"});
            this.ParitycomboBox.Location = new System.Drawing.Point(63, 78);
            this.ParitycomboBox.Name = "ParitycomboBox";
            this.ParitycomboBox.Size = new System.Drawing.Size(121, 20);
            this.ParitycomboBox.TabIndex = 10;
            this.ParitycomboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            // 
            // StopBitscomboBox
            // 
            this.StopBitscomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StopBitscomboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StopBitscomboBox.FormattingEnabled = true;
            this.StopBitscomboBox.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.StopBitscomboBox.Location = new System.Drawing.Point(249, 46);
            this.StopBitscomboBox.Name = "StopBitscomboBox";
            this.StopBitscomboBox.Size = new System.Drawing.Size(80, 20);
            this.StopBitscomboBox.TabIndex = 9;
            this.StopBitscomboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            // 
            // DataBitscomboBox
            // 
            this.DataBitscomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DataBitscomboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DataBitscomboBox.FormattingEnabled = true;
            this.DataBitscomboBox.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.DataBitscomboBox.Location = new System.Drawing.Point(249, 19);
            this.DataBitscomboBox.Name = "DataBitscomboBox";
            this.DataBitscomboBox.Size = new System.Drawing.Size(80, 20);
            this.DataBitscomboBox.TabIndex = 8;
            this.DataBitscomboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            // 
            // StopBitslabel
            // 
            this.StopBitslabel.AutoSize = true;
            this.StopBitslabel.Location = new System.Drawing.Point(197, 51);
            this.StopBitslabel.Name = "StopBitslabel";
            this.StopBitslabel.Size = new System.Drawing.Size(53, 12);
            this.StopBitslabel.TabIndex = 7;
            this.StopBitslabel.Text = "停止位：";
            // 
            // DataBitslabel
            // 
            this.DataBitslabel.AutoSize = true;
            this.DataBitslabel.Location = new System.Drawing.Point(197, 24);
            this.DataBitslabel.Name = "DataBitslabel";
            this.DataBitslabel.Size = new System.Drawing.Size(53, 12);
            this.DataBitslabel.TabIndex = 6;
            this.DataBitslabel.Text = "数据位：";
            // 
            // Paritylabel
            // 
            this.Paritylabel.AutoSize = true;
            this.Paritylabel.Location = new System.Drawing.Point(13, 83);
            this.Paritylabel.Name = "Paritylabel";
            this.Paritylabel.Size = new System.Drawing.Size(53, 12);
            this.Paritylabel.TabIndex = 5;
            this.Paritylabel.Text = "效验位：";
            // 
            // baudcomboBox
            // 
            this.baudcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.baudcomboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.baudcomboBox.FormattingEnabled = true;
            this.baudcomboBox.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "28800",
            "36000",
            "115200"});
            this.baudcomboBox.Location = new System.Drawing.Point(63, 49);
            this.baudcomboBox.Name = "baudcomboBox";
            this.baudcomboBox.Size = new System.Drawing.Size(121, 20);
            this.baudcomboBox.TabIndex = 4;
            this.baudcomboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            // 
            // baudlabel
            // 
            this.baudlabel.AutoSize = true;
            this.baudlabel.Location = new System.Drawing.Point(13, 54);
            this.baudlabel.Name = "baudlabel";
            this.baudlabel.Size = new System.Drawing.Size(53, 12);
            this.baudlabel.TabIndex = 3;
            this.baudlabel.Text = "波特率：";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(14, 24);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(41, 12);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "名字：";
            // 
            // NamecomboBox
            // 
            this.NamecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NamecomboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NamecomboBox.FormattingEnabled = true;
            this.NamecomboBox.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10",
            "COM11",
            "COM12",
            "COM13",
            "COM14",
            "COM15",
            "COM16",
            "COM17",
            "COM18",
            "COM19",
            "COM20",
            "COM21",
            "COM22",
            "COM23",
            "COM24",
            "COM25",
            "COM26",
            "COM27",
            "COM28",
            "COM29",
            "COM30",
            "COM31",
            "COM32",
            "COM33",
            "COM34",
            "COM35",
            "COM36",
            "COM37",
            "COM38",
            "COM39",
            "COM40",
            "COM41",
            "COM42",
            "COM43",
            "COM44",
            "COM45",
            "COM46",
            "COM47",
            "COM48",
            "COM49",
            "COM50"});
            this.NamecomboBox.Location = new System.Drawing.Point(63, 19);
            this.NamecomboBox.Name = "NamecomboBox";
            this.NamecomboBox.Size = new System.Drawing.Size(121, 20);
            this.NamecomboBox.TabIndex = 1;
            this.NamecomboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            // 
            // BtnOpen
            // 
            this.BtnOpen.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.BtnOpen.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.BtnOpen.FlatAppearance.BorderSize = 0;
            this.BtnOpen.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.BtnOpen.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BtnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOpen.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnOpen.Location = new System.Drawing.Point(249, 78);
            this.BtnOpen.Name = "BtnOpen";
            this.BtnOpen.Size = new System.Drawing.Size(80, 23);
            this.BtnOpen.TabIndex = 0;
            this.BtnOpen.Text = "保存并打开";
            this.BtnOpen.UseVisualStyleBackColor = false;
            this.BtnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // THlabel
            // 
            this.THlabel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.THlabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.THlabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.THlabel.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.THlabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.THlabel.Location = new System.Drawing.Point(725, 15);
            this.THlabel.Margin = new System.Windows.Forms.Padding(5);
            this.THlabel.Name = "THlabel";
            this.THlabel.Padding = new System.Windows.Forms.Padding(10);
            this.THlabel.Size = new System.Drawing.Size(132, 132);
            this.THlabel.TabIndex = 0;
            this.THlabel.Text = "编号：\r\n温度：--.--℃\r\n湿度：--.--%RH";
            this.THlabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.THlabel.Visible = false;
            // 
            // serialPort
            // 
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTitle.Location = new System.Drawing.Point(11, 6);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(128, 20);
            this.labelTitle.TabIndex = 4;
            this.labelTitle.Text = "温湿度测试软件";
            this.labelTitle.Click += new System.EventHandler(this.labelTitle_Click);
            // 
            // labelClose
            // 
            this.labelClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelClose.Location = new System.Drawing.Point(1405, 2);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(25, 25);
            this.labelClose.TabIndex = 5;
            this.labelClose.Text = "×";
            this.labelClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelClose.Click += new System.EventHandler(this.labelClose_Click);
            this.labelClose.MouseEnter += new System.EventHandler(this.labelClose_MouseEnter);
            this.labelClose.MouseLeave += new System.EventHandler(this.labelMinimize_MouseLeave);
            // 
            // labelMinimize
            // 
            this.labelMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelMinimize.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelMinimize.Location = new System.Drawing.Point(1343, 0);
            this.labelMinimize.Name = "labelMinimize";
            this.labelMinimize.Size = new System.Drawing.Size(25, 25);
            this.labelMinimize.TabIndex = 6;
            this.labelMinimize.Text = "-";
            this.labelMinimize.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.labelMinimize.Click += new System.EventHandler(this.labelMinimize_Click);
            this.labelMinimize.MouseEnter += new System.EventHandler(this.labelClose_MouseEnter);
            this.labelMinimize.MouseLeave += new System.EventHandler(this.labelMinimize_MouseLeave);
            // 
            // regCountToolStripStatusLabel
            // 
            this.regCountToolStripStatusLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.regCountToolStripStatusLabel.Name = "regCountToolStripStatusLabel";
            this.regCountToolStripStatusLabel.Size = new System.Drawing.Size(1405, 17);
            this.regCountToolStripStatusLabel.Spring = true;
            this.regCountToolStripStatusLabel.Text = "接收计数：0";
            this.regCountToolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regCountToolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(10, 868);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1420, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip1";
            // 
            // labelMaximum
            // 
            this.labelMaximum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMaximum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelMaximum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelMaximum.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelMaximum.Location = new System.Drawing.Point(1374, 0);
            this.labelMaximum.Name = "labelMaximum";
            this.labelMaximum.Size = new System.Drawing.Size(25, 25);
            this.labelMaximum.TabIndex = 7;
            this.labelMaximum.Text = "□";
            this.labelMaximum.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.labelMaximum.Click += new System.EventHandler(this.labelMaximum_Click);
            // 
            // tBReceiveCount
            // 
            this.tBReceiveCount.Location = new System.Drawing.Point(141, 875);
            this.tBReceiveCount.Name = "tBReceiveCount";
            this.tBReceiveCount.Size = new System.Drawing.Size(100, 21);
            this.tBReceiveCount.TabIndex = 8;
            this.tBReceiveCount.Text = "1000";
            this.tBReceiveCount.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(12, 878);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "设置状态计数最大值：";
            this.label4.Visible = false;
            // 
            // buttonSetting
            // 
            this.buttonSetting.Location = new System.Drawing.Point(247, 873);
            this.buttonSetting.Name = "buttonSetting";
            this.buttonSetting.Size = new System.Drawing.Size(75, 23);
            this.buttonSetting.TabIndex = 10;
            this.buttonSetting.Text = "设置";
            this.buttonSetting.UseVisualStyleBackColor = true;
            this.buttonSetting.Visible = false;
            this.buttonSetting.Click += new System.EventHandler(this.buttonSetting_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1440, 900);
            this.Controls.Add(this.buttonSetting);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tBReceiveCount);
            this.Controls.Add(this.labelMaximum);
            this.Controls.Add(this.labelMinimize);
            this.Controls.Add(this.labelClose);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.statusStrip);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(10, 30, 10, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "温湿度模块测试软件";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyUp);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.flowLayoutPanel.ResumeLayout(false);
            this.SettingGroupBox.ResumeLayout(false);
            this.SettingGroupBox.PerformLayout();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem settingMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Label THlabel;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button BtnOpen;
        private System.Windows.Forms.ComboBox ParitycomboBox;
        private System.Windows.Forms.ComboBox StopBitscomboBox;
        private System.Windows.Forms.ComboBox DataBitscomboBox;
        private System.Windows.Forms.Label StopBitslabel;
        private System.Windows.Forms.Label DataBitslabel;
        private System.Windows.Forms.Label Paritylabel;
        private System.Windows.Forms.ComboBox baudcomboBox;
        private System.Windows.Forms.Label baudlabel;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.ComboBox NamecomboBox;
        private System.Windows.Forms.ToolStripMenuItem SetSerialPortMenuItem;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.GroupBox SettingGroupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelHumiUnit;
        private System.Windows.Forms.Label labelTempUnit;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.TextBox textBoxHumiMistake;
        private System.Windows.Forms.TextBox textBoxHumiValue;
        private System.Windows.Forms.TextBox textBoxTempMistake;
        private System.Windows.Forms.TextBox textBoxTempValue;
        private System.Windows.Forms.Label labelHumiMistake;
        private System.Windows.Forms.Label labelHumiValue;
        private System.Windows.Forms.Label labelTempMistake;
        private System.Windows.Forms.Label labelTempValue;
        private System.Windows.Forms.TextBox textBoxReceiveCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.Label labelMinimize;
        private System.Windows.Forms.ToolStripStatusLabel regCountToolStripStatusLabel;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripMenuItem lookLogMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClearLogMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TestModelMenuItem;
        private System.Windows.Forms.Label labelMaximum;
        private System.Windows.Forms.ToolStripMenuItem explanationMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ModeSelectionMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Mode55RHMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Mode70RHMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SerialPortMenuItem;
        private System.Windows.Forms.TextBox tBReceiveCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonSetting;
        private System.Windows.Forms.ToolStripMenuItem ThresholdMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SQLManagementMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DataSeeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DataAnalysisMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WipeDataMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TextDataMenuItem;
    }
}

