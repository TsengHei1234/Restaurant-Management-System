using System;
using System.Data;
using System.Windows.Forms;
using C__Group_Assignment.Manager;

namespace C__Group_Assignment
{
    public partial class frmReservations : Form
    {
        private readonly ManagerService service = new ManagerService();
        private string selectedReservationID;

        public frmReservations()
        {
            InitializeComponent();
            cmbTime.Items.AddRange(new object[] { "8:00 AM - 10:00 AM", "9:00 AM - 11:00 AM", "10:00 AM - 12:00 PM", "11:00 AM - 1:00 PM", "12:00 PM - 2:00 PM", "1:00 PM - 3:00 PM", "2:00 PM - 4:00 PM", "3:00 PM - 5:00 PM", "4:00 PM - 6:00 PM", "5:00 PM - 7:00 PM", "6:00 PM - 8:00 PM", "7:00 PM - 9:00 PM", "8:00 PM - 10:00 PM", "9:00 PM - 11:00 PM", "10:00 PM - 12:00 AM" });
            cmbVenue.Items.AddRange(new object[] { "Hall1", "Hall2", "Hall3", "Hall4" });
            lbEditReservation.SelectedIndexChanged += lbEditReservation_SelectedIndexChanged;
            lblName.Text = "Welcome Back!\r\n" + (UserSession.UserName ?? "Manager");
            lblTime.Text = "Time: " + DateTime.Now.ToString("g");
            LoadReservations();
        }

        private void btnGraduation_Click(object sender, EventArgs e) { SaveReservation("Graduation"); }
        private void btnBirthday_Click(object sender, EventArgs e) { SaveReservation("Birthday"); }
        private void btnGathering_Click(object sender, EventArgs e) { SaveReservation("Gathering"); }
        private void btnParty_Click(object sender, EventArgs e) { SaveReservation("Party"); }

        private void SaveReservation(string type)
        {
            try
            {
                if (cmbTime.SelectedItem == null || cmbVenue.SelectedItem == null) throw new InvalidOperationException("Please choose a time and venue.");
                string startText = cmbTime.SelectedItem.ToString().Split('-')[0].Trim();
                DateTime parsedTime;
                if (!DateTime.TryParse(startText, out parsedTime)) throw new InvalidOperationException("The selected time is invalid.");
                DateTime dateTime = dateTimePicker1.Value.Date.Add(parsedTime.TimeOfDay);
                ReservationRecord existing = selectedReservationID == null ? null : service.GetReservation(selectedReservationID);
                ReservationRecord reservation = new ReservationRecord
                {
                    CustomerID = txtCustomerID.Text,
                    ReservationDateTime = dateTime,
                    PeopleAmount = Convert.ToInt32(numericGuest.Value),
                    ReservationType = type,
                    Venue = cmbVenue.SelectedItem.ToString(),
                    Status = existing == null ? "Successful" : existing.Status,
                    Feedback = existing == null ? "Pending" : existing.Feedback
                };
                if (selectedReservationID == null)
                {
                    selectedReservationID = service.AddReservation(reservation);
                    MessageBox.Show("Reservation " + selectedReservationID + " added successfully.");
                }
                else
                {
                    service.UpdateReservation(selectedReservationID, reservation);
                    MessageBox.Show("Reservation updated successfully.");
                }
                LoadReservations();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Unable to save reservation", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void LoadReservations()
        {
            DataTable reservations = service.LoadReservations();
            lbEditReservation.DataSource = reservations;
            lbEditReservation.DisplayMember = "ReservationID";
            lbEditReservation.ValueMember = "ReservationID";
            lbEditReservation.ClearSelected();
        }

        private void lbEditReservation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbEditReservation.SelectedValue == null || lbEditReservation.SelectedValue is DataRowView) return;
            LoadReservation(lbEditReservation.SelectedValue.ToString());
        }

        private void LoadReservation(string reservationID)
        {
            ReservationRecord reservation = service.GetReservation(reservationID);
            if (reservation == null) return;
            selectedReservationID = reservation.ReservationID;
            lblCurrent.Text = "Editing " + reservation.ReservationID;
            txtCustomerID.Text = reservation.CustomerID;
            dateTimePicker1.Value = reservation.ReservationDateTime;
            numericGuest.Value = Math.Min(numericGuest.Maximum, Math.Max(numericGuest.Minimum, reservation.PeopleAmount));
            SelectTime(reservation.ReservationDateTime);
            cmbVenue.SelectedItem = reservation.Venue;
        }

        private void SelectTime(DateTime dateTime)
        {
            string start = dateTime.ToString("h:mm tt");
            for (int index = 0; index < cmbTime.Items.Count; index++)
                if (cmbTime.Items[index].ToString().StartsWith(start + " ")) { cmbTime.SelectedIndex = index; return; }
        }

        private void btnSelectReservation_Click(object sender, EventArgs e)
        {
            if (lbEditReservation.SelectedValue == null) MessageBox.Show("Please select a reservation.");
            else LoadReservation(lbEditReservation.SelectedValue.ToString());
        }

        private void btnDeleteReservation_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(selectedReservationID)) throw new InvalidOperationException("Please select a reservation.");
                if (MessageBox.Show("Reject this reservation?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;
                if (!service.RejectReservation(selectedReservationID)) throw new InvalidOperationException("Completed or missing reservations cannot be rejected.");
                MessageBox.Show("Reservation rejected successfully.");
                ClearEditor();
                LoadReservations();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Unable to reject reservation", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnClear_Click(object sender, EventArgs e) { ClearEditor(); lbEditReservation.ClearSelected(); }

        private void ClearEditor()
        {
            selectedReservationID = null;
            lblCurrent.Text = "Adding New Reservation";
            txtCustomerID.Clear(); numericGuest.Value = numericGuest.Minimum;
            cmbTime.SelectedIndex = -1; cmbVenue.SelectedIndex = -1;
        }
    }
}
