using System;
using System.Drawing;
using System.Windows.Forms;
using C__Group_Assignment.Manager;

namespace C__Group_Assignment
{
    public partial class frmAddMenuItem : Form
    {
        private readonly ManagerService service = new ManagerService();
        private string selectedImagePath;

        public frmAddMenuItem()
        {
            InitializeComponent();
            rbAvailable.Checked = true;
            lblName.Text = "Welcome Back!\r\n" + (UserSession.UserName ?? "Manager");
            lblTime.Text = "Time: " + DateTime.Now.ToString("g");
        }

        private void btnUploadItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (dialog.ShowDialog() != DialogResult.OK) return;
                selectedImagePath = dialog.FileName;
                using (Image image = Image.FromFile(selectedImagePath))
                {
                    pbUploadItem.Image = new Bitmap(image);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                decimal price;
                if (!decimal.TryParse(txtPrice.Text.Trim(), out price))
                    throw new InvalidOperationException("Please enter a valid price.");
                if (string.IsNullOrWhiteSpace(selectedImagePath))
                    throw new InvalidOperationException("Please upload an image.");

                string imageKey = MenuImageStore.Import(selectedImagePath);
                string foodID = service.AddFood(new FoodRecord
                {
                    FoodName = txtItemName.Text,
                    Category = cbAddCategory.SelectedItem == null ? null : cbAddCategory.SelectedItem.ToString(),
                    Price = price,
                    FoodStatus = rbAvailable.Checked ? "Available" : rbUnavailable.Checked ? "Unavailable" : null,
                    FoodImage = imageKey
                });
                MessageBox.Show("Item " + foodID + " saved successfully.", "Menu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtItemName.Clear();
                txtPrice.Clear();
                cbAddCategory.SelectedIndex = -1;
                pbUploadItem.Image = null;
                selectedImagePath = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Unable to save item", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
