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
    public partial class UpdateBookControl : UserControl
    {
        public UpdateBookControl()
        {
            InitializeComponent();
        }
        sql bgl = new sql();
        public string bookName;
        private void buttonUpdateBook_Click(object sender, EventArgs e)
        {
            SqlCommand command2 = new SqlCommand("update Tbl_book set BookPrice=@p1,BookDescription=@p2 where BookName=@p3", bgl.connection());
            try
            {
                command2.Parameters.AddWithValue("@p1", textUpdatePrice.Text);
                command2.Parameters.AddWithValue("@p2", richTextUpdateDescription.Text);
                command2.Parameters.AddWithValue("@p3", textUpdateName.Text);
                command2.ExecuteNonQuery();
                bgl.connection().Close();
                MessageBox.Show("Book information updated", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(SqlException ex1)
            {
                MessageBox.Show("Book information can not updated", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            this.Visible = false;
        }

        private void UpdateBookControl_Load(object sender, EventArgs e)
        {
            LoadBookInfo();
        }
        public void LoadBookInfo()
        {
            textUpdateName.Text = bookName;

            //bilgileri çekme
            SqlCommand command = new SqlCommand("select * From Tbl_book where BookName=@p1", bgl.connection());
            command.Parameters.AddWithValue("@p1", textUpdateName.Text);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                textUpdateAuthor.Text = dr[2].ToString();
                cmbUpdateBookType.Text = dr[3].ToString();
                textUpdatePrice.Text = dr[4].ToString();
                richTextUpdateDescription.Text = dr[5].ToString();
            }
            bgl.connection().Close();
        }
    }
}

