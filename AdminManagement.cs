using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginLibrary
{
    public partial class AdminManagement : Form
    {
        public AdminManagement()
        {
            InitializeComponent();
        }
        private void AdminManagement_Load(object sender, EventArgs e)
        {
            BookManagementView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BookManagementView.DataSource = GetData().Tables[0];

            dgvBorrowMan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBorrowMan.DataSource = GetBorrow().Tables[0];

            dgvListLoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListLoan.DataSource = GetLoan().Tables[0];
        }
        private void tabManBook_Click(object sender, EventArgs e)
        {

        }
        void refresh()
        {
            BookManagementView.DataSource = GetData().Tables[0];
            BookManagementView.Refresh();

            dgvBorrowMan.DataSource = GetBorrow().Tables[0];
            dgvBorrowMan.Refresh();

            dgvListLoan.DataSource = GetLoan().Tables[0];
            dgvListLoan.Refresh();
        }

        DataSet GetData()
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
            return data;
        }
        DataSet GetBorrow()
        {
            DataSet borrow = new DataSet();
            string queryBR = "select * from Members";
            using (SqlConnection conn = new SqlConnection(Connection.connect))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(queryBR, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(borrow);
                conn.Close();
            }
            return borrow;
        }
        DataSet GetLoan()
        {
            DataSet loan = new DataSet();
            string QueryLoan = "select * from Loans";
            using (SqlConnection conne = new SqlConnection(Connection.connect))
            {
                conne.Open();
                SqlCommand cmd = new SqlCommand(QueryLoan, conne);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(loan);
                conne.Close();
            }
            return loan;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }




        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAuthor_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow rowData = BookManagementView.Rows[e.RowIndex];
                txtID.Text = rowData.Cells["book_id"].Value.ToString();
                txtAuthor.Text = rowData.Cells["author_id"].Value.ToString();
                txtName.Text = rowData.Cells["book_name"].Value.ToString();
                txtPublishID.Text = rowData.Cells["publisher_id"].Value.ToString();
                txtAuthorName.Text = rowData.Cells["author_name"].Value.ToString();
                dtPublish.Value = (DateTime)rowData.Cells["publishing_date"].Value;

                btnDel.Enabled = true;
                btnUpdate.Enabled = true;
            }

        }
        private void dgvBorrowMan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow rowBorrow = this.dgvBorrowMan.Rows[e.RowIndex];
                    txtIDBorrow.Text = rowBorrow.Cells["borrower_id"].Value.ToString();
                    txtNameBorrow.Text = rowBorrow.Cells["borrower_name"].Value.ToString();
                    txtAddressBorrower.Text = rowBorrow.Cells["borrower_address"].Value.ToString();
                    txtPhoneBorrow.Text = rowBorrow.Cells["borrower_phone"].Value.ToString();
                    txtMail.Text = rowBorrow.Cells["borrower_email"].Value.ToString();
                    dtDOB.Value = (DateTime)rowBorrow.Cells["borrower_DOB"].Value;

                    btnDelBor.Enabled = true;
                    btnUpBor.Enabled = true;
                }
            }
            catch { }
        }
        private void dgvListLoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow rowLoan = this.dgvListLoan.Rows[e.RowIndex];
                    txtLoanID.Text = rowLoan.Cells["ticket_id"].Value.ToString();
                    txtBookLoanID.Text = rowLoan.Cells["book_id"].Value.ToString();
                    txtBorrowerIDLoan.Text = rowLoan.Cells["borrower_id"].Value.ToString();
                    dtpBorrowDateLoan.Value = (DateTime)rowLoan.Cells["borrow_date"].Value;
                    dtpReturnDateLoan.Value = (DateTime)rowLoan.Cells["return_date"].Value;

                    btnDelLoan.Enabled = true;
                    btnUpLoan.Enabled = true;
                }
            }
            catch { }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAuthor.Clear();
            txtID.Clear();
            txtName.Clear();
            txtPublishID.Clear();
            txtAuthorName.Clear();
            btnUpdate.Enabled = false;
            btnDel.Enabled = false;
        }
        private void delete(string s = "")
        {
            using (SqlConnection connection = new SqlConnection(Connection.connect))
            {
                connection.Open();
                string delQry = "DELETE FROM ";
                if (s.Equals("Book"))
                {
                    delQry += "Books WHERE book_id = @Id";
                    SqlCommand cmd = new SqlCommand(delQry, connection);
                    cmd.Parameters.AddWithValue("@Id", int.Parse(txtID.Text.Trim()));
                    cmd.ExecuteNonQuery();
                }
                else if (s.Equals("Borrowers"))
                {
                    delQry += "Members WHERE borrower_id = @Id";
                    SqlCommand cmd = new SqlCommand(delQry, connection);
                    cmd.Parameters.AddWithValue("@Id", int.Parse(txtIDBorrow.Text.Trim()));
                    cmd.ExecuteNonQuery();
                }
                else if (s.Equals("Loans"))
                {
                    delQry += "Loans WHERe ticket_id = @Id";
                    SqlCommand cmd = new SqlCommand(delQry, connection);
                    cmd.Parameters.AddWithValue("@Id", int.Parse(txtLoanID.Text.Trim()));
                    cmd.ExecuteNonQuery();
                }
                refresh();
            }
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            int tab = tabControl.TabIndex;
            switch (tab)
            {
                case 0:
                    delete("Book");
                    break;
                case 1:
                    delete("Borrowers");
                    break;
                case 2:
                    delete("Loans");
                    break;
            }
            txtAuthor.Clear();
            txtID.Clear();
            txtName.Clear();
            txtPublishID.Clear();
            txtAuthorName.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to Logout?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void BookManagementView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtCategory_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbPublisher_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.connect))
                {
                    connection.Open();
                    string addQry = "UPDATE Books \n SET book_name = @BookName, author_id = @AuthorID, author_name = @AuthorName," +
                        " publisher_id = @Publisher, publishing_date = @PublishDate WHERE book_id = @Id";
                    SqlCommand cmd = new SqlCommand(addQry, connection);
                    cmd.Parameters.AddWithValue("@Id", int.Parse(txtID.Text.Trim()));
                    cmd.Parameters.AddWithValue("@BookName", txtName.Text.Trim());
                    cmd.Parameters.AddWithValue("@AuthorID", txtAuthor.Text.Trim());
                    cmd.Parameters.AddWithValue("AuthorName", txtAuthorName.Text.Trim());
                    cmd.Parameters.AddWithValue("@Publisher", txtPublishID.Text.Trim());
                    cmd.Parameters.AddWithValue("@PublishDate", dtPublish.Value.Date);
                    cmd.ExecuteNonQuery();
                    refresh();
                    connection.Close();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.connect))
                {
                    connection.Open();
                    string addQry = "insert into Books values (@BookName,@AuthorID,@AuthorName,@PublishID,@PublishDate)";
                    SqlCommand cmd = new SqlCommand(addQry, connection);
                    cmd.Parameters.AddWithValue("@Id", int.Parse(txtID.Text.Trim()));
                    cmd.Parameters.AddWithValue("@BookName", txtName.Text.Trim());
                    cmd.Parameters.AddWithValue("@AuthorID", txtAuthor.Text.Trim());
                    cmd.Parameters.AddWithValue("@AuthorName", txtAuthorName.Text.Trim());
                    cmd.Parameters.AddWithValue("@PublishID", int.Parse(txtPublishID.Text.Trim()));
                    cmd.Parameters.AddWithValue("@PublishDate", dtPublish.Value.Date);
                    cmd.ExecuteNonQuery();
                    refresh();
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627) // Lỗi trùng ID
                {
                    MessageBox.Show("ID cannot be duplicated!");
                }
                else if (ex.Number == 547) // Lỗi khóa ngoại không tồn tại
                {
                    MessageBox.Show("ID not exist!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }




        private void dgvBorrowMan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }



        private void txtIDBorrow_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDelBor_Click(object sender, EventArgs e)
        {
            delete("Borrowers");
            txtIDBorrow.Clear();
            txtNameBorrow.Clear();
            txtPhoneBorrow.Clear();
            txtMail.Clear();
            txtAddressBorrower.Clear();
            btnUpBor.Enabled = false;
            btnDelBor.Enabled = false;
        }
        private void btnClearBor_Click(object sender, EventArgs e)
        {
            txtIDBorrow.Clear();
            txtNameBorrow.Clear();
            txtPhoneBorrow.Clear();
            txtMail.Clear();
            txtAddressBorrower.Clear();
            btnDelBor.Enabled = false;
            btnUpBor.Enabled = false;

        }
        private void btnUpBor_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.connect))
                {
                    connection.Open();
                    string addQry = "UPDATE Members \n SET borrower_name = @BorrowerName,borrower_DOB = @BorrowerDOB," +
                        " borrower_address = @BorrowAddress, borrower_phone = @BorrowPhone, borrower_email = @BorrowEmail WHERE borrower_id = @Id";
                    SqlCommand cmd = new SqlCommand(addQry, connection);
                    cmd.Parameters.AddWithValue("@Id", int.Parse(txtIDBorrow.Text.Trim()));
                    cmd.Parameters.AddWithValue("@BorrowerName", txtNameBorrow.Text.Trim());
                    cmd.Parameters.AddWithValue("@BorrowerDOB", dtDOB.Value.Date);
                    cmd.Parameters.AddWithValue("@BorrowAddress", txtAddressBorrower.Text.Trim());
                    cmd.Parameters.AddWithValue("@BorrowPhone", txtPhoneBorrow.Text.Trim());
                    cmd.Parameters.AddWithValue("@BorrowEmail", txtMail.Text.Trim());
                    cmd.ExecuteNonQuery();
                    refresh();
                    connection.Close();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void btnAddBor_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.connect))
                {
                    connection.Open();
                    string addQry = "insert into Members values (@BorrowerName,@BorrowerDOB,@BorrowAddress,@BorrowPhone,@BorrowEmail)";
                    SqlCommand cmd = new SqlCommand(addQry, connection);
                    cmd.Parameters.AddWithValue("@Id", int.Parse(txtIDBorrow.Text.Trim()));
                    cmd.Parameters.AddWithValue("@BorrowerName", txtNameBorrow.Text.Trim());
                    cmd.Parameters.AddWithValue("@BorrowerDOB", dtDOB.Value.Date);
                    cmd.Parameters.AddWithValue("@BorrowAddress", txtAddressBorrower.Text.Trim());
                    cmd.Parameters.AddWithValue("@BorrowPhone", txtPhoneBorrow.Text.Trim());
                    cmd.Parameters.AddWithValue("@BorrowEmail", txtMail.Text.Trim());
                    cmd.ExecuteNonQuery();
                    refresh();
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627) // Lỗi trùng ID
                {
                    MessageBox.Show("ID cannot be duplicated!");
                }
                else if (ex.Number == 547) // Lỗi khóa ngoại không tồn tại
                {
                    MessageBox.Show("ID not exist!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btnDelLoan_Click(object sender, EventArgs e)
        {
            delete("Loans");
            txtBookLoanID.Clear();
            txtLoanID.Clear();
            txtBorrowerIDLoan.Clear();
            btnDelLoan.Enabled = false;
            btnUpLoan.Enabled = false;
        }
        private void btnClearLoan_Click(object sender, EventArgs e)
        {
            txtBookLoanID.Clear();
            txtLoanID.Clear();
            txtBorrowerIDLoan.Clear();
            btnUpLoan.Enabled = false;
            btnDelLoan.Enabled = false;
        }


        private void btnUpLoan_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.connect))
                {
                    connection.Open();
                    string addQry = "UPDATE Loans \n SET book_id = @BookID,borrower_id = @BorrowerID," +
                        " borrow_date = @BorrowDate, return_date = @ReturnDate WHERE ticket_id = @Id";
                    SqlCommand cmd = new SqlCommand(addQry, connection);
                    cmd.Parameters.AddWithValue("@Id", int.Parse(txtLoanID.Text.Trim()));
                    cmd.Parameters.AddWithValue("@BorrowerID", txtBorrowerIDLoan.Text.Trim());
                    cmd.Parameters.AddWithValue("@BookID", txtBookLoanID.Text.Trim());
                    cmd.Parameters.AddWithValue("@BorrowDate", dtpBorrowDateLoan.Value.Date);
                    cmd.Parameters.AddWithValue("@ReturnDate", dtpReturnDateLoan.Value.Date);
                    cmd.ExecuteNonQuery();
                    refresh();
                    connection.Close();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void btnAddLoan_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.connect))
                {
                    connection.Open();
                    string addQry = "insert into Loans values (@BorrowerID,@BookID,@BorrowDate,@ReturnDate)";
                    SqlCommand cmd = new SqlCommand(addQry, connection);
                    cmd.Parameters.AddWithValue("@Id", int.Parse(txtLoanID.Text.Trim()));
                    cmd.Parameters.AddWithValue("@BorrowerID", txtBorrowerIDLoan.Text.Trim());
                    cmd.Parameters.AddWithValue("@BookID", txtBookLoanID.Text.Trim());
                    cmd.Parameters.AddWithValue("@BorrowDate", dtpBorrowDateLoan.Value.Date);
                    cmd.Parameters.AddWithValue("@ReturnDate", dtpReturnDateLoan.Value.Date);

                    cmd.ExecuteNonQuery();
                    refresh();
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627) // Lỗi trùng ID
                {
                    MessageBox.Show("ID cannot be duplicated!");
                }
                else if (ex.Number == 547) // Lỗi khóa ngoại không tồn tại
                {
                    MessageBox.Show("ID not exist!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnLogoutLoan_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to Logout?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnLogoutBor_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to Logout?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
