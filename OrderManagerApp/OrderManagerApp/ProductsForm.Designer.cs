namespace GUI
{
    partial class ProductsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            buttonBack = new Button();
            groupBox1 = new GroupBox();
            groupBox4 = new GroupBox();
            buttonDeleteProduct = new Button();
            groupBox3 = new GroupBox();
            textBoxEditFirstName = new TextBox();
            buttonEditProduct = new Button();
            groupBox2 = new GroupBox();
            textBoxName = new TextBox();
            buttonAddProduct = new Button();
            dataGridViewProducts = new DataGridView();
            numericUpDown1Price = new NumericUpDown();
            numericUpDown2StockQuantity = new NumericUpDown();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1Price).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2StockQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // buttonBack
            // 
            buttonBack.BackColor = Color.LightCoral;
            buttonBack.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            buttonBack.Location = new Point(50, 609);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(62, 33);
            buttonBack.TabIndex = 9;
            buttonBack.Text = "BACK";
            buttonBack.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Location = new Point(12, 210);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(444, 389);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(buttonDeleteProduct);
            groupBox4.Location = new Point(6, 282);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(432, 91);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "DELETE PRODUCT";
            // 
            // buttonDeleteProduct
            // 
            buttonDeleteProduct.BackColor = SystemColors.ActiveCaption;
            buttonDeleteProduct.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            buttonDeleteProduct.Location = new Point(162, 34);
            buttonDeleteProduct.Name = "buttonDeleteProduct";
            buttonDeleteProduct.Size = new Size(115, 31);
            buttonDeleteProduct.TabIndex = 2;
            buttonDeleteProduct.Text = "DELETE";
            buttonDeleteProduct.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(numericUpDown1);
            groupBox3.Controls.Add(numericUpDown2);
            groupBox3.Controls.Add(textBoxEditFirstName);
            groupBox3.Controls.Add(buttonEditProduct);
            groupBox3.Location = new Point(6, 146);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(432, 118);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "EDIT PRODUCT";
            // 
            // textBoxEditFirstName
            // 
            textBoxEditFirstName.Location = new Point(32, 22);
            textBoxEditFirstName.Name = "textBoxEditFirstName";
            textBoxEditFirstName.PlaceholderText = "Firstname";
            textBoxEditFirstName.Size = new Size(223, 23);
            textBoxEditFirstName.TabIndex = 6;
            // 
            // buttonEditProduct
            // 
            buttonEditProduct.BackColor = SystemColors.ActiveCaption;
            buttonEditProduct.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            buttonEditProduct.Location = new Point(311, 43);
            buttonEditProduct.Name = "buttonEditProduct";
            buttonEditProduct.Size = new Size(115, 31);
            buttonEditProduct.TabIndex = 2;
            buttonEditProduct.Text = "EDIT";
            buttonEditProduct.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(numericUpDown2StockQuantity);
            groupBox2.Controls.Add(numericUpDown1Price);
            groupBox2.Controls.Add(textBoxName);
            groupBox2.Controls.Add(buttonAddProduct);
            groupBox2.Location = new Point(6, 22);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(432, 118);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "ADD PRODUCT";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(32, 22);
            textBoxName.Name = "textBoxName";
            textBoxName.PlaceholderText = "Firstname";
            textBoxName.Size = new Size(223, 23);
            textBoxName.TabIndex = 3;
            // 
            // buttonAddProduct
            // 
            buttonAddProduct.BackColor = SystemColors.ActiveCaption;
            buttonAddProduct.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            buttonAddProduct.Location = new Point(311, 43);
            buttonAddProduct.Name = "buttonAddProduct";
            buttonAddProduct.Size = new Size(115, 31);
            buttonAddProduct.TabIndex = 2;
            buttonAddProduct.Text = "ADD";
            buttonAddProduct.UseVisualStyleBackColor = false;
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.AllowUserToAddRows = false;
            dataGridViewProducts.AllowUserToDeleteRows = false;
            dataGridViewProducts.AllowUserToResizeColumns = false;
            dataGridViewProducts.AllowUserToResizeRows = false;
            dataGridViewProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridViewProducts.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewProducts.Location = new Point(12, 12);
            dataGridViewProducts.MultiSelect = false;
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.ReadOnly = true;
            dataGridViewProducts.RowHeadersVisible = false;
            dataGridViewProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProducts.Size = new Size(444, 174);
            dataGridViewProducts.TabIndex = 7;
            // 
            // numericUpDown1Price
            // 
            numericUpDown1Price.DecimalPlaces = 2;
            numericUpDown1Price.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            numericUpDown1Price.Location = new Point(32, 51);
            numericUpDown1Price.Name = "numericUpDown1Price";
            numericUpDown1Price.Size = new Size(223, 23);
            numericUpDown1Price.TabIndex = 4;
            // 
            // numericUpDown2StockQuantity
            // 
            numericUpDown2StockQuantity.Location = new Point(32, 80);
            numericUpDown2StockQuantity.Name = "numericUpDown2StockQuantity";
            numericUpDown2StockQuantity.Size = new Size(223, 23);
            numericUpDown2StockQuantity.TabIndex = 5;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(32, 80);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(223, 23);
            numericUpDown1.TabIndex = 8;
            // 
            // numericUpDown2
            // 
            numericUpDown2.DecimalPlaces = 2;
            numericUpDown2.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            numericUpDown2.Location = new Point(32, 51);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(223, 23);
            numericUpDown2.TabIndex = 7;
            // 
            // ProductsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 654);
            Controls.Add(buttonBack);
            Controls.Add(groupBox1);
            Controls.Add(dataGridViewProducts);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProductsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProductsForm";
            groupBox1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1Price).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2StockQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonBack;
        private GroupBox groupBox1;
        private GroupBox groupBox4;
        private Button buttonDeleteProduct;
        private GroupBox groupBox3;
        private TextBox textBoxEditFirstName;
        private Button buttonEditProduct;
        private GroupBox groupBox2;
        private TextBox textBoxName;
        private Button buttonAddProduct;
        private DataGridView dataGridViewProducts;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown2StockQuantity;
        private NumericUpDown numericUpDown1Price;
    }
}