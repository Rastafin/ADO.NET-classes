namespace GUI
{
    partial class UserReservation
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
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            panel1 = new Panel();
            buttonAdminPanel = new Button();
            buttonEmployeePanel = new Button();
            buttonReservations = new Button();
            buttonWhatsOn = new Button();
            buttonProfile = new Button();
            pictureBox1 = new PictureBox();
            buttonLogout = new Button();
            dataGridViewReservations = new DataGridView();
            labelMessage = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReservations).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.Coral;
            panel1.Controls.Add(buttonAdminPanel);
            panel1.Controls.Add(buttonEmployeePanel);
            panel1.Controls.Add(buttonReservations);
            panel1.Controls.Add(buttonWhatsOn);
            panel1.Controls.Add(buttonProfile);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(buttonLogout);
            panel1.Location = new Point(0, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(230, 1215);
            panel1.TabIndex = 6;
            // 
            // buttonAdminPanel
            // 
            buttonAdminPanel.BackColor = Color.Coral;
            buttonAdminPanel.FlatAppearance.BorderColor = Color.Black;
            buttonAdminPanel.FlatAppearance.BorderSize = 2;
            buttonAdminPanel.FlatStyle = FlatStyle.Flat;
            buttonAdminPanel.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonAdminPanel.Location = new Point(12, 559);
            buttonAdminPanel.Name = "buttonAdminPanel";
            buttonAdminPanel.Size = new Size(200, 77);
            buttonAdminPanel.TabIndex = 13;
            buttonAdminPanel.Text = "ADMIN PANEL";
            buttonAdminPanel.UseVisualStyleBackColor = false;
            buttonAdminPanel.Click += buttonAdminPanel_Click;
            // 
            // buttonEmployeePanel
            // 
            buttonEmployeePanel.BackColor = Color.Coral;
            buttonEmployeePanel.FlatAppearance.BorderColor = Color.Black;
            buttonEmployeePanel.FlatAppearance.BorderSize = 2;
            buttonEmployeePanel.FlatStyle = FlatStyle.Flat;
            buttonEmployeePanel.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonEmployeePanel.Location = new Point(12, 431);
            buttonEmployeePanel.Name = "buttonEmployeePanel";
            buttonEmployeePanel.Size = new Size(200, 86);
            buttonEmployeePanel.TabIndex = 12;
            buttonEmployeePanel.Text = "EMPLOYEE PANEL";
            buttonEmployeePanel.UseVisualStyleBackColor = false;
            buttonEmployeePanel.Click += buttonEmployeePanel_Click;
            // 
            // buttonReservations
            // 
            buttonReservations.BackColor = Color.Coral;
            buttonReservations.FlatAppearance.BorderColor = Color.Black;
            buttonReservations.FlatAppearance.BorderSize = 2;
            buttonReservations.FlatStyle = FlatStyle.Flat;
            buttonReservations.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonReservations.Location = new Point(12, 327);
            buttonReservations.Name = "buttonReservations";
            buttonReservations.Size = new Size(200, 56);
            buttonReservations.TabIndex = 11;
            buttonReservations.Text = "RESERVATIONS";
            buttonReservations.UseVisualStyleBackColor = false;
            // 
            // buttonWhatsOn
            // 
            buttonWhatsOn.BackColor = Color.Coral;
            buttonWhatsOn.FlatAppearance.BorderColor = Color.Black;
            buttonWhatsOn.FlatAppearance.BorderSize = 2;
            buttonWhatsOn.FlatStyle = FlatStyle.Flat;
            buttonWhatsOn.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonWhatsOn.Location = new Point(12, 227);
            buttonWhatsOn.Name = "buttonWhatsOn";
            buttonWhatsOn.Size = new Size(200, 56);
            buttonWhatsOn.TabIndex = 9;
            buttonWhatsOn.Text = "WHAT'S ON";
            buttonWhatsOn.UseVisualStyleBackColor = false;
            buttonWhatsOn.Click += buttonWhatsOn_Click;
            // 
            // buttonProfile
            // 
            buttonProfile.BackColor = Color.Coral;
            buttonProfile.FlatAppearance.BorderColor = Color.Black;
            buttonProfile.FlatAppearance.BorderSize = 2;
            buttonProfile.FlatStyle = FlatStyle.Flat;
            buttonProfile.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonProfile.Location = new Point(12, 955);
            buttonProfile.Name = "buttonProfile";
            buttonProfile.Size = new Size(200, 56);
            buttonProfile.TabIndex = 8;
            buttonProfile.Text = "YOUR PROFILE";
            buttonProfile.UseVisualStyleBackColor = false;
            buttonProfile.Click += buttonProfile_Click;
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
            // 
            // buttonLogout
            // 
            buttonLogout.BackColor = Color.Coral;
            buttonLogout.FlatAppearance.BorderColor = Color.Black;
            buttonLogout.FlatAppearance.BorderSize = 2;
            buttonLogout.FlatStyle = FlatStyle.Flat;
            buttonLogout.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonLogout.Location = new Point(12, 1044);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(200, 56);
            buttonLogout.TabIndex = 6;
            buttonLogout.Text = "LOGOUT";
            buttonLogout.UseVisualStyleBackColor = false;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // dataGridViewReservations
            // 
            dataGridViewReservations.AllowUserToAddRows = false;
            dataGridViewReservations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewReservations.BackgroundColor = Color.Black;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = Color.Coral;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = Color.Coral;
            dataGridViewCellStyle9.SelectionForeColor = Color.Black;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dataGridViewReservations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewReservations.ColumnHeadersHeight = 50;
            dataGridViewReservations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewReservations.EnableHeadersVisualStyles = false;
            dataGridViewReservations.GridColor = Color.Snow;
            dataGridViewReservations.Location = new Point(332, 180);
            dataGridViewReservations.Name = "dataGridViewReservations";
            dataGridViewReservations.ReadOnly = true;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.Black;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = Color.Coral;
            dataGridViewCellStyle10.SelectionBackColor = Color.Black;
            dataGridViewCellStyle10.SelectionForeColor = Color.Coral;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dataGridViewReservations.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewReservations.RowHeadersVisible = false;
            dataGridViewReservations.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewReservations.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewReservations.RowTemplate.DefaultCellStyle.BackColor = Color.Black;
            dataGridViewReservations.RowTemplate.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewReservations.RowTemplate.DefaultCellStyle.ForeColor = Color.Coral;
            dataGridViewReservations.RowTemplate.Height = 300;
            dataGridViewReservations.RowTemplate.ReadOnly = true;
            dataGridViewReservations.RowTemplate.Resizable = DataGridViewTriState.False;
            dataGridViewReservations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewReservations.Size = new Size(1500, 950);
            dataGridViewReservations.TabIndex = 7;
            dataGridViewReservations.CellContentClick += dataGridViewReservations_CellContentClick;
            dataGridViewReservations.CellFormatting += dataGridViewReservations_CellFormatting;
            dataGridViewReservations.SelectionChanged += dataGridViewReservations_SelectionChanged;
            // 
            // labelMessage
            // 
            labelMessage.AutoSize = true;
            labelMessage.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelMessage.ForeColor = Color.Coral;
            labelMessage.Location = new Point(797, 78);
            labelMessage.Name = "labelMessage";
            labelMessage.Size = new Size(0, 40);
            labelMessage.TabIndex = 9;
            // 
            // UserReservation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1872, 1100);
            Controls.Add(labelMessage);
            Controls.Add(dataGridViewReservations);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserReservation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserReservation";
            WindowState = FormWindowState.Maximized;
            Load += UserReservation_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReservations).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button buttonAdminPanel;
        private Button buttonEmployeePanel;
        private Button buttonReservations;
        private Button buttonWhatsOn;
        private Button buttonProfile;
        private PictureBox pictureBox1;
        private Button buttonLogout;
        private DataGridView dataGridViewReservations;
        private Label labelMessage;
    }
}