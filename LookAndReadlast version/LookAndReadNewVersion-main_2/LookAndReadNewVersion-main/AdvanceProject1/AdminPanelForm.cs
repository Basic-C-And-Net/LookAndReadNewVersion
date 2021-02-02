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
    public partial class AdminPanelForm : Form
    {
        public AdminPanelForm()
        {
            InitializeComponent();
        }
        sql bgl = new sql();
        public string bookName2;
        private void AdminPanelForm_Load(object sender, EventArgs e)
        {
            FillData();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            addBookControl1.Visible = true;
            updateBookControl1.Visible = false;
            deleteBookControl2.Visible = false;
        }

      
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            addBookControl1.Visible = false;
            updateBookControl1.Visible = false;
            deleteBookControl2.Visible = true;
            deleteBookControl2.LoadBookInfo();
        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            addBookControl1.Visible = false;
            deleteBookControl2.Visible = false;
            updateBookControl1.Visible = true;
            updateBookControl1.LoadBookInfo();
            
        }

      

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = guna2DataGridView1.SelectedCells[0].RowIndex;
            bookName2 = guna2DataGridView1.Rows[selected].Cells[1].Value.ToString();
            updateBookControl1.bookName = bookName2;
            deleteBookControl2.bookName = bookName2;
            buttonUpdate.Enabled = true;
            buttonDelete.Enabled = true;
        }
        public void FillData()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter sqlda = new SqlDataAdapter("Select * From Tbl_book ", bgl.connection());
            sqlda.Fill(dt);
            guna2DataGridView1.DataSource = dt;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            FillData();
        }

       
    }
}
