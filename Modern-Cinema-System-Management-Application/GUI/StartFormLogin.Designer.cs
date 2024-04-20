namespace GUI
{
    partial class StartFormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonRegister = new Button();
            buttonLogin = new Button();
            textBoxLogin = new TextBox();
            textBoxPassword = new TextBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            buttonExit = new Button();
            labelMessage = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonRegister
            // 
            buttonRegister.BackColor = Color.Coral;
            buttonRegister.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonRegister.Location = new Point(860, 700);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(200, 56);
            buttonRegister.TabIndex = 0;
            buttonRegister.Text = "Register";
            buttonRegister.UseVisualStyleBackColor = false;
            buttonRegister.Click += button1_Click;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.Coral;
            buttonLogin.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonLogin.Location = new Point(860, 611);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(200, 56);
            buttonLogin.TabIndex = 1;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // textBoxLogin
            // 
            textBoxLogin.BackColor = Color.Coral;
            textBoxLogin.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxLogin.Location = new Point(737, 404);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.PlaceholderText = "LOGIN";
            textBoxLogin.Size = new Size(431, 46);
            textBoxLogin.TabIndex = 2;
            textBoxLogin.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = Color.Coral;
            textBoxPassword.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxPassword.Location = new Point(737, 489);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.PlaceholderText = "PASSWORD";
            textBoxPassword.Size = new Size(431, 46);
            textBoxPassword.TabIndex = 3;
            textBoxPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Coral;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1920, 114);
            panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._4170e6ab0f6d30dca42c2df7cf52fb999351cb63d11203175d4ddb638955e9c2;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(141, 94);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.Coral;
            buttonExit.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonExit.Location = new Point(860, 790);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(200, 56);
            buttonExit.TabIndex = 5;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // labelMessage
            // 
            labelMessage.AutoSize = true;
            labelMessage.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelMessage.ForeColor = Color.Coral;
            labelMessage.Location = new Point(724, 191);
            labelMessage.Name = "labelMessage";
            labelMessage.Size = new Size(0, 40);
            labelMessage.TabIndex = 6;
            // 
            // StartFormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1904, 1041);
            Controls.Add(labelMessage);
            Controls.Add(buttonExit);
            Controls.Add(panel1);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxLogin);
            Controls.Add(buttonLogin);
            Controls.Add(buttonRegister);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StartFormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonRegister;
        private Button buttonLogin;
        private TextBox textBoxLogin;
        private TextBox textBoxPassword;
        private Panel panel1;
        private Button buttonExit;
        private PictureBox pictureBox1;
        private Label labelMessage;
    }
}