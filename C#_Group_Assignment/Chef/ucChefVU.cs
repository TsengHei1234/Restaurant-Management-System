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
    public partial class ucChefVU : UserControl
    {
        public ucChefVU()
        {
            InitializeComponent();
        }

        public int vuTable
        {
            get { return Convert.ToInt32(lblTable.Text); }
            set { lblTable.Text = $"Table: {value}";  }
        }

        public string vuOrderTime
        {
            get { return lblOrderTime.Text; }
            set { lblOrderTime.Text = $"Order Time: {value}"; }
        }

        public string vuOrderType
        {
            get { return lblOrderType.Text; }
            set { lblOrderType.Text = $"Order Type: {value}"; }
        }

        public string vuFood
        {
            get { return lblFood.Text; }
            set { lblFood.Text = $"Food: {value}"; }
        }

        public int vuAmount
        {
            get { return Convert.ToInt32(lblAmount.Text); }
            set { lblAmount.Text = $"Amount: {value}"; }
        }
    }
}
