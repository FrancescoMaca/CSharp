
namespace CPU_Scheduler
{
    partial class EditProcessForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProcessForm));
            this.btDone = new System.Windows.Forms.Button();
            this.gbProcessGraphic = new System.Windows.Forms.GroupBox();
            this.lnkProcessName = new System.Windows.Forms.LinkLabel();
            this.lbName = new System.Windows.Forms.Label();
            this.lbColor = new System.Windows.Forms.Label();
            this.pnCurrentColor = new System.Windows.Forms.Panel();
            this.btColorPicker = new System.Windows.Forms.Button();
            this.lbProcessID = new System.Windows.Forms.Label();
            this.lbUnit2 = new System.Windows.Forms.Label();
            this.lbUnit1 = new System.Windows.Forms.Label();
            this.tbArrivalTime = new System.Windows.Forms.TextBox();
            this.tbDuration = new System.Windows.Forms.TextBox();
            this.lbArrivalTime = new System.Windows.Forms.Label();
            this.lbDuration = new System.Windows.Forms.Label();
            this.gbData = new System.Windows.Forms.GroupBox();
            this.gbPriority = new System.Windows.Forms.GroupBox();
            this.btIncreasePriority = new System.Windows.Forms.Button();
            this.btDecreasePriority = new System.Windows.Forms.Button();
            this.lbPriorityValue = new System.Windows.Forms.Label();
            this.lbProcessPrivilages = new System.Windows.Forms.Label();
            this.cbMode = new System.Windows.Forms.ComboBox();
            this.lbPriorityLevel = new System.Windows.Forms.Label();
            this.gbProcessGraphic.SuspendLayout();
            this.gbData.SuspendLayout();
            this.gbPriority.SuspendLayout();
            this.SuspendLayout();
            // 
            // btDone
            // 
            this.btDone.Location = new System.Drawing.Point(275, 248);
            this.btDone.Name = "btDone";
            this.btDone.Size = new System.Drawing.Size(143, 43);
            this.btDone.TabIndex = 0;
            this.btDone.Text = "Done";
            this.btDone.UseVisualStyleBackColor = true;
            this.btDone.Click += new System.EventHandler(this.btDone_Click);
            // 
            // gbProcessGraphic
            // 
            this.gbProcessGraphic.Controls.Add(this.lnkProcessName);
            this.gbProcessGraphic.Controls.Add(this.lbName);
            this.gbProcessGraphic.Controls.Add(this.lbColor);
            this.gbProcessGraphic.Controls.Add(this.pnCurrentColor);
            this.gbProcessGraphic.Controls.Add(this.btColorPicker);
            this.gbProcessGraphic.Location = new System.Drawing.Point(12, 12);
            this.gbProcessGraphic.Name = "gbProcessGraphic";
            this.gbProcessGraphic.Size = new System.Drawing.Size(257, 122);
            this.gbProcessGraphic.TabIndex = 1;
            this.gbProcessGraphic.TabStop = false;
            this.gbProcessGraphic.Text = "Esthetic";
            // 
            // lnkProcessName
            // 
            this.lnkProcessName.ActiveLinkColor = System.Drawing.Color.DarkGray;
            this.lnkProcessName.AutoSize = true;
            this.lnkProcessName.LinkColor = System.Drawing.Color.Black;
            this.lnkProcessName.Location = new System.Drawing.Point(63, 30);
            this.lnkProcessName.Name = "lnkProcessName";
            this.lnkProcessName.Size = new System.Drawing.Size(30, 17);
            this.lnkProcessName.TabIndex = 4;
            this.lnkProcessName.TabStop = true;
            this.lnkProcessName.Text = "null";
            this.lnkProcessName.VisitedLinkColor = System.Drawing.Color.Black;
            this.lnkProcessName.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkProcessName_LinkClicked);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(8, 30);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(49, 17);
            this.lbName.TabIndex = 3;
            this.lbName.Text = "Name:";
            // 
            // lbColor
            // 
            this.lbColor.AutoSize = true;
            this.lbColor.Location = new System.Drawing.Point(8, 60);
            this.lbColor.Name = "lbColor";
            this.lbColor.Size = new System.Drawing.Size(45, 17);
            this.lbColor.TabIndex = 2;
            this.lbColor.Text = "Color:";
            // 
            // pnCurrentColor
            // 
            this.pnCurrentColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnCurrentColor.Location = new System.Drawing.Point(131, 60);
            this.pnCurrentColor.Name = "pnCurrentColor";
            this.pnCurrentColor.Size = new System.Drawing.Size(50, 50);
            this.pnCurrentColor.TabIndex = 1;
            this.pnCurrentColor.Click += new System.EventHandler(this.pnCurrentColor_Click);
            // 
            // btColorPicker
            // 
            this.btColorPicker.Location = new System.Drawing.Point(11, 80);
            this.btColorPicker.Name = "btColorPicker";
            this.btColorPicker.Size = new System.Drawing.Size(104, 28);
            this.btColorPicker.TabIndex = 0;
            this.btColorPicker.Text = "Select Color";
            this.btColorPicker.UseVisualStyleBackColor = true;
            this.btColorPicker.Click += new System.EventHandler(this.btColorPicker_Click);
            // 
            // lbProcessID
            // 
            this.lbProcessID.AutoSize = true;
            this.lbProcessID.Location = new System.Drawing.Point(6, 121);
            this.lbProcessID.Name = "lbProcessID";
            this.lbProcessID.Size = new System.Drawing.Size(39, 17);
            this.lbProcessID.TabIndex = 11;
            this.lbProcessID.Text = "P-ID:";
            // 
            // lbUnit2
            // 
            this.lbUnit2.AutoSize = true;
            this.lbUnit2.Location = new System.Drawing.Point(167, 60);
            this.lbUnit2.Name = "lbUnit2";
            this.lbUnit2.Size = new System.Drawing.Size(78, 17);
            this.lbUnit2.TabIndex = 10;
            this.lbUnit2.Text = "time unit(s)";
            // 
            // lbUnit1
            // 
            this.lbUnit1.AutoSize = true;
            this.lbUnit1.Location = new System.Drawing.Point(167, 21);
            this.lbUnit1.Name = "lbUnit1";
            this.lbUnit1.Size = new System.Drawing.Size(78, 17);
            this.lbUnit1.TabIndex = 9;
            this.lbUnit1.Text = "time unit(s)";
            // 
            // tbArrivalTime
            // 
            this.tbArrivalTime.Location = new System.Drawing.Point(98, 55);
            this.tbArrivalTime.MaxLength = 7;
            this.tbArrivalTime.Name = "tbArrivalTime";
            this.tbArrivalTime.Size = new System.Drawing.Size(63, 22);
            this.tbArrivalTime.TabIndex = 8;
            // 
            // tbDuration
            // 
            this.tbDuration.Location = new System.Drawing.Point(98, 21);
            this.tbDuration.MaxLength = 7;
            this.tbDuration.Name = "tbDuration";
            this.tbDuration.Size = new System.Drawing.Size(63, 22);
            this.tbDuration.TabIndex = 7;
            // 
            // lbArrivalTime
            // 
            this.lbArrivalTime.AutoSize = true;
            this.lbArrivalTime.Location = new System.Drawing.Point(8, 60);
            this.lbArrivalTime.Name = "lbArrivalTime";
            this.lbArrivalTime.Size = new System.Drawing.Size(87, 17);
            this.lbArrivalTime.TabIndex = 6;
            this.lbArrivalTime.Text = "Arrival Time:";
            // 
            // lbDuration
            // 
            this.lbDuration.AutoSize = true;
            this.lbDuration.Location = new System.Drawing.Point(8, 21);
            this.lbDuration.Name = "lbDuration";
            this.lbDuration.Size = new System.Drawing.Size(66, 17);
            this.lbDuration.TabIndex = 5;
            this.lbDuration.Text = "Duration:";
            // 
            // gbData
            // 
            this.gbData.Controls.Add(this.lbArrivalTime);
            this.gbData.Controls.Add(this.lbProcessID);
            this.gbData.Controls.Add(this.tbDuration);
            this.gbData.Controls.Add(this.lbDuration);
            this.gbData.Controls.Add(this.lbUnit2);
            this.gbData.Controls.Add(this.tbArrivalTime);
            this.gbData.Controls.Add(this.lbUnit1);
            this.gbData.Location = new System.Drawing.Point(12, 140);
            this.gbData.Name = "gbData";
            this.gbData.Size = new System.Drawing.Size(257, 151);
            this.gbData.TabIndex = 12;
            this.gbData.TabStop = false;
            this.gbData.Text = "Data";
            // 
            // gbPriority
            // 
            this.gbPriority.Controls.Add(this.btIncreasePriority);
            this.gbPriority.Controls.Add(this.btDecreasePriority);
            this.gbPriority.Controls.Add(this.lbPriorityValue);
            this.gbPriority.Controls.Add(this.lbProcessPrivilages);
            this.gbPriority.Controls.Add(this.cbMode);
            this.gbPriority.Controls.Add(this.lbPriorityLevel);
            this.gbPriority.Location = new System.Drawing.Point(275, 12);
            this.gbPriority.Name = "gbPriority";
            this.gbPriority.Size = new System.Drawing.Size(143, 230);
            this.gbPriority.TabIndex = 13;
            this.gbPriority.TabStop = false;
            this.gbPriority.Text = "Priority";
            // 
            // btIncreasePriority
            // 
            this.btIncreasePriority.AutoSize = true;
            this.btIncreasePriority.Location = new System.Drawing.Point(85, 56);
            this.btIncreasePriority.Name = "btIncreasePriority";
            this.btIncreasePriority.Size = new System.Drawing.Size(44, 27);
            this.btIncreasePriority.TabIndex = 6;
            this.btIncreasePriority.Text = "+";
            this.btIncreasePriority.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btIncreasePriority.UseVisualStyleBackColor = true;
            this.btIncreasePriority.Click += new System.EventHandler(this.btIncreasePriority_Click);
            // 
            // btDecreasePriority
            // 
            this.btDecreasePriority.AutoSize = true;
            this.btDecreasePriority.Location = new System.Drawing.Point(10, 56);
            this.btDecreasePriority.Name = "btDecreasePriority";
            this.btDecreasePriority.Size = new System.Drawing.Size(44, 27);
            this.btDecreasePriority.TabIndex = 5;
            this.btDecreasePriority.Text = "-";
            this.btDecreasePriority.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btDecreasePriority.UseVisualStyleBackColor = true;
            this.btDecreasePriority.Click += new System.EventHandler(this.btDecreasePriority_Click);
            // 
            // lbPriorityValue
            // 
            this.lbPriorityValue.AutoSize = true;
            this.lbPriorityValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbPriorityValue.Location = new System.Drawing.Point(97, 30);
            this.lbPriorityValue.Name = "lbPriorityValue";
            this.lbPriorityValue.Size = new System.Drawing.Size(32, 19);
            this.lbPriorityValue.TabIndex = 4;
            this.lbPriorityValue.Text = "null";
            // 
            // lbProcessPrivilages
            // 
            this.lbProcessPrivilages.AutoSize = true;
            this.lbProcessPrivilages.Location = new System.Drawing.Point(6, 131);
            this.lbProcessPrivilages.Name = "lbProcessPrivilages";
            this.lbProcessPrivilages.Size = new System.Drawing.Size(127, 17);
            this.lbProcessPrivilages.TabIndex = 3;
            this.lbProcessPrivilages.Text = "Process privileges:";
            // 
            // cbMode
            // 
            this.cbMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMode.FormattingEnabled = true;
            this.cbMode.Items.AddRange(new object[] {
            "User",
            "Kernel"});
            this.cbMode.Location = new System.Drawing.Point(9, 151);
            this.cbMode.Name = "cbMode";
            this.cbMode.Size = new System.Drawing.Size(120, 24);
            this.cbMode.TabIndex = 2;
            this.cbMode.SelectedIndexChanged += new System.EventHandler(this.cbMode_SelectedIndexChanged);
            // 
            // lbPriorityLevel
            // 
            this.lbPriorityLevel.AutoSize = true;
            this.lbPriorityLevel.Location = new System.Drawing.Point(6, 30);
            this.lbPriorityLevel.Name = "lbPriorityLevel";
            this.lbPriorityLevel.Size = new System.Drawing.Size(89, 17);
            this.lbPriorityLevel.TabIndex = 1;
            this.lbPriorityLevel.Text = "Priority level:";
            // 
            // EditProcessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 303);
            this.Controls.Add(this.gbPriority);
            this.Controls.Add(this.gbData);
            this.Controls.Add(this.gbProcessGraphic);
            this.Controls.Add(this.btDone);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditProcessForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Editing \"null\"";
            this.Load += new System.EventHandler(this.EditProcessForm_Load);
            this.gbProcessGraphic.ResumeLayout(false);
            this.gbProcessGraphic.PerformLayout();
            this.gbData.ResumeLayout(false);
            this.gbData.PerformLayout();
            this.gbPriority.ResumeLayout(false);
            this.gbPriority.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btDone;
        private System.Windows.Forms.GroupBox gbProcessGraphic;
        private System.Windows.Forms.Label lbColor;
        private System.Windows.Forms.Panel pnCurrentColor;
        private System.Windows.Forms.Button btColorPicker;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.LinkLabel lnkProcessName;
        private System.Windows.Forms.Label lbArrivalTime;
        private System.Windows.Forms.Label lbDuration;
        private System.Windows.Forms.Label lbUnit2;
        private System.Windows.Forms.Label lbUnit1;
        private System.Windows.Forms.TextBox tbArrivalTime;
        private System.Windows.Forms.TextBox tbDuration;
        private System.Windows.Forms.Label lbProcessID;
        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.GroupBox gbPriority;
        private System.Windows.Forms.Label lbPriorityLevel;
        private System.Windows.Forms.ComboBox cbMode;
        private System.Windows.Forms.Label lbProcessPrivilages;
        private System.Windows.Forms.Label lbPriorityValue;
        private System.Windows.Forms.Button btDecreasePriority;
        private System.Windows.Forms.Button btIncreasePriority;
    }
}