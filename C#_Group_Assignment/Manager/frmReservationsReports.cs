using System;
using System.Windows.Forms;
using C__Group_Assignment.Manager;

namespace C__Group_Assignment
{
    public partial class frmReservationsReports : Form
    {
        private readonly ManagerService service = new ManagerService();

        public frmReservationsReports()
        {
            InitializeComponent();
            lblName.Text = "Welcome Back!\r\n" + (UserSession.UserName ?? "Manager");
            lblTime.Text = "Time: " + DateTime.Now.ToString("g");
        }

        private void frmReservationsReports_Load(object sender, EventArgs e)
        {
            dataGridView.AutoGenerateColumns = false;
            dataGridView.DataSource = service.LoadReservationReport();
        }
    }
}
