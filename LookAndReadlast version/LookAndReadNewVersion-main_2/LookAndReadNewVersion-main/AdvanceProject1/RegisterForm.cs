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
using System.Text.RegularExpressions;

namespace AdvanceProject1
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }
        sql bgl = new sql();
        Regex rgx = new Regex("[^a-zA-Z-]");

        private void btnLogin2_Click(object sender, EventArgs e)
        {
            bool a = Regex.IsMatch(textName.Text, @"^[\p{L}]+$");
            bool b = Regex.IsMatch(textSurname.Text, @"^[\p{L}]+$");
            if (a && b && textName.Text!="" && textSurname.Text!="" && textUsername.Text != "" && textPassword.Text != "" && mskPhone.Text!="")
            {
                SqlCommand command = new SqlCommand("insert into Tbl_customer (CustomerName,CustomerSurname,CustomerUsername,CustomerPassword,CustomerPhone) values (@p1,@p2,@p3,@p4,@p5)", bgl.connection());



                command.Parameters.AddWithValue("@p1", textName.Text);
                command.Parameters.AddWithValue("@p2", textSurname.Text);


                command.Parameters.AddWithValue("@p3", textUsername.Text);
                command.Parameters.AddWithValue("@p4", textPassword.Text);
                command.Parameters.AddWithValue("@p5", mskPhone.Text);
                command.ExecuteNonQuery();
                
                MessageBox.Show("Your registration has been completed.Your password is " + textPassword.Text);
                Form1 frm1 = new Form1();
                frm1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Name and surname can not contain number", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            bgl.connection().Close();

        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 frm = new Form1();
            frm.Show();
        }
    }
}
