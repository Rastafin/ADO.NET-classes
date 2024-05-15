using DataAccess.Models;
using Logic.Services;
using Logic.Services.Interfaces;
using OrderManagerApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class ProductsForm : Form
    {

        private readonly IProductService _productService;
        public ProductsForm()
        {
            InitializeComponent();
            _productService = new ProductService();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void refreshDGV()
        {
            try
            {
                dataGridViewProducts.DataSource = _productService.GetAllProducts();

                dataGridViewProducts.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridViewProducts.Columns["Price"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridViewProducts.Columns["StockQuantity"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            refreshDGV();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            Hide();
            mainForm.ShowDialog();
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "" || numericUpDown1Price.Value == 0.00m || numericUpDown2StockQuantity.Value == 0)
            {
                MessageBox.Show("Not every form field is filled.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

             try
             {
            _productService.AddProduct(new Product(
                textBoxName.Text,
                numericUpDown1Price.Value,
                Convert.ToInt16(numericUpDown2StockQuantity.Value)));

            refreshDGV();

            MessageBox.Show("Product added successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
              catch (Exception ex)
            {
                 MessageBox.Show(ex.Message);
            }
        }

        private void buttonEditProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewProducts.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridViewProducts.SelectedRows[0];

                    if (selectedRow.Cells["Id"].Value == null)
                    {
                        throw new Exception("Selected product data is incomplete.");
                    }

                    int productId = (int)selectedRow.Cells["Id"].Value;
                    string Name = textBoxEditName.Text;
                    decimal Price = numericUpDown3PriceEdit.Value;
                    int StockQuantity = (int)numericUpDown4StockQunatityEdit.Value;

                    if (string.IsNullOrEmpty(Name) || Price == 0.00m || StockQuantity == 0)
                    {
                        MessageBox.Show("Not every form field is filled.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (productId < 1)
                    {
                        throw new Exception("Invalid Product ID.");
                    }

                    _productService.UpdateProduct(new Product(
                        productId,
                        Name,
                        Price,
                        StockQuantity));

                    refreshDGV();

                    MessageBox.Show("Product updated successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewProducts_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewProducts.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewProducts.SelectedRows[0];

                if (selectedRow.Cells["Name"].Value != null &&
                    selectedRow.Cells["Price"].Value != null &&
                    selectedRow.Cells["StockQuantity"].Value != null)
                {
                    string Name = selectedRow.Cells["Name"].Value.ToString()!;
                    decimal Price = Convert.ToDecimal(selectedRow.Cells["Price"].Value.ToString()!);
                    int StockQuantity = Convert.ToInt16(selectedRow.Cells["StockQuantity"].Value.ToString()!);

                    textBoxEditName.Text = Name;
                    numericUpDown3PriceEdit.Value = Price;
                    numericUpDown4StockQunatityEdit.Value = StockQuantity;
                }
                else
                {
                    textBoxEditName.Text = String.Empty;
                    numericUpDown3PriceEdit.Value = 0.00m;
                    numericUpDown4StockQunatityEdit.Value = 0;
                }
            }
        }

        private void buttonDeleteProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewProducts.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridViewProducts.SelectedRows[0];

                    if (selectedRow.Cells["Id"].Value == null)
                    {
                        throw new Exception("Selected product data is incomplete.");
                    }

                    int productId = (int)selectedRow.Cells["Id"].Value;

                    if (productId < 1)
                    {
                        throw new Exception("Invalid product ID.");
                    }

                    _productService.DeleteProduct(productId);

                    refreshDGV();

                    MessageBox.Show("Product deleted successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridViewProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
