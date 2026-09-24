using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__Group_Assignment
{
    public partial class frmMenu : Form
    {
        private frmCustomer frmCustomer;

        public frmMenu(frmCustomer frmCustomer)
        {
            InitializeComponent();
            this.frmCustomer = frmCustomer;
            frmCustomer.getMenuForm(this);
        }

        private void frmMenu_Load(object sender, EventArgs e)
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
            category = "All";
            LoadFoodItems("All");
        }

        public string category = "All";

        public void LoadFoodItems(string category)
        {
            pnlFoods.Controls.Clear();
            Customer LoadFoodTable = new Customer();
            DataTable FoodTable = LoadFoodTable.LoadFood();
            foreach (DataRow row in FoodTable.Rows)
            {
                string FoodID = row["FoodID"].ToString();
                string FoodName = row["FoodName"].ToString();
                string FoodCategory = row["Category"].ToString();
                int FoodPrice = Convert.ToInt32(row["Price"]);
                string foodImage = row["FoodImage"].ToString();
                bool FoodAvailable = LoadFoodTable.CheckFoodAvailable(FoodID);

                if (FoodCategory == category)
                {
                    var Food = new ucFood(this)
                    {
                        foodID = FoodID,
                        foodName = FoodName,
                        foodCategory = FoodCategory,
                        foodPrice = FoodPrice,
                        foodImage = GetImageFromResources(foodImage),
                        foodAvailable = FoodAvailable
                    };
                    pnlFoods.Controls.Add(Food);
                }
                else if (category == "All")
                {
                    var Food = new ucFood(this)
                    {
                        foodID = FoodID,
                        foodName = FoodName,
                        foodCategory = FoodCategory,
                        foodPrice = FoodPrice,
                        foodImage = GetImageFromResources(foodImage),
                        foodAvailable = FoodAvailable
                    };
                    pnlFoods.Controls.Add(Food);
                }
            }
        }

        private Image GetImageFromResources(string imageName)
        {
            return MenuImageStore.Load(imageName);
        }

        public void UpdateMaximumOrder()    //numericUpDown limit for each ucOrder, check ingredients
        {
            foreach (Control control in pnlOrders.Controls)
            {
                if (control is ucOrder order)
                {
                    Customer updateOrderMax = new Customer();
                    int MaximumOrder = updateOrderMax.CalculateMaxQuantity(order.orderID);
                    order.SetMaximumQuantity(MaximumOrder);
                }
            }
        }

        public ucOrder orderExists(string FoodName)     //Avoid Duplication for ucOrder
        {
            foreach (Control control in pnlOrders.Controls)
            {
                if (control is ucOrder order && order.orderName == FoodName)
                {
                    return order;
                }
            }
            return null;
        }

        public void updateTotalAmount() //Update Total Amount every numericUpDown changes and "Ordernow"
        {
            int total = 0;
            foreach (Control control in pnlOrders.Controls)
            {
                if (control is ucOrder order)
                {
                    total = total + (order.orderPrice * order.orderAmount);
                }
            }
            lblTotalAmount.Text = Convert.ToString(total);
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            Boolean comfirmOrder = false;

            foreach (Control control in pnlOrders.Controls)
            {
                if (control is ucOrder order)
                {
                    DialogResult confirmationOrder = MessageBox.Show("Are you sure you want to order?","Confirmation",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    comfirmOrder = true;
                    if (confirmationOrder == DialogResult.Yes)
                    {
                        Customer updateOrder = new Customer();
                        string newOrderID = updateOrder.UpdateOrdersTable(Convert.ToInt32(lblTotalAmount.Text));
                        OrderFood(newOrderID);
                        if (Customer.CustomerDineInMethod == "Reservation")
                        {
                            updateOrder.UpdateReservationTable("Ongoing");
                        }

                        MessageBox.Show("Order has been placed!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        pnlOrders.Controls.Clear();
                        frmCustomer.loadform(new frmViewOrder(null));

                        break;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            if (!comfirmOrder)
            {
                MessageBox.Show("You have not selected any order!", "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void OrderFood(string newOrderID)
        {
            foreach (Control control in pnlOrders.Controls)
            {
                if (control is ucOrder order)
                {
                    Customer updateOrder = new Customer();
                    updateOrder.UpdateOrderDetailsTable(newOrderID, order.orderID, order.orderAmount);
                }
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            category = "All";
            LoadFoodItems("All");
        }

        private void btnItalian_Click(object sender, EventArgs e)
        {
            category = "Italian";
            LoadFoodItems("Italian");
        }

        private void btnMexican_Click(object sender, EventArgs e)
        {
            category = "Mexican";
            LoadFoodItems("Mexican");
        }

        private void btnJapanese_Click(object sender, EventArgs e)
        {
            category = "Japanese";
            LoadFoodItems("Japanese");
        }
    }
}
