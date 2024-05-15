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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            buttonBack = new Button();
            groupBox1 = new GroupBox();
            groupBox4 = new GroupBox();
            buttonDeleteProduct = new Button();
            groupBox3 = new GroupBox();
            numericUpDown4StockQunatityEdit = new NumericUpDown();
            numericUpDown3PriceEdit = new NumericUpDown();
            textBoxEditName = new TextBox();
            buttonEditProduct = new Button();
            groupBox2 = new GroupBox();
            numericUpDown2StockQuantity = new NumericUpDown();
            numericUpDown1Price = new NumericUpDown();
            textBoxName = new TextBox();
            buttonAddProduct = new Button();
            dataGridViewProducts = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4StockQunatityEdit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3PriceEdit).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2StockQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1Price).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
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
            buttonBack.Click += buttonBack_Click;
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
            groupBox1.Enter += groupBox1_Enter;
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
            groupBox4.Enter += groupBox4_Enter;
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
            buttonDeleteProduct.Click += buttonDeleteProduct_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(numericUpDown4StockQunatityEdit);
            groupBox3.Controls.Add(numericUpDown3PriceEdit);
            groupBox3.Controls.Add(textBoxEditName);
            groupBox3.Controls.Add(buttonEditProduct);
            groupBox3.Location = new Point(6, 146);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(432, 118);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "EDIT PRODUCT";
            // 
            // numericUpDown4StockQunatityEdit
            // 
            numericUpDown4StockQunatityEdit.Location = new Point(32, 80);
            numericUpDown4StockQunatityEdit.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDown4StockQunatityEdit.Name = "numericUpDown4StockQunatityEdit";
            numericUpDown4StockQunatityEdit.Size = new Size(223, 23);
            numericUpDown4StockQunatityEdit.TabIndex = 8;
            // 
            // numericUpDown3PriceEdit
            // 
            numericUpDown3PriceEdit.DecimalPlaces = 2;
            numericUpDown3PriceEdit.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDown3PriceEdit.Location = new Point(32, 51);
            numericUpDown3PriceEdit.Maximum = new decimal(new int[] { 3000, 0, 0, 0 });
            numericUpDown3PriceEdit.Name = "numericUpDown3PriceEdit";
            numericUpDown3PriceEdit.Size = new Size(223, 23);
            numericUpDown3PriceEdit.TabIndex = 7;
            // 
            // textBoxEditName
            // 
            textBoxEditName.Location = new Point(32, 22);
            textBoxEditName.Name = "textBoxEditName";
            textBoxEditName.PlaceholderText = "Name";
            textBoxEditName.Size = new Size(223, 23);
            textBoxEditName.TabIndex = 6;
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
            buttonEditProduct.Click += buttonEditProduct_Click;
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
            // numericUpDown2StockQuantity
            // 
            numericUpDown2StockQuantity.Location = new Point(32, 80);
            numericUpDown2StockQuantity.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDown2StockQuantity.Name = "numericUpDown2StockQuantity";
            numericUpDown2StockQuantity.Size = new Size(223, 23);
            numericUpDown2StockQuantity.TabIndex = 5;
            // 
            // numericUpDown1Price
            // 
            numericUpDown1Price.DecimalPlaces = 2;
            numericUpDown1Price.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDown1Price.Location = new Point(32, 51);
            numericUpDown1Price.Maximum = new decimal(new int[] { 3000, 0, 0, 0 });
            numericUpDown1Price.Name = "numericUpDown1Price";
            numericUpDown1Price.Size = new Size(223, 23);
            numericUpDown1Price.TabIndex = 4;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(32, 22);
            textBoxName.Name = "textBoxName";
            textBoxName.PlaceholderText = "Name";
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
            buttonAddProduct.Click += buttonAddProduct_Click;
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.AllowUserToAddRows = false;
            dataGridViewProducts.AllowUserToDeleteRows = false;
            dataGridViewProducts.AllowUserToResizeColumns = false;
            dataGridViewProducts.AllowUserToResizeRows = false;
            dataGridViewProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewProducts.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewProducts.Location = new Point(12, 12);
            dataGridViewProducts.MultiSelect = false;
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.ReadOnly = true;
            dataGridViewProducts.RowHeadersVisible = false;
            dataGridViewProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProducts.Size = new Size(444, 174);
            dataGridViewProducts.TabIndex = 7;
            dataGridViewProducts.CellContentClick += dataGridViewProducts_CellContentClick;
            dataGridViewProducts.SelectionChanged += dataGridViewProducts_SelectionChanged;
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
            Load += ProductsForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4StockQunatityEdit).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3PriceEdit).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2StockQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1Price).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonBack;
        private GroupBox groupBox1;
        private GroupBox groupBox4;
        private Button buttonDeleteProduct;
        private GroupBox groupBox3;
        private TextBox textBoxEditName;
        private Button buttonEditProduct;
        private GroupBox groupBox2;
        private TextBox textBoxName;
        private Button buttonAddProduct;
        private DataGridView dataGridViewProducts;
        private NumericUpDown numericUpDown4StockQunatityEdit;
        private NumericUpDown numericUpDown3PriceEdit;
        private NumericUpDown numericUpDown2StockQuantity;
        private NumericUpDown numericUpDown1Price;
    }
}