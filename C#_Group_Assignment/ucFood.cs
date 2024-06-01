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
        private frmMenu parentForm;

        public ucFood(frmMenu parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        public string foodID { get; set; }

        public string foodCategory { get; set; }

        public string foodName
        {
            get { return lblFoodName.Text; }
            set { lblFoodName.Text = value; }
        }

        public string foodPrice
        {   
            get { return lblFoodPrice.Text; }
            set { lblFoodPrice.Text = value; }
        }

        public Image foodImage
        {
            get { return picItem.Image; }
            set { picItem.Image = value; }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            var order = new ucOrder()
            {
                orderId = foodID,
                orderName = foodName,
                orderCategory = foodCategory,
                orderPrice = foodPrice,
                orderImage = foodImage
            };
            parentForm.pnlOrders.Controls.Add(order);
        }
    }
}
