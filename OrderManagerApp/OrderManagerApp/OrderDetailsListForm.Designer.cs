namespace GUI
{
    partial class OrderDetailsListForm
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
            listBoxOrderDetailsList = new ListBox();
            buttonBack = new Button();
            SuspendLayout();
            // 
            // listBoxOrderDetailsList
            // 
            listBoxOrderDetailsList.BackColor = SystemColors.InactiveCaption;
            listBoxOrderDetailsList.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            listBoxOrderDetailsList.FormattingEnabled = true;
            listBoxOrderDetailsList.ItemHeight = 25;
            listBoxOrderDetailsList.Location = new Point(0, -1);
            listBoxOrderDetailsList.Name = "listBoxOrderDetailsList";
            listBoxOrderDetailsList.Size = new Size(382, 254);
            listBoxOrderDetailsList.TabIndex = 0;
            listBoxOrderDetailsList.SelectedIndexChanged += listBoxOrderDetailsList_SelectedIndexChanged;
            // 
            // buttonBack
            // 
            buttonBack.BackColor = Color.LightCoral;
            buttonBack.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            buttonBack.Location = new Point(299, 213);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(62, 33);
            buttonBack.TabIndex = 8;
            buttonBack.Text = "BACK";
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += buttonBack_Click;
            // 
            // OrderDetailsListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 258);
            Controls.Add(buttonBack);
            Controls.Add(listBoxOrderDetailsList);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OrderDetailsListForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OrderDetailsListForm";
            Load += OrderDetailsListForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxOrderDetailsList;
        private Button buttonBack;
    }
}