using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__Group_Assignment
{
    public partial class frmManager : Form
    {
        public frmManager()
        {
            InitializeComponent();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            Button seperateMaximize = (Button)sender;
            if (WindowState == FormWindowState.Maximized)
            {
                seperateMaximize.Image = Properties.Resources.Maximized_Icon_Resized;
                WindowState = FormWindowState.Normal;
                seperateMaximize.Name = "picMaximize";
            }
            else
            {
                seperateMaximize.Image = Properties.Resources.Min_Icon_Resized;
                WindowState = FormWindowState.Maximized;
                seperateMaximize.Name = "picSeperate";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
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

        bool sidebarExpand = true;

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
                if (pnlSidebar.Width >= 217)
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

        bool inventoryExpand = false;

        private void dropdownInventory_Tick(object sender, EventArgs e)
        {
            if (!inventoryExpand)
            {
                containerInventory.Height += 5;
                if (containerInventory.Height >= 171)
                {
                    dropdownInventory.Stop();
                    inventoryExpand = true;
                }
            }
            else
            {
                containerInventory.Height -= 5;
                if (containerInventory.Height <= 56)
                {
                    dropdownInventory.Stop();
                    inventoryExpand = false;
                }
            }
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            dropdownInventory.Start();
        }

        bool reportsExpand = false;

        private void dropdownReports_Tick(object sender, EventArgs e)
        {
            if (!reportsExpand)
            {
                containerReports.Height += 5;
                if (containerReports.Height >= 171)
                {
                    dropdownReports.Stop();
                    reportsExpand = true;
                }
            }
            else
            {
                containerReports.Height -= 5;
                if (containerReports.Height <= 56)
                {
                    dropdownReports.Stop();
                    reportsExpand = false;
                }
            }
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            dropdownReports.Start();
        }

        bool accountExpand = false;

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

        public void loadform(object Form)
        {
            if (this.pnlMain.Controls.Count > 0)
                this.pnlMain.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.pnlMain.Controls.Add(f);
            this.pnlMain.Tag = f;
            f.Show();
        }

        private void btnAddMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new frmAddMenuItem());
        }

        private void btnEditItems_Click(object sender, EventArgs e)
        {
            loadform(new frmEditItems());
        }

        private void btnReservations_Click(object sender, EventArgs e)
        {
            loadform(new frmReservations());
        }

        private void btnReservationsReports_Click(object sender, EventArgs e)
        {
            loadform(new frmReservationsReports());
        }

        private void btnSaleReports_Click(object sender, EventArgs e)
        {
            loadform(new frmSaleReports());
        }

        private void btnPersonalInfo_Click(object sender, EventArgs e)
        {
            loadform(new frmPersonalInfo());
        }

        private void btnSecurity_Click(object sender, EventArgs e)
        {
            loadform(new frmSecurity());
        }
    }
}
