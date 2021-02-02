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
using System.Text.RegularExpressions;

namespace AdvanceProject1
{
    public partial class AddBookControl : UserControl
    {
        public AddBookControl()
        {
            InitializeComponent();
        }
        sql bgl = new sql();
        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            bool a = Regex.IsMatch(textAddAuthor.Text, @"^[\p{L}\s]+$");
            if (a)
            {
                SqlCommand command = new SqlCommand("insert into Tbl_book (BookName,BookAuthor,BookType,BookPrice,BookDescription) values (@p1,@p2,@p3,@p4,@p5)", bgl.connection());

                try
                {

                    command.Parameters.AddWithValue("@p1", textAddName.Text);
                    command.Parameters.AddWithValue("@p2", textAddAuthor.Text);
                    command.Parameters.AddWithValue("@p3", cmbAddBookType.Text);
                    command.Parameters.AddWithValue("@p4", textAddPrice.Text);
                    command.Parameters.AddWithValue("@p5", richTextAddDescription.Text);
                    command.ExecuteNonQuery();
                   
                    MessageBox.Show("Book is succesfully added", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException ex1)
                {
                    MessageBox.Show("Book can not added.Price should contain only number.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Book can not added. Author name should contain only letter.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            bgl.connection().Close();

            this.Visible = false;
        }

        private void AddBookControl_Load(object sender, EventArgs e)
        {
            SqlCommand command3 = new SqlCommand("Select TypeName from Tbl_type", bgl.connection());
            SqlDataReader dr2 = command3.ExecuteReader();
            while (dr2.Read())
            {
                cmbAddBookType.Items.Add(dr2[0]);
            }
            bgl.connection().Close();
        }
    }
}
