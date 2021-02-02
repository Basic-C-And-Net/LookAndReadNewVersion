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
    public partial class UserProfileForm : Form
    {
        public UserProfileForm()
        {
            InitializeComponent();
        }

        sql bgl = new sql();

        public string username2;

        private void UserProfileForm_Load(object sender, EventArgs e)
        {
            //bilgileri çekme
            LoadInfo();
            //sipariş geçmişi
            DataTable dt = new DataTable();
            SqlDataAdapter sqlda = new SqlDataAdapter("Select OrderName,OrderPrice,OrderQuantity From Tbl_order where CustomerUsername='" + username2+"' and OrderState='true'" , bgl.connection());
            sqlda.Fill(dt);
            guna2DataGridView1.DataSource = dt;
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonUpdateInfo_Click(object sender, EventArgs e)
        {
            userInfoUpdateForm1.username = labelUsername.Text;
            userInfoUpdateForm1.Visible = true;
        }
        public void LoadInfo()
        {
            labelUsername.Text = username2;
            SqlCommand command = new SqlCommand("select CustomerName,CustomerSurname,CustomerPhone,CustomerPassword  From Tbl_customer where CustomerUsername=@p1", bgl.connection());
            command.Parameters.AddWithValue("@p1", labelUsername.Text);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                labelName.Text = dr[0].ToString();
                labelSurname.Text = dr[1].ToString();
                labelTel.Text = dr[2].ToString();
                labelPassword.Text = "";
                for (int i = 0; i < dr[3].ToString().Length; i++)
                {
                    labelPassword.Text += "*";
                }

            }
            bgl.connection().Close();
        }
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadInfo();

        }

        private void userInfoUpdateForm1_Load(object sender, EventArgs e)
        {

        }
    }
}
