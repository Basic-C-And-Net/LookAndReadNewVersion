
namespace AdvanceProject1
{
    partial class ShoppingChartForm2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShoppingChartForm2));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.shoppingChart2 = new AdvanceProject1.ShoppingChart();
            this.shoppingChart3 = new AdvanceProject1.ShoppingChart();
            this.shoppingChart4 = new AdvanceProject1.ShoppingChart();
            this.shoppingChart5 = new AdvanceProject1.ShoppingChart();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.shoppingChart2);
            this.flowLayoutPanel1.Controls.Add(this.shoppingChart3);
            this.flowLayoutPanel1.Controls.Add(this.shoppingChart4);
            this.flowLayoutPanel1.Controls.Add(this.shoppingChart5);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 18);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(40);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(813, 401);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.Location = new System.Drawing.Point(-7, 346);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(1018, 250);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 1;
            this.guna2PictureBox1.TabStop = false;
            // 
            // shoppingChart2
            // 
            this.shoppingChart2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(254)))), ((int)(((byte)(242)))));
            this.shoppingChart2.Location = new System.Drawing.Point(3, 3);
            this.shoppingChart2.Name = "shoppingChart2";
            this.shoppingChart2.Size = new System.Drawing.Size(767, 150);
            this.shoppingChart2.TabIndex = 1;
            // 
            // shoppingChart3
            // 
            this.shoppingChart3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(254)))), ((int)(((byte)(242)))));
            this.shoppingChart3.Location = new System.Drawing.Point(3, 159);
            this.shoppingChart3.Name = "shoppingChart3";
            this.shoppingChart3.Size = new System.Drawing.Size(767, 150);
            this.shoppingChart3.TabIndex = 2;
            // 
            // shoppingChart4
            // 
            this.shoppingChart4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(254)))), ((int)(((byte)(242)))));
            this.shoppingChart4.Location = new System.Drawing.Point(3, 315);
            this.shoppingChart4.Name = "shoppingChart4";
            this.shoppingChart4.Size = new System.Drawing.Size(767, 150);
            this.shoppingChart4.TabIndex = 3;
            // 
            // shoppingChart5
            // 
            this.shoppingChart5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(254)))), ((int)(((byte)(242)))));
            this.shoppingChart5.Location = new System.Drawing.Point(3, 471);
            this.shoppingChart5.Name = "shoppingChart5";
            this.shoppingChart5.Size = new System.Drawing.Size(767, 150);
            this.shoppingChart5.TabIndex = 4;
            // 
            // ShoppingChartForm2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(848, 597);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.guna2PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShoppingChartForm2";
            this.Text = "ShoppingChartForm2";
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private ShoppingChart shoppingChart2;
        private ShoppingChart shoppingChart3;
        private ShoppingChart shoppingChart4;
        private ShoppingChart shoppingChart5;
    }
}