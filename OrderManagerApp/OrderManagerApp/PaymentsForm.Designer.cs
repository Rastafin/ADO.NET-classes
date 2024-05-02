namespace GUI
{
    partial class PaymentsForm
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
            dataGridViewPayments = new DataGridView();
            groupBox4 = new GroupBox();
            groupBox2 = new GroupBox();
            label1 = new Label();
            comboBoxOrdersId = new ComboBox();
            buttonGeneratePayment = new Button();
            buttonBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPayments).BeginInit();
            groupBox4.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewPayments
            // 
            dataGridViewPayments.AllowUserToAddRows = false;
            dataGridViewPayments.AllowUserToDeleteRows = false;
            dataGridViewPayments.AllowUserToResizeColumns = false;
            dataGridViewPayments.AllowUserToResizeRows = false;
            dataGridViewPayments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewPayments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewPayments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewPayments.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewPayments.Location = new Point(12, 12);
            dataGridViewPayments.MultiSelect = false;
            dataGridViewPayments.Name = "dataGridViewPayments";
            dataGridViewPayments.ReadOnly = true;
            dataGridViewPayments.RowHeadersVisible = false;
            dataGridViewPayments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPayments.Size = new Size(444, 174);
            dataGridViewPayments.TabIndex = 1;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(groupBox2);
            groupBox4.Location = new Point(12, 205);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(444, 392);
            groupBox4.TabIndex = 6;
            groupBox4.TabStop = false;
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
            buttonGeneratePayment.Click += buttonGeneratePayment_Click;
            // 
            // buttonBack
            // 
            buttonBack.BackColor = Color.LightCoral;
            buttonBack.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            buttonBack.Location = new Point(50, 609);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(62, 33);
            buttonBack.TabIndex = 7;
            buttonBack.Text = "BACK";
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += buttonBack_Click;
            // 
            // PaymentsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 654);
            Controls.Add(buttonBack);
            Controls.Add(groupBox4);
            Controls.Add(dataGridViewPayments);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PaymentsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PaymentsForm";
            Load += PaymentsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPayments).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewPayments;
        private GroupBox groupBox4;
        private GroupBox groupBox2;
        private Button buttonGeneratePayment;
        private ComboBox comboBoxOrdersId;
        private Label label1;
        private Button buttonBack;
    }
}