using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace C__Group_Assignment
{
    public partial class frmViewSalesReport : Form
    {
        public frmViewSalesReport()
        {
            InitializeComponent();
            dataGridView1.ReadOnly = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void frmViewSalesReport_Load(object sender, EventArgs e)
        {
            LoadFilters();
            BindData();
        }

        private void LoadFilters()
        {
            cmbMonth.Items.Clear();
            cmbMonth.Items.Add("All");
            cmbMonth.Items.AddRange(DateTimeFormatInfo.InvariantInfo.MonthNames);
            if (cmbMonth.Items.Count > 0 && string.IsNullOrEmpty(Convert.ToString(cmbMonth.Items[cmbMonth.Items.Count - 1])))
            {
                cmbMonth.Items.RemoveAt(cmbMonth.Items.Count - 1);
            }

            cmbCategory.Items.Clear();
            cmbCategory.Items.Add("All");
            cmbChef.Items.Clear();
            cmbChef.Items.Add("All");

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SELECT DISTINCT Category FROM Food ORDER BY Category;", connection))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cmbCategory.Items.Add(reader.GetString(0));
                        }
                    }

                    using (SqlCommand command = new SqlCommand("SELECT UserID FROM Users WHERE Role = 'Chef' ORDER BY UserID;", connection))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cmbChef.Items.Add(reader.GetString(0));
                        }
                    }
                }

                cmbMonth.SelectedIndex = 0;
                cmbCategory.SelectedIndex = 0;
                cmbChef.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Unable to Load Report Filters", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bttnGenerateReport_Click(object sender, EventArgs e)
        {
            BindData();
        }

        private void BindData()
        {
            const string query = @"SELECT od.OrderID,
                                          od.FoodID,
                                          f.FoodName,
                                          f.Category,
                                          od.ChefID,
                                          od.OrderDetailsDate,
                                          od.Quantity,
                                          f.Price AS UnitPrice,
                                          f.Price * od.Quantity AS LineTotal,
                                          o.OrderPaymentType
                                   FROM OrderDetails od
                                   INNER JOIN Food f ON od.FoodID = f.FoodID
                                   INNER JOIN Orders o ON od.OrderID = o.OrderID
                                   WHERE o.OrderPaid = 'Paid'
                                     AND (@Month IS NULL OR MONTH(od.OrderDetailsDate) = @Month)
                                     AND (@Category IS NULL OR f.Category = @Category)
                                     AND (@ChefID IS NULL OR od.ChefID = @ChefID)
                                   ORDER BY od.OrderDetailsDate DESC, od.OrderID;";

            try
            {
                object month = DBNull.Value;
                if (cmbMonth.SelectedIndex > 0)
                {
                    month = cmbMonth.SelectedIndex;
                }

                object category = cmbCategory.SelectedIndex > 0 ? (object)cmbCategory.Text : DBNull.Value;
                object chefID = cmbChef.SelectedIndex > 0 ? (object)cmbChef.Text : DBNull.Value;

                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ConnectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    command.Parameters.Add("@Month", SqlDbType.Int).Value = month;
                    command.Parameters.Add("@Category", SqlDbType.NVarChar, 50).Value = category;
                    command.Parameters.Add("@ChefID", SqlDbType.NVarChar, 50).Value = chefID;

                    DataTable report = new DataTable();
                    adapter.Fill(report);
                    dataGridView1.DataSource = report;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Unable to Generate Sales Report", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
