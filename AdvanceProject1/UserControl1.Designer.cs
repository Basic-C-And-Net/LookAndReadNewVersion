
namespace AdvanceProject1
{
    partial class UserControl1
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
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.pnl_KitapAdi = new Guna.UI2.WinForms.Guna2Panel();
            this.labelKitapAdi = new System.Windows.Forms.Label();
            this.pnl_Yazar = new Guna.UI2.WinForms.Guna2Panel();
            this.labelYazar = new System.Windows.Forms.Label();
            this.pnl_Fiyat = new Guna.UI2.WinForms.Guna2Panel();
            this.labelFiyat = new System.Windows.Forms.Label();
            this.btn_SepeteEkle = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2GradientPanel1.SuspendLayout();
            this.pnl_KitapAdi.SuspendLayout();
            this.pnl_Yazar.SuspendLayout();
            this.pnl_Fiyat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.pnl_KitapAdi);
            this.guna2GradientPanel1.Controls.Add(this.pnl_Yazar);
            this.guna2GradientPanel1.Controls.Add(this.pnl_Fiyat);
            this.guna2GradientPanel1.Controls.Add(this.guna2PictureBox1);
            this.guna2GradientPanel1.Location = new System.Drawing.Point(3, 3);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(293, 463);
            this.guna2GradientPanel1.TabIndex = 0;
            // 
            // pnl_KitapAdi
            // 
            this.pnl_KitapAdi.Controls.Add(this.labelKitapAdi);
            this.pnl_KitapAdi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_KitapAdi.Location = new System.Drawing.Point(0, 297);
            this.pnl_KitapAdi.Name = "pnl_KitapAdi";
            this.pnl_KitapAdi.ShadowDecoration.Parent = this.pnl_KitapAdi;
            this.pnl_KitapAdi.Size = new System.Drawing.Size(293, 63);
            this.pnl_KitapAdi.TabIndex = 8;
            // 
            // labelKitapAdi
            // 
            this.labelKitapAdi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelKitapAdi.AutoSize = true;
            this.labelKitapAdi.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKitapAdi.Location = new System.Drawing.Point(78, 22);
            this.labelKitapAdi.Name = "labelKitapAdi";
            this.labelKitapAdi.Size = new System.Drawing.Size(132, 20);
            this.labelKitapAdi.TabIndex = 0;
            this.labelKitapAdi.Text = "Sofie\'nin  Dünyası";
            this.labelKitapAdi.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnl_Yazar
            // 
            this.pnl_Yazar.Controls.Add(this.labelYazar);
            this.pnl_Yazar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Yazar.Location = new System.Drawing.Point(0, 360);
            this.pnl_Yazar.Name = "pnl_Yazar";
            this.pnl_Yazar.ShadowDecoration.Parent = this.pnl_Yazar;
            this.pnl_Yazar.Size = new System.Drawing.Size(293, 52);
            this.pnl_Yazar.TabIndex = 7;
            // 
            // labelYazar
            // 
            this.labelYazar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelYazar.AutoSize = true;
            this.labelYazar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelYazar.Location = new System.Drawing.Point(81, 17);
            this.labelYazar.Name = "labelYazar";
            this.labelYazar.Size = new System.Drawing.Size(126, 20);
            this.labelYazar.TabIndex = 1;
            this.labelYazar.Text = "Jostein Gaarder";
            this.labelYazar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnl_Fiyat
            // 
            this.pnl_Fiyat.Controls.Add(this.labelFiyat);
            this.pnl_Fiyat.Controls.Add(this.btn_SepeteEkle);
            this.pnl_Fiyat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Fiyat.Location = new System.Drawing.Point(0, 412);
            this.pnl_Fiyat.Name = "pnl_Fiyat";
            this.pnl_Fiyat.ShadowDecoration.Parent = this.pnl_Fiyat;
            this.pnl_Fiyat.Size = new System.Drawing.Size(293, 51);
            this.pnl_Fiyat.TabIndex = 6;
            // 
            // labelFiyat
            // 
            this.labelFiyat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelFiyat.AutoSize = true;
            this.labelFiyat.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelFiyat.ForeColor = System.Drawing.Color.DarkRed;
            this.labelFiyat.Location = new System.Drawing.Point(15, 16);
            this.labelFiyat.Margin = new System.Windows.Forms.Padding(1);
            this.labelFiyat.Name = "labelFiyat";
            this.labelFiyat.Size = new System.Drawing.Size(91, 28);
            this.labelFiyat.TabIndex = 2;
            this.labelFiyat.Text = "29,90 ₺";
            this.labelFiyat.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_SepeteEkle
            // 
            this.btn_SepeteEkle.Animated = true;
            this.btn_SepeteEkle.AutoRoundedCorners = true;
            this.btn_SepeteEkle.BorderRadius = 19;
            this.btn_SepeteEkle.CheckedState.Parent = this.btn_SepeteEkle;
            this.btn_SepeteEkle.CustomImages.Parent = this.btn_SepeteEkle;
            this.btn_SepeteEkle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(16)))), ((int)(((byte)(2)))));
            this.btn_SepeteEkle.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(138)))), ((int)(((byte)(133)))));
            this.btn_SepeteEkle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_SepeteEkle.ForeColor = System.Drawing.Color.White;
            this.btn_SepeteEkle.HoverState.Parent = this.btn_SepeteEkle;
            this.btn_SepeteEkle.Location = new System.Drawing.Point(156, 3);
            this.btn_SepeteEkle.Name = "btn_SepeteEkle";
            this.btn_SepeteEkle.ShadowDecoration.Parent = this.btn_SepeteEkle;
            this.btn_SepeteEkle.Size = new System.Drawing.Size(118, 41);
            this.btn_SepeteEkle.TabIndex = 2;
            this.btn_SepeteEkle.Text = "Sepete Ekle";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(228)))), ((int)(((byte)(199)))));
            this.guna2PictureBox1.BorderRadius = 1;
            this.guna2PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Gray;
            this.guna2PictureBox1.Image = global::AdvanceProject1.Properties.Resources.sofienin_dunyasi_3776459_15_O;
            this.guna2PictureBox1.Location = new System.Drawing.Point(38, 1);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(211, 285);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 5;
            this.guna2PictureBox1.TabStop = false;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.Controls.Add(this.guna2GradientPanel1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(299, 469);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.pnl_KitapAdi.ResumeLayout(false);
            this.pnl_KitapAdi.PerformLayout();
            this.pnl_Yazar.ResumeLayout(false);
            this.pnl_Yazar.PerformLayout();
            this.pnl_Fiyat.ResumeLayout(false);
            this.pnl_Fiyat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2Panel pnl_KitapAdi;
        private System.Windows.Forms.Label labelKitapAdi;
        private Guna.UI2.WinForms.Guna2Panel pnl_Yazar;
        private System.Windows.Forms.Label labelYazar;
        private Guna.UI2.WinForms.Guna2Panel pnl_Fiyat;
        private System.Windows.Forms.Label labelFiyat;
        private Guna.UI2.WinForms.Guna2GradientTileButton btn_SepeteEkle;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}
