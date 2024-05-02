using DataAccess.Models;
using GUI;
using Logic.Services;
using Logic.Services.Interfaces;

namespace OrderManagerApp
{
    public partial class MainForm : Form
    {
        private readonly ICustomerService _customerService;
        public MainForm()
        {
            InitializeComponent();
            _customerService = new CustomerService();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonCustomers_Click(object sender, EventArgs e)
        {
            CustomersForm customersForm = new();
            Hide();
            customersForm.ShowDialog();
        }

        private void buttonPayments_Click(object sender, EventArgs e)
        {
            PaymentsForm paymentsForm = new PaymentsForm();
            Hide();
            paymentsForm.ShowDialog();
        }
    }
}
