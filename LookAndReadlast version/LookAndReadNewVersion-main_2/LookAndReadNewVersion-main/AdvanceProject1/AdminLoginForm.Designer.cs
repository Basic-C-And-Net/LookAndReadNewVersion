namespace AdvanceProject1
{
    partial class AdminLoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLoginForm));
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.loginButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.textPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.textUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(533, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(72, 56);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 31);
            this.label3.TabIndex = 20;
            this.label3.Text = "Admin Login";
            // 
            // loginButton
            // 
            this.loginButton.Animated = true;
            this.loginButton.AutoRoundedCorners = true;
            this.loginButton.BorderRadius = 17;
            this.loginButton.CheckedState.Parent = this.loginButton;
            this.loginButton.CustomImages.Parent = this.loginButton;
            this.loginButton.FillColor = System.Drawing.Color.IndianRed;
            this.loginButton.FillColor2 = System.Drawing.Color.OrangeRed;
            this.loginButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.HoverState.Parent = this.loginButton;
            this.loginButton.Location = new System.Drawing.Point(320, 162);
            this.loginButton.Margin = new System.Windows.Forms.Padding(2);
            this.loginButton.Name = "loginButton";
            this.loginButton.ShadowDecoration.Parent = this.loginButton;
            this.loginButton.Size = new System.Drawing.Size(189, 37);
            this.loginButton.TabIndex = 17;
            this.loginButton.Text = "LOGIN";
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // textPassword
            // 
            this.textPassword.Animated = true;
            this.textPassword.BorderRadius = 8;
            this.textPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textPassword.DefaultText = "";
            this.textPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textPassword.DisabledState.Parent = this.textPassword;
            this.textPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.textPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textPassword.FocusedState.Parent = this.textPassword;
            this.textPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textPassword.HoverState.Parent = this.textPassword;
            this.textPassword.IconLeft = ((System.Drawing.Image)(resources.GetObject("textPassword.IconLeft")));
            this.textPassword.Location = new System.Drawing.Point(78, 170);
            this.textPassword.Margin = new System.Windows.Forms.Padding(2);
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '\0';
            this.textPassword.PlaceholderText = "Password";
            this.textPassword.SelectedText = "";
            this.textPassword.ShadowDecoration.Parent = this.textPassword;
            this.textPassword.Size = new System.Drawing.Size(189, 29);
            this.textPassword.TabIndex = 14;
            this.textPassword.UseSystemPasswordChar = true;
            // 
            // textUsername
            // 
            this.textUsername.Animated = true;
            this.textUsername.BorderRadius = 8;
            this.textUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textUsername.DefaultText = "";
            this.textUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textUsername.DisabledState.Parent = this.textUsername;
            this.textUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textUsername.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.textUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textUsername.FocusedState.Parent = this.textUsername;
            this.textUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textUsername.HoverState.Parent = this.textUsername;
            this.textUsername.IconLeft = ((System.Drawing.Image)(resources.GetObject("textUsername.IconLeft")));
            this.textUsername.Location = new System.Drawing.Point(78, 114);
            this.textUsername.Margin = new System.Windows.Forms.Padding(2);
            this.textUsername.Name = "textUsername";
            this.textUsername.PasswordChar = '\0';
            this.textUsername.PlaceholderText = "User Name";
            this.textUsername.SelectedText = "";
            this.textUsername.ShadowDecoration.Parent = this.textUsername;
            this.textUsername.Size = new System.Drawing.Size(189, 29);
            this.textUsername.TabIndex = 13;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.Location = new System.Drawing.Point(-8, 250);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(764, 203);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 12;
            this.guna2PictureBox1.TabStop = false;
            // 
            // AdminLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 446);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textUsername);
            this.Controls.Add(this.guna2PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminLoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2GradientButton loginButton;
        private Guna.UI2.WinForms.Guna2TextBox textPassword;
        private Guna.UI2.WinForms.Guna2TextBox textUsername;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}