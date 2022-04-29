namespace War_Z_ESP_version_1
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.login = new System.Windows.Forms.Button();
            this.KeyBox = new System.Windows.Forms.TextBox();
            this.AboutLink = new System.Windows.Forms.LinkLabel();
            this.ActiveBox = new System.Windows.Forms.TextBox();
            this.KeyLink = new System.Windows.Forms.LinkLabel();
            this.KeyBuyLink = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.Transparent;
            this.login.BackgroundImage = global::War_Z_ESP_version_1.Properties.Resources.login_bot_2;
            this.login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.login.FlatAppearance.BorderSize = 0;
            this.login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login.ForeColor = System.Drawing.Color.Transparent;
            this.login.Location = new System.Drawing.Point(263, 445);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(260, 58);
            this.login.TabIndex = 0;
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // KeyBox
            // 
            this.KeyBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.KeyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyBox.Location = new System.Drawing.Point(181, 377);
            this.KeyBox.MaxLength = 12;
            this.KeyBox.Name = "KeyBox";
            this.KeyBox.Size = new System.Drawing.Size(415, 24);
            this.KeyBox.TabIndex = 1;
            this.KeyBox.TextChanged += new System.EventHandler(this.KeyBox_TextChanged);
            // 
            // AboutLink
            // 
            this.AboutLink.AutoSize = true;
            this.AboutLink.BackColor = System.Drawing.Color.Transparent;
            this.AboutLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutLink.LinkColor = System.Drawing.Color.White;
            this.AboutLink.Location = new System.Drawing.Point(694, 582);
            this.AboutLink.Name = "AboutLink";
            this.AboutLink.Size = new System.Drawing.Size(60, 24);
            this.AboutLink.TabIndex = 2;
            this.AboutLink.TabStop = true;
            this.AboutLink.Text = "About";
            this.AboutLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AboutLink_LinkClicked);
            // 
            // ActiveBox
            // 
            this.ActiveBox.Location = new System.Drawing.Point(653, 13);
            this.ActiveBox.Name = "ActiveBox";
            this.ActiveBox.ReadOnly = true;
            this.ActiveBox.Size = new System.Drawing.Size(100, 20);
            this.ActiveBox.TabIndex = 3;
            this.ActiveBox.Text = "Reissued";
            this.ActiveBox.Visible = false;
            // 
            // KeyLink
            // 
            this.KeyLink.ActiveLinkColor = System.Drawing.Color.White;
            this.KeyLink.AutoSize = true;
            this.KeyLink.BackColor = System.Drawing.Color.Transparent;
            this.KeyLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KeyLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyLink.LinkColor = System.Drawing.SystemColors.Window;
            this.KeyLink.Location = new System.Drawing.Point(249, 300);
            this.KeyLink.Name = "KeyLink";
            this.KeyLink.Size = new System.Drawing.Size(296, 25);
            this.KeyLink.TabIndex = 4;
            this.KeyLink.TabStop = true;
            this.KeyLink.Text = "Your Key can be found HERE";
            this.KeyLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // KeyBuyLink
            // 
            this.KeyBuyLink.AutoSize = true;
            this.KeyBuyLink.BackColor = System.Drawing.Color.Transparent;
            this.KeyBuyLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KeyBuyLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyBuyLink.ForeColor = System.Drawing.Color.White;
            this.KeyBuyLink.Location = new System.Drawing.Point(500, 407);
            this.KeyBuyLink.Name = "KeyBuyLink";
            this.KeyBuyLink.Size = new System.Drawing.Size(106, 20);
            this.KeyBuyLink.TabIndex = 6;
            this.KeyBuyLink.Text = "Purchase Key";
            this.KeyBuyLink.Click += new System.EventHandler(this.KeyBuyLink_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::War_Z_ESP_version_1.Properties.Resources.hack_login_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(766, 615);
            this.Controls.Add(this.KeyBuyLink);
            this.Controls.Add(this.KeyLink);
            this.Controls.Add(this.ActiveBox);
            this.Controls.Add(this.AboutLink);
            this.Controls.Add(this.KeyBox);
            this.Controls.Add(this.login);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(782, 653);
            this.MinimumSize = new System.Drawing.Size(782, 653);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WarZ Hack";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login;
        private System.Windows.Forms.TextBox KeyBox;
        private System.Windows.Forms.LinkLabel AboutLink;
        private System.Windows.Forms.TextBox ActiveBox;
        private System.Windows.Forms.LinkLabel KeyLink;
        private System.Windows.Forms.Label KeyBuyLink;
    }
}