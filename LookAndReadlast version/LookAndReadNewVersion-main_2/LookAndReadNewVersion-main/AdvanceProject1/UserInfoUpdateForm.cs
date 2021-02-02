using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace AdvanceProject1
{
    public partial class UserInfoUpdateForm : UserControl
    {
        public UserInfoUpdateForm()
        {
            InitializeComponent();
        }
        sql bgl = new sql();
        public string username;
        private void UserInfoUpdateForm_Load(object sender, EventArgs e)
        {
            textUsername.Text = username;

            //bilgileri çekme
            SqlCommand command = new SqlCommand("select * From Tbl_customer where CustomerUsername=@p1", bgl.connection());
            command.Parameters.AddWithValue("@p1", textUsername.Text);
            SqlDataReader dr = command.ExecuteReader();
            while(dr.Read()){
                textName.Text = dr[1].ToString();
                textSurname.Text = dr[2].ToString();
                textPassword.Text = dr[4].ToString();
                mskPhone.Text = dr[5].ToString();
            }
            bgl.connection().Close();


        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand command2 = new SqlCommand("update Tbl_customer set CustomerName=@p1 ,CustomerSurname=@p2,CustomerPassword=@p3,CustomerPhone=@p4 where CustomerUsername=@p5", bgl.connection());
            command2.Parameters.AddWithValue("@p1", textName.Text);
            command2.Parameters.AddWithValue("@p2", textSurname.Text);
            command2.Parameters.AddWithValue("@p3", textPassword.Text);
            command2.Parameters.AddWithValue("@p4", mskPhone.Text);
            command2.Parameters.AddWithValue("@p5", textUsername.Text);
            command2.ExecuteNonQuery();
            bgl.connection().Close();
            MessageBox.Show("Your information Updated", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Visible = false;
            
            
        }
    }
}
