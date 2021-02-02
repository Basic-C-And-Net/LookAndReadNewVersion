namespace AdvanceProject1
{
    partial class AddBookControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textAddName = new System.Windows.Forms.TextBox();
            this.textAddAuthor = new System.Windows.Forms.TextBox();
            this.textAddPrice = new System.Windows.Forms.TextBox();
            this.richTextAddDescription = new System.Windows.Forms.RichTextBox();
            this.cmbAddBookType = new System.Windows.Forms.ComboBox();
            this.buttonAddBook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Author :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Book Type :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Price :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Description :";
            // 
            // textAddName
            // 
            this.textAddName.Location = new System.Drawing.Point(84, 11);
            this.textAddName.Name = "textAddName";
            this.textAddName.Size = new System.Drawing.Size(100, 20);
            this.textAddName.TabIndex = 1;
            // 
            // textAddAuthor
            // 
            this.textAddAuthor.Location = new System.Drawing.Point(84, 35);
            this.textAddAuthor.Name = "textAddAuthor";
            this.textAddAuthor.Size = new System.Drawing.Size(100, 20);
            this.textAddAuthor.TabIndex = 2;
            // 
            // textAddPrice
            // 
            this.textAddPrice.Location = new System.Drawing.Point(84, 83);
            this.textAddPrice.Name = "textAddPrice";
            this.textAddPrice.Size = new System.Drawing.Size(100, 20);
            this.textAddPrice.TabIndex = 4;
            // 
            // richTextAddDescription
            // 
            this.richTextAddDescription.Location = new System.Drawing.Point(85, 109);
            this.richTextAddDescription.Name = "richTextAddDescription";
            this.richTextAddDescription.Size = new System.Drawing.Size(100, 42);
            this.richTextAddDescription.TabIndex = 5;
            this.richTextAddDescription.Text = "";
            // 
            // cmbAddBookType
            // 
            this.cmbAddBookType.FormattingEnabled = true;
            this.cmbAddBookType.Location = new System.Drawing.Point(84, 59);
            this.cmbAddBookType.Name = "cmbAddBookType";
            this.cmbAddBookType.Size = new System.Drawing.Size(100, 21);
            this.cmbAddBookType.TabIndex = 3;
            // 
            // buttonAddBook
            // 
            this.buttonAddBook.Location = new System.Drawing.Point(84, 157);
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Size = new System.Drawing.Size(100, 23);
            this.buttonAddBook.TabIndex = 11;
            this.buttonAddBook.Text = "Add Book";
            this.buttonAddBook.UseVisualStyleBackColor = true;
            this.buttonAddBook.Click += new System.EventHandler(this.buttonAddBook_Click);
            // 
            // AddBookControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonAddBook);
            this.Controls.Add(this.cmbAddBookType);
            this.Controls.Add(this.richTextAddDescription);
            this.Controls.Add(this.textAddPrice);
            this.Controls.Add(this.textAddAuthor);
            this.Controls.Add(this.textAddName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddBookControl";
            this.Size = new System.Drawing.Size(250, 187);
            this.Load += new System.EventHandler(this.AddBookControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textAddName;
        private System.Windows.Forms.TextBox textAddAuthor;
        private System.Windows.Forms.TextBox textAddPrice;
        private System.Windows.Forms.RichTextBox richTextAddDescription;
        private System.Windows.Forms.ComboBox cmbAddBookType;
        private System.Windows.Forms.Button buttonAddBook;
    }
}
