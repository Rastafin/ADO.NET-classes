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

        private void buttonProducts_Click(object sender, EventArgs e)
        {
            ProductsForm productsForm = new ProductsForm();
            Hide();
            productsForm.ShowDialog();
        }

        private void buttonOrders_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm();
            Hide();
            orderForm.ShowDialog();
        }
    }
}
