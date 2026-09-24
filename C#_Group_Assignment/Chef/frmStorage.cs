using System;
using System.Data;
using System.Windows.Forms;

namespace C__Group_Assignment.Chef
{
    public partial class frmStorage : Form
    {
        private readonly ChefService chefService = new ChefService();

        public frmStorage()
        {
            InitializeComponent();
            Load += frmStorage_Load;
            comboBox1.KeyUp += comboBox1_KeyUp;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            button2.Click += button2_Click;
            btnRestock.Text = "Restock 50";
        }

        private void frmStorage_Load(object sender, EventArgs e)
        {
            LoadStorageItems(string.Empty, false);
        }

        private void comboBox1_KeyUp(object sender, KeyEventArgs e)
        {
            LoadStorageItems(comboBox1.Text, true);
        }

        private void LoadStorageItems(string searchText, bool preserveText)
        {
            try
            {
                string currentText = comboBox1.Text;
                DataTable storage = chefService.LoadStorage(searchText);
                comboBox1.BeginUpdate();
                comboBox1.Items.Clear();
                foreach (DataRow row in storage.Rows)
                {
                    comboBox1.Items.Add(Convert.ToString(row["StorageName"]));
                }
                comboBox1.EndUpdate();

                if (preserveText)
                {
                    comboBox1.Text = currentText;
                    comboBox1.SelectionStart = currentText.Length;
                }
                else if (comboBox1.Items.Count > 0)
                {
                    comboBox1.SelectedIndex = 0;
                }

                if (comboBox1.Items.Count == 0)
                {
                    lblQuantity.Text = "No matching storage item";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Unable to Load Storage", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                return;
            }

            try
            {
                DataTable storage = chefService.LoadStorage(comboBox1.SelectedItem.ToString());
                lblQuantity.Text = storage.Rows.Count == 0
                    ? "Quantity not available"
                    : Convert.ToString(storage.Rows[0]["QuantityAvailable"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Unable to Read Storage", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRestock_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a storage item.", "Storage", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int newQuantity = chefService.RestockStorage(comboBox1.SelectedItem.ToString(), 50);
                lblQuantity.Text = newQuantity.ToString();
                MessageBox.Show("Restocked 50 units successfully.", "Storage Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Storage Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
