
namespace AdvanceProject1
{
    partial class ShoppingChart
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

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.ıconButtonBookDelete = new FontAwesome.Sharp.IconButton();
            this.labelKitapAdi = new System.Windows.Forms.Label();
            this.labelYazar = new System.Windows.Forms.Label();
            this.labelFiyat = new System.Windows.Forms.Label();
            this.guna2NumericUpDown1 = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.iconButtonAdd = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2NumericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ıconButtonBookDelete
            // 
            this.ıconButtonBookDelete.BackColor = System.Drawing.Color.White;
            this.ıconButtonBookDelete.FlatAppearance.BorderSize = 0;
            this.ıconButtonBookDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıconButtonBookDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(232)))));
            this.ıconButtonBookDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.ıconButtonBookDelete.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(14)))), ((int)(((byte)(0)))));
            this.ıconButtonBookDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconButtonBookDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButtonBookDelete.Location = new System.Drawing.Point(678, 49);
            this.ıconButtonBookDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ıconButtonBookDelete.Name = "ıconButtonBookDelete";
            this.ıconButtonBookDelete.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.ıconButtonBookDelete.Size = new System.Drawing.Size(63, 55);
            this.ıconButtonBookDelete.TabIndex = 4;
            this.ıconButtonBookDelete.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ıconButtonBookDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ıconButtonBookDelete.UseVisualStyleBackColor = false;
            // 
            // labelKitapAdi
            // 
            this.labelKitapAdi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelKitapAdi.AutoSize = true;
            this.labelKitapAdi.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKitapAdi.Location = new System.Drawing.Point(168, 50);
            this.labelKitapAdi.Name = "labelKitapAdi";
            this.labelKitapAdi.Size = new System.Drawing.Size(132, 20);
            this.labelKitapAdi.TabIndex = 5;
            this.labelKitapAdi.Text = "Sofie\'nin  Dünyası";
            this.labelKitapAdi.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelYazar
            // 
            this.labelYazar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelYazar.AutoSize = true;
            this.labelYazar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelYazar.Location = new System.Drawing.Point(168, 83);
            this.labelYazar.Name = "labelYazar";
            this.labelYazar.Size = new System.Drawing.Size(126, 20);
            this.labelYazar.TabIndex = 6;
            this.labelYazar.Text = "Jostein Gaarder";
            this.labelYazar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelFiyat
            // 
            this.labelFiyat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelFiyat.AutoSize = true;
            this.labelFiyat.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelFiyat.ForeColor = System.Drawing.Color.DarkRed;
            this.labelFiyat.Location = new System.Drawing.Point(467, 61);
            this.labelFiyat.Margin = new System.Windows.Forms.Padding(1);
            this.labelFiyat.Name = "labelFiyat";
            this.labelFiyat.Size = new System.Drawing.Size(91, 28);
            this.labelFiyat.TabIndex = 7;
            this.labelFiyat.Text = "29,90 ₺";
            this.labelFiyat.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // guna2NumericUpDown1
            // 
            this.guna2NumericUpDown1.BackColor = System.Drawing.Color.Gainsboro;
            this.guna2NumericUpDown1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2NumericUpDown1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2NumericUpDown1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2NumericUpDown1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2NumericUpDown1.DisabledState.Parent = this.guna2NumericUpDown1;
            this.guna2NumericUpDown1.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.guna2NumericUpDown1.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.guna2NumericUpDown1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2NumericUpDown1.FocusedState.Parent = this.guna2NumericUpDown1;
            this.guna2NumericUpDown1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2NumericUpDown1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2NumericUpDown1.Location = new System.Drawing.Point(340, 53);
            this.guna2NumericUpDown1.Name = "guna2NumericUpDown1";
            this.guna2NumericUpDown1.ShadowDecoration.Parent = this.guna2NumericUpDown1;
            this.guna2NumericUpDown1.Size = new System.Drawing.Size(100, 36);
            this.guna2NumericUpDown1.TabIndex = 8;
            this.guna2NumericUpDown1.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2NumericUpDown1.UpDownButtonForeColor = System.Drawing.Color.Black;
            // 
            // iconButtonAdd
            // 
            this.iconButtonAdd.BackColor = System.Drawing.Color.White;
            this.iconButtonAdd.FlatAppearance.BorderSize = 0;
            this.iconButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(232)))));
            this.iconButtonAdd.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.iconButtonAdd.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(14)))), ((int)(((byte)(0)))));
            this.iconButtonAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonAdd.Location = new System.Drawing.Point(609, 51);
            this.iconButtonAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButtonAdd.Name = "iconButtonAdd";
            this.iconButtonAdd.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.iconButtonAdd.Size = new System.Drawing.Size(63, 55);
            this.iconButtonAdd.TabIndex = 9;
            this.iconButtonAdd.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.iconButtonAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButtonAdd.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AdvanceProject1.Properties.Resources.sofienin_dunyasi_3776459_15_O;
            this.pictureBox1.Location = new System.Drawing.Point(15, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // ShoppingChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.iconButtonAdd);
            this.Controls.Add(this.guna2NumericUpDown1);
            this.Controls.Add(this.labelFiyat);
            this.Controls.Add(this.labelYazar);
            this.Controls.Add(this.labelKitapAdi);
            this.Controls.Add(this.ıconButtonBookDelete);
            this.Name = "ShoppingChart";
            this.Size = new System.Drawing.Size(802, 145);
            this.Load += new System.EventHandler(this.ShoppingChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2NumericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton ıconButtonBookDelete;
        private System.Windows.Forms.Label labelKitapAdi;
        private System.Windows.Forms.Label labelYazar;
        private System.Windows.Forms.Label labelFiyat;
        private Guna.UI2.WinForms.Guna2NumericUpDown guna2NumericUpDown1;
        private FontAwesome.Sharp.IconButton iconButtonAdd;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
