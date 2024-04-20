namespace GUI
{
    partial class UserProfileForm
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
            buttonAdminPanel = new Button();
            buttonEmployeePanel = new Button();
            buttonReservations = new Button();
            buttonWhatsOn = new Button();
            buttonProfile = new Button();
            pictureBox1 = new PictureBox();
            buttonLogout = new Button();
            comboBoxSex = new ComboBox();
            maskedTextBoxBirthday = new MaskedTextBox();
            maskedTextBoxZipCode = new MaskedTextBox();
            textBoxZipCode = new TextBox();
            textBoxHouseNumber = new TextBox();
            textBoxStreet = new TextBox();
            textBoxCity = new TextBox();
            textBoxCountry = new TextBox();
            textBoxPhoneNumber = new TextBox();
            textBoxSex = new TextBox();
            textBoxBirthday = new TextBox();
            textBoxLastname = new TextBox();
            textBoxName = new TextBox();
            textBoxEmail = new TextBox();
            textBoxLogin = new TextBox();
            buttonSaveChanges = new Button();
            textBoxHouseNumberTemplate = new TextBox();
            textBoxStreetTemplate = new TextBox();
            textBoxCityTemplate = new TextBox();
            textBoxCountryTemplate = new TextBox();
            textBoxNameTemplate = new TextBox();
            textBoxLastnameTemplate = new TextBox();
            textBoxPhoneNumberTemplate = new TextBox();
            textBoxLoginTemplate = new TextBox();
            textBoxEmailTemplate = new TextBox();
            labelMessage = new Label();
            labelMessageSuccess = new Label();
            buttonChangePassword = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(230, 1215);
            panel1.TabIndex = 7;
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
            // comboBoxSex
            // 
            comboBoxSex.BackColor = Color.LightSalmon;
            comboBoxSex.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSex.FlatStyle = FlatStyle.Flat;
            comboBoxSex.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxSex.FormattingEnabled = true;
            comboBoxSex.Items.AddRange(new object[] { "Man", "Woman", "Other" });
            comboBoxSex.Location = new Point(856, 617);
            comboBoxSex.Name = "comboBoxSex";
            comboBoxSex.Size = new Size(431, 48);
            comboBoxSex.TabIndex = 39;
            // 
            // maskedTextBoxBirthday
            // 
            maskedTextBoxBirthday.BackColor = Color.Coral;
            maskedTextBoxBirthday.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            maskedTextBoxBirthday.Location = new Point(856, 498);
            maskedTextBoxBirthday.Mask = "00/00/0000";
            maskedTextBoxBirthday.Name = "maskedTextBoxBirthday";
            maskedTextBoxBirthday.Size = new Size(431, 46);
            maskedTextBoxBirthday.TabIndex = 38;
            maskedTextBoxBirthday.TextAlign = HorizontalAlignment.Center;
            maskedTextBoxBirthday.ValidatingType = typeof(DateTime);
            // 
            // maskedTextBoxZipCode
            // 
            maskedTextBoxZipCode.BackColor = Color.Coral;
            maskedTextBoxZipCode.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            maskedTextBoxZipCode.Location = new Point(1408, 739);
            maskedTextBoxZipCode.Mask = "00-999";
            maskedTextBoxZipCode.Name = "maskedTextBoxZipCode";
            maskedTextBoxZipCode.Size = new Size(431, 46);
            maskedTextBoxZipCode.TabIndex = 37;
            maskedTextBoxZipCode.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxZipCode
            // 
            textBoxZipCode.BackColor = Color.Coral;
            textBoxZipCode.Enabled = false;
            textBoxZipCode.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxZipCode.Location = new Point(1408, 698);
            textBoxZipCode.Name = "textBoxZipCode";
            textBoxZipCode.PlaceholderText = "ZIP CODE";
            textBoxZipCode.ReadOnly = true;
            textBoxZipCode.Size = new Size(431, 46);
            textBoxZipCode.TabIndex = 36;
            textBoxZipCode.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxHouseNumber
            // 
            textBoxHouseNumber.BackColor = Color.Coral;
            textBoxHouseNumber.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxHouseNumber.Location = new Point(1408, 617);
            textBoxHouseNumber.Name = "textBoxHouseNumber";
            textBoxHouseNumber.PlaceholderText = "HOUSE NUMBER";
            textBoxHouseNumber.Size = new Size(431, 46);
            textBoxHouseNumber.TabIndex = 35;
            textBoxHouseNumber.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxStreet
            // 
            textBoxStreet.BackColor = Color.Coral;
            textBoxStreet.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxStreet.Location = new Point(1408, 502);
            textBoxStreet.Name = "textBoxStreet";
            textBoxStreet.PlaceholderText = "STREET";
            textBoxStreet.Size = new Size(431, 46);
            textBoxStreet.TabIndex = 34;
            textBoxStreet.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxCity
            // 
            textBoxCity.BackColor = Color.Coral;
            textBoxCity.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxCity.Location = new Point(1408, 387);
            textBoxCity.Name = "textBoxCity";
            textBoxCity.PlaceholderText = "CITY";
            textBoxCity.Size = new Size(431, 46);
            textBoxCity.TabIndex = 33;
            textBoxCity.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxCountry
            // 
            textBoxCountry.BackColor = Color.Coral;
            textBoxCountry.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxCountry.Location = new Point(1408, 271);
            textBoxCountry.Name = "textBoxCountry";
            textBoxCountry.PlaceholderText = "COUNTRY";
            textBoxCountry.Size = new Size(431, 46);
            textBoxCountry.TabIndex = 28;
            textBoxCountry.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxPhoneNumber
            // 
            textBoxPhoneNumber.BackColor = Color.Coral;
            textBoxPhoneNumber.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxPhoneNumber.Location = new Point(856, 743);
            textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            textBoxPhoneNumber.PlaceholderText = "PHONE NUMBER";
            textBoxPhoneNumber.Size = new Size(431, 46);
            textBoxPhoneNumber.TabIndex = 32;
            textBoxPhoneNumber.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxSex
            // 
            textBoxSex.BackColor = Color.Coral;
            textBoxSex.Enabled = false;
            textBoxSex.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxSex.Location = new Point(856, 574);
            textBoxSex.Name = "textBoxSex";
            textBoxSex.PlaceholderText = "SEX";
            textBoxSex.Size = new Size(431, 46);
            textBoxSex.TabIndex = 31;
            textBoxSex.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxBirthday
            // 
            textBoxBirthday.BackColor = Color.Coral;
            textBoxBirthday.Enabled = false;
            textBoxBirthday.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxBirthday.Location = new Point(856, 456);
            textBoxBirthday.Name = "textBoxBirthday";
            textBoxBirthday.PlaceholderText = "BIRTHDAY";
            textBoxBirthday.Size = new Size(431, 46);
            textBoxBirthday.TabIndex = 30;
            textBoxBirthday.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxLastname
            // 
            textBoxLastname.BackColor = Color.Coral;
            textBoxLastname.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxLastname.Location = new Point(856, 384);
            textBoxLastname.Name = "textBoxLastname";
            textBoxLastname.PlaceholderText = "LASTNAME";
            textBoxLastname.Size = new Size(431, 46);
            textBoxLastname.TabIndex = 29;
            textBoxLastname.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxName
            // 
            textBoxName.BackColor = Color.Coral;
            textBoxName.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxName.Location = new Point(856, 274);
            textBoxName.Name = "textBoxName";
            textBoxName.PlaceholderText = "NAME";
            textBoxName.Size = new Size(431, 46);
            textBoxName.TabIndex = 27;
            textBoxName.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxEmail
            // 
            textBoxEmail.BackColor = Color.Coral;
            textBoxEmail.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxEmail.Location = new Point(294, 387);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.PlaceholderText = "EMAIL";
            textBoxEmail.Size = new Size(431, 46);
            textBoxEmail.TabIndex = 26;
            textBoxEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxLogin
            // 
            textBoxLogin.BackColor = Color.Coral;
            textBoxLogin.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxLogin.Location = new Point(294, 274);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.PlaceholderText = "LOGIN";
            textBoxLogin.Size = new Size(431, 46);
            textBoxLogin.TabIndex = 24;
            textBoxLogin.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonSaveChanges
            // 
            buttonSaveChanges.BackColor = Color.Coral;
            buttonSaveChanges.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonSaveChanges.Location = new Point(971, 890);
            buttonSaveChanges.Name = "buttonSaveChanges";
            buttonSaveChanges.Size = new Size(200, 56);
            buttonSaveChanges.TabIndex = 40;
            buttonSaveChanges.Text = "Save Changes";
            buttonSaveChanges.UseVisualStyleBackColor = false;
            buttonSaveChanges.Click += buttonSaveChanges_Click;
            // 
            // textBoxHouseNumberTemplate
            // 
            textBoxHouseNumberTemplate.BackColor = Color.Coral;
            textBoxHouseNumberTemplate.Enabled = false;
            textBoxHouseNumberTemplate.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxHouseNumberTemplate.Location = new Point(1408, 574);
            textBoxHouseNumberTemplate.Name = "textBoxHouseNumberTemplate";
            textBoxHouseNumberTemplate.PlaceholderText = "HOUSE NUMBER";
            textBoxHouseNumberTemplate.ReadOnly = true;
            textBoxHouseNumberTemplate.Size = new Size(431, 46);
            textBoxHouseNumberTemplate.TabIndex = 41;
            textBoxHouseNumberTemplate.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxStreetTemplate
            // 
            textBoxStreetTemplate.BackColor = Color.Coral;
            textBoxStreetTemplate.Enabled = false;
            textBoxStreetTemplate.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxStreetTemplate.Location = new Point(1408, 456);
            textBoxStreetTemplate.Name = "textBoxStreetTemplate";
            textBoxStreetTemplate.PlaceholderText = "STREET";
            textBoxStreetTemplate.ReadOnly = true;
            textBoxStreetTemplate.Size = new Size(431, 46);
            textBoxStreetTemplate.TabIndex = 42;
            textBoxStreetTemplate.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxCityTemplate
            // 
            textBoxCityTemplate.BackColor = Color.Coral;
            textBoxCityTemplate.Enabled = false;
            textBoxCityTemplate.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxCityTemplate.Location = new Point(1408, 341);
            textBoxCityTemplate.Name = "textBoxCityTemplate";
            textBoxCityTemplate.PlaceholderText = "CITY";
            textBoxCityTemplate.ReadOnly = true;
            textBoxCityTemplate.Size = new Size(431, 46);
            textBoxCityTemplate.TabIndex = 43;
            textBoxCityTemplate.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxCountryTemplate
            // 
            textBoxCountryTemplate.BackColor = Color.Coral;
            textBoxCountryTemplate.Enabled = false;
            textBoxCountryTemplate.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxCountryTemplate.Location = new Point(1408, 227);
            textBoxCountryTemplate.Name = "textBoxCountryTemplate";
            textBoxCountryTemplate.PlaceholderText = "COUNTRY";
            textBoxCountryTemplate.ReadOnly = true;
            textBoxCountryTemplate.Size = new Size(431, 46);
            textBoxCountryTemplate.TabIndex = 44;
            textBoxCountryTemplate.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxNameTemplate
            // 
            textBoxNameTemplate.BackColor = Color.Coral;
            textBoxNameTemplate.Enabled = false;
            textBoxNameTemplate.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxNameTemplate.Location = new Point(856, 230);
            textBoxNameTemplate.Name = "textBoxNameTemplate";
            textBoxNameTemplate.PlaceholderText = "NAME";
            textBoxNameTemplate.ReadOnly = true;
            textBoxNameTemplate.Size = new Size(431, 46);
            textBoxNameTemplate.TabIndex = 45;
            textBoxNameTemplate.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxLastnameTemplate
            // 
            textBoxLastnameTemplate.BackColor = Color.Coral;
            textBoxLastnameTemplate.Enabled = false;
            textBoxLastnameTemplate.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxLastnameTemplate.Location = new Point(856, 341);
            textBoxLastnameTemplate.Name = "textBoxLastnameTemplate";
            textBoxLastnameTemplate.PlaceholderText = "LASTNAME";
            textBoxLastnameTemplate.ReadOnly = true;
            textBoxLastnameTemplate.Size = new Size(431, 46);
            textBoxLastnameTemplate.TabIndex = 46;
            textBoxLastnameTemplate.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxPhoneNumberTemplate
            // 
            textBoxPhoneNumberTemplate.BackColor = Color.Coral;
            textBoxPhoneNumberTemplate.Enabled = false;
            textBoxPhoneNumberTemplate.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxPhoneNumberTemplate.Location = new Point(856, 698);
            textBoxPhoneNumberTemplate.Name = "textBoxPhoneNumberTemplate";
            textBoxPhoneNumberTemplate.PlaceholderText = "PHONE NUMBER";
            textBoxPhoneNumberTemplate.ReadOnly = true;
            textBoxPhoneNumberTemplate.Size = new Size(431, 46);
            textBoxPhoneNumberTemplate.TabIndex = 47;
            textBoxPhoneNumberTemplate.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxLoginTemplate
            // 
            textBoxLoginTemplate.BackColor = Color.Coral;
            textBoxLoginTemplate.Enabled = false;
            textBoxLoginTemplate.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxLoginTemplate.Location = new Point(294, 230);
            textBoxLoginTemplate.Name = "textBoxLoginTemplate";
            textBoxLoginTemplate.PlaceholderText = "LOGIN";
            textBoxLoginTemplate.ReadOnly = true;
            textBoxLoginTemplate.Size = new Size(431, 46);
            textBoxLoginTemplate.TabIndex = 48;
            textBoxLoginTemplate.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxEmailTemplate
            // 
            textBoxEmailTemplate.BackColor = Color.Coral;
            textBoxEmailTemplate.Enabled = false;
            textBoxEmailTemplate.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxEmailTemplate.Location = new Point(294, 341);
            textBoxEmailTemplate.Name = "textBoxEmailTemplate";
            textBoxEmailTemplate.PlaceholderText = "EMAIL";
            textBoxEmailTemplate.ReadOnly = true;
            textBoxEmailTemplate.Size = new Size(431, 46);
            textBoxEmailTemplate.TabIndex = 49;
            textBoxEmailTemplate.TextAlign = HorizontalAlignment.Center;
            // 
            // labelMessage
            // 
            labelMessage.AutoSize = true;
            labelMessage.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelMessage.ForeColor = Color.Red;
            labelMessage.Location = new Point(802, 33);
            labelMessage.Name = "labelMessage";
            labelMessage.Size = new Size(0, 40);
            labelMessage.TabIndex = 50;
            labelMessage.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelMessageSuccess
            // 
            labelMessageSuccess.AutoSize = true;
            labelMessageSuccess.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelMessageSuccess.ForeColor = Color.Coral;
            labelMessageSuccess.Location = new Point(802, 33);
            labelMessageSuccess.Name = "labelMessageSuccess";
            labelMessageSuccess.Size = new Size(0, 40);
            labelMessageSuccess.TabIndex = 51;
            // 
            // buttonChangePassword
            // 
            buttonChangePassword.BackColor = Color.Coral;
            buttonChangePassword.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonChangePassword.Location = new Point(971, 977);
            buttonChangePassword.Name = "buttonChangePassword";
            buttonChangePassword.Size = new Size(200, 77);
            buttonChangePassword.TabIndex = 52;
            buttonChangePassword.Text = "Change Password";
            buttonChangePassword.UseVisualStyleBackColor = false;
            buttonChangePassword.Click += buttonChangePassword_Click;
            // 
            // UserProfileForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1872, 1100);
            Controls.Add(buttonChangePassword);
            Controls.Add(labelMessageSuccess);
            Controls.Add(labelMessage);
            Controls.Add(textBoxEmailTemplate);
            Controls.Add(textBoxLoginTemplate);
            Controls.Add(textBoxPhoneNumberTemplate);
            Controls.Add(textBoxLastnameTemplate);
            Controls.Add(textBoxNameTemplate);
            Controls.Add(textBoxCountryTemplate);
            Controls.Add(textBoxCityTemplate);
            Controls.Add(textBoxStreetTemplate);
            Controls.Add(textBoxHouseNumberTemplate);
            Controls.Add(buttonSaveChanges);
            Controls.Add(comboBoxSex);
            Controls.Add(maskedTextBoxBirthday);
            Controls.Add(maskedTextBoxZipCode);
            Controls.Add(textBoxZipCode);
            Controls.Add(textBoxHouseNumber);
            Controls.Add(textBoxStreet);
            Controls.Add(textBoxCity);
            Controls.Add(textBoxCountry);
            Controls.Add(textBoxPhoneNumber);
            Controls.Add(textBoxSex);
            Controls.Add(textBoxBirthday);
            Controls.Add(textBoxLastname);
            Controls.Add(textBoxName);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxLogin);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserProfileForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserProfileForm";
            WindowState = FormWindowState.Maximized;
            Load += UserProfileForm_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private ComboBox comboBoxSex;
        private MaskedTextBox maskedTextBoxBirthday;
        private MaskedTextBox maskedTextBoxZipCode;
        private TextBox textBoxZipCode;
        private TextBox textBoxHouseNumber;
        private TextBox textBoxStreet;
        private TextBox textBoxCity;
        private TextBox textBoxCountry;
        private TextBox textBoxPhoneNumber;
        private TextBox textBoxSex;
        private TextBox textBoxBirthday;
        private TextBox textBoxLastname;
        private TextBox textBoxName;
        private TextBox textBoxEmail;
        private TextBox textBoxLogin;
        private Button buttonSaveChanges;
        private TextBox textBoxHouseNumberTemplate;
        private TextBox textBoxStreetTemplate;
        private TextBox textBoxCityTemplate;
        private TextBox textBoxCountryTemplate;
        private TextBox textBoxNameTemplate;
        private TextBox textBoxLastnameTemplate;
        private TextBox textBoxPhoneNumberTemplate;
        private TextBox textBoxLoginTemplate;
        private TextBox textBoxEmailTemplate;
        private Label labelMessage;
        private Label labelMessageSuccess;
        private Button buttonChangePassword;
    }
}