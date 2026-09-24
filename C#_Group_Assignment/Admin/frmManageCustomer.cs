using C__Group_Assignment.Admin;
using System;
using System.Windows.Forms;

namespace C__Group_Assignment
{
    public partial class frmManageCustomer : Form
    {
        private const string ManagedRole = "Customer";
        private readonly AdminUserService userService = new AdminUserService();
        private string selectedUserID;

        public frmManageCustomer()
        {
            InitializeComponent();
            ConfigureForm();
        }

        private void ConfigureForm()
        {
            RoleCmbBox.DropDownStyle = ComboBoxStyle.DropDownList;
            RoleCmbBox.SelectedItem = ManagedRole;
            PasswordTextbox.UseSystemPasswordChar = true;
            dataGridView1.ReadOnly = true;
            dataGridView1.MultiSelect = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        private void frmManageCustomer_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void InsrtBttn_Click(object sender, EventArgs e)
        {
            AdminUserData user = ReadAndValidate();
            if (user != null)
            {
                ExecuteChange(() => userService.InsertUser(user), "Customer account created successfully.");
            }
        }

        private void UpdateBttn_Click(object sender, EventArgs e)
        {
            AdminUserData user = ReadAndValidate();
            if (user != null)
            {
                string originalUserID = selectedUserID ?? user.UserID;
                ExecuteChange(() => userService.UpdateUser(originalUserID, user), "Customer account updated successfully.");
            }
        }

        private void DltBttn_Click(object sender, EventArgs e)
        {
            string userID = UserIDTextbox.Text.Trim().ToUpperInvariant();
            if (!System.Text.RegularExpressions.Regex.IsMatch(userID, @"^C\d+$", System.Text.RegularExpressions.RegexOptions.IgnoreCase))
            {
                MessageBox.Show("The user ID must use the format C001.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"Delete customer {userID}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            ExecuteChange(
                () =>
                {
                    if (!userService.DeleteUser(userID, ManagedRole))
                    {
                        throw new InvalidOperationException("Customer account not found.");
                    }
                },
                "Customer account deleted successfully.");
        }

        private AdminUserData ReadAndValidate()
        {
            AdminUserData user = new AdminUserData
            {
                UserID = UserIDTextbox.Text,
                Username = UsernameTextbox.Text,
                Email = EmailTextbox.Text,
                Password = PasswordTextbox.Text,
                Role = RoleCmbBox.Text,
                SecurityAnswer = SecurityAnsTextbox.Text
            };
            string error = AdminUserInput.Validate(user, ManagedRole, @"^C\d+$", "C001");
            if (error != null)
            {
                MessageBox.Show(error, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
            return AdminUserInput.Normalize(user, ManagedRole);
        }

        private void ExecuteChange(Action action, string successMessage)
        {
            try
            {
                action();
                MessageBox.Show(successMessage, "Admin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshGrid();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Admin Operation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshGrid()
        {
            try
            {
                dataGridView1.DataSource = userService.LoadUsers(ManagedRole);
                dataGridView1.Columns["Password"].Visible = false;
                dataGridView1.Columns["SecurityAnswer"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Unable to Load Customers", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            selectedUserID = Convert.ToString(row.Cells["UserID"].Value);
            UserIDTextbox.Text = selectedUserID;
            UsernameTextbox.Text = Convert.ToString(row.Cells["Username"].Value);
            EmailTextbox.Text = Convert.ToString(row.Cells["Email"].Value);
            PasswordTextbox.Text = Convert.ToString(row.Cells["Password"].Value);
            RoleCmbBox.SelectedItem = ManagedRole;
            SecurityAnsTextbox.Text = Convert.ToString(row.Cells["SecurityAnswer"].Value);
        }

        private void ClearInputs()
        {
            selectedUserID = null;
            UserIDTextbox.Clear();
            UsernameTextbox.Clear();
            EmailTextbox.Clear();
            PasswordTextbox.Clear();
            SecurityAnsTextbox.Clear();
            RoleCmbBox.SelectedItem = ManagedRole;
        }
    }
}
