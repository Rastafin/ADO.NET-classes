using Backend.Model;
using Backend.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class EmployeePanelScreenings : Form
    {
        private readonly User _user;
        private bool isTimerActive = false;
        public EmployeePanelScreenings(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void EmployeePanelScreenings_Load(object sender, EventArgs e)
        {
            buttonScreenings.Enabled = false;
            buttonScreenings.BackColor = Color.SlateGray;

            dataGridViewScreenings.AutoGenerateColumns = false;

            dataGridViewScreenings.Columns.Add("StartTime", "Start Time");
            dataGridViewScreenings.Columns.Add("LastsUntil", "Lasts Until");
            dataGridViewScreenings.Columns.Add("Title", "Title");
            dataGridViewScreenings.Columns.Add("RoomNumber", "Room number");
            dataGridViewScreenings.Columns.Add("NumberOfReservedSeats", "Reserved seats");

            loadScreeningsToDGV();
        }

        private void loadScreeningsToDGV(string filter = "")
        {
            dataGridViewScreenings.Show();
            labelMessage.Text = string.Empty;
            buttonDeleteScreening.Enabled = true;

            try
            {
                List<Screening> screenings = Screening.GetCurrentScreenings();

                if (screenings == null || screenings.Count == 0)
                {
                    dataGridViewScreenings.Hide();
                    labelMessage.Text = "There are not any screenings";
                    buttonDeleteScreening.Enabled = false;
                    return;
                }

                dataGridViewScreenings.Rows.Clear();

                foreach (Screening screening in screenings)
                {
                    if (string.IsNullOrEmpty(filter)
                        || (screening.StartTime != null && screening.StartTime.Contains(filter, StringComparison.OrdinalIgnoreCase))
                        || (screening.Movie.Title != null && screening.Movie.Title.Contains(filter, StringComparison.OrdinalIgnoreCase))
                        || (screening.Room.RoomNumber != null && screening.Room.RoomNumber.Contains(filter, StringComparison.OrdinalIgnoreCase)))
                    {
                        var row = dataGridViewScreenings.Rows[dataGridViewScreenings.Rows.Add()];

                        row.Cells["StartTime"].Value = screening.StartTime;

                        //DateTime startRange = DateTime.ParseExact(ParsingService.ParseStartTime(screening.StartTime!), "HH:mm", CultureInfo.InvariantCulture);
                        DateTime startRange = ParsingService.ParseStringToDateTimeWithTime(screening.StartTime!);
                        DateTime endRange = startRange.AddMinutes((double)screening.Movie.Duaration! + 30);

                        row.Cells["LastsUntil"].Value = endRange.ToString("yyyy-MM-dd HH:mm");
                        row.Cells["Title"].Value = screening.Movie.Title;
                        row.Cells["RoomNumber"].Value = screening.Room.RoomNumber;
                        row.Cells["NumberOfReservedSeats"].Value = Reservation.GetNumberOfReservedSeatsForScreening(screening.Id);
                    }
                }

                if (dataGridViewScreenings.Rows.Count < 1)
                {
                    labelMessage.Text = "Cannot find any reservation";
                    buttonDeleteScreening.Enabled = false;
                    dataGridViewScreenings.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while trying to load screenings. " + ex.Message);
            }
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

        private void buttonAddMovieForm_Click(object sender, EventArgs e)
        {
            EmployeePanelMovies employeePanelMovies = new EmployeePanelMovies(_user);
            employeePanelMovies.Show();
            this.Close();
        }

        private void textBoxFilter_TextChanged(object sender, EventArgs e)
        {
            string filter = textBoxFilter.Text.Trim();
            loadScreeningsToDGV(filter);
        }

        private void buttonDeleteScreening_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewScreenings.SelectedRows.Count > 0)
                {
                    var selectedRow = dataGridViewScreenings.SelectedRows[0];

                    if (selectedRow.Cells["StartTime"].Value != null &&
                        selectedRow.Cells["Title"].Value != null &&
                        selectedRow.Cells["RoomNumber"].Value != null &&
                        selectedRow.Cells["NumberOfReservedSeats"].Value != null)
                    {
                        int screeningId = Screening.GetScreeningIdFromDateAndMovie(
                            selectedRow.Cells["StartTime"].Value.ToString()!,
                            Movie.GetMovieByTitle(selectedRow.Cells["Title"].Value.ToString()!).Id);

                        if (screeningId < 0) throw new Exception("Selected screening does not exist. ");

                        if (int.Parse(selectedRow.Cells["NumberOfReservedSeats"].Value.ToString()!) > 0)
                        {
                            ConfirmationForm confirmationForm = new ConfirmationForm();
                            confirmationForm.ActivateSecondMessage("Number of reserved seats for this screening: " +
                                selectedRow.Cells["NumberOfReservedSeats"].Value.ToString());
                            confirmationForm.ShowDialog();

                            if (confirmationForm.WasYesClicked)
                            {
                                Screening.DeleteScreeningWithReservations(screeningId, true);
                            }
                            else
                            {
                                return;
                            }
                        }
                        else
                        {
                            Screening.DeleteScreeningWithReservations(screeningId);
                        }

                        labelMessageConfirmation.Text = "This screening has been deleted";
                        buttonBack.Enabled = false;
                        buttonAddMovieForm.Enabled = false;
                        buttonUsersReservations.Enabled = false;

                        if (!isTimerActive)
                        {
                            isTimerActive = true;

                            System.Threading.Timer timer = null;
                            timer = new System.Threading.Timer((state) =>
                            {
                                labelMessageConfirmation.Invoke((MethodInvoker)(() => labelMessageConfirmation.Text = ""));
                                buttonBack.Invoke((MethodInvoker)(() => buttonBack.Enabled = true));
                                buttonAddMovieForm.Invoke((MethodInvoker)(() => buttonAddMovieForm.Enabled = true));
                                buttonUsersReservations.Invoke((MethodInvoker)(() => buttonUsersReservations.Enabled = true));
                                timer.Dispose();
                                isTimerActive = false;
                            }, null, 2000, System.Threading.Timeout.Infinite);
                        }

                        loadScreeningsToDGV();
                    }
                    else
                    {
                        throw new Exception("Invalid role cell or value is null. ");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while trying to delete selected screening. " + ex.Message);
            }
        }

        private void buttonAddNewScreening_Click(object sender, EventArgs e)
        {
            EmployeePanelScreeningsAdd employeePanelScreeningsAdd = new EmployeePanelScreeningsAdd();
            employeePanelScreeningsAdd.ShowDialog();
            loadScreeningsToDGV();
        }
    }
}
