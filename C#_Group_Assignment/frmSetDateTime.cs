using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace C__Group_Assignment
{
    public partial class frmSetDateTime : Form
    {
        private frmlogin frmlogin;

        public frmSetDateTime(frmlogin frmlogin)
        {
            InitializeComponent();
            this.frmlogin = frmlogin;
        }

        private void btnSetDateTime_Click(object sender, EventArgs e)
        {
            if (cmbTime.SelectedIndex == -1)
            {
                MessageBox.Show("Please select time before proceding!", "Time Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DateTime dateTime = dateTimePicker.Value.Date.Add(DateTime.Parse(cmbTime.SelectedItem.ToString().Split('-')[0]).TimeOfDay);
                MessageBox.Show($"Date and Time is changed to {Convert.ToString(dateTime)}");
                SetDateTime.CurrentDateTime = dateTime;
                frmlogin.UpdateDateTimeDisplay();
                this.Close();
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private Point mouseLocation;

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void pnlTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }
    }
}
