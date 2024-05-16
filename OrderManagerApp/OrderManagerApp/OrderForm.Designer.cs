namespace GUI
{
    partial class OrderForm
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
            groupBox4 = new GroupBox();
            groupBox5 = new GroupBox();
            buttonDeleteOrder = new Button();
            groupBox3 = new GroupBox();
            label4 = new Label();
            comboBoxOrderDelivered = new ComboBox();
            buttonConfirmOrderDelivered = new Button();
            groupBox1 = new GroupBox();
            label2 = new Label();
            comboBoxOrderSent = new ComboBox();
            buttonConfirmOrderSent = new Button();
            groupBox2 = new GroupBox();
            numericUpDown1QuantityOrders = new NumericUpDown();
            label5 = new Label();
            label1 = new Label();
            comboBoxProducts = new ComboBox();
            buttonAddOrder = new Button();
            dataGridViewOrders = new DataGridView();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1QuantityOrders).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).BeginInit();
            SuspendLayout();
            // 
            // buttonBack
            // 
            buttonBack.BackColor = Color.LightCoral;
            buttonBack.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            buttonBack.Location = new Point(51, 619);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(62, 33);
            buttonBack.TabIndex = 10;
            buttonBack.Text = "BACK";
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += buttonBack_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(groupBox5);
            groupBox4.Controls.Add(groupBox3);
            groupBox4.Controls.Add(groupBox1);
            groupBox4.Controls.Add(groupBox2);
            groupBox4.Location = new Point(12, 205);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(444, 408);
            groupBox4.TabIndex = 9;
            groupBox4.TabStop = false;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(buttonDeleteOrder);
            groupBox5.Location = new Point(6, 155);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(432, 73);
            groupBox5.TabIndex = 6;
            groupBox5.TabStop = false;
            groupBox5.Text = "DELETE ORDER";
            // 
            // buttonDeleteOrder
            // 
            buttonDeleteOrder.BackColor = SystemColors.ActiveCaption;
            buttonDeleteOrder.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            buttonDeleteOrder.Location = new Point(155, 22);
            buttonDeleteOrder.Name = "buttonDeleteOrder";
            buttonDeleteOrder.Size = new Size(115, 31);
            buttonDeleteOrder.TabIndex = 2;
            buttonDeleteOrder.Text = "DELETE";
            buttonDeleteOrder.UseVisualStyleBackColor = false;
            buttonDeleteOrder.Click += buttonDeleteOrder_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(comboBoxOrderDelivered);
            groupBox3.Controls.Add(buttonConfirmOrderDelivered);
            groupBox3.Location = new Point(6, 320);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(432, 73);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "ORDER DELIVERED";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(82, 31);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 4;
            label4.Text = "ORDER ID :";
            // 
            // comboBoxOrderDelivered
            // 
            comboBoxOrderDelivered.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxOrderDelivered.FormattingEnabled = true;
            comboBoxOrderDelivered.Location = new Point(152, 28);
            comboBoxOrderDelivered.Name = "comboBoxOrderDelivered";
            comboBoxOrderDelivered.Size = new Size(121, 23);
            comboBoxOrderDelivered.TabIndex = 3;
            comboBoxOrderDelivered.SelectedIndexChanged += comboBoxOrderDelivered_SelectedIndexChanged;
            // 
            // buttonConfirmOrderDelivered
            // 
            buttonConfirmOrderDelivered.BackColor = SystemColors.ActiveCaption;
            buttonConfirmOrderDelivered.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            buttonConfirmOrderDelivered.Location = new Point(311, 22);
            buttonConfirmOrderDelivered.Name = "buttonConfirmOrderDelivered";
            buttonConfirmOrderDelivered.Size = new Size(115, 31);
            buttonConfirmOrderDelivered.TabIndex = 2;
            buttonConfirmOrderDelivered.Text = "CONFIRM";
            buttonConfirmOrderDelivered.UseVisualStyleBackColor = false;
            buttonConfirmOrderDelivered.Click += buttonConfirmOrderDelivered_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(comboBoxOrderSent);
            groupBox1.Controls.Add(buttonConfirmOrderSent);
            groupBox1.Location = new Point(6, 234);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(432, 80);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "ORDER SENT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(85, 31);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 4;
            label2.Text = "ORDER ID :";
            // 
            // comboBoxOrderSent
            // 
            comboBoxOrderSent.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxOrderSent.FormattingEnabled = true;
            comboBoxOrderSent.Location = new Point(152, 28);
            comboBoxOrderSent.Name = "comboBoxOrderSent";
            comboBoxOrderSent.Size = new Size(121, 23);
            comboBoxOrderSent.TabIndex = 3;
            comboBoxOrderSent.SelectedIndexChanged += comboBoxOrderSent_SelectedIndexChanged;
            // 
            // buttonConfirmOrderSent
            // 
            buttonConfirmOrderSent.BackColor = SystemColors.ActiveCaption;
            buttonConfirmOrderSent.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            buttonConfirmOrderSent.Location = new Point(311, 22);
            buttonConfirmOrderSent.Name = "buttonConfirmOrderSent";
            buttonConfirmOrderSent.Size = new Size(115, 31);
            buttonConfirmOrderSent.TabIndex = 2;
            buttonConfirmOrderSent.Text = "CONFIRM";
            buttonConfirmOrderSent.UseVisualStyleBackColor = false;
            buttonConfirmOrderSent.Click += buttonConfirmOrderSent_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(numericUpDown1QuantityOrders);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(comboBoxProducts);
            groupBox2.Controls.Add(buttonAddOrder);
            groupBox2.Location = new Point(6, 22);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(432, 127);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "ADD THE PRODUCTS";
            // 
            // numericUpDown1QuantityOrders
            // 
            numericUpDown1QuantityOrders.Location = new Point(152, 79);
            numericUpDown1QuantityOrders.Name = "numericUpDown1QuantityOrders";
            numericUpDown1QuantityOrders.Size = new Size(121, 23);
            numericUpDown1QuantityOrders.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(80, 81);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 5;
            label5.Text = "QUANTITY:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 31);
            label1.Name = "label1";
            label1.Size = new Size(132, 15);
            label1.TabIndex = 4;
            label1.Text = "AVAILABLE PRODUCTS :";
            // 
            // comboBoxProducts
            // 
            comboBoxProducts.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxProducts.FormattingEnabled = true;
            comboBoxProducts.Location = new Point(152, 28);
            comboBoxProducts.Name = "comboBoxProducts";
            comboBoxProducts.Size = new Size(121, 23);
            comboBoxProducts.TabIndex = 3;
            // 
            // buttonAddOrder
            // 
            buttonAddOrder.BackColor = SystemColors.ActiveCaption;
            buttonAddOrder.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            buttonAddOrder.Location = new Point(311, 28);
            buttonAddOrder.Name = "buttonAddOrder";
            buttonAddOrder.Size = new Size(115, 31);
            buttonAddOrder.TabIndex = 2;
            buttonAddOrder.Text = "ADD";
            buttonAddOrder.UseVisualStyleBackColor = false;
            buttonAddOrder.Click += buttonAddOrder_Click;
            // 
            // dataGridViewOrders
            // 
            dataGridViewOrders.AllowUserToAddRows = false;
            dataGridViewOrders.AllowUserToDeleteRows = false;
            dataGridViewOrders.AllowUserToResizeColumns = false;
            dataGridViewOrders.AllowUserToResizeRows = false;
            dataGridViewOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewOrders.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewOrders.Location = new Point(12, 12);
            dataGridViewOrders.MultiSelect = false;
            dataGridViewOrders.Name = "dataGridViewOrders";
            dataGridViewOrders.ReadOnly = true;
            dataGridViewOrders.RowHeadersVisible = false;
            dataGridViewOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewOrders.Size = new Size(444, 174);
            dataGridViewOrders.TabIndex = 8;
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 671);
            Controls.Add(buttonBack);
            Controls.Add(groupBox4);
            Controls.Add(dataGridViewOrders);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OrderForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OrderForm";
            WindowState = FormWindowState.Minimized;
            Load += OrderForm_Load;
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1QuantityOrders).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonBack;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private Label label4;
        private ComboBox comboBoxOrderDelivered;
        private Button buttonConfirmOrderDelivered;
        private GroupBox groupBox1;
        private Label label2;
        private ComboBox comboBoxOrderSent;
        private Button buttonConfirmOrderSent;
        private GroupBox groupBox2;
        private Label label1;
        private ComboBox comboBoxProducts;
        private Button buttonAddOrder;
        private DataGridView dataGridViewOrders;
        private GroupBox groupBox5;
        private Label label6;
        private ComboBox comboBox1;
        private Button buttonDeleteOrder;
        private NumericUpDown numericUpDown1QuantityOrders;
        private Label label5;
    }
}