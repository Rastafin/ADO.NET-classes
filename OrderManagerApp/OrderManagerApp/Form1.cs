using DataAccess.Models;
using Logic.Services;
using Logic.Services.Interfaces;

namespace OrderManagerApp
{
    public partial class Form1 : Form
    {
        private readonly ICustomerService _customerService;
        public Form1()
        {
            InitializeComponent();
            _customerService = new CustomerService();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Customer> customers = _customerService.GetAllCustomers();

            customers.ForEach(customer => { MessageBox.Show(customer.FirstName); });
        }
    }
}
