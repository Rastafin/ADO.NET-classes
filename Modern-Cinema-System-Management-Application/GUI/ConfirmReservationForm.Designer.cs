namespace GUI
{
    partial class ConfirmReservationForm
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
            labelMessage = new Label();
            buttonConfirmation = new Button();
            buttonCancel = new Button();
            textBoxConfirmationNumber = new TextBox();
            labelWarning = new Label();
            SuspendLayout();
            // 
            // labelMessage
            // 
            labelMessage.AutoSize = true;
            labelMessage.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelMessage.ForeColor = Color.Coral;
            labelMessage.Location = new Point(12, 22);
            labelMessage.Name = "labelMessage";
            labelMessage.Size = new Size(679, 40);
            labelMessage.TabIndex = 10;
            labelMessage.Text = "Enter Confirmation Number to perform this action";
            // 
            // buttonConfirmation
            // 
            buttonConfirmation.BackColor = Color.LightSalmon;
            buttonConfirmation.FlatAppearance.BorderColor = Color.Black;
            buttonConfirmation.FlatAppearance.BorderSize = 2;
            buttonConfirmation.FlatStyle = FlatStyle.Flat;
            buttonConfirmation.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonConfirmation.Location = new Point(422, 174);
            buttonConfirmation.Name = "buttonConfirmation";
            buttonConfirmation.Size = new Size(157, 46);
            buttonConfirmation.TabIndex = 33;
            buttonConfirmation.Text = "CONFIRM";
            buttonConfirmation.UseVisualStyleBackColor = false;
            buttonConfirmation.Click += buttonConfirmation_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.LightSalmon;
            buttonCancel.FlatAppearance.BorderColor = Color.Black;
            buttonCancel.FlatAppearance.BorderSize = 2;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonCancel.Location = new Point(149, 174);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(157, 46);
            buttonCancel.TabIndex = 34;
            buttonCancel.Text = "CANCEL";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // textBoxConfirmationNumber
            // 
            textBoxConfirmationNumber.BackColor = Color.Coral;
            textBoxConfirmationNumber.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxConfirmationNumber.Location = new Point(173, 90);
            textBoxConfirmationNumber.Name = "textBoxConfirmationNumber";
            textBoxConfirmationNumber.PlaceholderText = "CONFIRMATION NUMBER";
            textBoxConfirmationNumber.Size = new Size(386, 46);
            textBoxConfirmationNumber.TabIndex = 35;
            textBoxConfirmationNumber.TextAlign = HorizontalAlignment.Center;
            textBoxConfirmationNumber.KeyPress += textBoxConfirmationNumber_KeyPress;
            // 
            // labelWarning
            // 
            labelWarning.AutoSize = true;
            labelWarning.Font = new Font("Segoe UI Semibold", 11.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelWarning.ForeColor = Color.Red;
            labelWarning.Location = new Point(266, 139);
            labelWarning.Name = "labelWarning";
            labelWarning.Size = new Size(204, 21);
            labelWarning.TabIndex = 36;
            labelWarning.Text = "This field cannot be empty";
            // 
            // ConfirmReservationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(14, 14, 14);
            ClientSize = new Size(713, 255);
            Controls.Add(labelWarning);
            Controls.Add(textBoxConfirmationNumber);
            Controls.Add(buttonCancel);
            Controls.Add(buttonConfirmation);
            Controls.Add(labelMessage);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ConfirmReservationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ConfirmReservationForm";
            Load += ConfirmReservationForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelMessage;
        private Button buttonConfirmation;
        private Button buttonCancel;
        private TextBox textBoxConfirmationNumber;
        private Label labelWarning;
    }
}