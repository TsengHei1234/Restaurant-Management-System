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
            lblBirthday.Font = new Font(lblBirthday.Font, FontStyle.Regular);
            lblGathering.Font = new Font(lblGathering.Font, FontStyle.Regular);
            lblParty.Font = new Font(lblParty.Font, FontStyle.Regular);
            lblGraduation.Font = new Font(lblGraduation.Font, FontStyle.Regular);
        }

        private string reservationType;
        private DateTime? dateReservation;  //question mark so that the value can be null
        private string timeReservation;
        private int numPeopleReservation;

        private void picBirthday_Click(object sender, EventArgs e)
        {
            fontRegular();
            lblBirthday.Font = new Font(lblBirthday.Font, FontStyle.Bold);
            reservationType = "Birthday";
        }

        private void picGathering_Click(object sender, EventArgs e)
        {
            fontRegular();
            lblGathering.Font = new Font(lblGathering.Font, FontStyle.Bold);
            reservationType = "Gathering";
        }

        private void picParty_Click(object sender, EventArgs e)
        {
            fontRegular();
            lblParty.Font = new Font(lblParty.Font, FontStyle.Bold);
            reservationType = "Party";
        }

        private void picGraduation_Click(object sender, EventArgs e)
        {
            fontRegular();
            lblGraduation.Font = new Font(lblGraduation.Font, FontStyle.Bold);
            reservationType = "Graduation";
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
            if (reservationType == null || dateReservation == null || timeReservation == null || numPeopleReservation == 0)
            {
                MessageBox.Show("Please complete filling up the reservation information!", "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DateTime dateTime = dateTimePicker.Value.Date.Add(DateTime.Parse(cmbReservationTime.SelectedItem.ToString().Split('-')[0]).TimeOfDay);
                DialogResult confirmMakeReservation = MessageBox.Show($"Are you sure you want to make this reservation? \nReservation Type: {reservationType}\nReservation Date and Time: {dateTime}\nTotal People: {numPeopleReservation}", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmMakeReservation == DialogResult.Yes)
                {
                    Customer updateReservation = new Customer();
                    updateReservation.InsertReservation(dateTime, numPeopleReservation, reservationType);
                    MessageBox.Show("Reservation form submitted successfully!", "Successfull");
                    reservationType = null;
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

        private void frmMakeReservation_Load(object sender, EventArgs e)
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
        }

        /*
         int getOrderID = Convert.ToInt32(totalOrderIdcmd.ExecuteScalar()) + 1;
            string newOrderID = $"O{getOrderID:D3}";

         DateTime dateTime = dateTimePicker.Value.Date.Add(DateTime.Parse(cmbTime.SelectedItem.ToString().Split('-')[0]).TimeOfDay);

        */
    }
}
