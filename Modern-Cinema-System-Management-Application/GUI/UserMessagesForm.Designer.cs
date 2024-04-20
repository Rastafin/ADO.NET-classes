namespace GUI
{
    partial class UserMessagesForm
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
            dataGridViewMessages = new DataGridView();
            buttonMarkAsRead = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMessages).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewMessages
            // 
            dataGridViewMessages.AllowUserToAddRows = false;
            dataGridViewMessages.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMessages.BackgroundColor = Color.Black;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Coral;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.Coral;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewMessages.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewMessages.ColumnHeadersHeight = 50;
            dataGridViewMessages.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewMessages.EnableHeadersVisualStyles = false;
            dataGridViewMessages.GridColor = Color.Snow;
            dataGridViewMessages.Location = new Point(12, 76);
            dataGridViewMessages.MultiSelect = false;
            dataGridViewMessages.Name = "dataGridViewMessages";
            dataGridViewMessages.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Black;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Coral;
            dataGridViewCellStyle2.SelectionBackColor = Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = Color.Coral;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewMessages.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewMessages.RowHeadersVisible = false;
            dataGridViewMessages.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewMessages.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewMessages.RowTemplate.DefaultCellStyle.BackColor = Color.Black;
            dataGridViewMessages.RowTemplate.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewMessages.RowTemplate.DefaultCellStyle.ForeColor = Color.Coral;
            dataGridViewMessages.RowTemplate.Height = 100;
            dataGridViewMessages.RowTemplate.ReadOnly = true;
            dataGridViewMessages.RowTemplate.Resizable = DataGridViewTriState.False;
            dataGridViewMessages.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewMessages.Size = new Size(680, 373);
            dataGridViewMessages.TabIndex = 7;
            dataGridViewMessages.CellFormatting += dataGridViewMessages_CellFormatting;
            // 
            // buttonMarkAsRead
            // 
            buttonMarkAsRead.BackColor = Color.Coral;
            buttonMarkAsRead.FlatAppearance.BorderColor = Color.Black;
            buttonMarkAsRead.FlatAppearance.BorderSize = 2;
            buttonMarkAsRead.FlatStyle = FlatStyle.Flat;
            buttonMarkAsRead.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonMarkAsRead.Location = new Point(491, 12);
            buttonMarkAsRead.Name = "buttonMarkAsRead";
            buttonMarkAsRead.Size = new Size(201, 47);
            buttonMarkAsRead.TabIndex = 33;
            buttonMarkAsRead.Text = "MARK AS READ";
            buttonMarkAsRead.UseVisualStyleBackColor = false;
            buttonMarkAsRead.Click += buttonDeleteScreening_Click;
            // 
            // UserMessagesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(14, 14, 14);
            ClientSize = new Size(704, 461);
            Controls.Add(buttonMarkAsRead);
            Controls.Add(dataGridViewMessages);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserMessagesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserMessagesForm";
            Load += UserMessagesForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewMessages).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewMessages;
        private Button buttonMarkAsRead;
    }
}