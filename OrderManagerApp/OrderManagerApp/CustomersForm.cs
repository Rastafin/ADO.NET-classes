using DataAccess.Models;
using Logic.Services;
using Logic.Services.Interfaces;
using OrderManagerApp;
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
    public partial class CustomersForm : Form
    {
        private readonly ICustomerService _customerService;
        public CustomersForm()
        {
            InitializeComponent();
            _customerService = new CustomerService();
        }

        private void refreshDGV()
        {
            try
            {
                dataGridViewCustomers.DataSource = _customerService.GetAllCustomers();

                dataGridViewCustomers.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridViewCustomers.Columns["FirstName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridViewCustomers.Columns["LastName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CustomersForm_Load(object sender, EventArgs e)
        {
            refreshDGV();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            Hide();
            mainForm.ShowDialog();
        }

        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {
            if (textBoxFirstName.Text == "" || textBoxLastName.Text == "" || textBoxEmail.Text == "")
            {
                MessageBox.Show("Not every form field is filled.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                _customerService.AddCustomer(new Customer(
                    textBoxFirstName.Text,
                    textBoxLastName.Text,
                    textBoxEmail.Text));

                refreshDGV();

                MessageBox.Show("Customer added successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewCustomers_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewCustomers.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewCustomers.SelectedRows[0];

                if (selectedRow.Cells["FirstName"].Value != null &&
                    selectedRow.Cells["LastName"].Value != null &&
                    selectedRow.Cells["Email"].Value != null)
                {
                    string firstName = selectedRow.Cells["FirstName"].Value.ToString()!;
                    string lastName = selectedRow.Cells["LastName"].Value.ToString()!;
                    string email = selectedRow.Cells["Email"].Value.ToString()!;

                    textBoxEditFirstName.Text = firstName;
                    textBoxEditLastName.Text = lastName;
                    textBoxEditEmail.Text = email;
                }
                else
                {
                    textBoxEditFirstName.Text = string.Empty;
                    textBoxEditLastName.Text = string.Empty;
                    textBoxEditEmail.Text = string.Empty;
                }
            }
        }

        private void buttonEditCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewCustomers.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridViewCustomers.SelectedRows[0];

                    if (selectedRow.Cells["Id"].Value == null)
                    {
                        throw new Exception("Selected user data is incomplete.");
                    }

                    int customerId = (int)selectedRow.Cells["Id"].Value;
                    string firstName = textBoxEditFirstName.Text;
                    string lastName = textBoxEditLastName.Text;
                    string email = textBoxEditEmail.Text;

                    if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(email))
                    {
                        MessageBox.Show("Not every form field is filled.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (customerId < 1)
                    {
                        throw new Exception("Invalid customer ID.");
                    }

                    _customerService.UpdateCustomer(new Customer(
                        customerId,
                        firstName,
                        lastName,
                        email));

                    refreshDGV();

                    MessageBox.Show("Customer updated successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDeleteCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewCustomers.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridViewCustomers.SelectedRows[0];

                    if (selectedRow.Cells["Id"].Value == null)
                    {
                        throw new Exception("Selected user data is incomplete.");
                    }

                    int customerId = (int)selectedRow.Cells["Id"].Value;

                    if (customerId < 1)
                    {
                        throw new Exception("Invalid customer ID.");
                    }

                    _customerService.DeleteCustomer(customerId);

                    refreshDGV();

                    MessageBox.Show("Customer deleted successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
