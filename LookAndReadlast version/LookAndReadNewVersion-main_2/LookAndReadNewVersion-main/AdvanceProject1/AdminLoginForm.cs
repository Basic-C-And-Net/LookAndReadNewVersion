using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AdvanceProject1
{
    public partial class AdminLoginForm : Form
    {
        public AdminLoginForm()
        {
            InitializeComponent();
        }

        sql bgl = new sql();

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 frm = new Form1();
            frm.Show();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
      

            Admin admin = new Admin();
            admin.SetUsername(textUsername.Text);
            admin.SetPassword(textPassword.Text);
            if (admin.Login())
            {
                Form1.isLogin = true;
                Form1 frm1 = new Form1();
                frm1.userName = textUsername.Text;
                frm1.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Incorrect entry.");

            }
        }
    }
}
