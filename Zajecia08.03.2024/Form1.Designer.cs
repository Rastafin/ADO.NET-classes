namespace Zajecia08._03._2024
{
    partial class Form1
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
            lblMovies = new Label();
            btnCzytnik = new Button();
            labelPodajTytul = new Label();
            textBoxTytul = new TextBox();
            buttonWyswietlZParametrem = new Button();
            textBoxRodzaj = new TextBox();
            labelRodzaj = new Label();
            buttonWyswietlSchematDataTable = new Button();
            buttonWyswietlFilmyDataAdapterDataTable = new Button();
            SuspendLayout();
            // 
            // lblMovies
            // 
            lblMovies.BackColor = SystemColors.ActiveBorder;
            lblMovies.Font = new Font("Segoe UI", 16F);
            lblMovies.Location = new Point(142, 34);
            lblMovies.Name = "lblMovies";
            lblMovies.Size = new Size(403, 247);
            lblMovies.TabIndex = 0;
            lblMovies.Text = "labelMovies";
            // 
            // btnCzytnik
            // 
            btnCzytnik.Location = new Point(247, 321);
            btnCzytnik.Name = "btnCzytnik";
            btnCzytnik.Size = new Size(177, 69);
            btnCzytnik.TabIndex = 1;
            btnCzytnik.Text = "Wyświetl film (czytnik)";
            btnCzytnik.UseVisualStyleBackColor = true;
            btnCzytnik.Click += btnCzytnik_Click;
            // 
            // labelPodajTytul
            // 
            labelPodajTytul.AutoSize = true;
            labelPodajTytul.Location = new Point(591, 52);
            labelPodajTytul.Name = "labelPodajTytul";
            labelPodajTytul.Size = new Size(64, 15);
            labelPodajTytul.TabIndex = 2;
            labelPodajTytul.Text = "Podaj tytul";
            // 
            // textBoxTytul
            // 
            textBoxTytul.Location = new Point(683, 52);
            textBoxTytul.Name = "textBoxTytul";
            textBoxTytul.Size = new Size(174, 23);
            textBoxTytul.TabIndex = 3;
            // 
            // buttonWyswietlZParametrem
            // 
            buttonWyswietlZParametrem.Location = new Point(683, 183);
            buttonWyswietlZParametrem.Name = "buttonWyswietlZParametrem";
            buttonWyswietlZParametrem.Size = new Size(177, 69);
            buttonWyswietlZParametrem.TabIndex = 4;
            buttonWyswietlZParametrem.Text = "Wyświetl z parametrem (czytnik)";
            buttonWyswietlZParametrem.UseVisualStyleBackColor = true;
            buttonWyswietlZParametrem.Click += buttonWyswietlZParametrem_Click;
            // 
            // textBoxRodzaj
            // 
            textBoxRodzaj.Location = new Point(683, 105);
            textBoxRodzaj.Name = "textBoxRodzaj";
            textBoxRodzaj.Size = new Size(174, 23);
            textBoxRodzaj.TabIndex = 6;
            textBoxRodzaj.KeyPress += textBoxRodzaj_KeyPress;
            // 
            // labelRodzaj
            // 
            labelRodzaj.AutoSize = true;
            labelRodzaj.Location = new Point(591, 105);
            labelRodzaj.Name = "labelRodzaj";
            labelRodzaj.Size = new Size(72, 15);
            labelRodzaj.TabIndex = 5;
            labelRodzaj.Text = "Podaj rodzaj";
            // 
            // buttonWyswietlSchematDataTable
            // 
            buttonWyswietlSchematDataTable.Location = new Point(949, 183);
            buttonWyswietlSchematDataTable.Name = "buttonWyswietlSchematDataTable";
            buttonWyswietlSchematDataTable.Size = new Size(177, 69);
            buttonWyswietlSchematDataTable.TabIndex = 7;
            buttonWyswietlSchematDataTable.Text = "Wyswietl schemat (DataTable)";
            buttonWyswietlSchematDataTable.UseVisualStyleBackColor = true;
            buttonWyswietlSchematDataTable.Click += buttonWyswietlSchematDataTable_Click;
            // 
            // buttonWyswietlFilmyDataAdapterDataTable
            // 
            buttonWyswietlFilmyDataAdapterDataTable.Location = new Point(949, 312);
            buttonWyswietlFilmyDataAdapterDataTable.Name = "buttonWyswietlFilmyDataAdapterDataTable";
            buttonWyswietlFilmyDataAdapterDataTable.Size = new Size(177, 69);
            buttonWyswietlFilmyDataAdapterDataTable.TabIndex = 8;
            buttonWyswietlFilmyDataAdapterDataTable.Text = "Wyswietl filmy (Adapter, DataTable)";
            buttonWyswietlFilmyDataAdapterDataTable.UseVisualStyleBackColor = true;
            buttonWyswietlFilmyDataAdapterDataTable.Click += buttonWyswietlFilmyDataAdapterDataTable_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1225, 592);
            Controls.Add(buttonWyswietlFilmyDataAdapterDataTable);
            Controls.Add(buttonWyswietlSchematDataTable);
            Controls.Add(textBoxRodzaj);
            Controls.Add(labelRodzaj);
            Controls.Add(buttonWyswietlZParametrem);
            Controls.Add(textBoxTytul);
            Controls.Add(labelPodajTytul);
            Controls.Add(btnCzytnik);
            Controls.Add(lblMovies);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMovies;
        private Button btnCzytnik;
        private Label labelPodajTytul;
        private TextBox textBoxTytul;
        private Button buttonWyswietlZParametrem;
        private TextBox textBoxRodzaj;
        private Label labelRodzaj;
        private Button buttonWyswietlSchematDataTable;
        private Button buttonWyswietlFilmyDataAdapterDataTable;
    }
}
