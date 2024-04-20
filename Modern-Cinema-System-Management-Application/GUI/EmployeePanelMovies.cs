using Backend.Model;
using Backend.Model.Enums;
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

namespace GUI
{
    public partial class EmployeePanelMovies : Form
    {
        private readonly User _user;
        private Movie _newMovie;
        private string _selectedImagePath;
        private readonly string _imagesPath = @"..\..\..\..\Backend\Data\Pictures\";
        public EmployeePanelMovies(User user)
        {
            InitializeComponent();
            _user = user;
            _newMovie = new Movie();
        }

        private void EmployeePanelMovies_Load(object sender, EventArgs e)
        {
            buttonAddMovieForm.Enabled = false;
            buttonAddMovieForm.BackColor = Color.SlateGray;
        }

        private void buttonUsersReservations_Click(object sender, EventArgs e)
        {

            EmployeePanelMainMenu employeePanelMainMenu = new EmployeePanelMainMenu(_user);
            employeePanelMainMenu.Show();
            this.Close();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            UserMainMenu? userMainMenu = Application.OpenForms.OfType<UserMainMenu>()
                            .Where(r => r.GetLoggedInUser().Id == _user.Id)
                            .FirstOrDefault();

            if (userMainMenu != null)
            {
                userMainMenu.loadScreeningsByDate();
                userMainMenu.Show();
            }

            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialogMoviePictureFile = new OpenFileDialog())
                {
                    openFileDialogMoviePictureFile.Filter = "Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";

                    if (openFileDialogMoviePictureFile.ShowDialog() == DialogResult.OK)
                    {
                        _selectedImagePath = openFileDialogMoviePictureFile.FileName;

                        _newMovie.ImageFileName = Path.GetFileName(_selectedImagePath);

                        pictureBoxMoviePicture.Image = Image.FromFile(_selectedImagePath);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while trying to add new movie picture. " + ex.Message);
            }
        }

        private void buttonAddMovie_Click(object sender, EventArgs e)
        {
            try
            {
                MovieCategory parsedMovieCategory;

                if (!Enum.TryParse(comboBoxCategory.Text, out parsedMovieCategory))
                {
                    labelMessage.Text = "Bad Movie Category format";
                    return;
                }

                if (_newMovie.ImageFileName == null || _newMovie.ImageFileName.Length == 0)
                {
                    labelMessage.Text = "You need to add movie photo file";
                    return;
                }

                if (!ValidationService.ValidateMovieAddProcess(textBoxTitle.Text, textBoxDescription.Text, textBoxDuration.Text,
                    textBoxDirector.Text, dateTimePickerReleaseDate.Value.ToString("yyyy-MM-dd"),
                    dateTimePickerWithdrawalDate.Value.ToString("yyyy-MM-dd"), _newMovie.ImageFileName!, out string message))
                {
                    labelMessage.Text = message;
                    return;
                }

                if (!string.IsNullOrEmpty(_newMovie.ImageFileName) && !string.IsNullOrEmpty(_selectedImagePath))
                {
                    string targetImagePath = Path.Combine(_imagesPath, _newMovie.ImageFileName);
                    File.Copy(_selectedImagePath, targetImagePath);
                }
                else
                {
                    labelMessage.Text = "Incorrect movie photo file";
                    return;
                }


                _newMovie.Title = textBoxTitle.Text;
                _newMovie.Description = textBoxDescription.Text;
                _newMovie.Duaration = int.Parse(textBoxDuration.Text);
                _newMovie.Director = textBoxDirector.Text;
                _newMovie.ReleaseDate = dateTimePickerReleaseDate.Value.ToString("yyyy-MM-dd");
                _newMovie.WithdrawalDate = dateTimePickerWithdrawalDate.Value.ToString("yyyy-MM-dd");
                _newMovie.Category = parsedMovieCategory;

                Movie.AddNewMovie(_newMovie);
                labelMessage.Text = "New movie has been added";
                RefreshFormContent();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while trying to add new movie. " + ex.Message);
            }
        }

        private void textBoxDuration_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void RefreshFormContent()
        {
            _newMovie = new Movie();
            _selectedImagePath = string.Empty;

            comboBoxCategory.SelectedIndex = -1;

            textBoxTitle.Clear();
            textBoxDescription.Clear();
            textBoxDuration.Clear();
            textBoxDirector.Clear();

            pictureBoxMoviePicture.Image = null;

            dateTimePickerReleaseDate.Value = DateTime.Today;
            dateTimePickerWithdrawalDate.Value = DateTime.Today;
        }

        private void buttonScreenings_Click(object sender, EventArgs e)
        {
            EmployeePanelScreenings employeePanelScreenings = new EmployeePanelScreenings(_user);
            employeePanelScreenings.Show();
            Close();
        }

        private void buttonCheckCurrentMovies_Click(object sender, EventArgs e)
        {
            EmployeePanelArchiveMovieForm employeePanelDeleteMovieForm = new EmployeePanelArchiveMovieForm();
            employeePanelDeleteMovieForm.ShowDialog();
        }
    }
}
