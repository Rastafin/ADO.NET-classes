using DataAccess.Models;
using DataAccess.Models.Enums;
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
    public partial class OrderForm : Form
    {
        private readonly IOrderService _orderService;
        private readonly IProductService _productService;
        private readonly IOrderDetailsService _orderDetailsService;
        private readonly ICustomerService _customerService;
        public OrderForm()
        {
            InitializeComponent();
            _orderService = new OrderService();
            _productService = new ProductService();
            _orderDetailsService = new OrderDetailsService();
            _customerService = new CustomerService();
        }

        private void refreshForm()
        {
            try
            {
                dataGridViewOrders.DataSource = _orderService.GetAllOrderViewModels();

                dataGridViewOrders.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                dataGridViewOrders.Columns["CustomerName"].HeaderText = "Name";
                dataGridViewOrders.Columns["OrderDate"].HeaderText = "Update Date";

                comboBoxProducts.Items.Clear();
                comboBoxCustomer.Items.Clear();
                comboBoxOrdersToApprove.Items.Clear();
                comboBoxOrdersToDeliver.Items.Clear();

                numericUpDownQuantity.Value = 0;

                foreach (Product product in _productService.GetAllAvailableProducts())
                {
                    comboBoxProducts.Items.Add(new { Name = product.Name, Id = product.Id });
                }

                comboBoxProducts.DisplayMember = "Name";
                comboBoxProducts.ValueMember = "Id";

                foreach (Customer customer in _customerService.GetAllCustomers())
                {
                    comboBoxCustomer.Items.Add(new { Name = customer.FirstName + " " + customer.LastName, Id = customer.Id });
                }

                comboBoxCustomer.DisplayMember = "Name";
                comboBoxCustomer.ValueMember = "Id";

                foreach(Order order in _orderService.GetAllOrders())
                {
                    if(order.Status == OrderStatus.Processed)
                    {
                        comboBoxOrdersToApprove.Items.Add(order.Id);
                    }
                }

                foreach(int orderId in _orderService.GetOrdersToDeliverIds())
                {
                    comboBoxOrdersToDeliver.Items.Add(orderId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            this.Hide();
            mainForm.ShowDialog();
        }

        private void buttonAddOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxProducts.SelectedItem == null)
                {
                    MessageBox.Show("Please select a product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (numericUpDownQuantity.Value < 1)
                {
                    MessageBox.Show("Please select a quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                dynamic selectedItem = comboBoxProducts.SelectedItem;
                int selectedProductId = selectedItem.Id;

                if (!checkBoxNewOrder.Checked)
                {
                    if (dataGridViewOrders.SelectedRows.Count != 1)
                    {
                        MessageBox.Show("Please select an order row in DataGridView.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    DataGridViewRow selectedRow = dataGridViewOrders.SelectedRows[0];

                    if (selectedRow.Cells["Id"].Value == null) throw new Exception("Selected order data is incomplete.");

                    int orderId = (int)selectedRow.Cells["Id"].Value;

                    Order selectedOrder = _orderService.GetOrderById(orderId);
                    if(selectedOrder.Status != OrderStatus.Processed)
                    {
                        MessageBox.Show("The order cannot be edited because it has already been approved.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    _orderDetailsService.AddOrderDetails
                        (new OrderDetails(
                            orderId,
                            selectedProductId,
                            (int)numericUpDownQuantity.Value
                        ));

                    MessageBox.Show("Order updated successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (checkBoxNewOrder.Checked)
                {
                    if (comboBoxCustomer.SelectedItem == null)
                    {
                        MessageBox.Show("Please select a customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    dynamic customer = comboBoxCustomer.SelectedItem;
                    int customerId = customer.Id;

                    int orderId = _orderService.AddOrder(new Order(
                        customerId,
                        DateTime.Now,
                        OrderStatus.Processed));

                    _orderDetailsService.AddOrderDetails(new OrderDetails(
                        orderId, selectedProductId, (int)numericUpDownQuantity.Value));

                    MessageBox.Show("Order created successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                refreshForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDeleteOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewOrders.SelectedRows.Count != 1)
                {
                    MessageBox.Show("Please select an order row in DataGridView.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DataGridViewRow selectedRow = dataGridViewOrders.SelectedRows[0];

                if (selectedRow.Cells["Id"].Value == null) throw new Exception("Selected order data is incomplete.");

                int orderId = (int)selectedRow.Cells["Id"].Value;

                if(_orderService.GetOrderById(orderId).Status != OrderStatus.Processed)
                {
                    MessageBox.Show("The order cannot be deleted because it has already been approved.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                foreach(OrderDetails orderDetail in _orderDetailsService.GetOrderDetailsForOrder(orderId))
                {
                    _orderDetailsService.DeleteOrderDetails(orderDetail.Id);
                }

                _orderService.DeleteOrder(orderId);

                refreshForm();

                MessageBox.Show("Order deleted successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void buttonConfirmOrderSent_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxOrdersToApprove.SelectedItem == null)
                {
                    MessageBox.Show("Please select an order to approve.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _orderService.ChangeStatus(int.Parse(comboBoxOrdersToApprove.SelectedItem.ToString()!), OrderStatus.Approved);

                refreshForm();

                MessageBox.Show("Order approved successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonConfirmOrderDelivered_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxOrdersToDeliver.SelectedItem == null)
                {
                    MessageBox.Show("Please select an order to deliver.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _orderService.ChangeStatus(int.Parse(comboBoxOrdersToDeliver.SelectedItem.ToString()!), OrderStatus.Delivered);

                refreshForm();

                MessageBox.Show("Order delivered successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxOrderSent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxOrderDelivered_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            refreshForm();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void comboBoxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxProducts.SelectedItem != null)
                {
                    var selectedItem = (dynamic)comboBoxProducts.SelectedItem;
                    int selectedProductId = selectedItem.Id;

                    numericUpDownQuantity.Maximum = _productService.GetProduct(selectedProductId).StockQuantity;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkBoxNewOrder_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxCustomer.Enabled = !comboBoxCustomer.Enabled;
        }

        private void dataGridViewOrders_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridViewOrders.CurrentRow != null)
            {
                int orderId = Convert.ToInt32(dataGridViewOrders.CurrentRow.Cells["Id"].Value);
                OrderDetailsListForm orderDetailsListForm = new OrderDetailsListForm(orderId);
                orderDetailsListForm.Show();
            }
                
        }
    }
}
