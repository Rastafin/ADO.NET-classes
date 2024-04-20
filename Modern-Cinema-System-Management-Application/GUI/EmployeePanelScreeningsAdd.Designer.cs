namespace GUI
{
    partial class EmployeePanelScreeningsAdd
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
            buttonCancel = new Button();
            dateTimePickerDay = new DateTimePicker();
            maskedTextBoxHour = new MaskedTextBox();
            labelMovieDetails = new Label();
            comboBoxMovies = new ComboBox();
            textBoxMovie = new TextBox();
            buttonAddScreening = new Button();
            labelMessage = new Label();
            SuspendLayout();
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.LightSalmon;
            buttonCancel.FlatAppearance.BorderColor = Color.Black;
            buttonCancel.FlatAppearance.BorderSize = 2;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonCancel.Location = new Point(524, 546);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(157, 46);
            buttonCancel.TabIndex = 32;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // dateTimePickerDay
            // 
            dateTimePickerDay.CalendarForeColor = Color.White;
            dateTimePickerDay.CalendarMonthBackground = Color.Black;
            dateTimePickerDay.CalendarTitleBackColor = Color.Black;
            dateTimePickerDay.CalendarTitleForeColor = Color.White;
            dateTimePickerDay.CalendarTrailingForeColor = Color.White;
            dateTimePickerDay.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePickerDay.Format = DateTimePickerFormat.Custom;
            dateTimePickerDay.Location = new Point(162, 221);
            dateTimePickerDay.Name = "dateTimePickerDay";
            dateTimePickerDay.Size = new Size(265, 43);
            dateTimePickerDay.TabIndex = 33;
            dateTimePickerDay.ValueChanged += dateTimePickerDay_ValueChanged;
            // 
            // maskedTextBoxHour
            // 
            maskedTextBoxHour.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            maskedTextBoxHour.Location = new Point(433, 221);
            maskedTextBoxHour.Mask = "00:00";
            maskedTextBoxHour.Name = "maskedTextBoxHour";
            maskedTextBoxHour.Size = new Size(100, 43);
            maskedTextBoxHour.TabIndex = 34;
            maskedTextBoxHour.Text = "1000";
            maskedTextBoxHour.TextAlign = HorizontalAlignment.Center;
            maskedTextBoxHour.ValidatingType = typeof(DateTime);
            // 
            // labelMovieDetails
            // 
            labelMovieDetails.AutoSize = true;
            labelMovieDetails.Font = new Font("Segoe UI Semibold", 28F, FontStyle.Bold, GraphicsUnit.Point);
            labelMovieDetails.ForeColor = Color.Coral;
            labelMovieDetails.Location = new Point(162, 60);
            labelMovieDetails.Name = "labelMovieDetails";
            labelMovieDetails.Size = new Size(379, 51);
            labelMovieDetails.TabIndex = 63;
            labelMovieDetails.Text = "SCREENING DETAILS";
            labelMovieDetails.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboBoxMovies
            // 
            comboBoxMovies.BackColor = Color.LightSalmon;
            comboBoxMovies.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMovies.FlatStyle = FlatStyle.Flat;
            comboBoxMovies.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxMovies.FormattingEnabled = true;
            comboBoxMovies.Location = new Point(162, 346);
            comboBoxMovies.MaxDropDownItems = 3;
            comboBoxMovies.Name = "comboBoxMovies";
            comboBoxMovies.Size = new Size(371, 48);
            comboBoxMovies.TabIndex = 65;
            // 
            // textBoxMovie
            // 
            textBoxMovie.BackColor = Color.Coral;
            textBoxMovie.Enabled = false;
            textBoxMovie.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxMovie.Location = new Point(162, 303);
            textBoxMovie.Name = "textBoxMovie";
            textBoxMovie.PlaceholderText = "MOVIE";
            textBoxMovie.Size = new Size(371, 46);
            textBoxMovie.TabIndex = 64;
            textBoxMovie.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonAddScreening
            // 
            buttonAddScreening.BackColor = Color.Coral;
            buttonAddScreening.FlatAppearance.BorderColor = Color.Black;
            buttonAddScreening.FlatAppearance.BorderSize = 2;
            buttonAddScreening.FlatStyle = FlatStyle.Flat;
            buttonAddScreening.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonAddScreening.Location = new Point(259, 454);
            buttonAddScreening.Name = "buttonAddScreening";
            buttonAddScreening.Size = new Size(200, 77);
            buttonAddScreening.TabIndex = 66;
            buttonAddScreening.Text = "Add";
            buttonAddScreening.UseVisualStyleBackColor = false;
            buttonAddScreening.Click += buttonAddScreening_Click;
            // 
            // labelMessage
            // 
            labelMessage.AutoSize = true;
            labelMessage.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelMessage.ForeColor = Color.Coral;
            labelMessage.Location = new Point(171, 129);
            labelMessage.Name = "labelMessage";
            labelMessage.Size = new Size(0, 40);
            labelMessage.TabIndex = 67;
            // 
            // EmployeePanelScreeningsAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(14, 14, 14);
            ClientSize = new Size(714, 623);
            Controls.Add(labelMessage);
            Controls.Add(buttonAddScreening);
            Controls.Add(comboBoxMovies);
            Controls.Add(textBoxMovie);
            Controls.Add(labelMovieDetails);
            Controls.Add(maskedTextBoxHour);
            Controls.Add(dateTimePickerDay);
            Controls.Add(buttonCancel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EmployeePanelScreeningsAdd";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmployeePanelScreeningsAdd";
            Load += EmployeePanelScreeningsAdd_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCancel;
        private DateTimePicker dateTimePickerDay;
        private MaskedTextBox maskedTextBoxHour;
        private Label labelMovieDetails;
        private ComboBox comboBoxMovies;
        private TextBox textBoxMovie;
        private Button buttonAddScreening;
        private Label labelMessage;
    }
}