namespace GUI
{
    partial class ConfirmationForm
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
            buttonNo = new Button();
            buttonYes = new Button();
            labelSecondMessage = new Label();
            SuspendLayout();
            // 
            // labelMessage
            // 
            labelMessage.AutoSize = true;
            labelMessage.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelMessage.ForeColor = Color.Coral;
            labelMessage.Location = new Point(23, 31);
            labelMessage.Name = "labelMessage";
            labelMessage.Size = new Size(681, 40);
            labelMessage.TabIndex = 9;
            labelMessage.Text = "Are you sure that you want to perform this action?";
            // 
            // buttonNo
            // 
            buttonNo.BackColor = Color.LightSalmon;
            buttonNo.FlatAppearance.BorderColor = Color.Black;
            buttonNo.FlatAppearance.BorderSize = 2;
            buttonNo.FlatStyle = FlatStyle.Flat;
            buttonNo.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonNo.Location = new Point(109, 151);
            buttonNo.Name = "buttonNo";
            buttonNo.Size = new Size(157, 46);
            buttonNo.TabIndex = 31;
            buttonNo.Text = "NO";
            buttonNo.UseVisualStyleBackColor = false;
            buttonNo.Click += buttonNo_Click;
            // 
            // buttonYes
            // 
            buttonYes.BackColor = Color.LightSalmon;
            buttonYes.FlatAppearance.BorderColor = Color.Black;
            buttonYes.FlatAppearance.BorderSize = 2;
            buttonYes.FlatStyle = FlatStyle.Flat;
            buttonYes.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonYes.Location = new Point(462, 151);
            buttonYes.Name = "buttonYes";
            buttonYes.Size = new Size(157, 46);
            buttonYes.TabIndex = 32;
            buttonYes.Text = "YES";
            buttonYes.UseVisualStyleBackColor = false;
            buttonYes.Click += buttonYes_Click;
            // 
            // labelSecondMessage
            // 
            labelSecondMessage.AutoSize = true;
            labelSecondMessage.Font = new Font("Segoe UI Semibold", 17F, FontStyle.Bold, GraphicsUnit.Point);
            labelSecondMessage.ForeColor = Color.Red;
            labelSecondMessage.Location = new Point(109, 83);
            labelSecondMessage.Name = "labelSecondMessage";
            labelSecondMessage.Size = new Size(0, 31);
            labelSecondMessage.TabIndex = 33;
            labelSecondMessage.Visible = false;
            // 
            // ConfirmationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(14, 14, 14);
            ClientSize = new Size(729, 255);
            Controls.Add(labelSecondMessage);
            Controls.Add(buttonYes);
            Controls.Add(buttonNo);
            Controls.Add(labelMessage);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ConfirmationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ConfirmationForm";
            Load += ConfirmationForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelMessage;
        private Button buttonNo;
        private Button buttonYes;
        private Label labelSecondMessage;
    }
}