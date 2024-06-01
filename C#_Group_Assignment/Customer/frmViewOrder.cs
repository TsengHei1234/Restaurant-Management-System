using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__Group_Assignment
{
    public partial class frmViewOrder : Form
    {
        public frmViewOrder()
        {
            InitializeComponent();
        }

        private void frmViewOrder_Load(object sender, EventArgs e)
        {
            int orderNo = 1;
            for (int i = 0; i < 10; i++)
            {
                ucViewOrder viewOrder = new ucViewOrder()
                {
                    viewOrderNo = orderNo,
                    viewOrderName = "Risotto alla Milanese",
                    viewOrderAmount = 2,
                    vieworderStatus = "Completed",
                    viewOrderPrice = "20",
                    //viewOrderImage = "0"
                };
                pnlViewOrder.Controls.Add(viewOrder);
                orderNo += 1;
            }
        }

        bool checkoutExpand = false;

        private void transitionCheckout_Tick(object sender, EventArgs e)
        {
            if (checkoutExpand)
            {
                pnlCheckout.Width -= 5;
                if (pnlCheckout.Width <= 0)
                {
                    transitionCheckout.Stop();
                }
            }
            else
            {
                pnlCheckout.Width += 5;
                if (pnlCheckout.Width >= 278)
                {
                    transitionCheckout.Stop();
                }
            }
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            Boolean hasOrder = false;
            Boolean statusOrder = false;  // for future with database if food is still Pending or In Progress

            foreach (Control control in pnlViewOrder.Controls)
            {
                if (control is ucViewOrder)
                {
                    hasOrder = true;
                    break;
                }
            }

            foreach (Control control in pnlViewOrder.Controls)
            {
                if (control is ucViewOrder viewOrder && (viewOrder.vieworderStatus == "In Progress" || viewOrder.vieworderStatus == "Pending"))
                {
                    statusOrder = false;
                    break;
                }
                else
                {
                    statusOrder = true;
                }
            }

            if (!hasOrder)
            {
                MessageBox.Show("Please order Food to Proceed to checkout", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!statusOrder)
            {
                MessageBox.Show("Your food is still in progress, please wait until your food is served.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (pnlCheckout.Width < 278)
                {
                    checkoutExpand = false;
                    transitionCheckout.Start();
                }
            }
        }

        string paymentType;

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (pnlCheckout.Width > 0)
            {
                checkoutExpand = true;
                transitionCheckout.Start();
                fontRegular();
                paymentType = null;
            }
        }

        private void fontRegular()
        {
            lblCash.Font = new Font(lblCash.Font, FontStyle.Regular);
            lblCredit.Font = new Font(lblCredit.Font, FontStyle.Regular);
            lblOnline.Font = new Font(lblOnline.Font, FontStyle.Regular);
        }

        private void picCash_Click(object sender, EventArgs e)
        {
            fontRegular();
            lblCash.Font = new Font(lblCash.Font, FontStyle.Bold);
            paymentType = "Cash in Hand";
        }

        private void picCredit_Click(object sender, EventArgs e)
        {
            fontRegular();
            lblCredit.Font = new Font(lblCredit.Font, FontStyle.Bold);
            paymentType = "Credit Card";
        }

        private void picOnline_Click(object sender, EventArgs e)
        {
            fontRegular();
            lblOnline.Font = new Font(lblOnline.Font, FontStyle.Bold);
            paymentType = "Online Banking";
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (paymentType == null)
            {
                MessageBox.Show("Please choose a payment method before paying!","IMPORTANT!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DialogResult confirmationOrder = MessageBox.Show($"Are you sure you want to pay by {paymentType}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmationOrder == DialogResult.Yes)
                {
                    MessageBox.Show($"Payment Completed!\nTotal Amount: {lblPrice.Text}\nPayment Method: {paymentType}");
                    paymentType = null;
                    fontRegular();

                    ArrayList viewOrderRemove = new ArrayList();
                    foreach (Control control in pnlViewOrder.Controls)
                    {
                        if (control is ucViewOrder viewOrder)
                        {
                            viewOrderRemove.Add(viewOrder);
                        }
                    }

                    foreach (ucViewOrder viewOrder in viewOrderRemove)
                    {
                        pnlViewOrder.Controls.Remove(viewOrder);
                    }

                    if (pnlCheckout.Width > 0)
                    {
                        checkoutExpand = true;
                        transitionCheckout.Start();
                    }
                }
            }

        }
    }
}
