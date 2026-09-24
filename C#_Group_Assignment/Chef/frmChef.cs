using System;
using System.Drawing;
using System.Windows.Forms;

namespace C__Group_Assignment
{
    public partial class frmChef : Form
    {
        private Point mouseLocation;
        private bool sidebarExpand = true;
        private bool accountExpand;

        public frmChef()
        {
            InitializeComponent();
            btnSignOut.Click += btnSignOut_Click;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            Button maximizeButton = (Button)sender;
            if (WindowState == FormWindowState.Maximized)
            {
                maximizeButton.Image = Properties.Resources.Maximized_Icon_Resized;
                WindowState = FormWindowState.Normal;
            }
            else
            {
                maximizeButton.Image = Properties.Resources.Min_Icon_Resized;
                WindowState = FormWindowState.Maximized;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void pnlTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePosition = Control.MousePosition;
                mousePosition.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePosition;
            }
        }

        private void transitionSidebar_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                pnlSidebar.Width -= 5;
                if (pnlSidebar.Width <= 68)
                {
                    sidebarExpand = false;
                    transitionSidebar.Stop();
                }
            }
            else
            {
                pnlSidebar.Width += 5;
                if (pnlSidebar.Width >= 200)
                {
                    sidebarExpand = true;
                    transitionSidebar.Stop();
                }
            }
        }

        private void btnSidebar_Click(object sender, EventArgs e)
        {
            transitionSidebar.Start();
        }

        private void dropdownAccount_Tick(object sender, EventArgs e)
        {
            if (!accountExpand)
            {
                containerAccount.Height += 5;
                if (containerAccount.Height >= 171)
                {
                    dropdownAccount.Stop();
                    accountExpand = true;
                }
            }
            else
            {
                containerAccount.Height -= 5;
                if (containerAccount.Height <= 56)
                {
                    dropdownAccount.Stop();
                    accountExpand = false;
                }
            }
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            dropdownAccount.Start();
        }

        public void loadform(object formObject)
        {
            Form form = formObject as Form;
            if (form == null)
            {
                throw new ArgumentException("Only Windows Forms can be loaded in the Chef workspace.", nameof(formObject));
            }

            while (pnlMain.Controls.Count > 0)
            {
                Control oldControl = pnlMain.Controls[0];
                pnlMain.Controls.RemoveAt(0);
                oldControl.Dispose();
            }

            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(form);
            pnlMain.Tag = form;
            form.Show();
        }

        private void btnViewUpdateOrder_Click(object sender, EventArgs e)
        {
            loadform(new frmViewUpdateOrder());
        }

        private void btnManageInventory_Click(object sender, EventArgs e)
        {
            loadform(new frmManageInventory());
        }

        private void btnPersonalInfo_Click(object sender, EventArgs e)
        {
            loadform(new frmPersonalInfo(UserSession.UserID, UserSession.Role));
        }

        private void btnSecurity_Click(object sender, EventArgs e)
        {
            loadform(new frmSecurity());
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            UserSession.Clear();
            Close();
        }
    }
}
