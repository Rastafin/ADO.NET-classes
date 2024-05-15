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
            groupBox3 = new GroupBox();
            label4 = new Label();
            comboBoxOrderStatus = new ComboBox();
            buttonChangeStatus = new Button();
            groupBox1 = new GroupBox();
            numericUpDownSettlePaymentAmount = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            comboBoxSettlePaymentsId = new ComboBox();
            buttonSettlePayment = new Button();
            groupBox2 = new GroupBox();
            label1 = new Label();
            comboBoxOrdersId = new ComboBox();
            buttonChooseCustomer = new Button();
            dataGridViewOrders = new DataGridView();
            buttonViewOrderDetails = new Button();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSettlePaymentAmount).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).BeginInit();
            SuspendLayout();
            // 
            // buttonBack
            // 
            buttonBack.BackColor = Color.LightCoral;
            buttonBack.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            buttonBack.Location = new Point(50, 609);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(62, 33);
            buttonBack.TabIndex = 10;
            buttonBack.Text = "BACK";
            buttonBack.UseVisualStyleBackColor = false;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(groupBox3);
            groupBox4.Controls.Add(groupBox1);
            groupBox4.Controls.Add(groupBox2);
            groupBox4.Location = new Point(12, 205);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(444, 392);
            groupBox4.TabIndex = 9;
            groupBox4.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(comboBoxOrderStatus);
            groupBox3.Controls.Add(buttonChangeStatus);
            groupBox3.Location = new Point(6, 285);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(432, 73);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "ORDER STATUS";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 31);
            label4.Name = "label4";
            label4.Size = new Size(91, 15);
            label4.TabIndex = 4;
            label4.Text = "ORDER STATUS :";
            // 
            // comboBoxOrderStatus
            // 
            comboBoxOrderStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxOrderStatus.FormattingEnabled = true;
            comboBoxOrderStatus.Location = new Point(156, 28);
            comboBoxOrderStatus.Name = "comboBoxOrderStatus";
            comboBoxOrderStatus.Size = new Size(121, 23);
            comboBoxOrderStatus.TabIndex = 3;
            // 
            // buttonChangeStatus
            // 
            buttonChangeStatus.BackColor = SystemColors.ActiveCaption;
            buttonChangeStatus.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            buttonChangeStatus.Location = new Point(311, 22);
            buttonChangeStatus.Name = "buttonChangeStatus";
            buttonChangeStatus.Size = new Size(115, 31);
            buttonChangeStatus.TabIndex = 2;
            buttonChangeStatus.Text = "CHANGE";
            buttonChangeStatus.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numericUpDownSettlePaymentAmount);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(comboBoxSettlePaymentsId);
            groupBox1.Controls.Add(buttonSettlePayment);
            groupBox1.Location = new Point(6, 123);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(432, 134);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "ORDER DATE";
            // 
            // numericUpDownSettlePaymentAmount
            // 
            numericUpDownSettlePaymentAmount.DecimalPlaces = 2;
            numericUpDownSettlePaymentAmount.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            numericUpDownSettlePaymentAmount.Location = new Point(156, 86);
            numericUpDownSettlePaymentAmount.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDownSettlePaymentAmount.Name = "numericUpDownSettlePaymentAmount";
            numericUpDownSettlePaymentAmount.Size = new Size(120, 23);
            numericUpDownSettlePaymentAmount.TabIndex = 6;
            numericUpDownSettlePaymentAmount.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(73, 88);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 5;
            label3.Text = "AMOUNT:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 31);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 4;
            label2.Text = "PAYMENT ID:";
            // 
            // comboBoxSettlePaymentsId
            // 
            comboBoxSettlePaymentsId.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSettlePaymentsId.FormattingEnabled = true;
            comboBoxSettlePaymentsId.Location = new Point(155, 28);
            comboBoxSettlePaymentsId.Name = "comboBoxSettlePaymentsId";
            comboBoxSettlePaymentsId.Size = new Size(121, 23);
            comboBoxSettlePaymentsId.TabIndex = 3;
            // 
            // buttonSettlePayment
            // 
            buttonSettlePayment.BackColor = SystemColors.ActiveCaption;
            buttonSettlePayment.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            buttonSettlePayment.Location = new Point(311, 54);
            buttonSettlePayment.Name = "buttonSettlePayment";
            buttonSettlePayment.Size = new Size(115, 31);
            buttonSettlePayment.TabIndex = 2;
            buttonSettlePayment.Text = "SETTLE";
            buttonSettlePayment.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(comboBoxOrdersId);
            groupBox2.Controls.Add(buttonChooseCustomer);
            groupBox2.Location = new Point(6, 22);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(432, 73);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "CHOSSE THE COSTUMER ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 31);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 4;
            label1.Text = "CUSTOMER ID:";
            // 
            // comboBoxOrdersId
            // 
            comboBoxOrdersId.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxOrdersId.FormattingEnabled = true;
            comboBoxOrdersId.Location = new Point(152, 28);
            comboBoxOrdersId.Name = "comboBoxOrdersId";
            comboBoxOrdersId.Size = new Size(121, 23);
            comboBoxOrdersId.TabIndex = 3;
            // 
            // buttonChooseCustomer
            // 
            buttonChooseCustomer.BackColor = SystemColors.ActiveCaption;
            buttonChooseCustomer.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            buttonChooseCustomer.Location = new Point(311, 22);
            buttonChooseCustomer.Name = "buttonChooseCustomer";
            buttonChooseCustomer.Size = new Size(115, 31);
            buttonChooseCustomer.TabIndex = 2;
            buttonChooseCustomer.Text = "CHOOSE";
            buttonChooseCustomer.UseVisualStyleBackColor = false;
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
            // buttonViewOrderDetails
            // 
            buttonViewOrderDetails.BackColor = SystemColors.ActiveCaption;
            buttonViewOrderDetails.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            buttonViewOrderDetails.Location = new Point(329, 611);
            buttonViewOrderDetails.Name = "buttonViewOrderDetails";
            buttonViewOrderDetails.Size = new Size(115, 31);
            buttonViewOrderDetails.TabIndex = 11;
            buttonViewOrderDetails.Text = "ORDER DETAILS";
            buttonViewOrderDetails.UseVisualStyleBackColor = false;
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 654);
            Controls.Add(buttonViewOrderDetails);
            Controls.Add(buttonBack);
            Controls.Add(groupBox4);
            Controls.Add(dataGridViewOrders);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OrderForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OrderForm";
            WindowState = FormWindowState.Minimized;
            groupBox4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSettlePaymentAmount).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonBack;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private Label label4;
        private ComboBox comboBoxOrderStatus;
        private Button buttonChangeStatus;
        private GroupBox groupBox1;
        private NumericUpDown numericUpDownSettlePaymentAmount;
        private Label label3;
        private Label label2;
        private ComboBox comboBoxSettlePaymentsId;
        private Button buttonSettlePayment;
        private GroupBox groupBox2;
        private Label label1;
        private ComboBox comboBoxOrdersId;
        private Button buttonChooseCustomer;
        private DataGridView dataGridViewOrders;
        private Button buttonViewOrderDetails;
    }
}