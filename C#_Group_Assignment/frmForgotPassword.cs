using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__Group_Assignment
{
    public partial class frmForgotPassword : Form
    {
        public frmForgotPassword()
        {
            InitializeComponent();
        }

        private string currentRoleID;
        private string currentRole;

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

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsernameEmail.Text) || string.IsNullOrWhiteSpace(txtSecurityAnswer.Text))
            {
                MessageBox.Show("Please fill in both Username/Email and Security Answer.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString()))
            {
                con.Open();
                string query = @"SELECT UserID, Role 
                                 FROM Users 
                                 WHERE (Username COLLATE Latin1_General_CS_AS = @UsernameEmail OR Email COLLATE Latin1_General_CS_AS = @UsernameEmail)
                                 AND SecurityAnswer = @SecurityAnswer";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@UsernameEmail", txtUsernameEmail.Text);
                cmd.Parameters.AddWithValue("@SecurityAnswer", txtSecurityAnswer.Text);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    currentRoleID = reader["UserID"].ToString();
                    currentRole = reader["Role"].ToString();

                    label3.Visible = true;
                    txtNewPassword.Visible = true;
                    btnComfirm.Visible = true;
                }
                else
                {
                    MessageBox.Show("Incorrect Username/Email or Security Answer.", "Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                con.Close();
            }
        }

        private void btnComfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNewPassword.Text))
            {
                MessageBox.Show("Please enter a new password.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show($"Are you sure you want to change your password?\n New Password: {txtNewPassword.Text}", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString()))
                {
                    con.Open();
                    string query = "UPDATE Users SET Password = @Password WHERE UserID = @UserID";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Password", txtNewPassword.Text);
                    cmd.Parameters.AddWithValue("@UserID", currentRoleID);

                    cmd.ExecuteNonQuery();
                    con.Close();
                }


                MessageBox.Show("Password updated successfully!", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
