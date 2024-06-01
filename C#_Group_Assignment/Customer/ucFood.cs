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
    public partial class ucFood : UserControl
    {
        private frmMenu frmMenu;

        public ucFood(frmMenu frmMenu)
        {
            InitializeComponent();
            this.frmMenu = frmMenu;
        }

        public string foodID { get; set; }

        public string foodCategory { get; set; }

        public string foodName
        {
            get { return lblFoodName.Text; }
            set { lblFoodName.Text = value; }
        }

        public int foodPrice
        {   
            get { return Convert.ToInt32(lblFoodPrice.Text); }
            set { lblFoodPrice.Text = Convert.ToString(value); }
        }

        public Image foodImage
        {
            get { return picItem.Image; }
            set { picItem.Image = value; }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            var existingOrder = frmMenu.orderExists(foodName);
            if (existingOrder != null)
            {
                existingOrder.IncrementQuantity();
            }
            else
            {
                var order = new ucOrder(frmMenu)
                {
                    orderId = foodID,
                    orderName = foodName,
                    orderCategory = foodCategory,
                    orderPrice = foodPrice,
                    orderImage = foodImage
                };
                frmMenu.pnlOrders.Controls.Add(order);
            }
            frmMenu.updateTotalAmount();
        }
    }
}
