namespace GUI
{
    partial class EmployeePanelMovies
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
            panel1 = new Panel();
            buttonScreenings = new Button();
            labelEmployeePanel = new Label();
            buttonAddMovieForm = new Button();
            buttonUsersReservations = new Button();
            pictureBox1 = new PictureBox();
            buttonBack = new Button();
            pictureBoxMoviePicture = new PictureBox();
            buttonAddPicture = new Button();
            comboBoxCategory = new ComboBox();
            textBoxCategory = new TextBox();
            textBoxTitle = new TextBox();
            textBoxDirector = new TextBox();
            textBoxDuration = new TextBox();
            textBoxDescription = new TextBox();
            dateTimePickerReleaseDate = new DateTimePicker();
            textBoxReleaseDate = new TextBox();
            textBoxWithdrawalDate = new TextBox();
            dateTimePickerWithdrawalDate = new DateTimePicker();
            buttonAddMovie = new Button();
            labelMessage = new Label();
            panel2 = new Panel();
            labelMovieDetails = new Label();
            buttonCheckCurrentMovies = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMoviePicture).BeginInit();
            panel2.SuspendLayout();
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
            panel1.TabIndex = 9;
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
            buttonScreenings.Click += buttonScreenings_Click;
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
            // pictureBoxMoviePicture
            // 
            pictureBoxMoviePicture.BackColor = Color.FromArgb(14, 14, 14);
            pictureBoxMoviePicture.Location = new Point(333, 247);
            pictureBoxMoviePicture.Name = "pictureBoxMoviePicture";
            pictureBoxMoviePicture.Size = new Size(402, 542);
            pictureBoxMoviePicture.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxMoviePicture.TabIndex = 10;
            pictureBoxMoviePicture.TabStop = false;
            // 
            // buttonAddPicture
            // 
            buttonAddPicture.BackColor = Color.Coral;
            buttonAddPicture.FlatAppearance.BorderColor = Color.Black;
            buttonAddPicture.FlatAppearance.BorderSize = 2;
            buttonAddPicture.FlatStyle = FlatStyle.Flat;
            buttonAddPicture.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonAddPicture.Location = new Point(441, 864);
            buttonAddPicture.Name = "buttonAddPicture";
            buttonAddPicture.Size = new Size(194, 45);
            buttonAddPicture.TabIndex = 31;
            buttonAddPicture.Text = "ADD PICTURE";
            buttonAddPicture.UseVisualStyleBackColor = false;
            buttonAddPicture.Click += buttonAdd_Click;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.BackColor = Color.LightSalmon;
            comboBoxCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCategory.FlatStyle = FlatStyle.Flat;
            comboBoxCategory.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Items.AddRange(new object[] { "Comedy", "Action", "Adventure", "Drama", "Horror", "Thriller" });
            comboBoxCategory.Location = new Point(531, 107);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(431, 48);
            comboBoxCategory.TabIndex = 41;
            // 
            // textBoxCategory
            // 
            textBoxCategory.BackColor = Color.Coral;
            textBoxCategory.Enabled = false;
            textBoxCategory.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxCategory.Location = new Point(531, 64);
            textBoxCategory.Name = "textBoxCategory";
            textBoxCategory.PlaceholderText = "CATEGORY";
            textBoxCategory.Size = new Size(431, 46);
            textBoxCategory.TabIndex = 40;
            textBoxCategory.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxTitle
            // 
            textBoxTitle.BackColor = Color.Coral;
            textBoxTitle.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxTitle.Location = new Point(20, 89);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.PlaceholderText = "TITLE";
            textBoxTitle.Size = new Size(431, 46);
            textBoxTitle.TabIndex = 49;
            textBoxTitle.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxDirector
            // 
            textBoxDirector.BackColor = Color.Coral;
            textBoxDirector.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxDirector.Location = new Point(20, 246);
            textBoxDirector.Name = "textBoxDirector";
            textBoxDirector.PlaceholderText = "DIRECTOR";
            textBoxDirector.Size = new Size(431, 46);
            textBoxDirector.TabIndex = 51;
            textBoxDirector.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxDuration
            // 
            textBoxDuration.BackColor = Color.Coral;
            textBoxDuration.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxDuration.Location = new Point(20, 401);
            textBoxDuration.Name = "textBoxDuration";
            textBoxDuration.PlaceholderText = "DURATION (MIN)";
            textBoxDuration.Size = new Size(431, 46);
            textBoxDuration.TabIndex = 53;
            textBoxDuration.TextAlign = HorizontalAlignment.Center;
            textBoxDuration.KeyPress += textBoxDuration_KeyPress;
            // 
            // textBoxDescription
            // 
            textBoxDescription.BackColor = Color.Coral;
            textBoxDescription.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxDescription.Location = new Point(20, 553);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.PlaceholderText = "DESCRIPTION";
            textBoxDescription.Size = new Size(431, 46);
            textBoxDescription.TabIndex = 54;
            textBoxDescription.TextAlign = HorizontalAlignment.Center;
            // 
            // dateTimePickerReleaseDate
            // 
            dateTimePickerReleaseDate.CalendarForeColor = Color.White;
            dateTimePickerReleaseDate.CalendarMonthBackground = Color.Black;
            dateTimePickerReleaseDate.CalendarTitleBackColor = Color.Black;
            dateTimePickerReleaseDate.CalendarTitleForeColor = Color.White;
            dateTimePickerReleaseDate.CalendarTrailingForeColor = Color.White;
            dateTimePickerReleaseDate.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePickerReleaseDate.Format = DateTimePickerFormat.Custom;
            dateTimePickerReleaseDate.Location = new Point(531, 264);
            dateTimePickerReleaseDate.Name = "dateTimePickerReleaseDate";
            dateTimePickerReleaseDate.Size = new Size(431, 43);
            dateTimePickerReleaseDate.TabIndex = 55;
            // 
            // textBoxReleaseDate
            // 
            textBoxReleaseDate.BackColor = Color.Coral;
            textBoxReleaseDate.Enabled = false;
            textBoxReleaseDate.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxReleaseDate.Location = new Point(531, 221);
            textBoxReleaseDate.Name = "textBoxReleaseDate";
            textBoxReleaseDate.PlaceholderText = "RELEASE DATE";
            textBoxReleaseDate.Size = new Size(431, 46);
            textBoxReleaseDate.TabIndex = 56;
            textBoxReleaseDate.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxWithdrawalDate
            // 
            textBoxWithdrawalDate.BackColor = Color.Coral;
            textBoxWithdrawalDate.Enabled = false;
            textBoxWithdrawalDate.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxWithdrawalDate.Location = new Point(531, 376);
            textBoxWithdrawalDate.Name = "textBoxWithdrawalDate";
            textBoxWithdrawalDate.PlaceholderText = "WITHDRAWAL DATE";
            textBoxWithdrawalDate.Size = new Size(431, 46);
            textBoxWithdrawalDate.TabIndex = 57;
            textBoxWithdrawalDate.TextAlign = HorizontalAlignment.Center;
            // 
            // dateTimePickerWithdrawalDate
            // 
            dateTimePickerWithdrawalDate.CalendarForeColor = Color.White;
            dateTimePickerWithdrawalDate.CalendarMonthBackground = Color.Black;
            dateTimePickerWithdrawalDate.CalendarTitleBackColor = Color.Black;
            dateTimePickerWithdrawalDate.CalendarTitleForeColor = Color.White;
            dateTimePickerWithdrawalDate.CalendarTrailingForeColor = Color.White;
            dateTimePickerWithdrawalDate.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePickerWithdrawalDate.Format = DateTimePickerFormat.Custom;
            dateTimePickerWithdrawalDate.Location = new Point(531, 418);
            dateTimePickerWithdrawalDate.Name = "dateTimePickerWithdrawalDate";
            dateTimePickerWithdrawalDate.Size = new Size(431, 43);
            dateTimePickerWithdrawalDate.TabIndex = 58;
            // 
            // buttonAddMovie
            // 
            buttonAddMovie.BackColor = Color.Coral;
            buttonAddMovie.FlatAppearance.BorderColor = Color.Black;
            buttonAddMovie.FlatAppearance.BorderSize = 2;
            buttonAddMovie.FlatStyle = FlatStyle.Flat;
            buttonAddMovie.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonAddMovie.Location = new Point(1202, 1015);
            buttonAddMovie.Name = "buttonAddMovie";
            buttonAddMovie.Size = new Size(226, 73);
            buttonAddMovie.TabIndex = 59;
            buttonAddMovie.Text = "ADD MOVIE";
            buttonAddMovie.UseVisualStyleBackColor = false;
            buttonAddMovie.Click += buttonAddMovie_Click;
            // 
            // labelMessage
            // 
            labelMessage.AutoSize = true;
            labelMessage.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelMessage.ForeColor = Color.Red;
            labelMessage.Location = new Point(1114, 890);
            labelMessage.Name = "labelMessage";
            labelMessage.Size = new Size(0, 40);
            labelMessage.TabIndex = 60;
            labelMessage.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(14, 14, 14);
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(textBoxTitle);
            panel2.Controls.Add(textBoxCategory);
            panel2.Controls.Add(comboBoxCategory);
            panel2.Controls.Add(dateTimePickerWithdrawalDate);
            panel2.Controls.Add(textBoxDirector);
            panel2.Controls.Add(textBoxWithdrawalDate);
            panel2.Controls.Add(textBoxDuration);
            panel2.Controls.Add(textBoxReleaseDate);
            panel2.Controls.Add(textBoxDescription);
            panel2.Controls.Add(dateTimePickerReleaseDate);
            panel2.Location = new Point(809, 156);
            panel2.Name = "panel2";
            panel2.Size = new Size(1005, 713);
            panel2.TabIndex = 61;
            // 
            // labelMovieDetails
            // 
            labelMovieDetails.AutoSize = true;
            labelMovieDetails.Font = new Font("Segoe UI Semibold", 28F, FontStyle.Bold, GraphicsUnit.Point);
            labelMovieDetails.ForeColor = Color.Coral;
            labelMovieDetails.Location = new Point(1158, 53);
            labelMovieDetails.Name = "labelMovieDetails";
            labelMovieDetails.Size = new Size(293, 51);
            labelMovieDetails.TabIndex = 62;
            labelMovieDetails.Text = "MOVIE DETAILS";
            labelMovieDetails.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // buttonCheckCurrentMovies
            // 
            buttonCheckCurrentMovies.BackColor = Color.Coral;
            buttonCheckCurrentMovies.FlatAppearance.BorderColor = Color.Black;
            buttonCheckCurrentMovies.FlatAppearance.BorderSize = 2;
            buttonCheckCurrentMovies.FlatStyle = FlatStyle.Flat;
            buttonCheckCurrentMovies.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonCheckCurrentMovies.Location = new Point(1634, 1010);
            buttonCheckCurrentMovies.Name = "buttonCheckCurrentMovies";
            buttonCheckCurrentMovies.Size = new Size(226, 78);
            buttonCheckCurrentMovies.TabIndex = 63;
            buttonCheckCurrentMovies.Text = "CHECK CURRENT MOVIES";
            buttonCheckCurrentMovies.UseVisualStyleBackColor = false;
            buttonCheckCurrentMovies.Click += buttonCheckCurrentMovies_Click;
            // 
            // EmployeePanelMovies
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1872, 1100);
            Controls.Add(buttonCheckCurrentMovies);
            Controls.Add(labelMovieDetails);
            Controls.Add(panel2);
            Controls.Add(labelMessage);
            Controls.Add(buttonAddMovie);
            Controls.Add(buttonAddPicture);
            Controls.Add(pictureBoxMoviePicture);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EmployeePanelMovies";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmployeePanelMovies";
            WindowState = FormWindowState.Maximized;
            Load += EmployeePanelMovies_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMoviePicture).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
        private PictureBox pictureBoxMoviePicture;
        private Button buttonAddPicture;
        private ComboBox comboBoxCategory;
        private TextBox textBoxCategory;
        private TextBox textBoxTitle;
        private TextBox textBoxDirector;
        private TextBox textBoxDuration;
        private TextBox textBoxDescription;
        private DateTimePicker dateTimePickerReleaseDate;
        private TextBox textBoxReleaseDate;
        private TextBox textBoxWithdrawalDate;
        private DateTimePicker dateTimePickerWithdrawalDate;
        private Button buttonAddMovie;
        private Label labelMessage;
        private Panel panel2;
        private Label labelMovieDetails;
        private Button buttonCheckCurrentMovies;
    }
}