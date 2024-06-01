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
        public ucOrder()
        {
            InitializeComponent();
        }

        public string orderId { get; set; }

        public string orderCategory { get; set; }

        public string orderName
        {
            get { return lblOrderName.Text; }
            set { lblOrderName.Text = value; }
        }

        public string orderPrice
        {
            get { return lblPrice.Text; }
            set { lblPrice.Text = value; }
        }

        public Image orderImage
        {
            get { return picFood.Image; }
            set { picFood.Image = value; }
        }
    }
}
