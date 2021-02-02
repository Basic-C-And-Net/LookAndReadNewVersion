namespace AdvanceProject1
{
    partial class UpdateBookControl
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
            this.buttonUpdateBook = new System.Windows.Forms.Button();
            this.cmbUpdateBookType = new System.Windows.Forms.ComboBox();
            this.richTextUpdateDescription = new System.Windows.Forms.RichTextBox();
            this.textUpdatePrice = new System.Windows.Forms.TextBox();
            this.textUpdateAuthor = new System.Windows.Forms.TextBox();
            this.textUpdateName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonUpdateBook
            // 
            this.buttonUpdateBook.Location = new System.Drawing.Point(91, 156);
            this.buttonUpdateBook.Name = "buttonUpdateBook";
            this.buttonUpdateBook.Size = new System.Drawing.Size(100, 23);
            this.buttonUpdateBook.TabIndex = 22;
            this.buttonUpdateBook.Text = "Update Book";
            this.buttonUpdateBook.UseVisualStyleBackColor = true;
            this.buttonUpdateBook.Click += new System.EventHandler(this.buttonUpdateBook_Click);
            // 
            // cmbUpdateBookType
            // 
            this.cmbUpdateBookType.Enabled = false;
            this.cmbUpdateBookType.FormattingEnabled = true;
            this.cmbUpdateBookType.Location = new System.Drawing.Point(91, 58);
            this.cmbUpdateBookType.Name = "cmbUpdateBookType";
            this.cmbUpdateBookType.Size = new System.Drawing.Size(100, 21);
            this.cmbUpdateBookType.TabIndex = 21;
            // 
            // richTextUpdateDescription
            // 
            this.richTextUpdateDescription.Location = new System.Drawing.Point(92, 108);
            this.richTextUpdateDescription.Name = "richTextUpdateDescription";
            this.richTextUpdateDescription.Size = new System.Drawing.Size(100, 42);
            this.richTextUpdateDescription.TabIndex = 20;
            this.richTextUpdateDescription.Text = "";
            // 
            // textUpdatePrice
            // 
            this.textUpdatePrice.Location = new System.Drawing.Point(91, 82);
            this.textUpdatePrice.Name = "textUpdatePrice";
            this.textUpdatePrice.Size = new System.Drawing.Size(100, 20);
            this.textUpdatePrice.TabIndex = 19;
            // 
            // textUpdateAuthor
            // 
            this.textUpdateAuthor.Enabled = false;
            this.textUpdateAuthor.Location = new System.Drawing.Point(91, 34);
            this.textUpdateAuthor.Name = "textUpdateAuthor";
            this.textUpdateAuthor.Size = new System.Drawing.Size(100, 20);
            this.textUpdateAuthor.TabIndex = 18;
            // 
            // textUpdateName
            // 
            this.textUpdateName.Enabled = false;
            this.textUpdateName.Location = new System.Drawing.Point(91, 10);
            this.textUpdateName.Name = "textUpdateName";
            this.textUpdateName.Size = new System.Drawing.Size(100, 20);
            this.textUpdateName.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Description :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Price :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Book Type :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Author :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Name :";
            // 
            // UpdateBookControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonUpdateBook);
            this.Controls.Add(this.cmbUpdateBookType);
            this.Controls.Add(this.richTextUpdateDescription);
            this.Controls.Add(this.textUpdatePrice);
            this.Controls.Add(this.textUpdateAuthor);
            this.Controls.Add(this.textUpdateName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdateBookControl";
            this.Size = new System.Drawing.Size(250, 187);
            this.Load += new System.EventHandler(this.UpdateBookControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUpdateBook;
        private System.Windows.Forms.ComboBox cmbUpdateBookType;
        private System.Windows.Forms.RichTextBox richTextUpdateDescription;
        private System.Windows.Forms.TextBox textUpdatePrice;
        private System.Windows.Forms.TextBox textUpdateAuthor;
        private System.Windows.Forms.TextBox textUpdateName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
