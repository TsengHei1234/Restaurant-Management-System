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
    public partial class frmMenuFeedback : Form
    {
        public frmMenuFeedback()
        {
            InitializeComponent();
        }

        public string OrderTable
        {
            get { return lblTableNo.Text; }
            set { lblTableNo.Text = $"Table No: {value}"; }
        }

        public string OrderID
        {
            get { return lblOrderID.Text; }
            set { lblOrderID.Text = $"OrderID: {value}"; }
        }


        private void frmMenuFeedback_Load(object sender, EventArgs e)
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
            LoadCompletedOrders();
            if (cmbWalkInDate.Items.Count == 0)
            {
                MessageBox.Show("You don't have any completed orders to give feedback on!", "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        bool WalkInHistoryExpand = false;

        private void transitionWalkInHistory_Tick(object sender, EventArgs e)
        {
            if (WalkInHistoryExpand)
            {
                pnlWalkInHistory.Width -= 5;
                if (pnlWalkInHistory.Width <= 0)
                {
                    transitionWalkInHistory.Stop();
                }
            }
            else
            {
                pnlWalkInHistory.Width += 5;
                if (pnlWalkInHistory.Width >= 278)
                {
                    transitionWalkInHistory.Stop();
                }
            }
        }

        private void btnChooseFeedback_Click(object sender, EventArgs e)
        {
            LoadCompletedOrders();
            if (cmbWalkInDate.Items.Count == 0)
            {
                MessageBox.Show("You don't have any completed orders to give feedback on!", "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (pnlWalkInHistory.Width < 278)
            {
                WalkInHistoryExpand = false;
                transitionWalkInHistory.Start();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (pnlWalkInHistory.Width > 0)
            {
                WalkInHistoryExpand = true;
                transitionWalkInHistory.Start();
            }
        }

        private void cmbWalkInDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbWalkInDate.SelectedItem != null)
            {
                var selectedOrder = ((string, DateTime))cmbWalkInDate.SelectedItem;

                string selectedOrderID = selectedOrder.Item1;
                DateTime selectedOrderDate = selectedOrder.Item2;

                LoadCompletedOrderDetails(selectedOrderID, selectedOrderDate);
                frmReset();
            }
        }

        private void btnFeedbackNow_Click(object sender, EventArgs e)
        {
            if (cmbWalkInDate.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a date and time of your order!", "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (pnlWalkInHistory.Width > 0)
                {
                    WalkInHistoryExpand = true;
                    transitionWalkInHistory.Start();
                }
                pnlMenuFeedback.Visible = true;
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
            FeedbackMenu1 = 0;
            FeedbackMenu2 = 0;
            FeedbackMenu3 = 0;
            FeedbackMenuText = null;
            txtComments.Clear();
        }

        int FeedbackMenu1 = 0;
        int FeedbackMenu2 = 0;
        int FeedbackMenu3 = 0;
        string FeedbackMenuText;

        private void btnSubmitFeedback_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked) FeedbackMenu1 = 1;
            else if (radioButton2.Checked) FeedbackMenu1 = 2;
            else if (radioButton3.Checked) FeedbackMenu1 = 3;
            else if (radioButton4.Checked) FeedbackMenu1 = 4;
            else if (radioButton5.Checked) FeedbackMenu1 = 5;

            if (radioButton6.Checked) FeedbackMenu2 = 1;
            else if (radioButton7.Checked) FeedbackMenu2 = 2;
            else if (radioButton8.Checked) FeedbackMenu2 = 3;
            else if (radioButton9.Checked) FeedbackMenu2 = 4;
            else if (radioButton10.Checked) FeedbackMenu2 = 5;

            if (radioButton11.Checked) FeedbackMenu3 = 1;
            else if (radioButton12.Checked) FeedbackMenu3 = 2;
            else if (radioButton13.Checked) FeedbackMenu3 = 3;
            else if (radioButton14.Checked) FeedbackMenu3 = 4;
            else if (radioButton15.Checked) FeedbackMenu3 = 5;

            FeedbackMenuText = txtComments.Text;

            if (FeedbackMenu1 == 0 || FeedbackMenu2 == 0 || FeedbackMenu3 == 0)
            {
                MessageBox.Show("Please complete filling up the menu feedback!", "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string OrderIDPut = lblOrderID.Text.Replace("OrderID: ", "").Trim();
                Customer updateFeedbackDetails = new Customer();
                updateFeedbackDetails.SaveMenuFeedbackDetails(OrderIDPut, FeedbackMenu1, FeedbackMenu2, FeedbackMenu3, FeedbackMenuText);
                MessageBox.Show("Feedback has been submitted successfully!", "Feedback Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbWalkInDate.SelectedIndex = -1;
                cmbWalkInDate.Text = "Select your Walk-in Date...";
                pnlMenuFeedback.Visible = false;
                frmReset();
                LoadCompletedOrders();
                OrderID = null;
                lstFoodOrdered.Items.Clear();
                OrderTable = null;
            }
        }

        public void LoadCompletedOrders()
        {
            Customer loadCompletedOrders = new Customer();
            List<(string OrderID, DateTime OrderDate)> orders = loadCompletedOrders.LoadPendingMenuFeedback();

            cmbWalkInDate.Items.Clear();
            foreach (var order in orders)
            {
                cmbWalkInDate.Items.Add((order.OrderID.ToString(), order.OrderDate));
            }
        }

        public void LoadCompletedOrderDetails(string orderID, DateTime selectedDate)
        {
            Customer loadCompletedOrders = new Customer();
            lstFoodOrdered.Items.Clear();
            OrderTable = loadCompletedOrders.LoadCompletedOrderDetails(orderID, selectedDate);
            List<string> foodItems = loadCompletedOrders.LoadOrderFoodItems(orderID);
            if (foodItems != null)
            {
                foreach (var item in foodItems)
                {
                    lstFoodOrdered.Items.Add(item);
                }
                OrderID = orderID;
            }

        }
    }
}
