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
            /*for (int i = 0; i < 20; i++)
            {
                var Food = new ucFood(this)
                {
                    foodID = "F001",
                    foodName = "Hamburger",
                    foodCategory = "Western",
                    foodPrice = "20",
                    //FoodImage = "Nothing",
                };
                pnlFoods.Controls.Add(Food);
            }*/
            var Food = new ucFood(this)
            {
                foodID = "F001",
                foodName = "Hamburger",
                foodCategory = "Western",
                foodPrice = 20,
                //FoodImage = "Nothing",
            };
            pnlFoods.Controls.Add(Food);

            var Food1 = new ucFood(this)
            {
                foodID = "F002",
                foodName = "Spagetti",
                foodCategory = "Western",
                foodPrice = 10,
                //FoodImage = "Nothing",
            };
            pnlFoods.Controls.Add(Food1);

            var Food2 = new ucFood(this)
            {
                foodID = "F003",
                foodName = "Testing",
                foodCategory = "Western",
                foodPrice = 15,
                //FoodImage = "Nothing",
            };
            pnlFoods.Controls.Add(Food2);
        }
        
        public ucOrder orderExists(string FoodName)
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

        public void updateTotalAmount()
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
                if (control is ucOrder)
                {
                    DialogResult confirmationOrder = MessageBox.Show("Are you sure you want to order?","Confirmation",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    comfirmOrder = true;
                    if (confirmationOrder == DialogResult.Yes)
                    {
                        MessageBox.Show("Order has been placed!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        pnlOrders.Controls.Clear();
                        frmCustomer.loadform(new frmViewOrder());
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
    }
}
