using System;
using System.Drawing;
using System.Windows.Forms;

namespace C__Group_Assignment
{
    public partial class ucChefVU : UserControl
    {
        public event EventHandler StartRequested;
        public event EventHandler CompleteRequested;

        public ucChefVU()
        {
            InitializeComponent();
            btnIP.Click += btnIP_Click;
            btnComplete.Click += btnComplete_Click;
        }

        public string OrderDetailsID { get; set; }

        public string OrderID
        {
            get { return orderID; }
            set
            {
                orderID = value;
                lblOrderNo.Text = "Order No.\r\n" + value;
            }
        }
        private string orderID;

        public string OrderTable
        {
            set { lblTable.Text = "Table: " + value; }
        }

        public DateTime OrderDate
        {
            set { lblOrderTime.Text = "Order Time: " + value.ToString("g"); }
        }

        public string OrderType
        {
            set { lblOrderType.Text = "Order Type: " + value; }
        }

        public string FoodName
        {
            set { lblFood.Text = "Food: " + value; }
        }

        public int Quantity
        {
            set { lblAmount.Text = "Amount: " + value; }
        }

        public Image FoodImage
        {
            set { picFood.Image = value; }
        }

        public string OrderDetailsStatus
        {
            get { return orderDetailsStatus; }
            set
            {
                orderDetailsStatus = value;
                bool isPending = string.Equals(value, "Pending", StringComparison.OrdinalIgnoreCase);
                btnIP.Enabled = isPending;
                btnComplete.Enabled = !isPending && string.Equals(value, "In Progress", StringComparison.OrdinalIgnoreCase);
                btnIP.Text = isPending ? "Start" : "In Progress";
            }
        }
        private string orderDetailsStatus;

        private void btnIP_Click(object sender, EventArgs e)
        {
            StartRequested?.Invoke(this, EventArgs.Empty);
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            CompleteRequested?.Invoke(this, EventArgs.Empty);
        }
    }
}
