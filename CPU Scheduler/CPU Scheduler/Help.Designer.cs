
using System;

namespace CPU_Scheduler
{
    partial class HelpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpForm));
            this.picGithub = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picInstagram = new System.Windows.Forms.PictureBox();
            this.picLinkedin = new System.Windows.Forms.PictureBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbDescription = new System.Windows.Forms.Label();
            this.lbVersion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picGithub)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picInstagram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLinkedin)).BeginInit();
            this.SuspendLayout();
            // 
            // picGithub
            // 
            this.picGithub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picGithub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGithub.ErrorImage = null;
            this.picGithub.Image = ((System.Drawing.Image)(resources.GetObject("picGithub.Image")));
            this.picGithub.InitialImage = null;
            this.picGithub.Location = new System.Drawing.Point(6, 15);
            this.picGithub.Name = "picGithub";
            this.picGithub.Size = new System.Drawing.Size(50, 50);
            this.picGithub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGithub.TabIndex = 1;
            this.picGithub.TabStop = false;
            this.picGithub.Click += new System.EventHandler(this.picGithub_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picInstagram);
            this.groupBox1.Controls.Add(this.picLinkedin);
            this.groupBox1.Controls.Add(this.picGithub);
            this.groupBox1.Location = new System.Drawing.Point(421, 218);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 75);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // picInstagram
            // 
            this.picInstagram.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picInstagram.Image = ((System.Drawing.Image)(resources.GetObject("picInstagram.Image")));
            this.picInstagram.Location = new System.Drawing.Point(144, 15);
            this.picInstagram.Name = "picInstagram";
            this.picInstagram.Size = new System.Drawing.Size(50, 50);
            this.picInstagram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picInstagram.TabIndex = 3;
            this.picInstagram.TabStop = false;
            this.picInstagram.Click += new System.EventHandler(this.picInstagram_Click);
            // 
            // picLinkedin
            // 
            this.picLinkedin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLinkedin.Image = ((System.Drawing.Image)(resources.GetObject("picLinkedin.Image")));
            this.picLinkedin.Location = new System.Drawing.Point(74, 15);
            this.picLinkedin.Name = "picLinkedin";
            this.picLinkedin.Size = new System.Drawing.Size(50, 50);
            this.picLinkedin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLinkedin.TabIndex = 2;
            this.picLinkedin.TabStop = false;
            this.picLinkedin.Click += new System.EventHandler(this.picLinkedin_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lbTitle.Location = new System.Drawing.Point(12, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(173, 26);
            this.lbTitle.TabIndex = 3;
            this.lbTitle.Text = "How to use this?";
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbDescription.Location = new System.Drawing.Point(17, 48);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(607, 54);
            this.lbDescription.TabIndex = 4;
            this.lbDescription.Text = resources.GetString("lbDescription.Text");
            // 
            // lbVersion
            // 
            this.lbVersion.AutoSize = true;
            this.lbVersion.Location = new System.Drawing.Point(282, 266);
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.Size = new System.Drawing.Size(54, 17);
            this.lbVersion.TabIndex = 5;
            this.lbVersion.Text = "version";
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 305);
            this.Controls.Add(this.lbVersion);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HelpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Help";
            this.Load += new System.EventHandler(this.HelpForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picGithub)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picInstagram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLinkedin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picGithub;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox picInstagram;
        private System.Windows.Forms.PictureBox picLinkedin;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Label lbVersion;
    }
}