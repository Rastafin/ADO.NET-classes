namespace GUI
{
    partial class EmployeePanelArchiveMovieForm
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
            dataGridViewMovieTitles = new DataGridView();
            buttonCancel = new Button();
            buttonArchive = new Button();
            labelMessage = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMovieTitles).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewMovieTitles
            // 
            dataGridViewMovieTitles.AllowUserToAddRows = false;
            dataGridViewMovieTitles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMovieTitles.BackgroundColor = Color.Black;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Coral;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.Coral;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewMovieTitles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewMovieTitles.ColumnHeadersHeight = 50;
            dataGridViewMovieTitles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewMovieTitles.EnableHeadersVisualStyles = false;
            dataGridViewMovieTitles.GridColor = Color.Snow;
            dataGridViewMovieTitles.Location = new Point(55, 135);
            dataGridViewMovieTitles.MultiSelect = false;
            dataGridViewMovieTitles.Name = "dataGridViewMovieTitles";
            dataGridViewMovieTitles.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Black;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Coral;
            dataGridViewCellStyle2.SelectionBackColor = Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = Color.Coral;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewMovieTitles.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewMovieTitles.RowHeadersVisible = false;
            dataGridViewMovieTitles.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewMovieTitles.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewMovieTitles.RowTemplate.DefaultCellStyle.BackColor = Color.Black;
            dataGridViewMovieTitles.RowTemplate.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewMovieTitles.RowTemplate.DefaultCellStyle.ForeColor = Color.Coral;
            dataGridViewMovieTitles.RowTemplate.Height = 100;
            dataGridViewMovieTitles.RowTemplate.ReadOnly = true;
            dataGridViewMovieTitles.RowTemplate.Resizable = DataGridViewTriState.False;
            dataGridViewMovieTitles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewMovieTitles.Size = new Size(332, 373);
            dataGridViewMovieTitles.TabIndex = 8;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.Coral;
            buttonCancel.FlatAppearance.BorderColor = Color.Black;
            buttonCancel.FlatAppearance.BorderSize = 2;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonCancel.Location = new Point(235, 12);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(152, 43);
            buttonCancel.TabIndex = 34;
            buttonCancel.Text = "CANCEL";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonArchive
            // 
            buttonArchive.BackColor = Color.Coral;
            buttonArchive.FlatAppearance.BorderColor = Color.Black;
            buttonArchive.FlatAppearance.BorderSize = 2;
            buttonArchive.FlatStyle = FlatStyle.Flat;
            buttonArchive.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonArchive.Location = new Point(55, 12);
            buttonArchive.Name = "buttonArchive";
            buttonArchive.Size = new Size(152, 43);
            buttonArchive.TabIndex = 35;
            buttonArchive.Text = "ARCHIVE";
            buttonArchive.UseVisualStyleBackColor = false;
            buttonArchive.Click += buttonArchive_Click;
            // 
            // labelMessage
            // 
            labelMessage.AutoSize = true;
            labelMessage.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelMessage.ForeColor = Color.Coral;
            labelMessage.Location = new Point(25, 56);
            labelMessage.Name = "labelMessage";
            labelMessage.Size = new Size(0, 40);
            labelMessage.TabIndex = 36;
            // 
            // EmployeePanelArchiveMovieForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 20);
            ClientSize = new Size(447, 543);
            Controls.Add(labelMessage);
            Controls.Add(buttonArchive);
            Controls.Add(buttonCancel);
            Controls.Add(dataGridViewMovieTitles);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EmployeePanelArchiveMovieForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmployeePanelDeleteMovieForm";
            Load += EmployeePanelDeleteMovieForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewMovieTitles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewMovieTitles;
        private Button buttonCancel;
        private Button buttonArchive;
        private Label labelMessage;
    }
}