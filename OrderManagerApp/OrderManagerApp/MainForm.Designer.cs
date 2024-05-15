namespace OrderManagerApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelTitle = new Label();
            buttonCustomers = new Button();
            buttonProducts = new Button();
            buttonOrders = new Button();
            buttonPayments = new Button();
            groupBox1 = new GroupBox();
            buttonExit = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold);
            labelTitle.Location = new Point(97, 57);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(312, 45);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Order Manager App";
            // 
            // buttonCustomers
            // 
            buttonCustomers.BackColor = SystemColors.ActiveCaption;
            buttonCustomers.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            buttonCustomers.Location = new Point(32, 40);
            buttonCustomers.Name = "buttonCustomers";
            buttonCustomers.Size = new Size(151, 46);
            buttonCustomers.TabIndex = 1;
            buttonCustomers.Text = "CUSTOMERS";
            buttonCustomers.UseVisualStyleBackColor = false;
            buttonCustomers.Click += buttonCustomers_Click;
            // 
            // buttonProducts
            // 
            buttonProducts.BackColor = SystemColors.ActiveCaption;
            buttonProducts.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            buttonProducts.Location = new Point(219, 40);
            buttonProducts.Name = "buttonProducts";
            buttonProducts.Size = new Size(151, 46);
            buttonProducts.TabIndex = 2;
            buttonProducts.Text = "PRODUCTS";
            buttonProducts.UseVisualStyleBackColor = false;
            buttonProducts.Click += buttonProducts_Click;
            // 
            // buttonOrders
            // 
            buttonOrders.BackColor = SystemColors.ActiveCaption;
            buttonOrders.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            buttonOrders.Location = new Point(32, 154);
            buttonOrders.Name = "buttonOrders";
            buttonOrders.Size = new Size(151, 46);
            buttonOrders.TabIndex = 3;
            buttonOrders.Text = "ORDERS";
            buttonOrders.UseVisualStyleBackColor = false;
            buttonOrders.Click += buttonOrders_Click;
            // 
            // buttonPayments
            // 
            buttonPayments.BackColor = SystemColors.ActiveCaption;
            buttonPayments.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            buttonPayments.Location = new Point(219, 154);
            buttonPayments.Name = "buttonPayments";
            buttonPayments.Size = new Size(151, 46);
            buttonPayments.TabIndex = 4;
            buttonPayments.Text = "PAYMENTS";
            buttonPayments.UseVisualStyleBackColor = false;
            buttonPayments.Click += buttonPayments_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonExit);
            groupBox1.Controls.Add(buttonCustomers);
            groupBox1.Controls.Add(buttonOrders);
            groupBox1.Controls.Add(buttonPayments);
            groupBox1.Controls.Add(buttonProducts);
            groupBox1.Location = new Point(39, 131);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(401, 357);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.LightCoral;
            buttonExit.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            buttonExit.Location = new Point(123, 276);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(151, 46);
            buttonExit.TabIndex = 5;
            buttonExit.Text = "EXIT";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 561);
            Controls.Add(groupBox1);
            Controls.Add(labelTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Button buttonCustomers;
        private Button buttonProducts;
        private Button buttonOrders;
        private Button buttonPayments;
        private GroupBox groupBox1;
        private Button buttonExit;
    }
}
