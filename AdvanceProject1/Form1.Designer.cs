﻿
namespace AdvanceProject1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelInform = new System.Windows.Forms.Panel();
            this.ıconButtonWebPage = new FontAwesome.Sharp.IconButton();
            this.ıconButtonTwitter = new FontAwesome.Sharp.IconButton();
            this.ıconButtonInsta = new FontAwesome.Sharp.IconButton();
            this.ıconButtonInform = new FontAwesome.Sharp.IconButton();
            this.panelSide = new System.Windows.Forms.Panel();
            this.panelBook = new System.Windows.Forms.Panel();
            this.ıconButton4 = new FontAwesome.Sharp.IconButton();
            this.ıconButton3 = new FontAwesome.Sharp.IconButton();
            this.ıconButtonBook = new FontAwesome.Sharp.IconButton();
            this.ıconButtonShopping = new FontAwesome.Sharp.IconButton();
            this.ıconButtonHome = new FontAwesome.Sharp.IconButton();
            this.panelTimer = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMovement = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelSide2 = new System.Windows.Forms.Panel();
            this.panelLeft.SuspendLayout();
            this.panelInform.SuspendLayout();
            this.panelBook.SuspendLayout();
            this.panelTimer.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(119)))), ((int)(((byte)(108)))));
            this.panelLeft.Controls.Add(this.panelSide2);
            this.panelLeft.Controls.Add(this.panelInform);
            this.panelLeft.Controls.Add(this.ıconButtonInform);
            this.panelLeft.Controls.Add(this.panelSide);
            this.panelLeft.Controls.Add(this.panelBook);
            this.panelLeft.Controls.Add(this.ıconButtonBook);
            this.panelLeft.Controls.Add(this.ıconButtonShopping);
            this.panelLeft.Controls.Add(this.ıconButtonHome);
            this.panelLeft.Controls.Add(this.panelTimer);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Font = new System.Drawing.Font("Noto Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(237, 725);
            this.panelLeft.TabIndex = 0;
            // 
            // panelInform
            // 
            this.panelInform.Controls.Add(this.ıconButtonWebPage);
            this.panelInform.Controls.Add(this.ıconButtonTwitter);
            this.panelInform.Controls.Add(this.ıconButtonInsta);
            this.panelInform.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInform.Location = new System.Drawing.Point(0, 482);
            this.panelInform.Name = "panelInform";
            this.panelInform.Size = new System.Drawing.Size(237, 174);
            this.panelInform.TabIndex = 6;
            // 
            // ıconButtonWebPage
            // 
            this.ıconButtonWebPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(138)))), ((int)(((byte)(133)))));
            this.ıconButtonWebPage.Dock = System.Windows.Forms.DockStyle.Top;
            this.ıconButtonWebPage.FlatAppearance.BorderSize = 0;
            this.ıconButtonWebPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıconButtonWebPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(232)))));
            this.ıconButtonWebPage.IconChar = FontAwesome.Sharp.IconChar.Weebly;
            this.ıconButtonWebPage.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(16)))), ((int)(((byte)(2)))));
            this.ıconButtonWebPage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconButtonWebPage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButtonWebPage.Location = new System.Drawing.Point(0, 110);
            this.ıconButtonWebPage.Name = "ıconButtonWebPage";
            this.ıconButtonWebPage.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.ıconButtonWebPage.Size = new System.Drawing.Size(237, 55);
            this.ıconButtonWebPage.TabIndex = 9;
            this.ıconButtonWebPage.Text = "WEBPAGE";
            this.ıconButtonWebPage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButtonWebPage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ıconButtonWebPage.UseVisualStyleBackColor = false;
            // 
            // ıconButtonTwitter
            // 
            this.ıconButtonTwitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(138)))), ((int)(((byte)(133)))));
            this.ıconButtonTwitter.Dock = System.Windows.Forms.DockStyle.Top;
            this.ıconButtonTwitter.FlatAppearance.BorderSize = 0;
            this.ıconButtonTwitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıconButtonTwitter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(232)))));
            this.ıconButtonTwitter.IconChar = FontAwesome.Sharp.IconChar.Twitter;
            this.ıconButtonTwitter.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(16)))), ((int)(((byte)(2)))));
            this.ıconButtonTwitter.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconButtonTwitter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButtonTwitter.Location = new System.Drawing.Point(0, 55);
            this.ıconButtonTwitter.Name = "ıconButtonTwitter";
            this.ıconButtonTwitter.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.ıconButtonTwitter.Size = new System.Drawing.Size(237, 55);
            this.ıconButtonTwitter.TabIndex = 8;
            this.ıconButtonTwitter.Text = "TWITTER";
            this.ıconButtonTwitter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButtonTwitter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ıconButtonTwitter.UseVisualStyleBackColor = false;
            // 
            // ıconButtonInsta
            // 
            this.ıconButtonInsta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(138)))), ((int)(((byte)(133)))));
            this.ıconButtonInsta.Dock = System.Windows.Forms.DockStyle.Top;
            this.ıconButtonInsta.FlatAppearance.BorderSize = 0;
            this.ıconButtonInsta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıconButtonInsta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(232)))));
            this.ıconButtonInsta.IconChar = FontAwesome.Sharp.IconChar.Instagram;
            this.ıconButtonInsta.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(16)))), ((int)(((byte)(2)))));
            this.ıconButtonInsta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconButtonInsta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButtonInsta.Location = new System.Drawing.Point(0, 0);
            this.ıconButtonInsta.Name = "ıconButtonInsta";
            this.ıconButtonInsta.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.ıconButtonInsta.Size = new System.Drawing.Size(237, 55);
            this.ıconButtonInsta.TabIndex = 7;
            this.ıconButtonInsta.Text = "INSTAGRAM";
            this.ıconButtonInsta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButtonInsta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ıconButtonInsta.UseVisualStyleBackColor = false;
            // 
            // ıconButtonInform
            // 
            this.ıconButtonInform.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(138)))), ((int)(((byte)(133)))));
            this.ıconButtonInform.Dock = System.Windows.Forms.DockStyle.Top;
            this.ıconButtonInform.FlatAppearance.BorderSize = 0;
            this.ıconButtonInform.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıconButtonInform.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(232)))));
            this.ıconButtonInform.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            this.ıconButtonInform.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(16)))), ((int)(((byte)(2)))));
            this.ıconButtonInform.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconButtonInform.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButtonInform.Location = new System.Drawing.Point(0, 427);
            this.ıconButtonInform.Name = "ıconButtonInform";
            this.ıconButtonInform.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.ıconButtonInform.Size = new System.Drawing.Size(237, 55);
            this.ıconButtonInform.TabIndex = 5;
            this.ıconButtonInform.Text = "INFORMATION";
            this.ıconButtonInform.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButtonInform.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ıconButtonInform.UseVisualStyleBackColor = false;
            this.ıconButtonInform.Click += new System.EventHandler(this.ıconButtonInform_Click);
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(119)))), ((int)(((byte)(108)))));
            this.panelSide.Location = new System.Drawing.Point(3, 155);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(10, 46);
            this.panelSide.TabIndex = 0;
            // 
            // panelBook
            // 
            this.panelBook.Controls.Add(this.ıconButton4);
            this.panelBook.Controls.Add(this.ıconButton3);
            this.panelBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBook.Location = new System.Drawing.Point(0, 317);
            this.panelBook.Name = "panelBook";
            this.panelBook.Size = new System.Drawing.Size(237, 110);
            this.panelBook.TabIndex = 4;
            // 
            // ıconButton4
            // 
            this.ıconButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(138)))), ((int)(((byte)(133)))));
            this.ıconButton4.Dock = System.Windows.Forms.DockStyle.Top;
            this.ıconButton4.FlatAppearance.BorderSize = 0;
            this.ıconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıconButton4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(232)))));
            this.ıconButton4.IconChar = FontAwesome.Sharp.IconChar.RemoveFormat;
            this.ıconButton4.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(16)))), ((int)(((byte)(2)))));
            this.ıconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButton4.Location = new System.Drawing.Point(0, 55);
            this.ıconButton4.Name = "ıconButton4";
            this.ıconButton4.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.ıconButton4.Size = new System.Drawing.Size(237, 55);
            this.ıconButton4.TabIndex = 7;
            this.ıconButton4.Text = "BOOK";
            this.ıconButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ıconButton4.UseVisualStyleBackColor = false;
            // 
            // ıconButton3
            // 
            this.ıconButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(138)))), ((int)(((byte)(133)))));
            this.ıconButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.ıconButton3.FlatAppearance.BorderSize = 0;
            this.ıconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıconButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(232)))));
            this.ıconButton3.IconChar = FontAwesome.Sharp.IconChar.Readme;
            this.ıconButton3.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(16)))), ((int)(((byte)(2)))));
            this.ıconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButton3.Location = new System.Drawing.Point(0, 0);
            this.ıconButton3.Name = "ıconButton3";
            this.ıconButton3.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.ıconButton3.Size = new System.Drawing.Size(237, 55);
            this.ıconButton3.TabIndex = 6;
            this.ıconButton3.Text = "MAGAZINE";
            this.ıconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ıconButton3.UseVisualStyleBackColor = false;
            // 
            // ıconButtonBook
            // 
            this.ıconButtonBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(138)))), ((int)(((byte)(133)))));
            this.ıconButtonBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.ıconButtonBook.FlatAppearance.BorderSize = 0;
            this.ıconButtonBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıconButtonBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(232)))));
            this.ıconButtonBook.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.ıconButtonBook.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(16)))), ((int)(((byte)(2)))));
            this.ıconButtonBook.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconButtonBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButtonBook.Location = new System.Drawing.Point(0, 262);
            this.ıconButtonBook.Name = "ıconButtonBook";
            this.ıconButtonBook.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.ıconButtonBook.Size = new System.Drawing.Size(237, 55);
            this.ıconButtonBook.TabIndex = 3;
            this.ıconButtonBook.Text = "BOOK";
            this.ıconButtonBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButtonBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ıconButtonBook.UseVisualStyleBackColor = false;
            this.ıconButtonBook.Click += new System.EventHandler(this.ıconButton2_Click);
            // 
            // ıconButtonShopping
            // 
            this.ıconButtonShopping.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(138)))), ((int)(((byte)(133)))));
            this.ıconButtonShopping.Dock = System.Windows.Forms.DockStyle.Top;
            this.ıconButtonShopping.FlatAppearance.BorderSize = 0;
            this.ıconButtonShopping.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıconButtonShopping.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(232)))));
            this.ıconButtonShopping.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.ıconButtonShopping.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(16)))), ((int)(((byte)(2)))));
            this.ıconButtonShopping.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconButtonShopping.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButtonShopping.Location = new System.Drawing.Point(0, 207);
            this.ıconButtonShopping.Name = "ıconButtonShopping";
            this.ıconButtonShopping.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.ıconButtonShopping.Size = new System.Drawing.Size(237, 55);
            this.ıconButtonShopping.TabIndex = 2;
            this.ıconButtonShopping.Text = "SHOPPING CHART";
            this.ıconButtonShopping.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButtonShopping.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ıconButtonShopping.UseVisualStyleBackColor = false;
            this.ıconButtonShopping.Click += new System.EventHandler(this.ıconButton1_Click_1);
            // 
            // ıconButtonHome
            // 
            this.ıconButtonHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(138)))), ((int)(((byte)(133)))));
            this.ıconButtonHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.ıconButtonHome.FlatAppearance.BorderSize = 0;
            this.ıconButtonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıconButtonHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(232)))));
            this.ıconButtonHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.ıconButtonHome.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(16)))), ((int)(((byte)(2)))));
            this.ıconButtonHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconButtonHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButtonHome.Location = new System.Drawing.Point(0, 152);
            this.ıconButtonHome.Name = "ıconButtonHome";
            this.ıconButtonHome.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.ıconButtonHome.Size = new System.Drawing.Size(237, 55);
            this.ıconButtonHome.TabIndex = 1;
            this.ıconButtonHome.Text = "HOME";
            this.ıconButtonHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButtonHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ıconButtonHome.UseVisualStyleBackColor = false;
            this.ıconButtonHome.Click += new System.EventHandler(this.ıconButton1_Click);
            // 
            // panelTimer
            // 
            this.panelTimer.Controls.Add(this.label1);
            this.panelTimer.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTimer.Location = new System.Drawing.Point(0, 0);
            this.panelTimer.Name = "panelTimer";
            this.panelTimer.Size = new System.Drawing.Size(237, 152);
            this.panelTimer.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(232)))));
            this.label1.Font = new System.Drawing.Font("Noto Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(45, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "00:00";
            // 
            // panelMovement
            // 
            this.panelMovement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(58)))), ((int)(((byte)(53)))));
            this.panelMovement.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMovement.Location = new System.Drawing.Point(237, 0);
            this.panelMovement.Name = "panelMovement";
            this.panelMovement.Size = new System.Drawing.Size(766, 18);
            this.panelMovement.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(232)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(237, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(766, 134);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(237, 152);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(766, 573);
            this.panelMain.TabIndex = 3;
            // 
            // panelSide2
            // 
            this.panelSide2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(119)))), ((int)(((byte)(108)))));
            this.panelSide2.Location = new System.Drawing.Point(3, 439);
            this.panelSide2.Name = "panelSide2";
            this.panelSide2.Size = new System.Drawing.Size(10, 46);
            this.panelSide2.TabIndex = 1;
            this.panelSide2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 725);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMovement);
            this.Controls.Add(this.panelLeft);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelLeft.ResumeLayout(false);
            this.panelInform.ResumeLayout(false);
            this.panelBook.ResumeLayout(false);
            this.panelTimer.ResumeLayout(false);
            this.panelTimer.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelTimer;
        private System.Windows.Forms.Panel panelMovement;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelMain;
        private FontAwesome.Sharp.IconButton ıconButtonHome;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton ıconButtonShopping;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Panel panelBook;
        private FontAwesome.Sharp.IconButton ıconButton4;
        private FontAwesome.Sharp.IconButton ıconButton3;
        private FontAwesome.Sharp.IconButton ıconButtonBook;
        private System.Windows.Forms.Panel panelInform;
        private FontAwesome.Sharp.IconButton ıconButtonWebPage;
        private FontAwesome.Sharp.IconButton ıconButtonTwitter;
        private FontAwesome.Sharp.IconButton ıconButtonInsta;
        private FontAwesome.Sharp.IconButton ıconButtonInform;
        private System.Windows.Forms.Panel panelSide2;
    }
}
