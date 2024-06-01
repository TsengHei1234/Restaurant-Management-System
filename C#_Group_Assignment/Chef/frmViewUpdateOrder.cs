using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace C__Group_Assignment
{
    public partial class frmViewUpdateOrder : Form
    {
        public frmViewUpdateOrder()
        {
            InitializeComponent();
        }

        private void frmViewUpdateOrder_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                ucChefVU ChefVU = new ucChefVU()
                {
                    vuTable = 1,
                    vuOrderTime = "2:30",
                    vuOrderType = "Reservation",
                    vuFood = "Sandwich",
                    vuAmount = 3
                };
                pnlViewUpdateOrder.Controls.Add(ChefVU);
            }
        }
    }
}
