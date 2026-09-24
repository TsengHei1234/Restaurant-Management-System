using System;
using System.Drawing;
using System.Windows.Forms;

namespace C__Group_Assignment
{
    public partial class frmManager : Form
    {
        private Point mouseLocation;
        private bool sidebarExpand = true;
        private bool inventoryExpand;
        private bool accountExpand;

        public frmManager()
        {
            InitializeComponent();
            btnSignOut.Click += btnSignOut_Click;
        }

        private void btnMinimize_Click(object sender, EventArgs e) { WindowState = FormWindowState.Minimized; }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                btnMaximize.Image = Properties.Resources.Maximized_Icon_Resized;
                WindowState = FormWindowState.Normal;
            }
            else
            {
                btnMaximize.Image = Properties.Resources.Min_Icon_Resized;
                WindowState = FormWindowState.Maximized;
            }
        }

        private void btnExit_Click(object sender, EventArgs e) { Close(); }
        private void pnlTop_MouseDown(object sender, MouseEventArgs e) { mouseLocation = new Point(-e.X, -e.Y); }
        private void pnlTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            Point position = Control.MousePosition;
            position.Offset(mouseLocation.X, mouseLocation.Y);
            Location = position;
        }

        private void transitionSidebar_Tick(object sender, EventArgs e)
        {
            pnlSidebar.Width += sidebarExpand ? -5 : 5;
            if (pnlSidebar.Width <= 68) { pnlSidebar.Width = 68; sidebarExpand = false; transitionSidebar.Stop(); }
            else if (pnlSidebar.Width >= 217) { pnlSidebar.Width = 217; sidebarExpand = true; transitionSidebar.Stop(); }
        }
        private void btnSidebar_Click(object sender, EventArgs e) { transitionSidebar.Start(); }

        private void dropdownInventory_Tick(object sender, EventArgs e)
        {
            containerInventory.Height += inventoryExpand ? -5 : 5;
            if (containerInventory.Height <= 56) { containerInventory.Height = 56; inventoryExpand = false; dropdownInventory.Stop(); }
            else if (containerInventory.Height >= 171) { containerInventory.Height = 171; inventoryExpand = true; dropdownInventory.Stop(); }
        }
        private void btnInventory_Click(object sender, EventArgs e) { dropdownInventory.Start(); }

        private void dropdownAccount_Tick(object sender, EventArgs e)
        {
            containerAccount.Height += accountExpand ? -5 : 5;
            if (containerAccount.Height <= 56) { containerAccount.Height = 56; accountExpand = false; dropdownAccount.Stop(); }
            else if (containerAccount.Height >= 171) { containerAccount.Height = 171; accountExpand = true; dropdownAccount.Stop(); }
        }
        private void btnAccount_Click(object sender, EventArgs e) { dropdownAccount.Start(); }

        public void loadform(object form)
        {
            if (pnlMain.Controls.Count > 0) pnlMain.Controls[0].Dispose();
            Form child = form as Form;
            if (child == null) throw new ArgumentException("A Windows Form is required.", nameof(form));
            child.TopLevel = false;
            child.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(child);
            pnlMain.Tag = child;
            child.Show();
        }

        private void btnAddMenuItem_Click(object sender, EventArgs e) { loadform(new frmAddMenuItem()); }
        private void btnEditItems_Click(object sender, EventArgs e) { loadform(new frmEditItems()); }
        private void btnReservations_Click(object sender, EventArgs e) { loadform(new frmReservations()); }
        private void btnReservationsReports_Click(object sender, EventArgs e) { loadform(new frmReservationsReports()); }
        private void btnPersonalInfo_Click(object sender, EventArgs e) { loadform(new frmPersonalInfo()); }
        private void btnSecurity_Click(object sender, EventArgs e) { loadform(new frmSecurity()); }
        private void pnlMain_Paint(object sender, PaintEventArgs e) { }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            UserSession.Clear();
            Close();
        }
    }
}
