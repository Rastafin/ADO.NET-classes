namespace GUI
{
    partial class OrderDetailsForm
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
            groupBox3 = new GroupBox();
            label4 = new Label();
            comboBoxWithdrawPaymentsId = new ComboBox();
            buttonWithdrawPayment = new Button();
            groupBox1 = new GroupBox();
            numericUpDownSettlePaymentAmount = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            comboBoxSettlePaymentsId = new ComboBox();
            buttonSettlePayment = new Button();
            groupBox2 = new GroupBox();
            label1 = new Label();
            comboBoxOrdersId = new ComboBox();
            buttonGeneratePayment = new Button();
            dataGridViewOrderDetails = new DataGridView();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSettlePaymentAmount).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrderDetails).BeginInit();
            SuspendLayout();
            // 
            // buttonBack
            // 
            buttonBack.BackColor = Color.LightCoral;
            buttonBack.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            buttonBack.Location = new Point(50, 609);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(62, 33);
            buttonBack.TabIndex = 13;
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
            groupBox4.TabIndex = 12;
            groupBox4.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(comboBoxWithdrawPaymentsId);
            groupBox3.Controls.Add(buttonWithdrawPayment);
            groupBox3.Location = new Point(6, 285);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(432, 73);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "WITHDRAW PAYMENT";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(73, 31);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 4;
            label4.Text = "PAYMENT ID:";
            // 
            // comboBoxWithdrawPaymentsId
            // 
            comboBoxWithdrawPaymentsId.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxWithdrawPaymentsId.FormattingEnabled = true;
            comboBoxWithdrawPaymentsId.Location = new Point(156, 28);
            comboBoxWithdrawPaymentsId.Name = "comboBoxWithdrawPaymentsId";
            comboBoxWithdrawPaymentsId.Size = new Size(121, 23);
            comboBoxWithdrawPaymentsId.TabIndex = 3;
            // 
            // buttonWithdrawPayment
            // 
            buttonWithdrawPayment.BackColor = SystemColors.ActiveCaption;
            buttonWithdrawPayment.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            buttonWithdrawPayment.Location = new Point(311, 22);
            buttonWithdrawPayment.Name = "buttonWithdrawPayment";
            buttonWithdrawPayment.Size = new Size(115, 31);
            buttonWithdrawPayment.TabIndex = 2;
            buttonWithdrawPayment.Text = "WITHDRAW";
            buttonWithdrawPayment.UseVisualStyleBackColor = false;
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
            groupBox1.Text = "SETTLE PAYMENT";
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
            groupBox2.Controls.Add(buttonGeneratePayment);
            groupBox2.Location = new Point(6, 22);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(432, 73);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "GENERATE PAYMENT";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 31);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 4;
            label1.Text = "ORDER ID:";
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
            // buttonGeneratePayment
            // 
            buttonGeneratePayment.BackColor = SystemColors.ActiveCaption;
            buttonGeneratePayment.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            buttonGeneratePayment.Location = new Point(311, 22);
            buttonGeneratePayment.Name = "buttonGeneratePayment";
            buttonGeneratePayment.Size = new Size(115, 31);
            buttonGeneratePayment.TabIndex = 2;
            buttonGeneratePayment.Text = "GENERATE";
            buttonGeneratePayment.UseVisualStyleBackColor = false;
            // 
            // dataGridViewOrderDetails
            // 
            dataGridViewOrderDetails.AllowUserToAddRows = false;
            dataGridViewOrderDetails.AllowUserToDeleteRows = false;
            dataGridViewOrderDetails.AllowUserToResizeColumns = false;
            dataGridViewOrderDetails.AllowUserToResizeRows = false;
            dataGridViewOrderDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewOrderDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewOrderDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridViewOrderDetails.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewOrderDetails.Location = new Point(12, 12);
            dataGridViewOrderDetails.MultiSelect = false;
            dataGridViewOrderDetails.Name = "dataGridViewOrderDetails";
            dataGridViewOrderDetails.ReadOnly = true;
            dataGridViewOrderDetails.RowHeadersVisible = false;
            dataGridViewOrderDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewOrderDetails.Size = new Size(444, 174);
            dataGridViewOrderDetails.TabIndex = 11;
            // 
            // OrderDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 654);
            Controls.Add(buttonBack);
            Controls.Add(groupBox4);
            Controls.Add(dataGridViewOrderDetails);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OrderDetailsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OrderDetailsForm";
            groupBox4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSettlePaymentAmount).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrderDetails).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonBack;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private Label label4;
        private ComboBox comboBoxWithdrawPaymentsId;
        private Button buttonWithdrawPayment;
        private GroupBox groupBox1;
        private NumericUpDown numericUpDownSettlePaymentAmount;
        private Label label3;
        private Label label2;
        private ComboBox comboBoxSettlePaymentsId;
        private Button buttonSettlePayment;
        private GroupBox groupBox2;
        private Label label1;
        private ComboBox comboBoxOrdersId;
        private Button buttonGeneratePayment;
        private DataGridView dataGridViewOrderDetails;
    }
}