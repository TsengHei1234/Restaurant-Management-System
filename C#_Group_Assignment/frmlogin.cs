using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace C__Group_Assignment
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void frmlogin_Load(object sender, EventArgs e)
        {
            lblDateTime.Text = SetDateTime.CurrentDateTime.ToString();
        }

        public void UpdateDateTimeDisplay()
        {
            lblDateTime.Text = SetDateTime.CurrentDateTime.ToString();
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

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int loginAttempt = 3;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserLogin getUser = new UserLogin();
            string[] getIDUsername = getUser.Login(txtUsername.Text, txtPassword.Text);

            if (getIDUsername != null)
            {
                string userID = getIDUsername[0];
                string userName = getIDUsername[1];
                string userRole = getIDUsername[2]; 
                getUser.redirect_user(userID, userName, userRole);
                return;
            }
            else
            {
                loginAttempt--;
                if (loginAttempt == 0)
                {
                    MessageBox.Show($"No more attempts, login failed. \nYou will be Sign Out!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                else if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
                {
                    MessageBox.Show($"Username password cannot be empty. Please re-enter. \n({loginAttempt} Login Attempts Remaining!)", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    SetTextBoxEmpty();
                }
                else if (loginAttempt != 0)
                {
                    MessageBox.Show($"Incorrect Login Credentials!\n ({loginAttempt} Login Attempts Remaining!)", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    SetTextBoxEmpty();
                }
            }
        }

        private void SetTextBoxEmpty()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        private void btnSetDateTime_Click(object sender, EventArgs e)
        {
            frmSetDateTime frmSetDateTime = new frmSetDateTime(this);
            frmSetDateTime.Show();
            lblDateTime.Text = SetDateTime.CurrentDateTime.ToString();
        }

        private void linkForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmForgotPassword frmforgotPassword = new frmForgotPassword();
            frmforgotPassword.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCreateAccount frmCreateAccount = new frmCreateAccount();
            frmCreateAccount.Show();
        }
    }
}