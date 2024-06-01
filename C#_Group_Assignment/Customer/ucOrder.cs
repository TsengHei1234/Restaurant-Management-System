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
    public partial class ucOrder : UserControl
    {
        private frmMenu parentForm;

        public ucOrder(frmMenu parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        public string orderId { get; set; }

        public string orderCategory { get; set; }

        public string orderName
        {
            get { return lblOrderName.Text; }
            set { lblOrderName.Text = value; }
        }

        public int orderPrice
        {
            get { return Convert.ToInt32(lblPrice.Text); }
            set { lblPrice.Text = Convert.ToString(value); }
        }

        public int orderAmount
        {
            get { return (int)numOrder.Value; }
            set { numOrder.Value = value; }
        }

        public Image orderImage
        {
            get { return picFood.Image; }
            set { picFood.Image = value; }
        }

        public void IncrementQuantity()
        {
            numOrder.Value++;
        }

        private void numOrder_ValueChanged(object sender, EventArgs e)
        {
            parentForm.updateTotalAmount();
            if (numOrder.Value == 0)
            {
                parentForm.pnlOrders.Controls.Remove(this);
            }
        }
    }
}
