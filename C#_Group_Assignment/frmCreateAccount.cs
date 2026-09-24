using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__Group_Assignment
{
    public partial class frmCreateAccount : Form
    {
        public frmCreateAccount()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private Point mouseLocation;

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void pnlTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtSecurityAnswer.Text))
            {
                MessageBox.Show("Please enter a new password.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show($"Are you sure you want to create a new account?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString()))
                {
                    con.Open();
                    using (SqlTransaction transaction = con.BeginTransaction(IsolationLevel.Serializable))
                    {
                        string checkQuery = @"SELECT COUNT(*) FROM Users WHERE Username = @Username OR Email = @Email";
                        SqlCommand checkCmd = new SqlCommand(checkQuery, con, transaction);
                        checkCmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                        checkCmd.Parameters.AddWithValue("@Email", txtEmail.Text);

                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                        if (count > 0)
                        {
                            MessageBox.Show("Username or Email already exists", "Please use a different one", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            transaction.Rollback();
                            return;
                        }

                        const string nextIdQuery = @"SELECT ISNULL(MAX(TRY_CONVERT(int, SUBSTRING(CustomerID, 2, 20))), 0) + 1
                                                     FROM Customer WITH (UPDLOCK, HOLDLOCK)";
                        SqlCommand nextIdCmd = new SqlCommand(nextIdQuery, con, transaction);
                        int getCustomerID = Convert.ToInt32(nextIdCmd.ExecuteScalar());
                        string newCustomerID = $"C{getCustomerID:D3}";

                        string query = @"INSERT INTO Users (UserID, Username, Email, Password, Role, SecurityAnswer)
                                         VALUES (@UserID, @Username, @Email, @Password, @Role, @SecurityAnswer)";

                        SqlCommand cmd = new SqlCommand(query, con, transaction);
                        cmd.Parameters.AddWithValue("@UserID", newCustomerID);
                        cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                        cmd.Parameters.AddWithValue("@Role", "Customer");
                        cmd.Parameters.AddWithValue("@SecurityAnswer", txtSecurityAnswer.Text);
                        cmd.ExecuteNonQuery();

                        string insertCustomerQuery = "INSERT INTO Customer (CustomerID, Username) VALUES (@CustomerID, @Username)";
                        SqlCommand insertCustomerCmd = new SqlCommand(insertCustomerQuery, con, transaction);
                        insertCustomerCmd.Parameters.AddWithValue("@CustomerID", newCustomerID);
                        insertCustomerCmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                        insertCustomerCmd.ExecuteNonQuery();

                        transaction.Commit();
                    }
                }

                MessageBox.Show("Customer Account Created Successfully!", "Account Created", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
        }
    }
}
