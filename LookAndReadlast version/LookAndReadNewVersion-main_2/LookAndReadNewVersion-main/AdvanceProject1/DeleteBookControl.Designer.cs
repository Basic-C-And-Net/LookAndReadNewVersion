namespace AdvanceProject1
{
    partial class DeleteBookControl
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
            this.buttonDeleteBook = new System.Windows.Forms.Button();
            this.cmbDeleteBookType = new System.Windows.Forms.ComboBox();
            this.richTextDeleteDescription = new System.Windows.Forms.RichTextBox();
            this.textDeletePrice = new System.Windows.Forms.TextBox();
            this.textDeleteAuthor = new System.Windows.Forms.TextBox();
            this.textDeleteName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonDeleteBook
            // 
            this.buttonDeleteBook.Location = new System.Drawing.Point(89, 159);
            this.buttonDeleteBook.Name = "buttonDeleteBook";
            this.buttonDeleteBook.Size = new System.Drawing.Size(100, 23);
            this.buttonDeleteBook.TabIndex = 33;
            this.buttonDeleteBook.Text = "Delete Book";
            this.buttonDeleteBook.UseVisualStyleBackColor = true;
            this.buttonDeleteBook.Click += new System.EventHandler(this.buttonDeleteBook_Click);
            // 
            // cmbDeleteBookType
            // 
            this.cmbDeleteBookType.Enabled = false;
            this.cmbDeleteBookType.FormattingEnabled = true;
            this.cmbDeleteBookType.Location = new System.Drawing.Point(89, 61);
            this.cmbDeleteBookType.Name = "cmbDeleteBookType";
            this.cmbDeleteBookType.Size = new System.Drawing.Size(100, 21);
            this.cmbDeleteBookType.TabIndex = 32;
            // 
            // richTextDeleteDescription
            // 
            this.richTextDeleteDescription.Enabled = false;
            this.richTextDeleteDescription.Location = new System.Drawing.Point(90, 111);
            this.richTextDeleteDescription.Name = "richTextDeleteDescription";
            this.richTextDeleteDescription.ReadOnly = true;
            this.richTextDeleteDescription.Size = new System.Drawing.Size(100, 42);
            this.richTextDeleteDescription.TabIndex = 31;
            this.richTextDeleteDescription.Text = "";
            // 
            // textDeletePrice
            // 
            this.textDeletePrice.Enabled = false;
            this.textDeletePrice.Location = new System.Drawing.Point(89, 85);
            this.textDeletePrice.Name = "textDeletePrice";
            this.textDeletePrice.ReadOnly = true;
            this.textDeletePrice.Size = new System.Drawing.Size(100, 20);
            this.textDeletePrice.TabIndex = 30;
            // 
            // textDeleteAuthor
            // 
            this.textDeleteAuthor.Enabled = false;
            this.textDeleteAuthor.Location = new System.Drawing.Point(89, 37);
            this.textDeleteAuthor.Name = "textDeleteAuthor";
            this.textDeleteAuthor.ReadOnly = true;
            this.textDeleteAuthor.Size = new System.Drawing.Size(100, 20);
            this.textDeleteAuthor.TabIndex = 29;
            // 
            // textDeleteName
            // 
            this.textDeleteName.Enabled = false;
            this.textDeleteName.Location = new System.Drawing.Point(89, 13);
            this.textDeleteName.Name = "textDeleteName";
            this.textDeleteName.ReadOnly = true;
            this.textDeleteName.Size = new System.Drawing.Size(100, 20);
            this.textDeleteName.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Description :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Price :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Book Type :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Author :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Name :";
            // 
            // DeleteBookControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonDeleteBook);
            this.Controls.Add(this.cmbDeleteBookType);
            this.Controls.Add(this.richTextDeleteDescription);
            this.Controls.Add(this.textDeletePrice);
            this.Controls.Add(this.textDeleteAuthor);
            this.Controls.Add(this.textDeleteName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DeleteBookControl";
            this.Size = new System.Drawing.Size(250, 187);
            this.Load += new System.EventHandler(this.DeleteBookControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDeleteBook;
        private System.Windows.Forms.ComboBox cmbDeleteBookType;
        private System.Windows.Forms.RichTextBox richTextDeleteDescription;
        private System.Windows.Forms.TextBox textDeletePrice;
        private System.Windows.Forms.TextBox textDeleteAuthor;
        private System.Windows.Forms.TextBox textDeleteName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
