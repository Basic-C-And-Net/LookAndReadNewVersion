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
    public partial class ShoppingCartForm : Form
    {
        public ShoppingCartForm()
        {
            InitializeComponent();
        }
        sql bgl = new sql();
        public string username2;
        private void ShoppingCartForm_Load(object sender, EventArgs e)
        {
            LoadCart();
            calculateTotalPrice();


        }
        public void calculateTotalPrice()
        {
            int total=0;
            for (int i = 0; i<guna2DataGridView1.RowCount;i++)
            {

                int price = Convert.ToInt32(guna2DataGridView1.Rows[i].Cells[1].Value);
                int qty = Convert.ToInt32(guna2DataGridView1.Rows[i].Cells[2].Value);
                total += price * qty;
            }
            label4.Text = total.ToString();
        }
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
            panel1.Visible = true;
           
            int selected = guna2DataGridView1.SelectedCells[0].RowIndex;
            int price = Convert.ToInt32(guna2DataGridView1.Rows[selected].Cells[1].Value);
            int qty = Convert.ToInt32(guna2DataGridView1.Rows[selected].Cells[2].Value);


            labelName.Text = guna2DataGridView1.Rows[selected].Cells[0].Value.ToString();
            labelPrice.Text = (price*qty).ToString();
            labelQty.Text ="x "+guna2DataGridView1.Rows[selected].Cells[2].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Delete from Tbl_order where OrderName=@p1 and CustomerUsername=@p2 and OrderState=@p3", bgl.connection());
            command.Parameters.AddWithValue("@p1", labelName.Text);
            command.Parameters.AddWithValue("@p2", username2);
            command.Parameters.AddWithValue("@p3", false);
            command.ExecuteNonQuery();
            bgl.connection().Close();
            MessageBox.Show("The book has been removed from your cart", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadCart();
            panel1.Visible = false;
            calculateTotalPrice();
        }

        private void buttonReload_Click(object sender, EventArgs e)
        {

        }
        public void LoadCart()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter sqlda = new SqlDataAdapter("Select OrderName ,OrderPrice,OrderQuantity From Tbl_order where CustomerUsername='" + username2 + "' and OrderState='false'", bgl.connection());
            sqlda.Fill(dt);
            guna2DataGridView1.DataSource = dt;
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "" && (radioButton1.Checked==true || radioButton2.Checked==true))
            {
                SqlCommand command2 = new SqlCommand("update Tbl_order set OrderState=@p1 where CustomerUsername=@p2", bgl.connection());
                command2.Parameters.AddWithValue("@p1", true);
                command2.Parameters.AddWithValue("@p2", username2);
                command2.ExecuteNonQuery();
                bgl.connection().Close();
                MessageBox.Show("Purchase completed successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                richTextBox1.Text = "";
                radioButton1.Checked = false; 
                radioButton2.Checked=false;
                LoadCart();
            }
            else
            {
                MessageBox.Show("Please fill in all the blanks", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }
    }
}
