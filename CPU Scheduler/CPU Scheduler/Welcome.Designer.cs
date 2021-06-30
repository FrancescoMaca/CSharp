
namespace CPU_Scheduler
{
    partial class WelcomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeForm));
            this.lbExplaination = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.ttEmailCopied = new System.Windows.Forms.ToolTip(this.components);
            this.pbGif = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbGif)).BeginInit();
            this.SuspendLayout();
            // 
            // lbExplaination
            // 
            this.lbExplaination.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExplaination.Location = new System.Drawing.Point(11, 71);
            this.lbExplaination.Name = "lbExplaination";
            this.lbExplaination.Size = new System.Drawing.Size(647, 87);
            this.lbExplaination.TabIndex = 0;
            this.lbExplaination.Text = resources.GetString("lbExplaination.Text");
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Russo One", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(9, 23);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(228, 36);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Hey, hi there!";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Arial", 10.2F);
            this.lbEmail.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbEmail.Location = new System.Drawing.Point(11, 109);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(275, 19);
            this.lbEmail.TabIndex = 2;
            this.lbEmail.Text = "francesco.macaluso@allievi.bearzi.it\r\n";
            this.lbEmail.Click += new System.EventHandler(this.lbEmail_Click);
            // 
            // pbGif
            // 
            this.pbGif.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbGif.BackgroundImage")));
            this.pbGif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbGif.Cursor = System.Windows.Forms.Cursors.No;
            this.pbGif.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pbGif.ErrorImage")));
            this.pbGif.Image = ((System.Drawing.Image)(resources.GetObject("pbGif.Image")));
            this.pbGif.InitialImage = null;
            this.pbGif.Location = new System.Drawing.Point(416, 114);
            this.pbGif.Name = "pbGif";
            this.pbGif.Size = new System.Drawing.Size(223, 213);
            this.pbGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbGif.TabIndex = 3;
            this.pbGif.TabStop = false;
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 334);
            this.Controls.Add(this.pbGif);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.lbExplaination);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WelcomeForm";
            this.Text = "Application still in development...";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pbGif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbExplaination;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.ToolTip ttEmailCopied;
        private System.Windows.Forms.PictureBox pbGif;
    }
}