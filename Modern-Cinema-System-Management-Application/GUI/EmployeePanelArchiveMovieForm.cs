using Backend.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class EmployeePanelArchiveMovieForm : Form
    {
        public EmployeePanelArchiveMovieForm()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EmployeePanelDeleteMovieForm_Load(object sender, EventArgs e)
        {
            dataGridViewMovieTitles.AutoGenerateColumns = false;

            dataGridViewMovieTitles.Columns.Add("Title", "Title");

            loadMovieTitlesToDGV();
        }

        private void loadMovieTitlesToDGV()
        {
            dataGridViewMovieTitles.Show();
            buttonArchive.Enabled = true;

            try
            {
                List<string> movieTitles = Movie.GetAllMovieTitles();

                if (movieTitles == null || movieTitles.Count == 0)
                {
                    dataGridViewMovieTitles.Hide();
                    buttonArchive.Enabled = false;
                    labelMessage.Text = "Movie list is empty";
                    return;
                }

                dataGridViewMovieTitles.Rows.Clear();

                foreach (string movieTitle in movieTitles)
                {
                    var row = dataGridViewMovieTitles.Rows[dataGridViewMovieTitles.Rows.Add()];

                    row.Cells["Title"].Value = movieTitle;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while trying to load movie titles. " + ex.Message);
            }
        }

        private void buttonArchive_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewMovieTitles.SelectedRows.Count > 0)
                {
                    var selectedRow = dataGridViewMovieTitles.SelectedRows[0];

                    if (selectedRow.Cells["Title"].Value != null)
                    {
                        labelMessage.Text = Movie.ArchiveMovie(selectedRow.Cells["Title"].Value.ToString()!);
                    }
                    else
                    {
                        throw new Exception("Invalid role cell or value is null. ");
                    }
                }

                loadMovieTitlesToDGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while trying to archive selected movie. " + ex.Message);
            }
        }
    }
}
