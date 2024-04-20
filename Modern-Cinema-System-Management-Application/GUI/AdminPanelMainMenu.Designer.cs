namespace GUI
{
    partial class AdminPanelMainMenu
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            panel1 = new Panel();
            labelAdminPanel = new Label();
            buttonStatistics = new Button();
            buttonUsers = new Button();
            pictureBox1 = new PictureBox();
            buttonBack = new Button();
            dataGridViewUsers = new DataGridView();
            textBoxFilter = new TextBox();
            buttonChangeStatus = new Button();
            labelMessage = new Label();
            buttonChangeRole = new Button();
            comboBoxRole = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.Coral;
            panel1.Controls.Add(labelAdminPanel);
            panel1.Controls.Add(buttonStatistics);
            panel1.Controls.Add(buttonUsers);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(buttonBack);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(230, 1215);
            panel1.TabIndex = 6;
            // 
            // labelAdminPanel
            // 
            labelAdminPanel.AutoSize = true;
            labelAdminPanel.BackColor = Color.Coral;
            labelAdminPanel.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelAdminPanel.ForeColor = Color.Black;
            labelAdminPanel.Location = new Point(5, 139);
            labelAdminPanel.Name = "labelAdminPanel";
            labelAdminPanel.Size = new Size(207, 40);
            labelAdminPanel.TabIndex = 9;
            labelAdminPanel.Text = "ADMIN PANEL";
            // 
            // buttonStatistics
            // 
            buttonStatistics.BackColor = Color.Coral;
            buttonStatistics.FlatAppearance.BorderColor = Color.Black;
            buttonStatistics.FlatAppearance.BorderSize = 2;
            buttonStatistics.FlatStyle = FlatStyle.Flat;
            buttonStatistics.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonStatistics.Location = new Point(12, 319);
            buttonStatistics.Name = "buttonStatistics";
            buttonStatistics.Size = new Size(200, 56);
            buttonStatistics.TabIndex = 10;
            buttonStatistics.Text = "STATISTICS";
            buttonStatistics.UseVisualStyleBackColor = false;
            buttonStatistics.Click += buttonStatistics_Click;
            // 
            // buttonUsers
            // 
            buttonUsers.BackColor = Color.Coral;
            buttonUsers.FlatAppearance.BorderColor = Color.Black;
            buttonUsers.FlatAppearance.BorderSize = 2;
            buttonUsers.FlatStyle = FlatStyle.Flat;
            buttonUsers.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonUsers.Location = new Point(12, 227);
            buttonUsers.Name = "buttonUsers";
            buttonUsers.Size = new Size(200, 56);
            buttonUsers.TabIndex = 9;
            buttonUsers.Text = "USERS";
            buttonUsers.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._4170e6ab0f6d30dca42c2df7cf52fb999351cb63d11203175d4ddb638955e9c2;
            pictureBox1.Location = new Point(42, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(141, 94);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // buttonBack
            // 
            buttonBack.BackColor = Color.Coral;
            buttonBack.FlatAppearance.BorderColor = Color.Black;
            buttonBack.FlatAppearance.BorderSize = 2;
            buttonBack.FlatStyle = FlatStyle.Flat;
            buttonBack.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonBack.Location = new Point(12, 1044);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(200, 56);
            buttonBack.TabIndex = 6;
            buttonBack.Text = "BACK";
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += buttonBack_Click;
            // 
            // dataGridViewUsers
            // 
            dataGridViewUsers.AllowUserToAddRows = false;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewUsers.BackgroundColor = Color.Black;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.Coral;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.Coral;
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridViewUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewUsers.ColumnHeadersHeight = 50;
            dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewUsers.EnableHeadersVisualStyles = false;
            dataGridViewUsers.GridColor = Color.Snow;
            dataGridViewUsers.Location = new Point(332, 180);
            dataGridViewUsers.MultiSelect = false;
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.Black;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.Coral;
            dataGridViewCellStyle7.SelectionBackColor = Color.Black;
            dataGridViewCellStyle7.SelectionForeColor = Color.Coral;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridViewUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewUsers.RowHeadersVisible = false;
            dataGridViewUsers.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.GrayText;
            dataGridViewUsers.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewUsers.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewUsers.RowTemplate.DefaultCellStyle.BackColor = Color.Black;
            dataGridViewUsers.RowTemplate.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewUsers.RowTemplate.DefaultCellStyle.ForeColor = Color.Coral;
            dataGridViewUsers.RowTemplate.Height = 100;
            dataGridViewUsers.RowTemplate.ReadOnly = true;
            dataGridViewUsers.RowTemplate.Resizable = DataGridViewTriState.False;
            dataGridViewUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewUsers.Size = new Size(1500, 950);
            dataGridViewUsers.TabIndex = 7;
            dataGridViewUsers.CellClick += dataGridViewUsers_CellClick;
            dataGridViewUsers.CellFormatting += dataGridViewUsers_CellFormatting;
            dataGridViewUsers.RowHeaderMouseClick += dataGridViewUsers_RowHeaderMouseClick;
            dataGridViewUsers.SelectionChanged += dataGridViewUsers_SelectionChanged;
            // 
            // textBoxFilter
            // 
            textBoxFilter.BackColor = Color.Coral;
            textBoxFilter.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxFilter.Location = new Point(870, 62);
            textBoxFilter.Name = "textBoxFilter";
            textBoxFilter.PlaceholderText = "FILTER";
            textBoxFilter.Size = new Size(431, 46);
            textBoxFilter.TabIndex = 25;
            textBoxFilter.TextAlign = HorizontalAlignment.Center;
            textBoxFilter.TextChanged += textBoxFilter_TextChanged;
            // 
            // buttonChangeStatus
            // 
            buttonChangeStatus.BackColor = Color.Coral;
            buttonChangeStatus.FlatAppearance.BorderColor = Color.Black;
            buttonChangeStatus.FlatAppearance.BorderSize = 2;
            buttonChangeStatus.FlatStyle = FlatStyle.Flat;
            buttonChangeStatus.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonChangeStatus.Location = new Point(1605, 47);
            buttonChangeStatus.Name = "buttonChangeStatus";
            buttonChangeStatus.Size = new Size(200, 77);
            buttonChangeStatus.TabIndex = 26;
            buttonChangeStatus.Text = "CHANGE STATUS";
            buttonChangeStatus.UseVisualStyleBackColor = false;
            buttonChangeStatus.Click += buttonChangeStatus_Click;
            // 
            // labelMessage
            // 
            labelMessage.AutoSize = true;
            labelMessage.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelMessage.ForeColor = Color.Coral;
            labelMessage.Location = new Point(911, 127);
            labelMessage.Name = "labelMessage";
            labelMessage.Size = new Size(0, 40);
            labelMessage.TabIndex = 27;
            // 
            // buttonChangeRole
            // 
            buttonChangeRole.BackColor = Color.Coral;
            buttonChangeRole.FlatAppearance.BorderColor = Color.Black;
            buttonChangeRole.FlatAppearance.BorderSize = 2;
            buttonChangeRole.FlatStyle = FlatStyle.Flat;
            buttonChangeRole.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonChangeRole.Location = new Point(347, 47);
            buttonChangeRole.Name = "buttonChangeRole";
            buttonChangeRole.Size = new Size(200, 77);
            buttonChangeRole.TabIndex = 28;
            buttonChangeRole.Text = "CHANGE ROLE";
            buttonChangeRole.UseVisualStyleBackColor = false;
            buttonChangeRole.Click += buttonChangeRole_Click;
            // 
            // comboBoxRole
            // 
            comboBoxRole.BackColor = Color.LightSalmon;
            comboBoxRole.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRole.FlatStyle = FlatStyle.Flat;
            comboBoxRole.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Items.AddRange(new object[] { "User", "Employee", "Admin" });
            comboBoxRole.Location = new Point(588, 60);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(220, 48);
            comboBoxRole.TabIndex = 40;
            // 
            // AdminPanelMainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1872, 1100);
            Controls.Add(comboBoxRole);
            Controls.Add(buttonChangeRole);
            Controls.Add(labelMessage);
            Controls.Add(buttonChangeStatus);
            Controls.Add(textBoxFilter);
            Controls.Add(dataGridViewUsers);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminPanelMainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminPanelMainMenu";
            WindowState = FormWindowState.Maximized;
            Load += AdminPanelMainMenu_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button buttonStatistics;
        private Button buttonUsers;
        private PictureBox pictureBox1;
        private Button buttonBack;
        private DataGridView dataGridViewUsers;
        private Label labelAdminPanel;
        private TextBox textBoxFilter;
        private Button buttonChangeStatus;
        private Label labelMessage;
        private Button buttonChangeRole;
        private ComboBox comboBoxRole;
    }
}