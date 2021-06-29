
namespace CPU_Scheduler
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.btExit = new System.Windows.Forms.Button();
            this.lbTheme = new System.Windows.Forms.Label();
            this.gbAppearance = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbConfirmExit = new System.Windows.Forms.CheckBox();
            this.rbThemeColorDark = new System.Windows.Forms.RadioButton();
            this.rbThemeColorLight = new System.Windows.Forms.RadioButton();
            this.tabSettings = new System.Windows.Forms.TabControl();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.tabIO = new System.Windows.Forms.TabPage();
            this.gbDirectories = new System.Windows.Forms.GroupBox();
            this.tbSavepath = new System.Windows.Forms.TextBox();
            this.btBrowseFolder = new System.Windows.Forms.Button();
            this.lbSavePath = new System.Windows.Forms.Label();
            this.btApply = new System.Windows.Forms.Button();
            this.gbAppearance.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.tabIO.SuspendLayout();
            this.gbDirectories.SuspendLayout();
            this.SuspendLayout();
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(390, 259);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(93, 35);
            this.btExit.TabIndex = 0;
            this.btExit.Text = "Save / Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // lbTheme
            // 
            this.lbTheme.AutoSize = true;
            this.lbTheme.Location = new System.Drawing.Point(6, 26);
            this.lbTheme.Name = "lbTheme";
            this.lbTheme.Size = new System.Drawing.Size(165, 17);
            this.lbTheme.TabIndex = 3;
            this.lbTheme.Text = "Theme: (not working yet)";
            // 
            // gbAppearance
            // 
            this.gbAppearance.AutoSize = true;
            this.gbAppearance.Controls.Add(this.label1);
            this.gbAppearance.Controls.Add(this.cbConfirmExit);
            this.gbAppearance.Controls.Add(this.rbThemeColorDark);
            this.gbAppearance.Controls.Add(this.rbThemeColorLight);
            this.gbAppearance.Controls.Add(this.lbTheme);
            this.gbAppearance.Location = new System.Drawing.Point(8, 6);
            this.gbAppearance.Name = "gbAppearance";
            this.gbAppearance.Size = new System.Drawing.Size(471, 190);
            this.gbAppearance.TabIndex = 4;
            this.gbAppearance.TabStop = false;
            this.gbAppearance.Text = "Appearance";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "General";
            // 
            // cbConfirmExit
            // 
            this.cbConfirmExit.AutoSize = true;
            this.cbConfirmExit.Location = new System.Drawing.Point(6, 101);
            this.cbConfirmExit.Name = "cbConfirmExit";
            this.cbConfirmExit.Size = new System.Drawing.Size(123, 21);
            this.cbConfirmExit.TabIndex = 13;
            this.cbConfirmExit.Text = "Confirm on exit";
            this.cbConfirmExit.UseVisualStyleBackColor = true;
            this.cbConfirmExit.CheckedChanged += new System.EventHandler(this.cbConfirmExit_CheckedChanged);
            // 
            // rbThemeColorDark
            // 
            this.rbThemeColorDark.AutoSize = true;
            this.rbThemeColorDark.Location = new System.Drawing.Point(86, 46);
            this.rbThemeColorDark.Name = "rbThemeColorDark";
            this.rbThemeColorDark.Size = new System.Drawing.Size(59, 21);
            this.rbThemeColorDark.TabIndex = 5;
            this.rbThemeColorDark.Text = "Dark";
            this.rbThemeColorDark.UseVisualStyleBackColor = true;
            // 
            // rbThemeColorLight
            // 
            this.rbThemeColorLight.AutoSize = true;
            this.rbThemeColorLight.Checked = true;
            this.rbThemeColorLight.Location = new System.Drawing.Point(9, 46);
            this.rbThemeColorLight.Name = "rbThemeColorLight";
            this.rbThemeColorLight.Size = new System.Drawing.Size(60, 21);
            this.rbThemeColorLight.TabIndex = 4;
            this.rbThemeColorLight.TabStop = true;
            this.rbThemeColorLight.Text = "Light";
            this.rbThemeColorLight.UseVisualStyleBackColor = true;
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.tabGeneral);
            this.tabSettings.Controls.Add(this.tabIO);
            this.tabSettings.Location = new System.Drawing.Point(0, 0);
            this.tabSettings.Multiline = true;
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.SelectedIndex = 0;
            this.tabSettings.Size = new System.Drawing.Size(498, 253);
            this.tabSettings.TabIndex = 5;
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.gbAppearance);
            this.tabGeneral.Location = new System.Drawing.Point(4, 25);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(490, 224);
            this.tabGeneral.TabIndex = 0;
            this.tabGeneral.Text = "General";
            this.tabGeneral.UseVisualStyleBackColor = true;
            // 
            // tabIO
            // 
            this.tabIO.Controls.Add(this.gbDirectories);
            this.tabIO.Location = new System.Drawing.Point(4, 25);
            this.tabIO.Name = "tabIO";
            this.tabIO.Padding = new System.Windows.Forms.Padding(3);
            this.tabIO.Size = new System.Drawing.Size(490, 224);
            this.tabIO.TabIndex = 1;
            this.tabIO.Text = "I/O";
            this.tabIO.UseVisualStyleBackColor = true;
            // 
            // gbDirectories
            // 
            this.gbDirectories.Controls.Add(this.tbSavepath);
            this.gbDirectories.Controls.Add(this.btBrowseFolder);
            this.gbDirectories.Controls.Add(this.lbSavePath);
            this.gbDirectories.Location = new System.Drawing.Point(8, 6);
            this.gbDirectories.Name = "gbDirectories";
            this.gbDirectories.Size = new System.Drawing.Size(476, 155);
            this.gbDirectories.TabIndex = 7;
            this.gbDirectories.TabStop = false;
            this.gbDirectories.Text = "Directories";
            // 
            // tbSavepath
            // 
            this.tbSavepath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSavepath.Location = new System.Drawing.Point(6, 38);
            this.tbSavepath.Name = "tbSavepath";
            this.tbSavepath.ReadOnly = true;
            this.tbSavepath.Size = new System.Drawing.Size(346, 22);
            this.tbSavepath.TabIndex = 5;
            // 
            // btBrowseFolder
            // 
            this.btBrowseFolder.Location = new System.Drawing.Point(358, 36);
            this.btBrowseFolder.Name = "btBrowseFolder";
            this.btBrowseFolder.Size = new System.Drawing.Size(83, 24);
            this.btBrowseFolder.TabIndex = 6;
            this.btBrowseFolder.Text = "Browse";
            this.btBrowseFolder.UseVisualStyleBackColor = true;
            this.btBrowseFolder.Click += new System.EventHandler(this.btBrowseFolder_Click);
            // 
            // lbSavePath
            // 
            this.lbSavePath.AutoSize = true;
            this.lbSavePath.Location = new System.Drawing.Point(6, 18);
            this.lbSavePath.Name = "lbSavePath";
            this.lbSavePath.Size = new System.Drawing.Size(136, 17);
            this.lbSavePath.TabIndex = 4;
            this.lbSavePath.Text = "Current saving path:";
            // 
            // btApply
            // 
            this.btApply.Location = new System.Drawing.Point(319, 259);
            this.btApply.Name = "btApply";
            this.btApply.Size = new System.Drawing.Size(65, 35);
            this.btApply.TabIndex = 6;
            this.btApply.Text = "Apply";
            this.btApply.UseVisualStyleBackColor = true;
            this.btApply.Click += new System.EventHandler(this.btApply_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(495, 301);
            this.Controls.Add(this.btApply);
            this.Controls.Add(this.tabSettings);
            this.Controls.Add(this.btExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.gbAppearance.ResumeLayout(false);
            this.gbAppearance.PerformLayout();
            this.tabSettings.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.tabGeneral.PerformLayout();
            this.tabIO.ResumeLayout(false);
            this.gbDirectories.ResumeLayout(false);
            this.gbDirectories.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Label lbTheme;
        private System.Windows.Forms.GroupBox gbAppearance;
        private System.Windows.Forms.TabControl tabSettings;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.TabPage tabIO;
        private System.Windows.Forms.Button btBrowseFolder;
        private System.Windows.Forms.TextBox tbSavepath;
        private System.Windows.Forms.Label lbSavePath;
        private System.Windows.Forms.RadioButton rbThemeColorDark;
        private System.Windows.Forms.RadioButton rbThemeColorLight;
        private System.Windows.Forms.GroupBox gbDirectories;
        private System.Windows.Forms.Button btApply;
        private System.Windows.Forms.CheckBox cbConfirmExit;
        private System.Windows.Forms.Label label1;
    }
}