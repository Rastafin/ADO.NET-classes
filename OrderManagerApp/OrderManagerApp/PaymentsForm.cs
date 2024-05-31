using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess.Models.Enums;
using Logic.Services.Interfaces;
using Logic.Services;
using OrderManagerApp;

namespace GUI
{
    public partial class PaymentsForm : Form
    {
        private readonly IPaymentService _paymentService;
        private readonly IOrderService _orderService;
        private readonly ICustomerService _customerService;
        public PaymentsForm()
        {
            InitializeComponent();
            _paymentService = new PaymentService();
            _orderService = new OrderService();
            _customerService = new CustomerService();
        }

        private void PaymentsForm_Load(object sender, EventArgs e)
        {
            refreshForm();
        }

        private void refreshForm()
        {
            try
            {
                dataGridViewPayments.DataSource = _paymentService.GetAllPaymentsViewModel();

                dataGridViewPayments.Columns["PaymentId"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridViewPayments.Columns["Amount"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridViewPayments.Columns["PaymentDate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                dataGridViewPayments.Columns["CustomerName"].HeaderText = "Name";
                dataGridViewPayments.Columns["PaymentDate"].HeaderText = "Update Date";

                comboBoxOrdersId.Items.Clear();
                comboBoxSettlePaymentsId.Items.Clear();
                comboBoxWithdrawPaymentsId.Items.Clear();

                foreach (int id in _orderService.GetMissingOrderIdsInPayments())
                {
                    var customer = _customerService.GetCustomerByOrderId(id);
                    comboBoxOrdersId.Items.Add(new
                    {
                        Name = $"{id} - {customer.FirstName} {customer.LastName}"
                            ,
                        Id = id
                    });

                    comboBoxOrdersId.DisplayMember = "Name";
                    comboBoxOrdersId.ValueMember = "Id";
                }

                foreach (int id in _paymentService.GetPaymentIdsWithStatusWiting())
                {
                    var payment = _paymentService.GetPaymentById(id);
                    var customer = _customerService.GetCustomerByOrderId(payment.OrderId);
                    comboBoxSettlePaymentsId.Items.Add(new
                    {
                        Name = $"{id} - {customer.FirstName} {customer.LastName}"
                            ,
                        Id = id
                    });

                    comboBoxSettlePaymentsId.DisplayMember = "Name";
                    comboBoxSettlePaymentsId.ValueMember = "Id";
                }

                foreach(Payment payment in _paymentService.GetAllPayments())
                {
                    var customer = _customerService.GetCustomerByOrderId(payment.OrderId);
                    comboBoxWithdrawPaymentsId.Items.Add(new
                    {
                        Name = $"{payment.PaymentId} - {customer.FirstName} {customer.LastName}"
                            ,
                        Id = payment.PaymentId
                    });

                    comboBoxWithdrawPaymentsId.DisplayMember = "Name";
                    comboBoxWithdrawPaymentsId.ValueMember = "Id";
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
            Hide();
            mainForm.ShowDialog();
        }

        private void buttonGeneratePayment_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxOrdersId.SelectedItem == null)
                {
                    MessageBox.Show("Please select an OrderId.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                dynamic selectedItem = comboBoxOrdersId.SelectedItem;
                int selectedOrderId = selectedItem.Id;

                _paymentService.AddPayment(new Payment(
                    selectedOrderId,
                    DateTime.Now,
                    PaymentStatus.Waiting
                    ));

                refreshForm();

                MessageBox.Show("Payment added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSettlePayment_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxSettlePaymentsId.SelectedItem == null)
                {
                    MessageBox.Show("Please select a payment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                dynamic selectedItem = comboBoxSettlePaymentsId.SelectedItem;

                decimal settlementAmount = numericUpDownSettlePaymentAmount.Value;

                _paymentService.SettlePayment(selectedItem.Id, settlementAmount);

                refreshForm();

                MessageBox.Show("Payment settled successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxSettlePaymentsId_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxSettlePaymentsId.SelectedItem != null)
                {
                    dynamic selectedItem = comboBoxSettlePaymentsId.SelectedItem;

                    numericUpDownSettlePaymentAmount.Maximum = _paymentService.GetMaxSettlementAmount(selectedItem.Id);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewPayments_SelectionChanged(object sender, EventArgs e)
        {
            dataGridViewPayments.ClearSelection();
        }

        private void buttonWithdrawPayment_Click(object sender, EventArgs e)
        {
            try
            {
                if(comboBoxWithdrawPaymentsId.SelectedItem != null)
                {
                    dynamic selectedItem = comboBoxWithdrawPaymentsId.SelectedItem;

                    Payment payment = _paymentService.GetPaymentById(selectedItem.Id);

                    Order orderFromPaymentId = _orderService.GetOrderByPaymentId(selectedItem.Id);
                    if(orderFromPaymentId.Status == OrderStatus.Delivered)
                    {
                        MessageBox.Show("This payment cannot be withdrawn becouse the assigned order has already been delivered.", "Refusal", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }

                    payment.Amount = _paymentService.CalculateTotalAmountForOrder(orderFromPaymentId.OrderId);
                    payment.Status = PaymentStatus.Waiting;
                    payment.PaymentDate = DateTime.Now;

                    _paymentService.UpdatePayment(payment);

                    refreshForm();
                    
                    MessageBox.Show("Payment withdrawn successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please select a payment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
