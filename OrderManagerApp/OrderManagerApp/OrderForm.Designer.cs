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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            buttonBack = new Button();
            groupBox4 = new GroupBox();
            groupBox5 = new GroupBox();
            buttonDeleteOrder = new Button();
            groupBox3 = new GroupBox();
            label4 = new Label();
            comboBoxOrdersToDeliver = new ComboBox();
            buttonConfirmOrderDelivered = new Button();
            groupBox1 = new GroupBox();
            label2 = new Label();
            comboBoxOrdersToApprove = new ComboBox();
            buttonApproveOrder = new Button();
            groupBox2 = new GroupBox();
            checkBoxNewOrder = new CheckBox();
            label3 = new Label();
            comboBoxCustomer = new ComboBox();
            numericUpDownQuantity = new NumericUpDown();
            label5 = new Label();
            label1 = new Label();
            comboBoxProducts = new ComboBox();
            buttonAddOrderDetail = new Button();
            dataGridViewOrders = new DataGridView();
            label7 = new Label();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).BeginInit();
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
            groupBox3.Controls.Add(comboBoxOrdersToDeliver);
            groupBox3.Controls.Add(buttonConfirmOrderDelivered);
            groupBox3.Location = new Point(6, 320);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(432, 73);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "DELIVER ORDER";
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
            // comboBoxOrdersToDeliver
            // 
            comboBoxOrdersToDeliver.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxOrdersToDeliver.FormattingEnabled = true;
            comboBoxOrdersToDeliver.Location = new Point(152, 28);
            comboBoxOrdersToDeliver.Name = "comboBoxOrdersToDeliver";
            comboBoxOrdersToDeliver.Size = new Size(121, 23);
            comboBoxOrdersToDeliver.TabIndex = 3;
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
            groupBox1.Controls.Add(comboBoxOrdersToApprove);
            groupBox1.Controls.Add(buttonApproveOrder);
            groupBox1.Location = new Point(6, 234);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(432, 80);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "APPROVE ORDER";
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
            // comboBoxOrdersToApprove
            // 
            comboBoxOrdersToApprove.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxOrdersToApprove.FormattingEnabled = true;
            comboBoxOrdersToApprove.Location = new Point(152, 28);
            comboBoxOrdersToApprove.Name = "comboBoxOrdersToApprove";
            comboBoxOrdersToApprove.Size = new Size(121, 23);
            comboBoxOrdersToApprove.TabIndex = 3;
            // 
            // buttonApproveOrder
            // 
            buttonApproveOrder.BackColor = SystemColors.ActiveCaption;
            buttonApproveOrder.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            buttonApproveOrder.Location = new Point(311, 22);
            buttonApproveOrder.Name = "buttonApproveOrder";
            buttonApproveOrder.Size = new Size(115, 31);
            buttonApproveOrder.TabIndex = 2;
            buttonApproveOrder.Text = "APPROVE";
            buttonApproveOrder.UseVisualStyleBackColor = false;
            buttonApproveOrder.Click += buttonConfirmOrderSent_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(checkBoxNewOrder);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(comboBoxCustomer);
            groupBox2.Controls.Add(numericUpDownQuantity);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(comboBoxProducts);
            groupBox2.Controls.Add(buttonAddOrderDetail);
            groupBox2.Location = new Point(6, 22);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(432, 127);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "ADD PRODUCTS";
            // 
            // checkBoxNewOrder
            // 
            checkBoxNewOrder.AutoSize = true;
            checkBoxNewOrder.Checked = true;
            checkBoxNewOrder.CheckState = CheckState.Checked;
            checkBoxNewOrder.Location = new Point(301, 67);
            checkBoxNewOrder.Name = "checkBoxNewOrder";
            checkBoxNewOrder.Size = new Size(83, 19);
            checkBoxNewOrder.TabIndex = 9;
            checkBoxNewOrder.Text = "New Order";
            checkBoxNewOrder.UseVisualStyleBackColor = true;
            checkBoxNewOrder.CheckedChanged += checkBoxNewOrder_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(314, 20);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 8;
            label3.Text = "CUSTOMER:";
            // 
            // comboBoxCustomer
            // 
            comboBoxCustomer.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCustomer.FormattingEnabled = true;
            comboBoxCustomer.Location = new Point(291, 38);
            comboBoxCustomer.Name = "comboBoxCustomer";
            comboBoxCustomer.Size = new Size(121, 23);
            comboBoxCustomer.TabIndex = 7;
            // 
            // numericUpDownQuantity
            // 
            numericUpDownQuantity.Location = new Point(152, 38);
            numericUpDownQuantity.Name = "numericUpDownQuantity";
            numericUpDownQuantity.Size = new Size(121, 23);
            numericUpDownQuantity.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(180, 20);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 5;
            label5.Text = "QUANTITY:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 19);
            label1.Name = "label1";
            label1.Size = new Size(132, 15);
            label1.TabIndex = 4;
            label1.Text = "AVAILABLE PRODUCTS :";
            // 
            // comboBoxProducts
            // 
            comboBoxProducts.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxProducts.FormattingEnabled = true;
            comboBoxProducts.Location = new Point(14, 38);
            comboBoxProducts.Name = "comboBoxProducts";
            comboBoxProducts.Size = new Size(121, 23);
            comboBoxProducts.TabIndex = 3;
            comboBoxProducts.SelectedIndexChanged += comboBoxProducts_SelectedIndexChanged;
            // 
            // buttonAddOrderDetail
            // 
            buttonAddOrderDetail.BackColor = SystemColors.ActiveCaption;
            buttonAddOrderDetail.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            buttonAddOrderDetail.Location = new Point(155, 79);
            buttonAddOrderDetail.Name = "buttonAddOrderDetail";
            buttonAddOrderDetail.Size = new Size(115, 31);
            buttonAddOrderDetail.TabIndex = 2;
            buttonAddOrderDetail.Text = "ADD";
            buttonAddOrderDetail.UseVisualStyleBackColor = false;
            buttonAddOrderDetail.Click += buttonAddOrder_Click;
            // 
            // dataGridViewOrders
            // 
            dataGridViewOrders.AllowUserToAddRows = false;
            dataGridViewOrders.AllowUserToDeleteRows = false;
            dataGridViewOrders.AllowUserToResizeColumns = false;
            dataGridViewOrders.AllowUserToResizeRows = false;
            dataGridViewOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridViewOrders.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewOrders.Location = new Point(12, 12);
            dataGridViewOrders.MultiSelect = false;
            dataGridViewOrders.Name = "dataGridViewOrders";
            dataGridViewOrders.ReadOnly = true;
            dataGridViewOrders.RowHeadersVisible = false;
            dataGridViewOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewOrders.Size = new Size(444, 174);
            dataGridViewOrders.TabIndex = 8;
            dataGridViewOrders.DoubleClick += dataGridViewOrders_DoubleClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(122, 189);
            label7.Name = "label7";
            label7.Size = new Size(217, 15);
            label7.TabIndex = 10;
            label7.Text = "DOUBLE CLICK RECORD TO SEE DETAILS";
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 671);
            Controls.Add(label7);
            Controls.Add(buttonBack);
            Controls.Add(groupBox4);
            Controls.Add(dataGridViewOrders);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OrderForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OrderForm";
            Load += OrderForm_Load;
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonBack;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private Label label4;
        private ComboBox comboBoxOrdersToDeliver;
        private Button buttonConfirmOrderDelivered;
        private GroupBox groupBox1;
        private Label label2;
        private ComboBox comboBoxOrdersToApprove;
        private Button buttonApproveOrder;
        private GroupBox groupBox2;
        private Label label1;
        private ComboBox comboBoxProducts;
        private Button buttonAddOrderDetail;
        private DataGridView dataGridViewOrders;
        private GroupBox groupBox5;
        private Label label6;
        private ComboBox comboBox1;
        private Button buttonDeleteOrder;
        private NumericUpDown numericUpDownQuantity;
        private Label label5;
        private CheckBox checkBoxNewOrder;
        private Label label3;
        private ComboBox comboBoxCustomer;
        private Label label7;
    }
}