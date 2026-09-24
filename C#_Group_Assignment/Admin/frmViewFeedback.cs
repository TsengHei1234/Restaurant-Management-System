using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace C__Group_Assignment
{
    public partial class frmViewFeedback : Form
    {
        public frmViewFeedback()
        {
            InitializeComponent();
            buttonLoadFeedback_Click.Click += buttonLoadFeedback_Click_Handler;
            dataGridView1.ReadOnly = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void frmViewFeedback_Load(object sender, EventArgs e)
        {
            LoadFeedbackData();
        }

        private void buttonLoadFeedback_Click_Handler(object sender, EventArgs e)
        {
            LoadFeedbackData();
        }

        private void LoadFeedbackData()
        {
            const string query = @"SELECT FeedbackID,
                                          CustomerID,
                                          OrderID,
                                          ReservationID,
                                          FeedbackType,
                                          FeedbackDateTime,
                                          FeedbackRating1,
                                          FeedbackRating2,
                                          FeedbackRating3,
                                          FeedbackText
                                   FROM Feedback
                                   ORDER BY FeedbackDateTime DESC;";

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ConnectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable feedback = new DataTable();
                    adapter.Fill(feedback);
                    dataGridView1.DataSource = feedback;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Unable to Load Feedback", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
