using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace C__Group_Assignment
{
    public partial class frmCustomer : Form
    {
        private frmMenu frmMenu;

        public frmCustomer()
        {
            InitializeComponent();
        }

        public void getMenuForm(frmMenu frmMenu)
        {
            this.frmMenu = frmMenu;
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
            Boolean checkOrders = false;
            foreach (Control control in frmMenu.pnlOrders.Controls)
            {
                if (control is ucOrder)
                {
                    checkOrders = true;
                    break;
                }
            }

            if (checkOrders)
            {
                DialogResult leaveMenu = MessageBox.Show("Are you sure you want to leave this page? Food order progress will be lost!", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (leaveMenu == DialogResult.Yes)
                {
                    frmMenu.pnlOrders.Controls.Clear();
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
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

        bool reservationExpand = false;

        private void dropdownReservation_Tick(object sender, EventArgs e)
        {
            if (!reservationExpand)
            {
                containerReservation.Height += 5;
                if (containerReservation.Height >= 171)
                {
                    dropdownReservation.Stop();
                    reservationExpand = true;
                }
            }
            else
            {
                containerReservation.Height -= 5;
                if (containerReservation.Height <= 56)
                {
                    dropdownReservation.Stop();
                    reservationExpand = false;
                }
            }
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            dropdownReservation.Start();
        }

        bool feedbackExpand = false;

        private void dropdownFeedback_Tick(object sender, EventArgs e)
        {
            if (!feedbackExpand)
            {
                containerFeedback.Height += 5;
                if (containerFeedback.Height >= 171)
                {
                    dropdownFeedback.Stop();
                    feedbackExpand = true;
                }
            }
            else
            {
                containerFeedback.Height -= 5;
                if (containerFeedback.Height <= 56)
                {
                    dropdownFeedback.Stop();
                    feedbackExpand = false;
                }
            }
        }

        private void btnSendFeedback_Click(object sender, EventArgs e)
        {
            dropdownFeedback.Start();
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
                    accountExpand= false;
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

        public void confirmationLoadform(object Form)
        {
            Boolean checkOrders = false;
            foreach (Control control in frmMenu.pnlOrders.Controls)
            {
                if (control is ucOrder)
                {
                    checkOrders = true;
                    break;
                }
            }

            if (checkOrders)
            {
                DialogResult leaveMenu = MessageBox.Show("Are you sure you want to leave this page? Food order progress will be lost!", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (leaveMenu == DialogResult.Yes)
                {
                    frmMenu.pnlOrders.Controls.Clear();
                    loadform(Form);
                }
            }
            else
            {
                loadform(Form);
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            confirmationLoadform(new frmMenu(this));
        }

        private void btnViewOrder_Click(object sender, EventArgs e)
        {
            confirmationLoadform(new frmViewOrder());
        }

        private void btnMakeReservation_Click(object sender, EventArgs e)
        {
            confirmationLoadform(new frmMakeReservation());
        }

        private void btnReservationStatus_Click(object sender, EventArgs e)
        {
            confirmationLoadform(new frmReservationStatus());
        }

        private void btnReservationFeedback_Click(object sender, EventArgs e)
        {
            confirmationLoadform(new frmReservationFeedback());
        }

        private void btnMenuFeedback_Click(object sender, EventArgs e)
        {
            confirmationLoadform(new frmMenuFeedback());
        }

        private void btnPersonalInfo_Click(object sender, EventArgs e)
        {
            confirmationLoadform(new frmPersonalInfo());
        }

        private void btnSecurity_Click(object sender, EventArgs e)
        {
            confirmationLoadform(new frmSecurity());
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            loadform(new frmMenu(this));
            if (this.pnlMain.Controls.Count > 0)
                this.pnlMain.Controls.RemoveAt(0);

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

            con.Open();

            SqlCommand cmd = new SqlCommand("select Username from customer", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                MessageBox.Show(rd.GetString(0));
            }
            con.Close();
        }
    }  
    
}
