using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LoginLibrary
{
    public partial class student : Form
    {
        public student()
        {
            InitializeComponent();
        }
        DataSet GetData()
        //lấy dữ liệu từ SQL
        {
            DataSet data = new DataSet();
            string qr = "select * from Books";
            using (SqlConnection conn = new SqlConnection(Connection.connect))
            {
                SqlCommand cmd = new SqlCommand(qr, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                conn.Close();
            }
            SqlCommand sqlCommand = new SqlCommand();
            return data;
        }
        DataSet GetLoan()
        {
            DataSet data = new DataSet();
            string quer = "select * from Loans";
            using (SqlConnection con = new SqlConnection(Connection.connect))
            {
                SqlCommand cmd = new SqlCommand(quer, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                con.Close();
            }
            SqlCommand sqlCommand = new SqlCommand();
            return data;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow rowData = dgvListBook.Rows[e.RowIndex];
                txtBorowID.Text = rowData.Cells["book_id"].Value.ToString();
                txtBorowName.Text = rowData.Cells["book_name"].Value.ToString();
                txtAuthorID.Text = rowData.Cells["author_id"].Value.ToString();
                txtAuthorNameBook.Text = rowData.Cells["author_name"].Value.ToString();
                txtCategory.Text = rowData.Cells["publisher_id"].Value.ToString();
                dtpPublishDate.Value = (DateTime)rowData.Cells["publishing_date"].Value;

            }

        }

        private void student_Load(object sender, EventArgs e)
        {
            // đưa thông tin lên grid view
            dgvListBook.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListBook.DataSource = GetData().Tables[0];

            dgvLoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLoan.DataSource = GetLoan().Tables[0];
        }

        private void tbLoan_Click(object sender, EventArgs e)
        {

        }

        private void txtExitBook_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to Logout?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnExitLoans_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to Logout?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dgvLoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow rowData = dgvLoan.Rows[e.RowIndex];
                txtIDLoan.Text = rowData.Cells["ticket_id"].Value.ToString();
                txtBookLoan.Text = rowData.Cells["book_id"].Value.ToString();
                txtBorrowLoan.Text = rowData.Cells["borrower_id"].Value.ToString();
                dtpBorrowLoan.Value = (DateTime)rowData.Cells["borrow_date"].Value;
                dtpReturnLoan.Value = (DateTime)rowData.Cells["return_date"].Value;

            }
        }
    }
}

