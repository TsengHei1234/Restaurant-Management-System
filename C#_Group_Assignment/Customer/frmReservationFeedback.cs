using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

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
            // Database here, load info into cmbbox for user to select
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

        bool ReservationHistoryExpand = true;

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
            if (pnlReservationHistory.Width < 278)
            {
                ReservationHistoryExpand = false;
                transitionReservationHistory.Start();
            }
            /* here database reload data of datetime for cmbbox to have, because after feedback submitted,
             * user will still in the page, thus if there's no more reservation history, no more choices for user,
             * thus either letting them continue if still got data, or error mesage saying you have no more
             * reservation history after clicking on the choosefeedback button.
             * Maybe can based on userId , reservationStatus and reservationFeedback.
             * reservationStatus == completed and reservationFeedback == Pending only can be opened and store
            */
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
            // do if theres information in the pnlReservation, messagebox ask them if they want to lost info
            frmReset(); // after get database, if combobox is selected same value then no need reset, if different, reset the feedback menu
            // Here get their id type numpeople and venue from database. Example:
            ReservationID = "R001";
            ReservationType = "Graduation";
            ReservationNumberOfPeople = 50;
            ReservationVenue = "Hall1";
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
            ReservationID = null;
            ReservationType = null;
            ReservationNumberOfPeople = 0;
            ReservationVenue = null;
        }

        int FeedbackReservation1 = 0;
        int FeedbackReservation2 = 0;
        int FeedbackReservation3 = 0;
        string FeedbackReservationText;

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
                MessageBox.Show("Feedback has submitted successfully!", "Feedback Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbReservationDate.SelectedIndex = -1;
                cmbReservationDate.Text = "Select your datetime...";
                pnlReservationFeedback.Visible = false;
                frmReset();
            }
        }
    }
}