namespace GUI
{
    partial class ChangePasswordForm
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
            textBoxPassword = new TextBox();
            textBoxNewPassword = new TextBox();
            buttonChange = new Button();
            buttonCancel = new Button();
            labelMessage = new Label();
            SuspendLayout();
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = Color.Coral;
            textBoxPassword.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxPassword.Location = new Point(39, 133);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.PlaceholderText = "PASSWORD";
            textBoxPassword.Size = new Size(431, 46);
            textBoxPassword.TabIndex = 9;
            textBoxPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxNewPassword
            // 
            textBoxNewPassword.BackColor = Color.Coral;
            textBoxNewPassword.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxNewPassword.Location = new Point(39, 220);
            textBoxNewPassword.Name = "textBoxNewPassword";
            textBoxNewPassword.PasswordChar = '*';
            textBoxNewPassword.PlaceholderText = "NEW PASSWORD";
            textBoxNewPassword.Size = new Size(431, 46);
            textBoxNewPassword.TabIndex = 10;
            textBoxNewPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonChange
            // 
            buttonChange.BackColor = Color.Coral;
            buttonChange.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonChange.Location = new Point(153, 316);
            buttonChange.Name = "buttonChange";
            buttonChange.Size = new Size(200, 56);
            buttonChange.TabIndex = 20;
            buttonChange.Text = "Change";
            buttonChange.UseVisualStyleBackColor = false;
            buttonChange.Click += buttonChange_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.Coral;
            buttonCancel.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonCancel.Location = new Point(153, 405);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(200, 56);
            buttonCancel.TabIndex = 21;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // labelMessage
            // 
            labelMessage.AutoSize = true;
            labelMessage.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelMessage.ForeColor = Color.Red;
            labelMessage.Location = new Point(39, 32);
            labelMessage.Name = "labelMessage";
            labelMessage.Size = new Size(0, 40);
            labelMessage.TabIndex = 22;
            labelMessage.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ChangePasswordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(14, 14, 14);
            ClientSize = new Size(502, 524);
            Controls.Add(labelMessage);
            Controls.Add(buttonCancel);
            Controls.Add(buttonChange);
            Controls.Add(textBoxNewPassword);
            Controls.Add(textBoxPassword);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ChangePasswordForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChangePasswordForm";
            Load += ChangePasswordForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxPassword;
        private TextBox textBoxNewPassword;
        private Button buttonChange;
        private Button buttonCancel;
        private Label labelMessage;
    }
}