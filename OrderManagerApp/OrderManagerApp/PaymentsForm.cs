﻿using DataAccess.Models;
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
        public PaymentsForm()
        {
            InitializeComponent();
            _paymentService = new PaymentService();
            _orderService = new OrderService();
        }

        private void PaymentsForm_Load(object sender, EventArgs e)
        {
            refreshForm();
        }

        private void refreshForm()
        {
            try
            {
                dataGridViewPayments.DataSource = _paymentService.GetAllPayments();

                dataGridViewPayments.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridViewPayments.Columns["Amount"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridViewPayments.Columns["PaymentDate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                comboBoxOrdersId.Items.Clear();

                foreach (int id in _orderService.GetMissingOrderIdsInPayments())
                {
                    comboBoxOrdersId.Items.Add(id.ToString());
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

                _paymentService.AddPayment(new Payment(
                    int.Parse(comboBoxOrdersId.SelectedItem.ToString()!),
                    DateTime.Today,
                    PaymentStatus.Waiting
                    ));

                MessageBox.Show("Payment added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                refreshForm();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
