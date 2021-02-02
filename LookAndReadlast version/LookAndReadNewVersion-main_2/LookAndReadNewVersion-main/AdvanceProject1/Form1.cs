using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvanceProject1
{   
    public partial class Form1 : Form
    {

        bool mouseDown;
        private Point offset;
     
        public Form1()
        {
            InitializeComponent();
            customizeDesign();
        }
     

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public void customizeDesign()
        {
           
            panelInform.Visible = false;

        }

        public void hideSubMenu()
        {
           
            if (panelInform.Visible == true)
                panelInform.Visible = false;
        
        }

        public void showSubMenu(Panel panel)
        {
            if(panel.Visible == false)
            {
                hideSubMenu();
                panel.Visible = true;
            }
            else
            {
                panel.Visible = false;
            }
        }
        private void ıconButton1_Click(object sender, EventArgs e)
        {
            panelSide.Visible = true;
            panelSide.Top = ıconButtonHome.Top;
            panelSide2.Visible = false;
            openChildForm(new HomeForm());

        }

        private void ıconButton2_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            panelSide.Visible = true;
            panelSide.Top = ıconButtonBook.Top;
            panelSide2.Visible = false;

            BookForm frm2 = new BookForm();
            frm2.username = labelUserName.Text;
            frm2.isLogin2 = isLogin;
            openChildForm(frm2);
           

        }

        private void ıconButtonInform_Click(object sender, EventArgs e)
        {
            panelSide.Visible = false;
            panelSide2.Visible = true;
            panelSide2.Top = ıconButtonInform.Top;
            showSubMenu(panelInform);
        }

        private void panelMovement_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }
     

        private void panelMovement_MouseMove(object sender, MouseEventArgs e)
        {
            if(mouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void panelMovement_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }


        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttonShoppingCart_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            panelSide.Visible = true;
            panelSide.Top = buttonShoppingCart.Top;
            panelSide2.Visible = false;

            ShoppingCartForm frm2 = new ShoppingCartForm();
            frm2.username2 = labelUserName.Text;
            openChildForm(frm2);
            
        }

        private void ıconButtonInsta_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            System.Diagnostics.Process.Start("https://instagram.com/%22");
        }

        private void ıconButtonTwitter_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            System.Diagnostics.Process.Start("https://twitter.com/%22");
        }

        static public bool isLogin = false;

        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {

            LogInForm frm = new LogInForm();
            frm.Show();
            this.Hide();
        }

        private void guna2GradientTileButton2_Click(object sender, EventArgs e)
        {
            RegisterForm frm = new RegisterForm();
            frm.Show();
            this.Hide();
        }
        public string userName;
        private void Form1_Load(object sender, EventArgs e)
        {
           
            openChildForm(new HomeForm());
            labelUserName.Text = userName;
            if (isLogin)
            {
                guna2GradientTileButton1.Visible = false;
                guna2GradientTileButton2.Visible = false;
                buttonLogout.Visible = true;
                label2.Visible = false;
                buttonShoppingCart.Visible = true;
            }
            else
            {
                guna2GradientTileButton1.Visible = true;
                guna2GradientTileButton2.Visible = true;
                buttonLogout.Visible = false;
                buttonShoppingCart.Visible = false;
            }

            if (labelUserName.Text == "admin")
            {
                buttonShoppingCart.Visible = false;
            }

        }

        private void labelUserName_Click(object sender, EventArgs e)
        {

            if (labelUserName.Text != "admin")
            {
                UserProfileForm frm2 = new UserProfileForm();
                frm2.username2 = labelUserName.Text;
                openChildForm(frm2);
            }
            else
            {
               
                AdminPanelForm frm3 = new AdminPanelForm();
                openChildForm(frm3);
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            isLogin = false;
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTimer.Text = DateTime.Now.ToLongTimeString();
            labelDay.Text = DateTime.Now.ToLongDateString();
        }
    }
}
