namespace LoginLibrary;


using System.Data;
using System.Data.SqlClient;

public partial class login : Form
{
    public login()
    {
        InitializeComponent();

    }

    private void Account_Click(object sender, EventArgs e)
    {

    }
    void Login()
    {
        string account = txtAcc.Text.Trim();
        string password = txtPass.Text.Trim();
        string query = "select * from Accounts where username = '" + account + "' and user_password = '" + password + "'";
        using (SqlConnection conn = new SqlConnection(Connection.connect))
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string roll = reader["user_role"].ToString().Trim();
                if (roll.Equals("admin"))
                {
                    MessageBox.Show("Login successfully");
                    this.Hide();
                    AdminManagement a = new AdminManagement();
                    a.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Login successfully");
                    this.Hide();
                    student s = new student();
                    s.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Login Fail! Pls, check your Username/Password again.");
            }
            conn.Close();
        }
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
        Login();
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
        DialogResult result = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (result == DialogResult.Yes)
        {
            Application.Exit();
        }
    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {

    }
}


