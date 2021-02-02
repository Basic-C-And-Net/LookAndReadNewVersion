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
    public partial class DeleteBookControl : UserControl
    {
        public DeleteBookControl()
        {
            InitializeComponent();
        }
        sql bgl = new sql();
        public string bookName;

        private void buttonDeleteBook_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Delete from Tbl_book where BookName=@p1", bgl.connection());
            command.Parameters.AddWithValue("@p1", textDeleteName.Text);
            command.ExecuteNonQuery();
            bgl.connection().Close();
            MessageBox.Show("Book deleted", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Visible=false;
        }
        public void LoadBookInfo()
        {
            textDeleteName.Text = bookName;

            //bilgileri çekme
            SqlCommand command = new SqlCommand("select * From Tbl_book where BookName=@p1", bgl.connection());
            command.Parameters.AddWithValue("@p1", textDeleteName.Text);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                textDeleteAuthor.Text = dr[2].ToString();
                cmbDeleteBookType.Text = dr[3].ToString();
                textDeletePrice.Text = dr[4].ToString();
                richTextDeleteDescription.Text = dr[5].ToString();
            }
            bgl.connection().Close();
        }

        private void DeleteBookControl_Load(object sender, EventArgs e)
        {
            LoadBookInfo();
        }
    }
}
