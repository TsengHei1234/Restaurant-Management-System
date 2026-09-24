using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace C__Group_Assignment
{
    public partial class frmReservationFeedback : Form
    {
        public frmReservationFeedback()
        {
            InitializeComponent();
        }

        private void frmReservationFeedback_Load(object sender, EventArgs e)
        {
            lblName.Text = $"Welcome Back! \n{Customer.CustomerName}";

            if (Customer.CustomerDineInMethod == "Idle")
            {
                lblStatus.Text = $"Status: {Customer.CustomerDineInMethod}";
            }
            else if (Customer.CustomerDineInMethod == "Walk-In")
            {
                lblStatus.Text = $"Status: {Customer.CustomerDineInMethod} | {Customer.CustomerOrderTable}";
            }
            else if (Customer.CustomerDineInMethod == "Reservation")
            {
                lblStatus.Text = $"Status: {Customer.CustomerDineInMethod} | {Customer.CustomerReservationType}";
            }

            lblTime.Text = $"Time: {Customer.CurrentDateTime.ToString()}";

            LoadCompletedReservation();
            if (cmbReservationDate.Items.Count == 0)
            {
                MessageBox.Show("You don't have any reservation to feedback!", "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        public string ReservationID
        {
            get { return lblReservationID.Text;}
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

        private void transitionReservationHistory_Tick(object sender, EventArgs e)
        {
            if (ReservationHistoryExpand)
            {
                pnlReservationHistory.Width -= 5;
                if (pnlReservationHistory.Width <= 0)
                {
                    transitionReservationHistory.Stop();
                }
            }
            else
            {
                pnlReservationHistory.Width += 5;
                if (pnlReservationHistory.Width >= 278)
                {
                    transitionReservationHistory.Stop();
                }
            }
        }

        private void btnChooseFeedback_Click(object sender, EventArgs e)
        {
            LoadCompletedReservation();
            if (cmbReservationDate.Items.Count == 0)
            {
                MessageBox.Show("You don't have any reservation to feedback!", "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                if (pnlReservationHistory.Width < 278)
                {
                    ReservationHistoryExpand = false;
                    transitionReservationHistory.Start();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (pnlReservationHistory.Width > 0)
            {
                ReservationHistoryExpand = true;
                transitionReservationHistory.Start();
            }
        }

        private void cmbReservationDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbReservationDate.SelectedItem != null)
            {
                DateTime selectedDate = (DateTime)cmbReservationDate.SelectedItem;
                LoadCompletedReservationDetails(selectedDate);
                frmReset();
            }
        }

        private void btnFeedbackNow_Click(object sender, EventArgs e)
        {
            if (cmbReservationDate.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a date and time of your reservation!", "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (pnlReservationHistory.Width > 0)
                {
                    ReservationHistoryExpand = true;
                    transitionReservationHistory.Start();
                }
                pnlReservationFeedback.Visible = true;
            }
        }

        private void frmReset()
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;
            radioButton8.Checked = false;
            radioButton9.Checked = false;
            radioButton10.Checked = false;
            radioButton11.Checked = false;
            radioButton12.Checked = false;
            radioButton13.Checked = false;
            radioButton14.Checked = false;
            radioButton15.Checked = false;
            FeedbackReservation1 = 0;
            FeedbackReservation2 = 0;
            FeedbackReservation3 = 0;
            FeedbackReservationText = null;
            txtComments.Clear();

        }

        int FeedbackReservation1 = 0;
        int FeedbackReservation2 = 0;
        int FeedbackReservation3 = 0;
        string FeedbackReservationText = null;

        private void btnSubmitFeedback_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked) FeedbackReservation1 = 1;
            else if (radioButton2.Checked) FeedbackReservation1 = 2;
            else if (radioButton3.Checked) FeedbackReservation1 = 3;
            else if (radioButton4.Checked) FeedbackReservation1 = 4;
            else if (radioButton5.Checked) FeedbackReservation1 = 5;

            if (radioButton6.Checked) FeedbackReservation2 = 1;
            else if (radioButton7.Checked) FeedbackReservation2 = 2;
            else if (radioButton8.Checked) FeedbackReservation2 = 3;
            else if (radioButton9.Checked) FeedbackReservation2 = 4;
            else if (radioButton10.Checked) FeedbackReservation2 = 5;

            if (radioButton11.Checked) FeedbackReservation3 = 1;
            else if (radioButton12.Checked) FeedbackReservation3 = 2;
            else if (radioButton13.Checked) FeedbackReservation3 = 3;
            else if (radioButton14.Checked) FeedbackReservation3 = 4;
            else if (radioButton15.Checked) FeedbackReservation3 = 5;

            FeedbackReservationText = txtComments.Text;

            if (FeedbackReservation1 == 0 || FeedbackReservation2 == 0 || FeedbackReservation3 == 0)
            {
                MessageBox.Show("Please complete filling up the reservation feedback!", "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                string ReservationIDPut = lblReservationID.Text.Replace("Reservation ID: ", "").Trim();
                Customer updateFeedbackDetails = new Customer();
                updateFeedbackDetails.SaveFeedbackDetails(ReservationIDPut, FeedbackReservation1, FeedbackReservation2, FeedbackReservation3, FeedbackReservationText);
                updateFeedbackDetails.UpdateReservationStatus(ReservationIDPut);
                MessageBox.Show("Feedback has submitted successfully!", "Feedback Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbReservationDate.SelectedIndex = -1;
                cmbReservationDate.Text = "Select your datetime...";
                pnlReservationFeedback.Visible = false;
                frmReset();
                LoadCompletedReservation();
                ReservationID = null;
                ReservationType = null;
                ReservationNumberOfPeople = 0;
                ReservationVenue = null;
            }
        }

        public void LoadCompletedReservation()
        {
            Customer LoadSeccessfulReservationDates = new Customer();
            List<DateTime> reservationDates = LoadSeccessfulReservationDates.LoadPendingReservationFeedback();

            cmbReservationDate.Items.Clear();
            foreach (DateTime date in reservationDates)
            {
                cmbReservationDate.Items.Add(date);
            }
        }

        public void LoadCompletedReservationDetails(DateTime selectedDate)
        {
            Customer customer = new Customer();
            DataRow completedReservationDetails = customer.LoadCompletedReservationDetails(selectedDate);
            if (completedReservationDetails != null)
            {
                ReservationID = completedReservationDetails["ReservationID"].ToString();
                ReservationType = completedReservationDetails["ReservationType"].ToString();
                ReservationVenue = completedReservationDetails["ReservationVenue"].ToString();
                ReservationNumberOfPeople = Convert.ToInt32(completedReservationDetails["ReservationPeopleAmount"]);
            }
        }
    }
}