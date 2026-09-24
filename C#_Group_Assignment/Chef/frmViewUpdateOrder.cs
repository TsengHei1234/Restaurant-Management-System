using C__Group_Assignment.Chef;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace C__Group_Assignment
{
    public partial class frmViewUpdateOrder : Form
    {
        private readonly ChefService chefService = new ChefService();

        public frmViewUpdateOrder()
        {
            InitializeComponent();
        }

        private void frmViewUpdateOrder_Load(object sender, EventArgs e)
        {
            lblName.Text = "Welcome Back!\r\n" + UserSession.UserName;
            lblTime.Text = "Time: " + SetDateTime.CurrentDateTime.ToString("g");
            lblStatus.Text = "Status: Paid Orders Awaiting Preparation";
            LoadOrders();
        }

        private void LoadOrders()
        {
            try
            {
                DisposeOrderCards();
                DataTable orders = chefService.LoadActiveOrderDetails(UserSession.UserID);
                if (orders.Rows.Count == 0)
                {
                    pnlViewUpdateOrder.Controls.Add(new Label
                    {
                        AutoSize = true,
                        Font = new Font("Segoe UI", 12F, FontStyle.Regular),
                        Margin = new Padding(20),
                        Text = "No paid orders are waiting for this chef."
                    });
                    return;
                }

                foreach (DataRow row in orders.Rows)
                {
                    ucChefVU orderCard = new ucChefVU
                    {
                        OrderDetailsID = Convert.ToString(row["OrderDetailsID"]),
                        OrderID = Convert.ToString(row["OrderID"]),
                        OrderTable = Convert.ToString(row["OrderTable"]),
                        OrderDate = Convert.ToDateTime(row["OrderDate"]),
                        OrderType = Convert.ToString(row["OrderType"]),
                        FoodName = Convert.ToString(row["FoodName"]),
                        Quantity = Convert.ToInt32(row["Quantity"]),
                        FoodImage = LoadFoodImage(Convert.ToString(row["FoodImage"])),
                        OrderDetailsStatus = Convert.ToString(row["OrderDetailsStatus"])
                    };
                    orderCard.StartRequested += orderCard_StartRequested;
                    orderCard.CompleteRequested += orderCard_CompleteRequested;
                    pnlViewUpdateOrder.Controls.Add(orderCard);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Unable to Load Chef Orders", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void orderCard_StartRequested(object sender, EventArgs e)
        {
            ucChefVU orderCard = (ucChefVU)sender;
            try
            {
                if (!chefService.StartOrderDetail(orderCard.OrderDetailsID, UserSession.UserID))
                {
                    MessageBox.Show("This item was already accepted by another chef or is no longer pending.", "Order Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                LoadOrders();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Unable to Start Order", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void orderCard_CompleteRequested(object sender, EventArgs e)
        {
            ucChefVU orderCard = (ucChefVU)sender;
            try
            {
                if (!chefService.CompleteOrderDetail(orderCard.OrderDetailsID, UserSession.UserID))
                {
                    MessageBox.Show("Only the assigned chef can complete an in-progress item.", "Order Not Completed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                LoadOrders();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Unable to Complete Order", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static Image LoadFoodImage(string imageName)
        {
            if (string.IsNullOrWhiteSpace(imageName))
            {
                return null;
            }
            return Properties.Resources.ResourceManager.GetObject(imageName) as Image;
        }

        private void DisposeOrderCards()
        {
            while (pnlViewUpdateOrder.Controls.Count > 0)
            {
                Control control = pnlViewUpdateOrder.Controls[0];
                pnlViewUpdateOrder.Controls.RemoveAt(0);
                control.Dispose();
            }
        }
    }
}
