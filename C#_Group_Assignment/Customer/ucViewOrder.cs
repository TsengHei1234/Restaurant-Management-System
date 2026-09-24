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
    public partial class ucViewOrder : UserControl
    {
        public ucViewOrder()
        {
            InitializeComponent();
        }

        public int viewOrderNo
        {
            get { return int.Parse(lblOrderNo.Text); }
            set { lblOrderNo.Text = $"Order No.\n{value.ToString()}"; }
        }

        public string viewOrderID { get; set; }

        public string viewOrderName
        {
            get { return lblOrderName.Text; }
            set { lblOrderName.Text = value; }
        }

        public int viewOrderAmount
        {
            get { return Convert.ToInt32(lblAmount.Text); }
            set { lblAmount.Text = $"Amount: {value}"; }
        }

        public string viewOrderStatus
        {
            get { return lblStatus.Text; }
            set { lblStatus.Text = value; }
        }

        public int viewOrderPrice
        {
            get { return Convert.ToInt32(lblPrice.Text); }
            set { lblPrice.Text = $"{value}"; }
        }

        public Image viewOrderImage
        {
            get { return picFood.Image; }
            set { picFood.Image = value; }
        }
    }
}
