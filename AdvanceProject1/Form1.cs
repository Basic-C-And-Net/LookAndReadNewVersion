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
     
        public Form1()
        {
            InitializeComponent();
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
        }

        private void ıconButton2_Click(object sender, EventArgs e)
        {
            panelSide.Visible = true;
            panelSide.Top = ıconButtonBook.Top;
            panelSide2.Visible = false;
        }

        private void ıconButtonInform_Click(object sender, EventArgs e)
        {
            panelSide.Visible = false;
            panelSide2.Visible = true;
        }


    }
}
