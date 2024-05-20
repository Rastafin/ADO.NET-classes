using DataAccess.Models;
using Logic.Services;
using Logic.Services.Interfaces;
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
    public partial class OrderDetailsListForm : Form
    {
        private readonly int _orderId;
        private readonly IOrderDetailsService _orderDetailsService;
        private readonly IProductService _productService;
        public OrderDetailsListForm(int orderId)
        {
            InitializeComponent();
            _orderId = orderId;
            _orderDetailsService = new OrderDetailsService();
            _productService = new ProductService();
        }

        private void OrderDetailsListForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (_orderId < 1) throw new Exception("Incorrect order id.");

                foreach (OrderDetails item in _orderDetailsService.GetOrderDetailsForOrder(_orderId))
                {
                    listBoxOrderDetailsList.Items.Add($"{_productService.GetProduct(item.ProductId).Name} x {item.Quantity}" +
                        $" = {(decimal)item.Quantity * _productService.GetProduct(item.ProductId).Price}");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listBoxOrderDetailsList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
