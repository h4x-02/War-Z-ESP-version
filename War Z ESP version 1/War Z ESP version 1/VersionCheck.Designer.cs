namespace War_Z_ESP_version_1
{
    partial class VersionCheck
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VersionCheck));
            this.button1 = new System.Windows.Forms.Button();
            this.VerBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(296, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Check For Updates + Security";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // VerBox
            // 
            this.VerBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.VerBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.VerBox.Location = new System.Drawing.Point(265, 65);
            this.VerBox.Name = "VerBox";
            this.VerBox.ReadOnly = true;
            this.VerBox.Size = new System.Drawing.Size(43, 13);
            this.VerBox.TabIndex = 1;
            this.VerBox.Text = "1.0.1.A";
            this.VerBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.VerBox.TextChanged += new System.EventHandler(this.VerBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Version:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // VersionCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 80);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VerBox);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(336, 118);
            this.MinimumSize = new System.Drawing.Size(336, 118);
            this.Name = "VersionCheck";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WarZ Hack Version Checker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox VerBox;
        private System.Windows.Forms.Label label1;
    }
}