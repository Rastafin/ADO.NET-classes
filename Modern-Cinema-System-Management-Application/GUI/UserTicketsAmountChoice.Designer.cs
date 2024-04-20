namespace GUI
{
    partial class UserTicketsAmountChoice
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
            labelMessageHeaderTitle = new Label();
            pictureBoxMovie = new PictureBox();
            labelMovieTitle = new Label();
            comboBoxMovieHours = new ComboBox();
            labelRegularTicket = new Label();
            labelHalfpriceTicket = new Label();
            numericUpDownRegular = new NumericUpDown();
            numericUpDownHalfprice = new NumericUpDown();
            buttonChooseSeats = new Button();
            buttonCancel = new Button();
            labelDate = new Label();
            labelMessage = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMovie).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRegular).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHalfprice).BeginInit();
            SuspendLayout();
            // 
            // labelMessageHeaderTitle
            // 
            labelMessageHeaderTitle.AutoSize = true;
            labelMessageHeaderTitle.Font = new Font("Segoe UI Semibold", 30F, FontStyle.Bold, GraphicsUnit.Point);
            labelMessageHeaderTitle.ForeColor = Color.Coral;
            labelMessageHeaderTitle.Location = new Point(478, 33);
            labelMessageHeaderTitle.Name = "labelMessageHeaderTitle";
            labelMessageHeaderTitle.Size = new Size(256, 54);
            labelMessageHeaderTitle.TabIndex = 9;
            labelMessageHeaderTitle.Text = "Select tickets";
            // 
            // pictureBoxMovie
            // 
            pictureBoxMovie.Location = new Point(50, 178);
            pictureBoxMovie.Name = "pictureBoxMovie";
            pictureBoxMovie.Size = new Size(271, 383);
            pictureBoxMovie.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxMovie.TabIndex = 10;
            pictureBoxMovie.TabStop = false;
            // 
            // labelMovieTitle
            // 
            labelMovieTitle.AutoSize = true;
            labelMovieTitle.Font = new Font("Segoe UI Semibold", 22F, FontStyle.Bold, GraphicsUnit.Point);
            labelMovieTitle.ForeColor = Color.Coral;
            labelMovieTitle.Location = new Point(50, 99);
            labelMovieTitle.Name = "labelMovieTitle";
            labelMovieTitle.Size = new Size(103, 41);
            labelMovieTitle.TabIndex = 11;
            labelMovieTitle.Text = "Movie";
            // 
            // comboBoxMovieHours
            // 
            comboBoxMovieHours.BackColor = Color.LightSalmon;
            comboBoxMovieHours.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMovieHours.FlatStyle = FlatStyle.Flat;
            comboBoxMovieHours.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxMovieHours.FormattingEnabled = true;
            comboBoxMovieHours.Location = new Point(53, 662);
            comboBoxMovieHours.Name = "comboBoxMovieHours";
            comboBoxMovieHours.Size = new Size(200, 45);
            comboBoxMovieHours.TabIndex = 24;
            comboBoxMovieHours.SelectedIndexChanged += comboBoxSex_SelectedIndexChanged;
            // 
            // labelRegularTicket
            // 
            labelRegularTicket.AutoSize = true;
            labelRegularTicket.Font = new Font("Segoe UI Semibold", 22F, FontStyle.Bold, GraphicsUnit.Point);
            labelRegularTicket.ForeColor = Color.Coral;
            labelRegularTicket.Location = new Point(555, 264);
            labelRegularTicket.Name = "labelRegularTicket";
            labelRegularTicket.Size = new Size(226, 41);
            labelRegularTicket.TabIndex = 25;
            labelRegularTicket.Text = "Reguler tickets:";
            // 
            // labelHalfpriceTicket
            // 
            labelHalfpriceTicket.AutoSize = true;
            labelHalfpriceTicket.Font = new Font("Segoe UI Semibold", 22F, FontStyle.Bold, GraphicsUnit.Point);
            labelHalfpriceTicket.ForeColor = Color.Coral;
            labelHalfpriceTicket.Location = new Point(555, 352);
            labelHalfpriceTicket.Name = "labelHalfpriceTicket";
            labelHalfpriceTicket.Size = new Size(255, 41);
            labelHalfpriceTicket.TabIndex = 26;
            labelHalfpriceTicket.Text = "Half-price tickets:";
            // 
            // numericUpDownRegular
            // 
            numericUpDownRegular.BackColor = Color.LightSalmon;
            numericUpDownRegular.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            numericUpDownRegular.Location = new Point(898, 268);
            numericUpDownRegular.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            numericUpDownRegular.Name = "numericUpDownRegular";
            numericUpDownRegular.Size = new Size(193, 39);
            numericUpDownRegular.TabIndex = 27;
            numericUpDownRegular.TextAlign = HorizontalAlignment.Center;
            // 
            // numericUpDownHalfprice
            // 
            numericUpDownHalfprice.BackColor = Color.LightSalmon;
            numericUpDownHalfprice.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            numericUpDownHalfprice.Location = new Point(898, 356);
            numericUpDownHalfprice.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            numericUpDownHalfprice.Name = "numericUpDownHalfprice";
            numericUpDownHalfprice.Size = new Size(193, 39);
            numericUpDownHalfprice.TabIndex = 28;
            numericUpDownHalfprice.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonChooseSeats
            // 
            buttonChooseSeats.BackColor = Color.Coral;
            buttonChooseSeats.FlatAppearance.BorderColor = Color.Black;
            buttonChooseSeats.FlatAppearance.BorderSize = 2;
            buttonChooseSeats.FlatStyle = FlatStyle.Flat;
            buttonChooseSeats.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonChooseSeats.Location = new Point(514, 647);
            buttonChooseSeats.Name = "buttonChooseSeats";
            buttonChooseSeats.Size = new Size(200, 77);
            buttonChooseSeats.TabIndex = 29;
            buttonChooseSeats.Text = "Choose seats";
            buttonChooseSeats.UseVisualStyleBackColor = false;
            buttonChooseSeats.Click += buttonChooseSeats_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.LightSalmon;
            buttonCancel.FlatAppearance.BorderColor = Color.Black;
            buttonCancel.FlatAppearance.BorderSize = 2;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonCancel.Location = new Point(937, 661);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(157, 46);
            buttonCancel.TabIndex = 30;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Segoe UI Semibold", 22F, FontStyle.Bold, GraphicsUnit.Point);
            labelDate.ForeColor = Color.Coral;
            labelDate.Location = new Point(50, 589);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(83, 41);
            labelDate.TabIndex = 31;
            labelDate.Text = "Date";
            // 
            // labelMessage
            // 
            labelMessage.AutoSize = true;
            labelMessage.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelMessage.ForeColor = Color.Coral;
            labelMessage.Location = new Point(356, 766);
            labelMessage.Name = "labelMessage";
            labelMessage.Size = new Size(513, 40);
            labelMessage.TabIndex = 32;
            labelMessage.Text = "At least one ticket need to be selected";
            labelMessage.Visible = false;
            // 
            // UserTicketsAmountChoice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(14, 14, 14);
            ClientSize = new Size(1184, 850);
            Controls.Add(labelMessage);
            Controls.Add(labelDate);
            Controls.Add(buttonCancel);
            Controls.Add(buttonChooseSeats);
            Controls.Add(numericUpDownHalfprice);
            Controls.Add(numericUpDownRegular);
            Controls.Add(labelHalfpriceTicket);
            Controls.Add(labelRegularTicket);
            Controls.Add(comboBoxMovieHours);
            Controls.Add(labelMovieTitle);
            Controls.Add(pictureBoxMovie);
            Controls.Add(labelMessageHeaderTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserTicketsAmountChoice";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserTicketsAmountChoice";
            Load += UserTicketsAmountChoice_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxMovie).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRegular).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHalfprice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelMessageHeaderTitle;
        private PictureBox pictureBoxMovie;
        private Label labelMovieTitle;
        private ComboBox comboBoxMovieHours;
        private Label labelRegularTicket;
        private Label labelHalfpriceTicket;
        private NumericUpDown numericUpDownRegular;
        private NumericUpDown numericUpDownHalfprice;
        private Button buttonChooseSeats;
        private Button buttonCancel;
        private Label labelDate;
        private Label labelMessage;
    }
}