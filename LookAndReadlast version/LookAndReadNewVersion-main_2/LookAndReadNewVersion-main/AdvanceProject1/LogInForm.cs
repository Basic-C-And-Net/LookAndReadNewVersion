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
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        sql bgl = new sql();

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            textPassword.PasswordChar = '●';
            textPassword.MaxLength = 8;
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 frm = new Form1();
            frm.Show();
          
            
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.SetUsername(textUsername.Text);
            customer.SetPassword(textPassword.Text);
            if (customer.Login())
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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            RegisterForm frm3 = new RegisterForm();

            frm3.Show();
            this.Hide();
        }


        private void buttonAdminLogin_Click(object sender, EventArgs e)
        {
            AdminLoginForm frm4 = new AdminLoginForm();
            frm4.Show();
            this.Hide();
        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {

            textPassword.PasswordChar = guna2ToggleSwitch1.Checked ? '\0' : '*';

        }
    }
}
