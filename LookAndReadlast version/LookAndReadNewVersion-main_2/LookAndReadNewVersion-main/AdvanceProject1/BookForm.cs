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
    public partial class BookForm : Form
    {
        public BookForm()
        {
            InitializeComponent();
        }
        sql bgl = new sql();
        private void BookForm_Load(object sender, EventArgs e)
        {
            FillData();

            SqlCommand command3 = new SqlCommand("Select TypeName from Tbl_type", bgl.connection()); 
            SqlDataReader dr2 = command3.ExecuteReader();
            while (dr2.Read())
            { 
                cmbBookType.Items.Add(dr2[0]); 
            }
            bgl.connection().Close();

            //DataSearch();
            if (!isLogin2|| username == "admin")
            {
                buttonAddCart.Enabled = false;
                btnDecrease.Enabled = false;
                btnIncrease.Enabled = false;
            }
            else
            {
                buttonAddCart.Enabled = true;
                btnDecrease.Enabled = true;
                btnIncrease.Enabled = true;
            }
        
        }
        DataTable dt = new DataTable();
        public void FillData()
        {
            
            SqlDataAdapter sqlda = new SqlDataAdapter("Select BookName,BookAuthor,BookType,BookPrice,BookDescription From Tbl_book ", bgl.connection());
            sqlda.Fill(dt);
            guna2DataGridView1.DataSource = dt;
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = guna2DataGridView1.SelectedCells[0].RowIndex;
            txtName.Text = guna2DataGridView1.Rows[selected].Cells[0].Value.ToString();
            txtAuthor.Text = guna2DataGridView1.Rows[selected].Cells[1].Value.ToString();
            txtType.Text = guna2DataGridView1.Rows[selected].Cells[2].Value.ToString();
            txtPrice.Text = guna2DataGridView1.Rows[selected].Cells[3].Value.ToString();
            richTextBoxDescription.Text = guna2DataGridView1.Rows[selected].Cells[4].Value.ToString();
            txtQty.Text = 1.ToString();
        }
        public string username;
        public bool isLogin2;
        private void buttonAddCart_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("insert into Tbl_order (CustomerUsername,OrderName,OrderPrice,OrderState,OrderQuantity) values (@p1,@p2,@p3,@p4,@p5)", bgl.connection());
            command.Parameters.AddWithValue("@p1", username);
            command.Parameters.AddWithValue("@p2", txtName.Text);
            command.Parameters.AddWithValue("@p3", txtPrice.Text);
            command.Parameters.AddWithValue("@p4", 0);
            command.Parameters.AddWithValue("@p5", txtQty.Text);
            command.ExecuteNonQuery();
            bgl.connection().Close();
            MessageBox.Show("The book has been added to your cart", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        int value ;
        private void btnIncrease_Click(object sender, EventArgs e)
        {
            value = Convert.ToInt32(txtQty.Text);
            value++;
            txtQty.Text = value.ToString();
        }

        private void btnDecrease_Click(object sender, EventArgs e)
        {
            if (value>1)
            {
                value = Convert.ToInt32(txtQty.Text);
                value--;
                txtQty.Text = value.ToString();
            }
            
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

        }

     

        private void textSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = string.Format("BookName like '%{0}%'", textSearch.Text);
                guna2DataGridView1.DataSource = dv.ToTable();

            }
        }

        private void textUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = string.Format("BookName like '%{0}%'", textSearch.Text);
                guna2DataGridView1.DataSource = dv.ToTable();

            }
        }

        private void cmbBookType_SelectedValueChanged(object sender, EventArgs e)
        {
            dt.Clear();
            SqlDataAdapter sqlda = new SqlDataAdapter("Select * From Tbl_book where BookType='" + cmbBookType.Text + "'", bgl.connection());
            sqlda.Fill(dt);
            guna2DataGridView1.DataSource = dt;
            
        }

        private void cmbBookType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
