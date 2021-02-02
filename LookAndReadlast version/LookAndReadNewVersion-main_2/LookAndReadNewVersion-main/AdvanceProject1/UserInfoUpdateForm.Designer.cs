namespace AdvanceProject1
{
    partial class UserInfoUpdateForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textUsername = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.mskPhone = new System.Windows.Forms.MaskedTextBox();
            this.textSurname = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textUsername
            // 
            this.textUsername.Enabled = false;
            this.textUsername.Location = new System.Drawing.Point(99, 83);
            this.textUsername.Name = "textUsername";
            this.textUsername.ReadOnly = true;
            this.textUsername.Size = new System.Drawing.Size(119, 20);
            this.textUsername.TabIndex = 45;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(26, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 44;
            this.label9.Text = "User Name :";
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(99, 109);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(119, 20);
            this.textPassword.TabIndex = 43;
            this.textPassword.UseSystemPasswordChar = true;
            // 
            // mskPhone
            // 
            this.mskPhone.Location = new System.Drawing.Point(99, 135);
            this.mskPhone.Mask = "(999) 0000000";
            this.mskPhone.Name = "mskPhone";
            this.mskPhone.Size = new System.Drawing.Size(119, 20);
            this.mskPhone.TabIndex = 42;
            // 
            // textSurname
            // 
            this.textSurname.Location = new System.Drawing.Point(99, 57);
            this.textSurname.Name = "textSurname";
            this.textSurname.Size = new System.Drawing.Size(119, 20);
            this.textSurname.TabIndex = 41;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(99, 31);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(119, 20);
            this.textName.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(31, 109);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Password :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(8, 134);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Phone Number :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(37, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Surname :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(51, 34);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Name :";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(66, 185);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(119, 23);
            this.buttonUpdate.TabIndex = 46;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // UserInfoUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.textUsername);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.mskPhone);
            this.Controls.Add(this.textSurname);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Name = "UserInfoUpdateForm";
            this.Size = new System.Drawing.Size(245, 235);
            this.Load += new System.EventHandler(this.UserInfoUpdateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textUsername;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.MaskedTextBox mskPhone;
        private System.Windows.Forms.TextBox textSurname;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonUpdate;
    }
}
