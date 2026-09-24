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
    public partial class ucOrder : UserControl
    {
        private frmMenu frmMenu;

        public ucOrder(frmMenu frmMenu)
        {
            InitializeComponent();
            this.frmMenu = frmMenu;
        }

        public string orderID { get; set; }

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

        public void SetMaximumQuantity(int MaximumOrder)
        {
            int MaxOrder = Convert.ToInt32(numOrder.Value) + MaximumOrder;  // bug fix: maximumorder clash with numorder.Max, thus cannot go over the available amount 
            if (MaxOrder > 0)                                               // bug fix: Negative value is presented, fix to not having negative value
            {
                numOrder.Maximum = MaxOrder;
            }
            //MessageBox.Show(MaximumOrder.ToString());
        }

        public int oldQuantity = 1;

        private void numOrder_ValueChanged(object sender, EventArgs e)
        {
            int newQuantity = (int)numOrder.Value;
            int quantityChange = 0;
            Customer AddDeductIngredients = new Customer();

            if (newQuantity > oldQuantity)
            {
                quantityChange = newQuantity - oldQuantity;
                AddDeductIngredients.DeductIngredients(orderID, quantityChange);
            }
            else if (newQuantity < oldQuantity)
            {
                quantityChange = oldQuantity - newQuantity;
                AddDeductIngredients.RestoreIngredients(orderID, quantityChange);
            }

            if (newQuantity == numOrder.Maximum)
            {
                MessageBox.Show($"The maximum value you can order is {numOrder.Maximum}.", "Limit Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            oldQuantity = newQuantity;
            frmMenu.updateTotalAmount();
            frmMenu.UpdateMaximumOrder();
            frmMenu.LoadFoodItems(frmMenu.category);

            if (numOrder.Value == 0)
            {
                frmMenu.pnlOrders.Controls.Remove(this);
            }
        }

        private void ucOrder_Load(object sender, EventArgs e)
        {
            Customer deductIngredients = new Customer();
            deductIngredients.DeductIngredients(orderID);
            oldQuantity = Convert.ToInt32(numOrder.Value);
            frmMenu.UpdateMaximumOrder
                ();
            if (oldQuantity == numOrder.Maximum)
            {
                MessageBox.Show($"The maximum value you can order is {numOrder.Maximum}.", "Limit Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
