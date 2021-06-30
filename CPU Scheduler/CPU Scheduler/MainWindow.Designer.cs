
namespace CPU_Scheduler
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.gbScheduler = new System.Windows.Forms.GroupBox();
            this.cbTimeSlice = new System.Windows.Forms.ComboBox();
            this.lbTimeSlice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbModeSwitch = new System.Windows.Forms.CheckBox();
            this.cbContextSwitch = new System.Windows.Forms.CheckBox();
            this.cbAlgorithm = new System.Windows.Forms.ComboBox();
            this.lbAlgorithmType = new System.Windows.Forms.Label();
            this.pnButtonsContainer = new System.Windows.Forms.Panel();
            this.btStart = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.btImport = new System.Windows.Forms.Button();
            this.btEditProcess = new System.Windows.Forms.Button();
            this.btExport = new System.Windows.Forms.Button();
            this.pnGraphic = new System.Windows.Forms.Panel();
            this.lbGraphTitle = new System.Windows.Forms.Label();
            this.lbTotalWaitingTimeValue = new System.Windows.Forms.Label();
            this.lbTotalWaitingTime = new System.Windows.Forms.Label();
            this.lbData = new System.Windows.Forms.Label();
            this.lbThroughputValue = new System.Windows.Forms.Label();
            this.lbCpuUsageValue = new System.Windows.Forms.Label();
            this.lbThroughput = new System.Windows.Forms.Label();
            this.lbCpuUsage = new System.Windows.Forms.Label();
            this.lbAlgorithmDescriptionValue = new System.Windows.Forms.Label();
            this.lbAlgorithmDesc = new System.Windows.Forms.Label();
            this.menuTopBar = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnGraphContainer = new System.Windows.Forms.Panel();
            this.gbOutput = new System.Windows.Forms.GroupBox();
            this.gbOutputGeneral = new System.Windows.Forms.GroupBox();
            this.lbTotalBurstValue = new System.Windows.Forms.Label();
            this.lbTotalBurst = new System.Windows.Forms.Label();
            this.lbTotalTimeValue = new System.Windows.Forms.Label();
            this.lbTotalTime = new System.Windows.Forms.Label();
            this.pnSettingsContainer = new System.Windows.Forms.Panel();
            this.gbProcessList = new System.Windows.Forms.GroupBox();
            this.lvProcesses = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colArrival = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDuration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btRemoveProcess = new System.Windows.Forms.Button();
            this.btAddProcess = new System.Windows.Forms.Button();
            this.pnOutputContainer = new System.Windows.Forms.Panel();
            this.ttCpuUsage = new System.Windows.Forms.ToolTip(this.components);
            this.ttTimeSlice = new System.Windows.Forms.ToolTip(this.components);
            this.gbScheduler.SuspendLayout();
            this.pnButtonsContainer.SuspendLayout();
            this.menuTopBar.SuspendLayout();
            this.pnGraphContainer.SuspendLayout();
            this.gbOutput.SuspendLayout();
            this.gbOutputGeneral.SuspendLayout();
            this.pnSettingsContainer.SuspendLayout();
            this.gbProcessList.SuspendLayout();
            this.pnOutputContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbScheduler
            // 
            this.gbScheduler.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbScheduler.Controls.Add(this.cbTimeSlice);
            this.gbScheduler.Controls.Add(this.lbTimeSlice);
            this.gbScheduler.Controls.Add(this.label1);
            this.gbScheduler.Controls.Add(this.cbModeSwitch);
            this.gbScheduler.Controls.Add(this.cbContextSwitch);
            this.gbScheduler.Controls.Add(this.cbAlgorithm);
            this.gbScheduler.Controls.Add(this.lbAlgorithmType);
            this.gbScheduler.Location = new System.Drawing.Point(10, 10);
            this.gbScheduler.Name = "gbScheduler";
            this.gbScheduler.Size = new System.Drawing.Size(414, 109);
            this.gbScheduler.TabIndex = 1;
            this.gbScheduler.TabStop = false;
            this.gbScheduler.Text = "Settings";
            // 
            // cbTimeSlice
            // 
            this.cbTimeSlice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTimeSlice.FormattingEnabled = true;
            this.cbTimeSlice.Items.AddRange(new object[] {
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
            this.cbTimeSlice.Location = new System.Drawing.Point(95, 78);
            this.cbTimeSlice.Name = "cbTimeSlice";
            this.cbTimeSlice.Size = new System.Drawing.Size(46, 24);
            this.cbTimeSlice.TabIndex = 19;
            // 
            // lbTimeSlice
            // 
            this.lbTimeSlice.AutoSize = true;
            this.lbTimeSlice.Location = new System.Drawing.Point(12, 81);
            this.lbTimeSlice.Name = "lbTimeSlice";
            this.lbTimeSlice.Size = new System.Drawing.Size(77, 17);
            this.lbTimeSlice.TabIndex = 18;
            this.lbTimeSlice.Text = "Time Slice:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "Dispatcher:";
            // 
            // cbModeSwitch
            // 
            this.cbModeSwitch.AutoSize = true;
            this.cbModeSwitch.Location = new System.Drawing.Point(188, 64);
            this.cbModeSwitch.Name = "cbModeSwitch";
            this.cbModeSwitch.Size = new System.Drawing.Size(189, 21);
            this.cbModeSwitch.TabIndex = 16;
            this.cbModeSwitch.Text = "Kernel-User Mode Switch";
            this.cbModeSwitch.UseVisualStyleBackColor = true;
            // 
            // cbContextSwitch
            // 
            this.cbContextSwitch.AutoSize = true;
            this.cbContextSwitch.Location = new System.Drawing.Point(188, 44);
            this.cbContextSwitch.Name = "cbContextSwitch";
            this.cbContextSwitch.Size = new System.Drawing.Size(121, 21);
            this.cbContextSwitch.TabIndex = 15;
            this.cbContextSwitch.Text = "Context Switch";
            this.cbContextSwitch.UseVisualStyleBackColor = true;
            // 
            // cbAlgorithm
            // 
            this.cbAlgorithm.BackColor = System.Drawing.Color.White;
            this.cbAlgorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAlgorithm.FormattingEnabled = true;
            this.cbAlgorithm.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbAlgorithm.Items.AddRange(new object[] {
            "FCFS",
            "Round Robin",
            "SJF",
            "SRTF",
            "Priority"});
            this.cbAlgorithm.Location = new System.Drawing.Point(12, 48);
            this.cbAlgorithm.Name = "cbAlgorithm";
            this.cbAlgorithm.Size = new System.Drawing.Size(155, 24);
            this.cbAlgorithm.TabIndex = 2;
            this.cbAlgorithm.SelectedIndexChanged += new System.EventHandler(this.cbAlgorithm_SelectedIndexChanged);
            // 
            // lbAlgorithmType
            // 
            this.lbAlgorithmType.AutoSize = true;
            this.lbAlgorithmType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAlgorithmType.Location = new System.Drawing.Point(12, 27);
            this.lbAlgorithmType.Name = "lbAlgorithmType";
            this.lbAlgorithmType.Size = new System.Drawing.Size(120, 18);
            this.lbAlgorithmType.TabIndex = 1;
            this.lbAlgorithmType.Text = "Algorithm type:";
            // 
            // pnButtonsContainer
            // 
            this.pnButtonsContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnButtonsContainer.Controls.Add(this.btStart);
            this.pnButtonsContainer.Controls.Add(this.btClear);
            this.pnButtonsContainer.Controls.Add(this.btImport);
            this.pnButtonsContainer.Controls.Add(this.btEditProcess);
            this.pnButtonsContainer.Controls.Add(this.btExport);
            this.pnButtonsContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnButtonsContainer.Location = new System.Drawing.Point(0, 495);
            this.pnButtonsContainer.Name = "pnButtonsContainer";
            this.pnButtonsContainer.Size = new System.Drawing.Size(439, 128);
            this.pnButtonsContainer.TabIndex = 18;
            // 
            // btStart
            // 
            this.btStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btStart.Location = new System.Drawing.Point(329, 80);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(93, 38);
            this.btStart.TabIndex = 4;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btClear
            // 
            this.btClear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btClear.Location = new System.Drawing.Point(230, 80);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(93, 38);
            this.btClear.TabIndex = 7;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btImport
            // 
            this.btImport.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btImport.Location = new System.Drawing.Point(65, 5);
            this.btImport.Name = "btImport";
            this.btImport.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btImport.Size = new System.Drawing.Size(50, 30);
            this.btImport.TabIndex = 14;
            this.btImport.Text = "Import";
            this.btImport.UseVisualStyleBackColor = true;
            this.btImport.Click += new System.EventHandler(this.btImport_Click);
            // 
            // btEditProcess
            // 
            this.btEditProcess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btEditProcess.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btEditProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btEditProcess.Location = new System.Drawing.Point(328, 5);
            this.btEditProcess.Name = "btEditProcess";
            this.btEditProcess.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btEditProcess.Size = new System.Drawing.Size(96, 32);
            this.btEditProcess.TabIndex = 12;
            this.btEditProcess.Text = "Edit";
            this.btEditProcess.UseVisualStyleBackColor = true;
            this.btEditProcess.Click += new System.EventHandler(this.btEditProcess_Click);
            // 
            // btExport
            // 
            this.btExport.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btExport.Location = new System.Drawing.Point(9, 5);
            this.btExport.Name = "btExport";
            this.btExport.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btExport.Size = new System.Drawing.Size(50, 30);
            this.btExport.TabIndex = 13;
            this.btExport.Text = "Export";
            this.btExport.UseVisualStyleBackColor = true;
            this.btExport.Click += new System.EventHandler(this.btExport_Click);
            // 
            // pnGraphic
            // 
            this.pnGraphic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnGraphic.AutoScroll = true;
            this.pnGraphic.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnGraphic.BackColor = System.Drawing.Color.White;
            this.pnGraphic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnGraphic.Location = new System.Drawing.Point(6, 48);
            this.pnGraphic.Name = "pnGraphic";
            this.pnGraphic.Size = new System.Drawing.Size(845, 196);
            this.pnGraphic.TabIndex = 2;
            // 
            // lbGraphTitle
            // 
            this.lbGraphTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbGraphTitle.AutoSize = true;
            this.lbGraphTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGraphTitle.Location = new System.Drawing.Point(371, 25);
            this.lbGraphTitle.Name = "lbGraphTitle";
            this.lbGraphTitle.Size = new System.Drawing.Size(112, 20);
            this.lbGraphTitle.TabIndex = 3;
            this.lbGraphTitle.Text = "Gnatt Graph";
            // 
            // lbTotalWaitingTimeValue
            // 
            this.lbTotalWaitingTimeValue.AutoSize = true;
            this.lbTotalWaitingTimeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalWaitingTimeValue.Location = new System.Drawing.Point(140, 105);
            this.lbTotalWaitingTimeValue.Name = "lbTotalWaitingTimeValue";
            this.lbTotalWaitingTimeValue.Size = new System.Drawing.Size(80, 17);
            this.lbTotalWaitingTimeValue.TabIndex = 9;
            this.lbTotalWaitingTimeValue.Text = "0 time units";
            // 
            // lbTotalWaitingTime
            // 
            this.lbTotalWaitingTime.AutoSize = true;
            this.lbTotalWaitingTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbTotalWaitingTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalWaitingTime.Location = new System.Drawing.Point(21, 105);
            this.lbTotalWaitingTime.Name = "lbTotalWaitingTime";
            this.lbTotalWaitingTime.Size = new System.Drawing.Size(121, 17);
            this.lbTotalWaitingTime.TabIndex = 8;
            this.lbTotalWaitingTime.Text = "Total waiting time:";
            this.lbTotalWaitingTime.Click += new System.EventHandler(this.lbWaitingTime_Click);
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lbData.Location = new System.Drawing.Point(6, 142);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(78, 18);
            this.lbData.TabIndex = 7;
            this.lbData.Text = "Statistics";
            // 
            // lbThroughputValue
            // 
            this.lbThroughputValue.AutoSize = true;
            this.lbThroughputValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThroughputValue.Location = new System.Drawing.Point(108, 55);
            this.lbThroughputValue.Name = "lbThroughputValue";
            this.lbThroughputValue.Size = new System.Drawing.Size(147, 17);
            this.lbThroughputValue.TabIndex = 6;
            this.lbThroughputValue.Text = "0.00 process/time unit";
            // 
            // lbCpuUsageValue
            // 
            this.lbCpuUsageValue.AutoSize = true;
            this.lbCpuUsageValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCpuUsageValue.Location = new System.Drawing.Point(142, 130);
            this.lbCpuUsageValue.Name = "lbCpuUsageValue";
            this.lbCpuUsageValue.Size = new System.Drawing.Size(28, 17);
            this.lbCpuUsageValue.TabIndex = 5;
            this.lbCpuUsageValue.Text = "0%";
            // 
            // lbThroughput
            // 
            this.lbThroughput.AutoSize = true;
            this.lbThroughput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbThroughput.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThroughput.Location = new System.Drawing.Point(21, 55);
            this.lbThroughput.Name = "lbThroughput";
            this.lbThroughput.Size = new System.Drawing.Size(86, 17);
            this.lbThroughput.TabIndex = 3;
            this.lbThroughput.Text = "Throughput:";
            this.lbThroughput.Click += new System.EventHandler(this.lbThroughput_Click);
            // 
            // lbCpuUsage
            // 
            this.lbCpuUsage.AutoSize = true;
            this.lbCpuUsage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbCpuUsage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCpuUsage.Location = new System.Drawing.Point(21, 130);
            this.lbCpuUsage.Name = "lbCpuUsage";
            this.lbCpuUsage.Size = new System.Drawing.Size(105, 17);
            this.lbCpuUsage.TabIndex = 2;
            this.lbCpuUsage.Text = "CPU Utilization:";
            this.lbCpuUsage.Click += new System.EventHandler(this.lbCpuUsage_Click);
            // 
            // lbAlgorithmDescriptionValue
            // 
            this.lbAlgorithmDescriptionValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbAlgorithmDescriptionValue.Location = new System.Drawing.Point(17, 50);
            this.lbAlgorithmDescriptionValue.Name = "lbAlgorithmDescriptionValue";
            this.lbAlgorithmDescriptionValue.Size = new System.Drawing.Size(822, 92);
            this.lbAlgorithmDescriptionValue.TabIndex = 1;
            this.lbAlgorithmDescriptionValue.Text = "null";
            // 
            // lbAlgorithmDesc
            // 
            this.lbAlgorithmDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbAlgorithmDesc.AutoSize = true;
            this.lbAlgorithmDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lbAlgorithmDesc.Location = new System.Drawing.Point(1, 18);
            this.lbAlgorithmDesc.Name = "lbAlgorithmDesc";
            this.lbAlgorithmDesc.Size = new System.Drawing.Size(170, 18);
            this.lbAlgorithmDesc.TabIndex = 0;
            this.lbAlgorithmDesc.Text = "Algorithm Description";
            // 
            // menuTopBar
            // 
            this.menuTopBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuTopBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuTopBar.Location = new System.Drawing.Point(0, 0);
            this.menuTopBar.Name = "menuTopBar";
            this.menuTopBar.Size = new System.Drawing.Size(1307, 30);
            this.menuTopBar.TabIndex = 13;
            this.menuTopBar.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IOToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.settingsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("settingsToolStripMenuItem.Image")));
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(96, 26);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // IOToolStripMenuItem
            // 
            this.IOToolStripMenuItem.Name = "IOToolStripMenuItem";
            this.IOToolStripMenuItem.Size = new System.Drawing.Size(116, 26);
            this.IOToolStripMenuItem.Text = "I/O";
            this.IOToolStripMenuItem.Click += new System.EventHandler(this.IOToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(113, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripMenuItem.Image")));
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(75, 26);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // pnGraphContainer
            // 
            this.pnGraphContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnGraphContainer.Controls.Add(this.lbGraphTitle);
            this.pnGraphContainer.Controls.Add(this.pnGraphic);
            this.pnGraphContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnGraphContainer.Location = new System.Drawing.Point(439, 30);
            this.pnGraphContainer.Name = "pnGraphContainer";
            this.pnGraphContainer.Size = new System.Drawing.Size(868, 260);
            this.pnGraphContainer.TabIndex = 14;
            // 
            // gbOutput
            // 
            this.gbOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbOutput.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbOutput.Controls.Add(this.gbOutputGeneral);
            this.gbOutput.Controls.Add(this.lbAlgorithmDesc);
            this.gbOutput.Controls.Add(this.lbAlgorithmDescriptionValue);
            this.gbOutput.Controls.Add(this.lbData);
            this.gbOutput.Location = new System.Drawing.Point(6, 6);
            this.gbOutput.Name = "gbOutput";
            this.gbOutput.Size = new System.Drawing.Size(845, 347);
            this.gbOutput.TabIndex = 10;
            this.gbOutput.TabStop = false;
            // 
            // gbOutputGeneral
            // 
            this.gbOutputGeneral.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbOutputGeneral.Controls.Add(this.lbTotalBurstValue);
            this.gbOutputGeneral.Controls.Add(this.lbTotalBurst);
            this.gbOutputGeneral.Controls.Add(this.lbTotalTimeValue);
            this.gbOutputGeneral.Controls.Add(this.lbTotalTime);
            this.gbOutputGeneral.Controls.Add(this.lbCpuUsage);
            this.gbOutputGeneral.Controls.Add(this.lbThroughput);
            this.gbOutputGeneral.Controls.Add(this.lbTotalWaitingTimeValue);
            this.gbOutputGeneral.Controls.Add(this.lbCpuUsageValue);
            this.gbOutputGeneral.Controls.Add(this.lbThroughputValue);
            this.gbOutputGeneral.Controls.Add(this.lbTotalWaitingTime);
            this.gbOutputGeneral.Location = new System.Drawing.Point(20, 169);
            this.gbOutputGeneral.Name = "gbOutputGeneral";
            this.gbOutputGeneral.Size = new System.Drawing.Size(298, 166);
            this.gbOutputGeneral.TabIndex = 10;
            this.gbOutputGeneral.TabStop = false;
            this.gbOutputGeneral.Text = "General";
            // 
            // lbTotalBurstValue
            // 
            this.lbTotalBurstValue.AutoSize = true;
            this.lbTotalBurstValue.Location = new System.Drawing.Point(140, 80);
            this.lbTotalBurstValue.Name = "lbTotalBurstValue";
            this.lbTotalBurstValue.Size = new System.Drawing.Size(80, 17);
            this.lbTotalBurstValue.TabIndex = 13;
            this.lbTotalBurstValue.Text = "0 time units";
            // 
            // lbTotalBurst
            // 
            this.lbTotalBurst.AutoSize = true;
            this.lbTotalBurst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbTotalBurst.Location = new System.Drawing.Point(21, 80);
            this.lbTotalBurst.Name = "lbTotalBurst";
            this.lbTotalBurst.Size = new System.Drawing.Size(112, 17);
            this.lbTotalBurst.TabIndex = 12;
            this.lbTotalBurst.Text = "Total CPU burst:";
            this.lbTotalBurst.Click += new System.EventHandler(this.lbTotalBurst_Click);
            // 
            // lbTotalTimeValue
            // 
            this.lbTotalTimeValue.AutoSize = true;
            this.lbTotalTimeValue.Location = new System.Drawing.Point(108, 30);
            this.lbTotalTimeValue.Name = "lbTotalTimeValue";
            this.lbTotalTimeValue.Size = new System.Drawing.Size(80, 17);
            this.lbTotalTimeValue.TabIndex = 11;
            this.lbTotalTimeValue.Text = "0 time units";
            // 
            // lbTotalTime
            // 
            this.lbTotalTime.AutoSize = true;
            this.lbTotalTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbTotalTime.Location = new System.Drawing.Point(21, 30);
            this.lbTotalTime.Name = "lbTotalTime";
            this.lbTotalTime.Size = new System.Drawing.Size(74, 17);
            this.lbTotalTime.TabIndex = 10;
            this.lbTotalTime.Text = "Total time:";
            this.lbTotalTime.Click += new System.EventHandler(this.lbTotalTime_Click);
            // 
            // pnSettingsContainer
            // 
            this.pnSettingsContainer.Controls.Add(this.gbProcessList);
            this.pnSettingsContainer.Controls.Add(this.pnButtonsContainer);
            this.pnSettingsContainer.Controls.Add(this.gbScheduler);
            this.pnSettingsContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnSettingsContainer.Location = new System.Drawing.Point(0, 30);
            this.pnSettingsContainer.Name = "pnSettingsContainer";
            this.pnSettingsContainer.Size = new System.Drawing.Size(439, 623);
            this.pnSettingsContainer.TabIndex = 15;
            // 
            // gbProcessList
            // 
            this.gbProcessList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbProcessList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbProcessList.Controls.Add(this.lvProcesses);
            this.gbProcessList.Controls.Add(this.btRemoveProcess);
            this.gbProcessList.Controls.Add(this.btAddProcess);
            this.gbProcessList.Location = new System.Drawing.Point(10, 125);
            this.gbProcessList.Name = "gbProcessList";
            this.gbProcessList.Size = new System.Drawing.Size(414, 368);
            this.gbProcessList.TabIndex = 15;
            this.gbProcessList.TabStop = false;
            this.gbProcessList.Text = "Process List";
            // 
            // lvProcesses
            // 
            this.lvProcesses.AllowDrop = true;
            this.lvProcesses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvProcesses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colArrival,
            this.colDuration,
            this.colID});
            this.lvProcesses.HideSelection = false;
            this.lvProcesses.Location = new System.Drawing.Point(15, 50);
            this.lvProcesses.Name = "lvProcesses";
            this.lvProcesses.Size = new System.Drawing.Size(384, 303);
            this.lvProcesses.TabIndex = 11;
            this.lvProcesses.UseCompatibleStateImageBehavior = false;
            this.lvProcesses.View = System.Windows.Forms.View.Details;
            this.lvProcesses.DragDrop += new System.Windows.Forms.DragEventHandler(this.lvProcesses_DragDrop);
            this.lvProcesses.DragEnter += new System.Windows.Forms.DragEventHandler(this.lvProcesses_DragEnter);
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 173;
            // 
            // colArrival
            // 
            this.colArrival.Text = "Arrival Time";
            this.colArrival.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colArrival.Width = 110;
            // 
            // colDuration
            // 
            this.colDuration.Text = "Duration";
            this.colDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colDuration.Width = 90;
            // 
            // colID
            // 
            this.colID.Text = "ID";
            this.colID.Width = 148;
            // 
            // btRemoveProcess
            // 
            this.btRemoveProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btRemoveProcess.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btRemoveProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btRemoveProcess.Location = new System.Drawing.Point(162, 15);
            this.btRemoveProcess.Name = "btRemoveProcess";
            this.btRemoveProcess.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btRemoveProcess.Size = new System.Drawing.Size(121, 30);
            this.btRemoveProcess.TabIndex = 9;
            this.btRemoveProcess.Text = "Remove process";
            this.btRemoveProcess.UseVisualStyleBackColor = true;
            this.btRemoveProcess.Click += new System.EventHandler(this.btRemoveProcess_Click);
            // 
            // btAddProcess
            // 
            this.btAddProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btAddProcess.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btAddProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btAddProcess.Location = new System.Drawing.Point(295, 15);
            this.btAddProcess.Name = "btAddProcess";
            this.btAddProcess.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btAddProcess.Size = new System.Drawing.Size(109, 30);
            this.btAddProcess.TabIndex = 8;
            this.btAddProcess.Text = "Add process";
            this.btAddProcess.UseVisualStyleBackColor = true;
            this.btAddProcess.Click += new System.EventHandler(this.btAddProcess_Click);
            // 
            // pnOutputContainer
            // 
            this.pnOutputContainer.Controls.Add(this.gbOutput);
            this.pnOutputContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnOutputContainer.Location = new System.Drawing.Point(439, 290);
            this.pnOutputContainer.Name = "pnOutputContainer";
            this.pnOutputContainer.Size = new System.Drawing.Size(868, 363);
            this.pnOutputContainer.TabIndex = 11;
            // 
            // ttCpuUsage
            // 
            this.ttCpuUsage.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttCpuUsage.ToolTipTitle = "CPU Usage";
            // 
            // ttTimeSlice
            // 
            this.ttTimeSlice.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttTimeSlice.ToolTipTitle = "Time Slice";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1307, 653);
            this.Controls.Add(this.pnOutputContainer);
            this.Controls.Add(this.pnGraphContainer);
            this.Controls.Add(this.pnSettingsContainer);
            this.Controls.Add(this.menuTopBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuTopBar;
            this.MinimumSize = new System.Drawing.Size(1125, 680);
            this.Name = "MainWindow";
            this.Text = "CPU Algorithm Viewer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.gbScheduler.ResumeLayout(false);
            this.gbScheduler.PerformLayout();
            this.pnButtonsContainer.ResumeLayout(false);
            this.menuTopBar.ResumeLayout(false);
            this.menuTopBar.PerformLayout();
            this.pnGraphContainer.ResumeLayout(false);
            this.pnGraphContainer.PerformLayout();
            this.gbOutput.ResumeLayout(false);
            this.gbOutput.PerformLayout();
            this.gbOutputGeneral.ResumeLayout(false);
            this.gbOutputGeneral.PerformLayout();
            this.pnSettingsContainer.ResumeLayout(false);
            this.gbProcessList.ResumeLayout(false);
            this.pnOutputContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbScheduler;
        private System.Windows.Forms.Label lbAlgorithmType;
        private System.Windows.Forms.Panel pnGraphic;
        private System.Windows.Forms.ComboBox cbAlgorithm;
        private System.Windows.Forms.Label lbGraphTitle;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btEditProcess;
        private System.Windows.Forms.Label lbAlgorithmDesc;
        private System.Windows.Forms.Label lbAlgorithmDescriptionValue;
        private System.Windows.Forms.Button btImport;
        private System.Windows.Forms.Button btExport;
        private System.Windows.Forms.MenuStrip menuTopBar;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem IOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lbThroughput;
        private System.Windows.Forms.Label lbThroughputValue;
        private System.Windows.Forms.Label lbCpuUsageValue;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.Label lbTotalWaitingTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbModeSwitch;
        private System.Windows.Forms.CheckBox cbContextSwitch;
        private System.Windows.Forms.Label lbCpuUsage;
        private System.Windows.Forms.Label lbTotalWaitingTimeValue;
        private System.Windows.Forms.Panel pnGraphContainer;
        private System.Windows.Forms.Panel pnButtonsContainer;
        private System.Windows.Forms.GroupBox gbOutput;
        private System.Windows.Forms.Panel pnSettingsContainer;
        private System.Windows.Forms.GroupBox gbProcessList;
        private System.Windows.Forms.ListView lvProcesses;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colArrival;
        private System.Windows.Forms.ColumnHeader colDuration;
        private System.Windows.Forms.ColumnHeader colID;
        private System.Windows.Forms.Button btRemoveProcess;
        private System.Windows.Forms.Button btAddProcess;
        private System.Windows.Forms.Panel pnOutputContainer;
        private System.Windows.Forms.GroupBox gbOutputGeneral;
        private System.Windows.Forms.Label lbTotalTimeValue;
        private System.Windows.Forms.Label lbTotalTime;
        private System.Windows.Forms.Label lbTotalBurstValue;
        private System.Windows.Forms.Label lbTotalBurst;
        private System.Windows.Forms.ToolTip ttCpuUsage;
        private System.Windows.Forms.ComboBox cbTimeSlice;
        private System.Windows.Forms.Label lbTimeSlice;
        private System.Windows.Forms.ToolTip ttTimeSlice;
    }
}

