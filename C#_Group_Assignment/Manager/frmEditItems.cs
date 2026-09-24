using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using C__Group_Assignment.Manager;

namespace C__Group_Assignment
{
    public partial class frmEditItems : Form
    {
        private readonly ManagerService service = new ManagerService();
        private string selectedFoodID;
        private string selectedImageKey;
        private string replacementImagePath;

        public frmEditItems()
        {
            InitializeComponent();
            lblName.Text = "Welcome Back!\r\n" + (UserSession.UserName ?? "Manager");
            lblTime.Text = "Time: " + DateTime.Now.ToString("g");
            LoadFoods();
        }

        private void LoadFoods()
        {
            DataTable foods = service.LoadFoods();
            lbEdit.DataSource = foods;
            lbEdit.DisplayMember = "FoodName";
            lbEdit.ValueMember = "FoodID";
            lbEdit.ClearSelected();
        }

        private void lbEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbEdit.SelectedValue == null || lbEdit.SelectedValue is DataRowView) return;
            LoadSelection(lbEdit.SelectedValue.ToString());
        }

        private void btnSelect_Click_1(object sender, EventArgs e)
        {
            if (lbEdit.SelectedValue == null) MessageBox.Show("Please select a menu item.");
            else LoadSelection(lbEdit.SelectedValue.ToString());
        }

        private void LoadSelection(string foodID)
        {
            FoodRecord food = service.GetFood(foodID);
            if (food == null) return;
            selectedFoodID = food.FoodID;
            selectedImageKey = food.FoodImage;
            replacementImagePath = null;
            txtEditItemName.Text = food.FoodName;
            txtEditPrice.Text = food.Price.ToString("0");
            rbAvailable.Checked = food.FoodStatus == "Available";
            rbUnavailable.Checked = food.FoodStatus == "Unavailable";
            pbEdit.Image = MenuImageStore.Load(food.FoodImage);
        }

        private void btnEditUploadItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (dialog.ShowDialog() != DialogResult.OK) return;
                replacementImagePath = dialog.FileName;
                using (Image image = Image.FromFile(replacementImagePath)) pbEdit.Image = new Bitmap(image);
            }
        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(selectedFoodID)) throw new InvalidOperationException("Please select a menu item.");
                decimal price;
                if (!decimal.TryParse(txtEditPrice.Text.Trim(), out price)) throw new InvalidOperationException("Please enter a valid price.");
                FoodRecord existing = service.GetFood(selectedFoodID);
                string imageKey = replacementImagePath == null ? selectedImageKey : MenuImageStore.Import(replacementImagePath);
                service.UpdateFood(selectedFoodID, new FoodRecord
                {
                    FoodName = txtEditItemName.Text,
                    Category = existing.Category,
                    Price = price,
                    FoodStatus = rbAvailable.Checked ? "Available" : rbUnavailable.Checked ? "Unavailable" : null,
                    FoodImage = imageKey
                });
                MessageBox.Show("Item updated successfully.");
                LoadFoods();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Unable to update item", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(selectedFoodID)) throw new InvalidOperationException("Please select a menu item.");
                if (MessageBox.Show("Delete this menu item?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;
                service.DeleteFood(selectedFoodID);
                ClearEditor();
                LoadFoods();
                MessageBox.Show("Item deleted successfully.");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Unable to delete item", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnCancelEdit_Click(object sender, EventArgs e) { ClearEditor(); lbEdit.ClearSelected(); }

        private void ClearEditor()
        {
            selectedFoodID = null; selectedImageKey = null; replacementImagePath = null;
            txtEditItemName.Clear(); txtEditPrice.Clear(); pbEdit.Image = null;
            rbAvailable.Checked = false; rbUnavailable.Checked = false;
        }
    }
}
