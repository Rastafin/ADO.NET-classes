namespace GUI
{
    partial class EmployeePanelScreenings
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            buttonScreenings = new Button();
            labelEmployeePanel = new Label();
            buttonAddMovieForm = new Button();
            buttonUsersReservations = new Button();
            pictureBox1 = new PictureBox();
            buttonBack = new Button();
            dataGridViewScreenings = new DataGridView();
            textBoxFilter = new TextBox();
            labelMessage = new Label();
            buttonDeleteScreening = new Button();
            buttonAddNewScreening = new Button();
            labelMessageConfirmation = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewScreenings).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.Coral;
            panel1.Controls.Add(buttonScreenings);
            panel1.Controls.Add(labelEmployeePanel);
            panel1.Controls.Add(buttonAddMovieForm);
            panel1.Controls.Add(buttonUsersReservations);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(buttonBack);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(230, 1215);
            panel1.TabIndex = 10;
            // 
            // buttonScreenings
            // 
            buttonScreenings.BackColor = Color.Coral;
            buttonScreenings.FlatAppearance.BorderColor = Color.Black;
            buttonScreenings.FlatAppearance.BorderSize = 2;
            buttonScreenings.FlatStyle = FlatStyle.Flat;
            buttonScreenings.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonScreenings.Location = new Point(12, 454);
            buttonScreenings.Name = "buttonScreenings";
            buttonScreenings.Size = new Size(200, 56);
            buttonScreenings.TabIndex = 11;
            buttonScreenings.Text = "SCREENINGS";
            buttonScreenings.UseVisualStyleBackColor = false;
            // 
            // labelEmployeePanel
            // 
            labelEmployeePanel.AutoSize = true;
            labelEmployeePanel.BackColor = Color.Coral;
            labelEmployeePanel.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelEmployeePanel.ForeColor = Color.Black;
            labelEmployeePanel.Location = new Point(35, 130);
            labelEmployeePanel.Name = "labelEmployeePanel";
            labelEmployeePanel.Size = new Size(158, 80);
            labelEmployeePanel.TabIndex = 9;
            labelEmployeePanel.Text = "EMPLOYEE\r\nPANEL";
            labelEmployeePanel.TextAlign = ContentAlignment.TopCenter;
            // 
            // buttonAddMovieForm
            // 
            buttonAddMovieForm.BackColor = Color.Coral;
            buttonAddMovieForm.FlatAppearance.BorderColor = Color.Black;
            buttonAddMovieForm.FlatAppearance.BorderSize = 2;
            buttonAddMovieForm.FlatStyle = FlatStyle.Flat;
            buttonAddMovieForm.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonAddMovieForm.Location = new Point(12, 354);
            buttonAddMovieForm.Name = "buttonAddMovieForm";
            buttonAddMovieForm.Size = new Size(200, 56);
            buttonAddMovieForm.TabIndex = 10;
            buttonAddMovieForm.Text = "ADD MOVIE";
            buttonAddMovieForm.UseVisualStyleBackColor = false;
            buttonAddMovieForm.Click += buttonAddMovieForm_Click;
            // 
            // buttonUsersReservations
            // 
            buttonUsersReservations.BackColor = Color.Coral;
            buttonUsersReservations.FlatAppearance.BorderColor = Color.Black;
            buttonUsersReservations.FlatAppearance.BorderSize = 2;
            buttonUsersReservations.FlatStyle = FlatStyle.Flat;
            buttonUsersReservations.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonUsersReservations.Location = new Point(12, 227);
            buttonUsersReservations.Name = "buttonUsersReservations";
            buttonUsersReservations.Size = new Size(200, 86);
            buttonUsersReservations.TabIndex = 9;
            buttonUsersReservations.Text = "USERS\r\nRESERVATIONS";
            buttonUsersReservations.UseVisualStyleBackColor = false;
            buttonUsersReservations.Click += buttonUsersReservations_Click;
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
            // dataGridViewScreenings
            // 
            dataGridViewScreenings.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewScreenings.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewScreenings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewScreenings.BackgroundColor = Color.Black;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.Coral;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.Coral;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewScreenings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewScreenings.ColumnHeadersHeight = 50;
            dataGridViewScreenings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewScreenings.EnableHeadersVisualStyles = false;
            dataGridViewScreenings.GridColor = Color.Snow;
            dataGridViewScreenings.Location = new Point(330, 249);
            dataGridViewScreenings.MultiSelect = false;
            dataGridViewScreenings.Name = "dataGridViewScreenings";
            dataGridViewScreenings.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Black;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Coral;
            dataGridViewCellStyle3.SelectionBackColor = Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = Color.Coral;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewScreenings.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewScreenings.RowHeadersVisible = false;
            dataGridViewScreenings.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.GrayText;
            dataGridViewScreenings.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewScreenings.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewScreenings.RowTemplate.DefaultCellStyle.BackColor = Color.Black;
            dataGridViewScreenings.RowTemplate.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewScreenings.RowTemplate.DefaultCellStyle.ForeColor = Color.Coral;
            dataGridViewScreenings.RowTemplate.Height = 100;
            dataGridViewScreenings.RowTemplate.ReadOnly = true;
            dataGridViewScreenings.RowTemplate.Resizable = DataGridViewTriState.False;
            dataGridViewScreenings.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewScreenings.Size = new Size(1500, 950);
            dataGridViewScreenings.TabIndex = 11;
            // 
            // textBoxFilter
            // 
            textBoxFilter.BackColor = Color.Coral;
            textBoxFilter.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxFilter.Location = new Point(868, 91);
            textBoxFilter.Name = "textBoxFilter";
            textBoxFilter.PlaceholderText = "FILTER";
            textBoxFilter.Size = new Size(431, 46);
            textBoxFilter.TabIndex = 31;
            textBoxFilter.TextAlign = HorizontalAlignment.Center;
            textBoxFilter.TextChanged += textBoxFilter_TextChanged;
            // 
            // labelMessage
            // 
            labelMessage.AutoSize = true;
            labelMessage.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelMessage.ForeColor = Color.Coral;
            labelMessage.Location = new Point(909, 150);
            labelMessage.Name = "labelMessage";
            labelMessage.Size = new Size(0, 40);
            labelMessage.TabIndex = 30;
            // 
            // buttonDeleteScreening
            // 
            buttonDeleteScreening.BackColor = Color.Coral;
            buttonDeleteScreening.FlatAppearance.BorderColor = Color.Black;
            buttonDeleteScreening.FlatAppearance.BorderSize = 2;
            buttonDeleteScreening.FlatStyle = FlatStyle.Flat;
            buttonDeleteScreening.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonDeleteScreening.Location = new Point(574, 79);
            buttonDeleteScreening.Name = "buttonDeleteScreening";
            buttonDeleteScreening.Size = new Size(200, 77);
            buttonDeleteScreening.TabIndex = 32;
            buttonDeleteScreening.Text = "DELETE\r\nSCREENING";
            buttonDeleteScreening.UseVisualStyleBackColor = false;
            buttonDeleteScreening.Click += buttonDeleteScreening_Click;
            // 
            // buttonAddNewScreening
            // 
            buttonAddNewScreening.BackColor = Color.Coral;
            buttonAddNewScreening.FlatAppearance.BorderColor = Color.Black;
            buttonAddNewScreening.FlatAppearance.BorderSize = 2;
            buttonAddNewScreening.FlatStyle = FlatStyle.Flat;
            buttonAddNewScreening.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonAddNewScreening.Location = new Point(1399, 78);
            buttonAddNewScreening.Name = "buttonAddNewScreening";
            buttonAddNewScreening.Size = new Size(200, 77);
            buttonAddNewScreening.TabIndex = 33;
            buttonAddNewScreening.Text = "ADD NEW\r\nSCREENING";
            buttonAddNewScreening.UseVisualStyleBackColor = false;
            buttonAddNewScreening.Click += buttonAddNewScreening_Click;
            // 
            // labelMessageConfirmation
            // 
            labelMessageConfirmation.AutoSize = true;
            labelMessageConfirmation.Font = new Font("Segoe UI Semibold", 28F, FontStyle.Bold, GraphicsUnit.Point);
            labelMessageConfirmation.ForeColor = Color.Red;
            labelMessageConfirmation.Location = new Point(803, 9);
            labelMessageConfirmation.Name = "labelMessageConfirmation";
            labelMessageConfirmation.Size = new Size(0, 51);
            labelMessageConfirmation.TabIndex = 34;
            // 
            // EmployeePanelScreenings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1872, 1100);
            Controls.Add(labelMessageConfirmation);
            Controls.Add(buttonAddNewScreening);
            Controls.Add(buttonDeleteScreening);
            Controls.Add(textBoxFilter);
            Controls.Add(labelMessage);
            Controls.Add(dataGridViewScreenings);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EmployeePanelScreenings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmployeePanelScreenings";
            WindowState = FormWindowState.Maximized;
            Load += EmployeePanelScreenings_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewScreenings).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button buttonScreenings;
        private Label labelEmployeePanel;
        private Button buttonAddMovieForm;
        private Button buttonUsersReservations;
        private PictureBox pictureBox1;
        private Button buttonBack;
        private DataGridView dataGridViewScreenings;
        private TextBox textBoxFilter;
        private Label labelMessage;
        private Button buttonDeleteScreening;
        private Button buttonAddNewScreening;
        private Label labelMessageConfirmation;
    }
}