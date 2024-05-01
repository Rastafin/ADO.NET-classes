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
            catch(Exception ex)
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
            if(textBoxFirstName.Text == "" || textBoxLastName.Text == "" || textBoxEmail.Text == "")
            {
                MessageBox.Show("Not every pool of form is filled.", "Warning", MessageBoxButtons.OK);
                return;
            }

            try
            {
                _customerService.AddCustomer(new Customer(
                textBoxFirstName.Text,
                textBoxLastName.Text,
                textBoxEmail.Text));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            refreshDGV();
        }
    }
}
