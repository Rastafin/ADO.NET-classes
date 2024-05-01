namespace GUI
{
    partial class CustomersForm
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
            dataGridViewCustomers = new DataGridView();
            groupBox1 = new GroupBox();
            groupBox4 = new GroupBox();
            buttonDeleteCustomer = new Button();
            groupBox3 = new GroupBox();
            buttonEditCustomer = new Button();
            groupBox2 = new GroupBox();
            buttonAddCustomer = new Button();
            buttonBack = new Button();
            textBoxFirstName = new TextBox();
            textBoxLastName = new TextBox();
            textBoxEmail = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomers).BeginInit();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewCustomers
            // 
            dataGridViewCustomers.AllowUserToAddRows = false;
            dataGridViewCustomers.AllowUserToDeleteRows = false;
            dataGridViewCustomers.AllowUserToResizeColumns = false;
            dataGridViewCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCustomers.Location = new Point(12, 12);
            dataGridViewCustomers.Name = "dataGridViewCustomers";
            dataGridViewCustomers.ReadOnly = true;
            dataGridViewCustomers.RowHeadersVisible = false;
            dataGridViewCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCustomers.Size = new Size(444, 174);
            dataGridViewCustomers.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Location = new Point(12, 210);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(444, 410);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(buttonDeleteCustomer);
            groupBox4.Location = new Point(6, 282);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(432, 118);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "DELETECUSTOMER";
            // 
            // buttonDeleteCustomer
            // 
            buttonDeleteCustomer.BackColor = SystemColors.ActiveCaption;
            buttonDeleteCustomer.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            buttonDeleteCustomer.Location = new Point(311, 44);
            buttonDeleteCustomer.Name = "buttonDeleteCustomer";
            buttonDeleteCustomer.Size = new Size(115, 31);
            buttonDeleteCustomer.TabIndex = 2;
            buttonDeleteCustomer.Text = "DELETE";
            buttonDeleteCustomer.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(buttonEditCustomer);
            groupBox3.Location = new Point(6, 146);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(432, 118);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "EDIT CUSTOMER";
            // 
            // buttonEditCustomer
            // 
            buttonEditCustomer.BackColor = SystemColors.ActiveCaption;
            buttonEditCustomer.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            buttonEditCustomer.Location = new Point(311, 43);
            buttonEditCustomer.Name = "buttonEditCustomer";
            buttonEditCustomer.Size = new Size(115, 31);
            buttonEditCustomer.TabIndex = 2;
            buttonEditCustomer.Text = "EDIT";
            buttonEditCustomer.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxEmail);
            groupBox2.Controls.Add(textBoxLastName);
            groupBox2.Controls.Add(textBoxFirstName);
            groupBox2.Controls.Add(buttonAddCustomer);
            groupBox2.Location = new Point(6, 22);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(432, 118);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "ADD CUSTOMER";
            // 
            // buttonAddCustomer
            // 
            buttonAddCustomer.BackColor = SystemColors.ActiveCaption;
            buttonAddCustomer.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            buttonAddCustomer.Location = new Point(311, 43);
            buttonAddCustomer.Name = "buttonAddCustomer";
            buttonAddCustomer.Size = new Size(115, 31);
            buttonAddCustomer.TabIndex = 2;
            buttonAddCustomer.Text = "ADD";
            buttonAddCustomer.UseVisualStyleBackColor = false;
            buttonAddCustomer.Click += buttonAddCustomer_Click;
            // 
            // buttonBack
            // 
            buttonBack.BackColor = Color.LightCoral;
            buttonBack.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            buttonBack.Location = new Point(35, 629);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(62, 33);
            buttonBack.TabIndex = 6;
            buttonBack.Text = "BACK";
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += buttonBack_Click;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(32, 22);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.PlaceholderText = "Firstname";
            textBoxFirstName.Size = new Size(223, 23);
            textBoxFirstName.TabIndex = 3;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(32, 51);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.PlaceholderText = "Lastname";
            textBoxLastName.Size = new Size(223, 23);
            textBoxLastName.TabIndex = 4;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(32, 80);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.PlaceholderText = "Email";
            textBoxEmail.Size = new Size(223, 23);
            textBoxEmail.TabIndex = 5;
            // 
            // CustomersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 674);
            Controls.Add(buttonBack);
            Controls.Add(groupBox1);
            Controls.Add(dataGridViewCustomers);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CustomersForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomersForm";
            Load += CustomersForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomers).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewCustomers;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button buttonAddCustomer;
        private GroupBox groupBox4;
        private Button buttonDeleteCustomer;
        private GroupBox groupBox3;
        private Button buttonEditCustomer;
        private Button buttonBack;
        private TextBox textBoxEmail;
        private TextBox textBoxLastName;
        private TextBox textBoxFirstName;
    }
}