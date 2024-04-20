namespace GUI
{
    partial class AdminPanelStatistics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panel1 = new Panel();
            labelAdminPanel = new Label();
            buttonStatistics = new Button();
            buttonUsers = new Button();
            pictureBox1 = new PictureBox();
            buttonBack = new Button();
            chartSex = new System.Windows.Forms.DataVisualization.Charting.Chart();
            labelMessage = new Label();
            chartMovieCategory = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label1 = new Label();
            labelMovieCategory = new Label();
            chartAge = new System.Windows.Forms.DataVisualization.Charting.Chart();
            labelAge = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartSex).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartMovieCategory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartAge).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.Coral;
            panel1.Controls.Add(labelAdminPanel);
            panel1.Controls.Add(buttonStatistics);
            panel1.Controls.Add(buttonUsers);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(buttonBack);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(230, 1215);
            panel1.TabIndex = 7;
            // 
            // labelAdminPanel
            // 
            labelAdminPanel.AutoSize = true;
            labelAdminPanel.BackColor = Color.Coral;
            labelAdminPanel.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelAdminPanel.ForeColor = Color.Black;
            labelAdminPanel.Location = new Point(5, 139);
            labelAdminPanel.Name = "labelAdminPanel";
            labelAdminPanel.Size = new Size(207, 40);
            labelAdminPanel.TabIndex = 9;
            labelAdminPanel.Text = "ADMIN PANEL";
            // 
            // buttonStatistics
            // 
            buttonStatistics.BackColor = Color.Coral;
            buttonStatistics.FlatAppearance.BorderColor = Color.Black;
            buttonStatistics.FlatAppearance.BorderSize = 2;
            buttonStatistics.FlatStyle = FlatStyle.Flat;
            buttonStatistics.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonStatistics.Location = new Point(12, 319);
            buttonStatistics.Name = "buttonStatistics";
            buttonStatistics.Size = new Size(200, 56);
            buttonStatistics.TabIndex = 10;
            buttonStatistics.Text = "STATISTICS";
            buttonStatistics.UseVisualStyleBackColor = false;
            // 
            // buttonUsers
            // 
            buttonUsers.BackColor = Color.Coral;
            buttonUsers.FlatAppearance.BorderColor = Color.Black;
            buttonUsers.FlatAppearance.BorderSize = 2;
            buttonUsers.FlatStyle = FlatStyle.Flat;
            buttonUsers.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonUsers.Location = new Point(12, 227);
            buttonUsers.Name = "buttonUsers";
            buttonUsers.Size = new Size(200, 56);
            buttonUsers.TabIndex = 9;
            buttonUsers.Text = "USERS";
            buttonUsers.UseVisualStyleBackColor = false;
            buttonUsers.Click += buttonUsers_Click;
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
            // chartSex
            // 
            chartSex.BackColor = Color.FromArgb(14, 14, 14);
            chartSex.BorderlineColor = Color.Coral;
            chartSex.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartSex.BorderlineWidth = 3;
            chartArea1.BackColor = Color.FromArgb(14, 14, 14);
            chartArea1.Name = "ChartArea1";
            chartSex.ChartAreas.Add(chartArea1);
            legend1.BackColor = Color.FromArgb(14, 14, 14);
            legend1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            legend1.ForeColor = Color.White;
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            legend1.TitleFont = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            chartSex.Legends.Add(legend1);
            chartSex.Location = new Point(504, 139);
            chartSex.Name = "chartSex";
            series1.BackSecondaryColor = Color.FromArgb(14, 14, 14);
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartSex.Series.Add(series1);
            chartSex.Size = new Size(447, 559);
            chartSex.TabIndex = 8;
            chartSex.Text = "chart1";
            chartSex.MouseClick += chartSex_MouseClick;
            // 
            // labelMessage
            // 
            labelMessage.AutoSize = true;
            labelMessage.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelMessage.ForeColor = Color.White;
            labelMessage.Location = new Point(843, 43);
            labelMessage.Name = "labelMessage";
            labelMessage.Size = new Size(0, 40);
            labelMessage.TabIndex = 9;
            // 
            // chartMovieCategory
            // 
            chartMovieCategory.BackColor = Color.FromArgb(14, 14, 14);
            chartMovieCategory.BorderlineColor = Color.Coral;
            chartMovieCategory.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartMovieCategory.BorderlineWidth = 3;
            chartArea2.BackColor = Color.FromArgb(14, 14, 14);
            chartArea2.Name = "ChartArea1";
            chartMovieCategory.ChartAreas.Add(chartArea2);
            legend2.BackColor = Color.FromArgb(14, 14, 14);
            legend2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            legend2.ForeColor = Color.White;
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            legend2.TitleFont = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            chartMovieCategory.Legends.Add(legend2);
            chartMovieCategory.Location = new Point(1093, 139);
            chartMovieCategory.Name = "chartMovieCategory";
            chartMovieCategory.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series2.BackSecondaryColor = Color.FromArgb(14, 14, 14);
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartMovieCategory.Series.Add(series2);
            chartMovieCategory.Size = new Size(447, 559);
            chartMovieCategory.TabIndex = 10;
            chartMovieCategory.Text = "chart1";
            chartMovieCategory.MouseClick += chartMovieCategory_MouseClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Coral;
            label1.Location = new Point(651, 169);
            label1.Name = "label1";
            label1.Size = new Size(163, 30);
            label1.TabIndex = 11;
            label1.Text = "ALL USERS SEX";
            // 
            // labelMovieCategory
            // 
            labelMovieCategory.AutoSize = true;
            labelMovieCategory.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            labelMovieCategory.ForeColor = Color.Coral;
            labelMovieCategory.Location = new Point(1209, 169);
            labelMovieCategory.Name = "labelMovieCategory";
            labelMovieCategory.Size = new Size(212, 30);
            labelMovieCategory.TabIndex = 12;
            labelMovieCategory.Text = "MOVIE CATEGORIES";
            // 
            // chartAge
            // 
            chartAge.BackColor = Color.FromArgb(14, 14, 14);
            chartAge.BorderlineColor = Color.Coral;
            chartAge.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartAge.BorderlineWidth = 3;
            chartArea3.BackColor = Color.FromArgb(14, 14, 14);
            chartArea3.Name = "ChartArea1";
            chartAge.ChartAreas.Add(chartArea3);
            legend3.BackColor = Color.FromArgb(14, 14, 14);
            legend3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            legend3.ForeColor = Color.White;
            legend3.IsTextAutoFit = false;
            legend3.Name = "Legend1";
            legend3.TitleFont = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            chartAge.Legends.Add(legend3);
            chartAge.Location = new Point(504, 728);
            chartAge.Name = "chartAge";
            chartAge.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series3.BackSecondaryColor = Color.FromArgb(14, 14, 14);
            series3.ChartArea = "ChartArea1";
            series3.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            chartAge.Series.Add(series3);
            chartAge.Size = new Size(1036, 382);
            chartAge.TabIndex = 13;
            chartAge.Text = "chart1";
            chartAge.MouseClick += chartAge_MouseClick;
            // 
            // labelAge
            // 
            labelAge.AutoSize = true;
            labelAge.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            labelAge.ForeColor = Color.Coral;
            labelAge.Location = new Point(911, 737);
            labelAge.Name = "labelAge";
            labelAge.Size = new Size(216, 30);
            labelAge.TabIndex = 14;
            labelAge.Text = "USERS AGE GROUPS";
            // 
            // AdminPanelStatistics
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1872, 1100);
            Controls.Add(labelAge);
            Controls.Add(chartAge);
            Controls.Add(labelMovieCategory);
            Controls.Add(label1);
            Controls.Add(chartMovieCategory);
            Controls.Add(labelMessage);
            Controls.Add(chartSex);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminPanelStatistics";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminPanelStatistics";
            WindowState = FormWindowState.Maximized;
            Load += AdminPanelStatistics_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartSex).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartMovieCategory).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartAge).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label labelAdminPanel;
        private Button buttonStatistics;
        private Button buttonUsers;
        private PictureBox pictureBox1;
        private Button buttonBack;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSex;
        private Label labelMessage;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMovieCategory;
        private Label label1;
        private Label labelMovieCategory;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAge;
        private Label labelAge;
    }
}