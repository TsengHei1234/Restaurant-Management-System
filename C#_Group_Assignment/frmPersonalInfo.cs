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
    public partial class frmPersonalInfo : Form
    {
        public frmPersonalInfo()
            : this(UserSession.UserID, UserSession.Role)
        {
        }

        public frmPersonalInfo(string roleID, string role)
        {
            InitializeComponent();
            currentUserID = roleID;
            currentRole = role;
        }

        private string originalUsername;
        private string originalEmail;
        private string originalPassword;
        private string originalSecurityAnswer;

        private string currentUserID;
        private string currentRole;

        private void frmPersonalInfo_Load(object sender, EventArgs e)
        {
            LoadUserInfo();
        }

        private void LoadUserInfo()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString()))
            {
                con.Open();
                string query = "SELECT Username, Email, Password, SecurityAnswer FROM Users WHERE UserID = @UserID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@UserID", currentUserID);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    originalUsername = reader["Username"].ToString();
                    originalEmail = reader["Email"].ToString();
                    originalPassword = reader["Password"].ToString();
                    originalSecurityAnswer = reader["SecurityAnswer"].ToString();

                    txtUsername.Text = originalUsername;
                    txtEmail.Text = originalEmail;
                    txtPassword.Text = originalPassword;
                    txtSecurityAnswer.Text = originalSecurityAnswer;
                }
            }
        }

        private void btnUpdateProfile_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtSecurityAnswer.Text))
            {
                MessageBox.Show("All fields are required. Please fill in all the information.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtUsername.Text == originalUsername &&
                txtEmail.Text == originalEmail &&
                txtPassword.Text == originalPassword &&
                txtSecurityAnswer.Text == originalSecurityAnswer)
            {
                MessageBox.Show("You have no info changed", "No Changes Detected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to update your profile?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                UpdateUserInfo();
            }
        }

        private void UpdateUserInfo()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString()))
            {
                con.Open();
                string query = "UPDATE Users SET Username = @Username, Email = @Email, Password = @Password, SecurityAnswer = @SecurityAnswer WHERE UserID = @UserID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                cmd.Parameters.AddWithValue("@SecurityAnswer", txtSecurityAnswer.Text);
                cmd.Parameters.AddWithValue("@UserID", currentUserID);

                cmd.ExecuteNonQuery();

                if (currentRole == "Customer")
                {
                    string updateCustomerQuery = "UPDATE Customer SET Username = @Username WHERE CustomerID = @CustomerID";
                    SqlCommand updateCustomerCmd = new SqlCommand(updateCustomerQuery, con);
                    updateCustomerCmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                    updateCustomerCmd.Parameters.AddWithValue("@CustomerID", currentUserID);

                    updateCustomerCmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Profile updated successfully!", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

            originalUsername = txtUsername.Text;
            originalEmail = txtEmail.Text;
            originalPassword = txtPassword.Text;
            originalSecurityAnswer = txtSecurityAnswer.Text;

            if (currentRole == "Customer")
            {
                Customer.CustomerName = txtUsername.Text;
            }

            UserSession.UpdateUserName(txtUsername.Text);
        }
    }
}
