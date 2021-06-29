
namespace CPU_Scheduler
{
    partial class ChangeNameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeNameForm));
            this.gbName = new System.Windows.Forms.GroupBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btChangeName = new System.Windows.Forms.Button();
            this.gbName.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbName
            // 
            this.gbName.Controls.Add(this.tbName);
            this.gbName.Controls.Add(this.btChangeName);
            this.gbName.Location = new System.Drawing.Point(12, 12);
            this.gbName.Name = "gbName";
            this.gbName.Size = new System.Drawing.Size(363, 100);
            this.gbName.TabIndex = 0;
            this.gbName.TabStop = false;
            this.gbName.Text = "Process Name";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(6, 23);
            this.tbName.MaxLength = 16;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(351, 22);
            this.tbName.TabIndex = 2;
            this.tbName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbName_KeyUp);
            // 
            // btChangeName
            // 
            this.btChangeName.Location = new System.Drawing.Point(259, 51);
            this.btChangeName.Name = "btChangeName";
            this.btChangeName.Size = new System.Drawing.Size(98, 43);
            this.btChangeName.TabIndex = 1;
            this.btChangeName.Text = "Change";
            this.btChangeName.UseVisualStyleBackColor = true;
            this.btChangeName.Click += new System.EventHandler(this.btChangeName_Click);
            // 
            // ChangeNameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 121);
            this.Controls.Add(this.gbName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChangeNameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Change process name";
            this.Load += new System.EventHandler(this.ChangeNameForm_Load);
            this.gbName.ResumeLayout(false);
            this.gbName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btChangeName;
    }
}