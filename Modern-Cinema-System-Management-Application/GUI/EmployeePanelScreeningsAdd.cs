using Backend.Model;
using Backend.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class EmployeePanelScreeningsAdd : Form
    {
        public EmployeePanelScreeningsAdd()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAddScreening_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxMovies.SelectedIndex < 0) throw new Exception("Error connected with comboBox index. ");

                Movie selectedMovie = Movie.GetMovieByTitle(comboBoxMovies.SelectedItem.ToString()!);
                DateTime selectedDateFromPicker =
                    ParsingService.ParseStringToDateTime(dateTimePickerDay.Value.ToString("yyyy-MM-dd"));

                if (!ValidationService.ValidateScreeningAddProcess(selectedMovie, selectedDateFromPicker,
                    maskedTextBoxHour.Text, out string message))
                {
                    labelMessage.ForeColor = Color.Red;
                    labelMessage.Text = message;
                    return;
                }

                Screening screening = new Screening((dateTimePickerDay.Value.ToString("yyyy-MM-dd") + ' ' + maskedTextBoxHour.Text),
                    selectedMovie.Id, 1);

                Screening.AddNewScreening(screening);
                labelMessage.ForeColor = Color.Coral;
                labelMessage.Text = "New screening has been added";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while trying to add new screening. " + ex.Message);
            }
        }

        private void EmployeePanelScreeningsAdd_Load(object sender, EventArgs e)
        {
            loadMoviesToCB();
        }

        private void loadMoviesToCB()
        {
            try
            {
                comboBoxMovies.Items.Clear();
                buttonAddScreening.Enabled = true;
                labelMessage.Text = string.Empty;

                DateTime selectedDateFromPicker =
                    ParsingService.ParseStringToDateTime(dateTimePickerDay.Value.ToString("yyyy-MM-dd"));

                List<Movie> moviesForSelectedDate = Movie.GetMoviesAvailableForScreening(selectedDateFromPicker);

                if (moviesForSelectedDate == null || moviesForSelectedDate.Count == 0)
                {
                    labelMessage.ForeColor = Color.Coral;
                    labelMessage.Text = "There is no any movie available\nfor selected date";
                    buttonAddScreening.Enabled = false;
                    return;
                }

                foreach (Movie movie in moviesForSelectedDate)
                {
                    comboBoxMovies.Items.Add(movie.Title);
                }

                comboBoxMovies.MaxDropDownItems = 8;
                comboBoxMovies.DropDownHeight = comboBoxMovies.ItemHeight * 5;
                comboBoxMovies.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while trying to load movies to comboBox. " + ex.Message);
            }

        }

        private void dateTimePickerDay_ValueChanged(object sender, EventArgs e)
        {
            loadMoviesToCB();
        }
    }
}
