using Backend.Model;
using Backend.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class AdminPanelMainMenu : Form
    {
        private readonly User _user;
        public AdminPanelMainMenu(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void AdminPanelMainMenu_Load(object sender, EventArgs e)
        {
            buttonUsers.Enabled = false;
            buttonUsers.BackColor = Color.SlateGray;

            dataGridViewUsers.AutoGenerateColumns = false;

            dataGridViewUsers.Columns.Add("Name", "Name");
            dataGridViewUsers.Columns.Add("Lastname", "Last name");
            dataGridViewUsers.Columns.Add("Birthday", "Birthday");
            dataGridViewUsers.Columns.Add("Sex", "Sex");
            dataGridViewUsers.Columns.Add("PhoneNumber", "Phone number");
            dataGridViewUsers.Columns.Add("Login", "Login");
            dataGridViewUsers.Columns.Add("Email", "Email");
            dataGridViewUsers.Columns.Add("Role", "Role");
            dataGridViewUsers.Columns.Add("Status", "Status");


            dataGridViewUsers.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewUsers.Columns["Lastname"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewUsers.Columns["Email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;

            loadUsersToDGV();
        }

        private void loadUsersToDGV(string filter = "")
        {
            dataGridViewUsers.Show();
            labelMessage.Text = String.Empty;

            try
            {
                List<Person> clients = Person.GetClients();

                if (clients == null || clients.Count == 0)
                {
                    dataGridViewUsers.Hide();
                    labelMessage.Text = "There are not any users";
                    return;
                }

                dataGridViewUsers.Rows.Clear();

                foreach (Person client in clients)
                {
                    if (string.IsNullOrEmpty(filter)
                        || (client.Name != null && client.Name.Contains(filter, StringComparison.OrdinalIgnoreCase))
                        || (client.LastName != null && client.LastName.Contains(filter, StringComparison.OrdinalIgnoreCase))
                        || (client.User.Login != null && client.User.Login.Contains(filter, StringComparison.OrdinalIgnoreCase))
                        || (client.User.Email != null && client.User.Email.Contains(filter, StringComparison.OrdinalIgnoreCase)))
                    {
                        var row = dataGridViewUsers.Rows[dataGridViewUsers.Rows.Add()];

                        row.Cells["Name"].Value = client.Name;
                        row.Cells["LastName"].Value = client.LastName;
                        row.Cells["Birthday"].Value = client.Birthday;
                        row.Cells["Sex"].Value = client.Sex;
                        row.Cells["PhoneNumber"].Value = client.PhoneNumber;
                        row.Cells["Login"].Value = client.User.Login;
                        row.Cells["Email"].Value = client.User.Email;
                        row.Cells["Role"].Value = client.User.Role;
                        row.Cells["Status"].Value = client.User.Status;
                    }
                }

                if (dataGridViewUsers.Rows.Count > 0)
                {
                    DataGridViewRow firstRow = dataGridViewUsers.Rows[0];
                    changeComboBoxRoleValue(firstRow);
                }

                if (dataGridViewUsers.Rows.Count < 1)
                {
                    labelMessage.Text = "Cannot find any user";
                    dataGridViewUsers.Hide();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error occurred while trying to load users. " + ex.Message);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            UserMainMenu? userMainMenu = Application.OpenForms.OfType<UserMainMenu>()
                .Where(r => r.GetLoggedInUser().Id == _user.Id)
                .FirstOrDefault();

            if (userMainMenu != null) { userMainMenu.Show(); }

            this.Close();
        }

        private void dataGridViewUsers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex % 2 == 1)
            {
                dataGridViewUsers.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(20, 20, 20);
            }
        }

        private void textBoxFilter_TextChanged(object sender, EventArgs e)
        {
            string filter = textBoxFilter.Text.Trim();
            loadUsersToDGV(filter);
        }

        private void buttonChangeStatus_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewUsers.SelectedRows.Count > 0
                    && dataGridViewUsers.SelectedRows[0].Cells["Login"].Value != null)
                {
                    User user = User.GetUserByLogin(dataGridViewUsers.SelectedRows[0].Cells["Login"].Value.ToString());

                    if (dataGridViewUsers.SelectedRows[0].Cells["Login"].Value.ToString() == _user.Login)
                    {
                        labelMessage.Text = "You cannot modify your own status";
                        return;
                    }

                    ConfirmationForm confirmationForm = new ConfirmationForm();
                    confirmationForm.ShowDialog();

                    if (confirmationForm.WasYesClicked)
                    {
                        User.ChangeUserStatus(user);
                        loadUsersToDGV();
                        textBoxFilter.Text = string.Empty;
                        labelMessage.Text = string.Empty;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while trying to change user status. " + ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewUsers_SelectionChanged(object sender, EventArgs e)
        {
        }

        private void dataGridViewUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    DataGridViewRow clickedRow = dataGridViewUsers.Rows[e.RowIndex];

                    changeComboBoxRoleValue(clickedRow);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while trying to set role in comboBox. " + ex.Message);
            }
        }

        private void changeComboBoxRoleValue(DataGridViewRow clickedRow)
        {
            if (clickedRow.Cells["Role"].Value != null && !clickedRow.Cells["Role"].Value.Equals(DBNull.Value))
            {
                string role = clickedRow.Cells["Role"].Value.ToString();

                if (comboBoxRole.Items.Contains(role))
                {
                    comboBoxRole.SelectedItem = role;
                }
                else
                {
                    throw new Exception("Role not found in ComboBox.");
                }
            }
            else
            {
                throw new Exception("Invalid role cell or value is null.");
            }
        }

        private void dataGridViewUsers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        }

        private void buttonChangeRole_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewUsers.SelectedRows.Count > 0)
                {
                    var selectedRow = dataGridViewUsers.SelectedRows[0];

                    if (selectedRow.Cells["Role"].Value != null && !selectedRow.Cells["Role"].Value.Equals(DBNull.Value))
                    {
                        string? selectedRoleInGrid = selectedRow.Cells["Role"].Value.ToString();
                        string? selectedRoleInComboBox = comboBoxRole.SelectedItem.ToString();

                        if (selectedRow.Cells["Login"].Value.ToString() == _user.Login)
                        {
                            labelMessage.Text = "You cannot modify your own role";
                            return;
                        }

                        if (selectedRoleInComboBox != null && !selectedRoleInGrid!.Equals(selectedRoleInComboBox))
                        {
                            if (Enum.TryParse(selectedRoleInComboBox, out Role parsedRole))
                            {
                                if (selectedRow.Cells["Login"].Value == null || selectedRow.Cells["Login"].Value.Equals(DBNull.Value))
                                    throw new Exception("Invalid login cell or value is null.");

                                ConfirmationForm confirmationForm = new ConfirmationForm();
                                confirmationForm.ShowDialog();

                                if (confirmationForm.WasYesClicked)
                                {
                                    User.ChangeUserRole(User.GetUserByLogin(selectedRow.Cells["Login"].Value.ToString()), parsedRole);
                                    loadUsersToDGV();
                                    textBoxFilter.Text = string.Empty;
                                    labelMessage.Text = string.Empty;
                                }
                            }
                            else
                            {
                                throw new Exception("Failed parsing comboBoxRole value. ");
                            }
                        }
                        else
                        {
                            labelMessage.Text = "You must change the value firstly";
                        }
                    }
                    else
                    {
                        throw new Exception("Invalid role cell or value is null. ");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while trying to change user role. " + ex.Message);
            }
        }

        private void buttonStatistics_Click(object sender, EventArgs e)
        {
            AdminPanelStatistics adminPanelStatistics = new AdminPanelStatistics(_user);
            adminPanelStatistics.Show();
            Hide();
        }
    }
}
