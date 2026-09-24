using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__Group_Assignment
{
    public partial class frmReservationStatus : Form
    {
        public frmReservationStatus()
        {
            InitializeComponent();
            dgvReservations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void frmReservationStatus_Load(object sender, EventArgs e)
        {
            string customerID = Customer.CustomerID; // Replace with the actual customer ID you want to filter by
            LoadReservations(customerID);
        }

        public DataTable GetReservationsByCustomerID(string customerID)
        {
            DataTable reservations = new DataTable();
            string connectionString = ConfigurationManager.ConnectionStrings["myCS"].ToString();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT ReservationID, CustomerID, ReservationDateTime, ReservationPeopleAmount, ReservationType, ReservationVenue, ReservationStatus, ReservationFeedback FROM Reservation WHERE CustomerID = @CustomerID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CustomerID", customerID);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(reservations);
                }
            }
            return reservations;
        }

        public void LoadReservations(string customerID)
        {
            DataTable reservations = GetReservationsByCustomerID(customerID);
            dgvReservations.DataSource = reservations;
        }
    }
}

