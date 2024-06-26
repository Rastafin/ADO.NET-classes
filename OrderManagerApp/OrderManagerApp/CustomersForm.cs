﻿using DataAccess.Models;
using Logic.Services;
using Logic.Services.Interfaces;
using OrderManagerApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        private readonly IValidationService _validationService;
        public CustomersForm()
        {
            InitializeComponent();
            _customerService = new CustomerService();
            _validationService = new ValidationService();
        }

        private void refreshDGV()
        {
            try
            {
                dataGridViewCustomers.DataSource = _customerService.GetAllCustomers();

                dataGridViewCustomers.Columns["CustomerId"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
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

        private void buttonBack_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            Hide();
            mainForm.ShowDialog();
        }

        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {
            if(!_validationService.ValidateCustomerAddOrEditProcess(textBoxFirstName.Text, textBoxLastName.Text, textBoxEmail.Text, out string message))
            {
                MessageBox.Show(message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                    if (selectedRow.Cells["CustomerId"].Value == null)
                    {
                        throw new Exception("Selected user data is incomplete.");
                    }

                    int customerId = (int)selectedRow.Cells["CustomerId"].Value;
                    string? existingEmail = selectedRow.Cells["Email"].Value.ToString();

                    string firstName = textBoxEditFirstName.Text;
                    string lastName = textBoxEditLastName.Text;
                    string newEmail = textBoxEditEmail.Text;

                    if (customerId < 1)
                    {
                        throw new Exception("Invalid customer ID.");
                    }

                    if(!_validationService.ValidateCustomerAddOrEditProcess(firstName, lastName, newEmail, out string message, existingEmail!))
                    {
                        MessageBox.Show(message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    _customerService.UpdateCustomer(new Customer(
                        customerId,
                        firstName,
                        lastName,
                        newEmail));

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

                    if (selectedRow.Cells["CustomerId"].Value == null)
                    {
                        throw new Exception("Selected user data is incomplete.");
                    }

                    int customerId = (int)selectedRow.Cells["CustomerId"].Value;

                    if (customerId < 1)
                    {
                        throw new Exception("Invalid customer ID.");
                    }

                    _customerService.DeleteCustomer(customerId);

                    refreshDGV();

                    MessageBox.Show("Customer deleted successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (SqlException)
            {
                MessageBox.Show($"This Customer cannot be deleted. Please check if the customer has an active order.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
