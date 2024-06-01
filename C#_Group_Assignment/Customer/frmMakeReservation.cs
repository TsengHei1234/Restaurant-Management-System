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
    public partial class frmMakeReservation : Form
    {
        public frmMakeReservation()
        {
            InitializeComponent();
        }

        private void fontRegular()
        {
            lblTable.Font = new Font(lblTable.Font, FontStyle.Regular);
            lblBirthday.Font = new Font(lblBirthday.Font, FontStyle.Regular);
            lblGathering.Font = new Font(lblGathering.Font, FontStyle.Regular);
            lblParty.Font = new Font(lblParty.Font, FontStyle.Regular);
        }

        private string venueType;
        private DateTime? dateReservation;  //question mark so that the value can be null
        private string timeReservation;
        private int numPeopleReservation;

        private void picTable_Click(object sender, EventArgs e)
        {
            fontRegular();
            lblTable.Font = new Font(lblTable.Font, FontStyle.Bold);
            venueType = "Birthday";
        }

        private void picBirthday_Click(object sender, EventArgs e)
        {
            fontRegular();
            lblBirthday.Font = new Font(lblBirthday.Font, FontStyle.Bold);
            venueType = "Birthday";
        }

        private void picGathering_Click(object sender, EventArgs e)
        {
            fontRegular();
            lblGathering.Font = new Font(lblGathering.Font, FontStyle.Bold);
            venueType = "Gathering";
        }

        private void picParty_Click(object sender, EventArgs e)
        {
            fontRegular();
            lblParty.Font = new Font(lblParty.Font, FontStyle.Bold);
            venueType = "Party";
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            dateReservation = dateTimePicker.Value;    // MessageBox.Show("Selected Date: " + selectedDate.ToString("yyyy-MM-dd"));
        }

        private void cmbReservationTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            timeReservation = cmbReservationTime.Text;
        }

        private void numPeople_ValueChanged(object sender, EventArgs e)
        {
            numPeopleReservation = Convert.ToInt32(numPeople.Value);
        }

        private void btnComfirmReservation_Click(object sender, EventArgs e)
        {
            if (venueType == null || dateReservation == null || timeReservation == null || numPeopleReservation == 0)
            {
                MessageBox.Show("Please complete filling up the reservation information!", "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Reservation form submitted successfully!", "Successfull");
                // Database here to store info into database
                venueType = null;
                dateReservation = null;
                timeReservation = null;
                numPeopleReservation = 0;
                fontRegular();

                cmbReservationTime.SelectedIndex = -1;
                cmbReservationTime.Text = "Choose your time here...";
                dateTimePicker.Value = DateTime.Now;
                numPeople.Value = numPeople.Minimum;
            }
        }
    }
}
