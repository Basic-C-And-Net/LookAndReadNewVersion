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
        private void Form1_Load(object sender, EventArgs e)
        {
           
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
            panelBook.Visible = false;
            panelInform.Visible = false;

        }

        public void hideSubMenu()
        {
            if (panelBook.Visible == true)
                panelBook.Visible = false;
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
            

        }

        private void ıconButton1_Click_1(object sender, EventArgs e)
        {
            panelSide.Visible = true;
            panelSide.Top = ıconButtonShopping.Top;
            panelSide2.Visible = false;
            openChildForm(new ShoppingChartForm());
            
            labelBolumAdi.Text = "SHOPPING CHART";
        }

        private void ıconButton2_Click(object sender, EventArgs e)
        {
            panelSide.Visible = true;
            panelSide.Top = ıconButtonBook.Top;
            panelSide2.Visible = false;

            showSubMenu(panelBook);
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

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ıconButton3_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new Books());
            labelBolumAdi.Text = "MAGAZINE";

        }

        private void ıconButton4_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new Books());
            labelBolumAdi.Text = "BOOKS";
        }

        private void ıconButtonInsta_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void ıconButtonTwitter_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void ıconButtonWebPage_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {
            openChildForm(new LogInForm());
        }

        private void guna2GradientTileButton2_Click(object sender, EventArgs e)
        {
            openChildForm(new LogInForm());
        }

        private void guna2VScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userControl15_Load(object sender, EventArgs e)
        {

        }

        private void userControl14_Load(object sender, EventArgs e)
        {

        }

        private void userControl12_Load(object sender, EventArgs e)
        {

        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
