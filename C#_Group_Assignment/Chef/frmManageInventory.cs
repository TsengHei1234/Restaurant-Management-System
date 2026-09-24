using C__Group_Assignment.Chef;
using System;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace C__Group_Assignment
{
    public partial class frmManageInventory : Form
    {
        private readonly ChefService chefService = new ChefService();

        public frmManageInventory()
        {
            InitializeComponent();
            Load += frmManageInventory_Load;
            btnAdd.Text = "Transfer from Storage";
            btnDelete.Text = "Return to Storage";
        }

        private void frmManageInventory_Load(object sender, EventArgs e)
        {
            lblName.Text = "Welcome Back!\r\n" + UserSession.UserName;
            lblTime.Text = "Time: " + SetDateTime.CurrentDateTime.ToString("g");
            lblStatus.Text = "Status: Inventory Management";
            CheckLowInventory();
        }

        private void CheckLowInventory()
        {
            try
            {
                DataTable lowInventory = chefService.LoadLowInventory(10);
                if (lowInventory.Rows.Count == 0)
                {
                    return;
                }

                StringBuilder items = new StringBuilder();
                foreach (DataRow row in lowInventory.Rows)
                {
                    items.AppendLine($"{row["IngredientName"]} - {row["QuantityAvailable"]} left");
                }
                MessageBox.Show("The following ingredients are low in stock:\n\n" + items, "Low Inventory Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Unable to Check Inventory", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable ingredients = chefService.SearchIngredients(txtIngSearch.Text);
                if (ingredients.Rows.Count == 0)
                {
                    label3.Text = "Ingredient not found";
                    return;
                }

                DataRow row = ingredients.Rows[0];
                txtIngSearch.Text = Convert.ToString(row["IngredientName"]);
                label3.Text = Convert.ToString(row["QuantityAvailable"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Unable to Search Inventory", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int quantity;
            if (!TryReadPositiveQuantity(IngAdd.Text, out quantity))
            {
                return;
            }

            ExecuteInventoryChange(
                () => chefService.TransferFromStorage(txtIngSearch.Text.Trim(), quantity),
                "Inventory quantity transferred from storage successfully.");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int quantity;
            if (!TryReadPositiveQuantity(IngDeduct.Text, out quantity))
            {
                return;
            }

            ExecuteInventoryChange(
                () => chefService.ReturnToStorage(txtIngSearch.Text.Trim(), quantity),
                "Inventory quantity returned to storage successfully.");
        }

        private static bool TryReadPositiveQuantity(string text, out int quantity)
        {
            if (!int.TryParse(text, out quantity) || quantity <= 0)
            {
                MessageBox.Show("Enter a whole-number quantity greater than zero.", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void ExecuteInventoryChange(Action change, string successMessage)
        {
            try
            {
                change();
                MessageBox.Show(successMessage, "Inventory Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSearch_Click(this, EventArgs.Empty);
                IngAdd.Clear();
                IngDeduct.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Inventory Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (frmStorage storageForm = new frmStorage())
            {
                storageForm.ShowDialog(this);
            }
        }
    }
}
