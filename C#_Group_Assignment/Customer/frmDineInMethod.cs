using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace C__Group_Assignment
{
    public partial class frmDineInMethod : Form
    {
        private frmCustomer frmCustomer;

        public frmDineInMethod(frmCustomer frmCustomer)
        {
            InitializeComponent();
            this.frmCustomer = frmCustomer;
        }

        public string ReservationID
        {
            get { return lblReservationID.Text; }
            set { lblReservationID.Text = $"Reservation ID: {value}"; }
        }

        public string ReservationType
        {
            get { return lblReservationType.Text; }
            set { lblReservationType.Text = $"Reservation Type: {value}"; }
        }

        public int ReservationNumberOfPeople
        {
            get { return Convert.ToInt32(lblReservationNumber.Text); }
            set { lblReservationNumber.Text = $"Number of People: {value}"; }
        }

        public string ReservationVenue
        {
            get { return lblReservationVenue.Text; }
            set { lblReservationVenue.Text = $"Reservation Venue: {value}"; }
        }

        bool ReservationHistoryExpand = false;

        private void transitionReservationDetails_Tick(object sender, EventArgs e)
        {
            if (ReservationHistoryExpand)
            {
                pnlReservationDetails.Width -= 5;
                if (pnlReservationDetails.Width <= 0)
                {
                    transitionReservationDetails.Stop();
                }
            }
            else
            {
                pnlReservationDetails.Width += 5;
                if (pnlReservationDetails.Width >= 278)
                {
                    transitionReservationDetails.Stop();
                }
            }
        }

        private void ResetReservationPanel()
        {
            cmbReservationDates.SelectedIndex = -1;
            lblReservationID.Text = $"Reservation ID: ";
            lblReservationType.Text = $"Reservation Type: ";
            lblReservationVenue.Text = $"Reservation Venue: ";
            lblReservationNumber.Text = $"Number of People: ";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            ResetReservationPanel();
            if (pnlReservationDetails.Width > 0)
            {
                ReservationHistoryExpand = true;
                transitionReservationDetails.Start();
            }
        }

        private void btnWalkIn_Click(object sender, EventArgs e)
        {
            ResetReservationPanel();
            if (pnlReservationDetails.Width > 0)
            {
                ReservationHistoryExpand = true;
                transitionReservationDetails.Start();
            }

            Customer customer = new Customer();
            List<string> occupiedTables = customer.GetOccupiedTables();

            List<string> allTables = new List<string>();
            for (int i = 1; i <= 15; i++)
            {
                allTables.Add($"Table{i}");
            }

            List<string> availableTables = allTables.Except(occupiedTables).ToList();

            cmbTableNumber.Items.Clear();
            cmbTableNumber.Items.AddRange(availableTables.ToArray());
            cmbTableNumber.SelectedIndex = 0;

            lblSelectTable.Visible = true;
            cmbTableNumber.Visible = true;
            btnChooseTable.Visible = true;
        }

        private void btnChooseTable_Click(object sender, EventArgs e)
        {
            if (cmbTableNumber.SelectedIndex == -1)
            {
                MessageBox.Show("Please select your table number before proceeding!", "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                DialogResult confirmationTable = MessageBox.Show($"You have selected {cmbTableNumber.SelectedItem.ToString()}.\nPress Yes to comfirm and proceed.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmationTable == DialogResult.Yes)
                {
                    Customer.CustomerOrderTable = cmbTableNumber.SelectedItem.ToString();
                    Customer.CustomerDineInMethod = "Walk-In";
                    frmCustomer.SetExistingDineIn();
                    frmCustomer.confirmationLoadform(new frmMenu(frmCustomer));
                }
            }
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            LoadReservationDates();
            if (cmbReservationDates.Items.Count == 0)
            {
                MessageBox.Show("You don't have any reservation at this moment!", "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                lblSelectTable.Visible = false;
                cmbTableNumber.Visible = false;
                btnChooseTable.Visible = false;

                if (pnlReservationDetails.Width < 278)
                {
                    ReservationHistoryExpand = false;
                    transitionReservationDetails.Start();
                }
            }
        }

        private void cmbReservationDates_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbReservationDates.SelectedItem != null)
            {
                DateTime selectedDate = (DateTime)cmbReservationDates.SelectedItem;
                LoadReservationDetails(selectedDate);
            }
        }

        private void LoadReservationDates()
        {
            Customer customer = new Customer(); 
            List<DateTime> reservationDates = customer.LoadReservationDates(); 

            cmbReservationDates.Items.Clear();
            foreach (DateTime date in reservationDates)
            {
                cmbReservationDates.Items.Add(date);
            }
        }

        private void LoadReservationDetails(DateTime selectedDate)
        {
            Customer customer = new Customer(); 
            DataRow reservationDetails = customer.LoadReservationDetails(selectedDate);

            if (reservationDetails != null)
            {
                string ReservationID = reservationDetails["ReservationID"].ToString();
                string ReservationType = reservationDetails["ReservationType"].ToString();
                string ReservationVenue = reservationDetails["ReservationVenue"].ToString();
                string ReservationAmount = reservationDetails["ReservationPeopleAmount"].ToString();

                lblReservationID.Text = $"Reservation ID: {ReservationID}";
                lblReservationType.Text = $"Reservation Type: {ReservationType}";
                lblReservationVenue.Text = $"Reservation Venue: {ReservationVenue}";
                lblReservationNumber.Text = $"Number of People: {ReservationAmount}";
            }
        }

        private void btnChooseReservation_Click(object sender, EventArgs e)
        {
            if (cmbReservationDates.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a date and time of your reservation!", "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult confirmationTable = MessageBox.Show($"You have selected {ReservationID}\n{ReservationType}\n{ReservationVenue}.\nPress Yes to comfirm and proceed.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmationTable == DialogResult.Yes)
                {
                    string ReservationID = lblReservationID.Text.Replace("Reservation ID: ", "").Trim();
                    string ReservationType = lblReservationType.Text.Replace("Reservation Type: ", "").Trim();
                    string ReservationVenue = lblReservationVenue.Text.Replace("Reservation Venue: ", "").Trim();

                    Customer.ReservationID = ReservationID;
                    Customer.CustomerReservationType = ReservationType;
                    Customer.CustomerOrderTable = ReservationVenue;
                    Customer.CustomerDineInMethod = "Reservation";
                    ResetReservationPanel();
                    frmCustomer.SetExistingDineIn();
                    frmCustomer.confirmationLoadform(new frmMenu(frmCustomer));
                }
            }
        }

        private void frmDineInMethod_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Welcome {Customer.CustomerName}!";
        }
    }
}
