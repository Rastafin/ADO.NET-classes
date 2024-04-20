namespace GUI
{
    partial class UserMainMenu
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
            panel1 = new Panel();
            buttonAdminPanel = new Button();
            buttonEmployeePanel = new Button();
            buttonReservations = new Button();
            buttonWhatsOn = new Button();
            buttonProfile = new Button();
            pictureBox1 = new PictureBox();
            buttonLogout = new Button();
            dataGridViewMovies = new DataGridView();
            dateTimePicker1 = new DateTimePicker();
            labelMessage = new Label();
            buttonNewMessage = new Button();
            labelNewMessage = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMovies).BeginInit();
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
            panel1.TabIndex = 5;
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
            buttonEmployeePanel.Click += buttonEmployeePanel_Click_1;
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
            buttonReservations.Click += buttonReservations_Click;
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
            buttonLogout.Click += buttonExit_Click;
            // 
            // dataGridViewMovies
            // 
            dataGridViewMovies.AllowUserToAddRows = false;
            dataGridViewMovies.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMovies.BackgroundColor = Color.Black;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.Coral;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.Coral;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewMovies.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewMovies.ColumnHeadersHeight = 50;
            dataGridViewMovies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewMovies.EnableHeadersVisualStyles = false;
            dataGridViewMovies.GridColor = Color.Snow;
            dataGridViewMovies.Location = new Point(332, 180);
            dataGridViewMovies.Name = "dataGridViewMovies";
            dataGridViewMovies.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.Black;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.Coral;
            dataGridViewCellStyle4.SelectionBackColor = Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = Color.Coral;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridViewMovies.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewMovies.RowHeadersVisible = false;
            dataGridViewMovies.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewMovies.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewMovies.RowTemplate.DefaultCellStyle.BackColor = Color.Black;
            dataGridViewMovies.RowTemplate.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewMovies.RowTemplate.DefaultCellStyle.ForeColor = Color.Coral;
            dataGridViewMovies.RowTemplate.Height = 300;
            dataGridViewMovies.RowTemplate.ReadOnly = true;
            dataGridViewMovies.RowTemplate.Resizable = DataGridViewTriState.False;
            dataGridViewMovies.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewMovies.Size = new Size(1500, 950);
            dataGridViewMovies.TabIndex = 6;
            dataGridViewMovies.CellContentClick += dataGridViewMovies_CellContentClick;
            dataGridViewMovies.CellFormatting += dataGridViewMovies_CellFormatting;
            dataGridViewMovies.CellPainting += dataGridViewMovies_CellPainting;
            dataGridViewMovies.SelectionChanged += dataGridViewMovies_SelectionChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarForeColor = Color.White;
            dateTimePicker1.CalendarMonthBackground = Color.Black;
            dateTimePicker1.CalendarTitleBackColor = Color.Black;
            dateTimePicker1.CalendarTitleForeColor = Color.White;
            dateTimePicker1.CalendarTrailingForeColor = Color.White;
            dateTimePicker1.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(927, 36);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(265, 43);
            dateTimePicker1.TabIndex = 7;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // labelMessage
            // 
            labelMessage.AutoSize = true;
            labelMessage.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelMessage.ForeColor = Color.Coral;
            labelMessage.Location = new Point(788, 106);
            labelMessage.Name = "labelMessage";
            labelMessage.Size = new Size(0, 40);
            labelMessage.TabIndex = 8;
            // 
            // buttonNewMessage
            // 
            buttonNewMessage.BackgroundImage = Properties.Resources.Zrzut_ekranu_2024_02_02_142236;
            buttonNewMessage.BackgroundImageLayout = ImageLayout.Stretch;
            buttonNewMessage.FlatAppearance.BorderColor = Color.White;
            buttonNewMessage.FlatAppearance.BorderSize = 0;
            buttonNewMessage.FlatStyle = FlatStyle.Flat;
            buttonNewMessage.Location = new Point(361, 36);
            buttonNewMessage.Name = "buttonNewMessage";
            buttonNewMessage.Size = new Size(93, 100);
            buttonNewMessage.TabIndex = 9;
            buttonNewMessage.Text = "button1";
            buttonNewMessage.UseVisualStyleBackColor = true;
            buttonNewMessage.Click += button1_Click;
            // 
            // labelNewMessage
            // 
            labelNewMessage.AutoSize = true;
            labelNewMessage.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelNewMessage.ForeColor = Color.Red;
            labelNewMessage.Location = new Point(361, 116);
            labelNewMessage.Name = "labelNewMessage";
            labelNewMessage.Size = new Size(87, 15);
            labelNewMessage.TabIndex = 10;
            labelNewMessage.Text = "NEW MESSAGE";
            // 
            // UserMainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1872, 1100);
            Controls.Add(labelNewMessage);
            Controls.Add(buttonNewMessage);
            Controls.Add(labelMessage);
            Controls.Add(dateTimePicker1);
            Controls.Add(dataGridViewMovies);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserMainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserMainMenu";
            WindowState = FormWindowState.Maximized;
            Load += UserMainMenu_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMovies).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button buttonLogout;
        private PictureBox pictureBox1;
        private Button buttonProfile;
        private Button buttonWhatsOn;
        private Button buttonReservations;
        private Button buttonAdminPanel;
        private Button buttonEmployeePanel;
        private DataGridView dataGridViewMovies;
        private DateTimePicker dateTimePicker1;
        private Label labelMessage;
        private Button buttonNewMessage;
        private Label labelNewMessage;
    }
}