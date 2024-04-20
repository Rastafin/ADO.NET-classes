using Backend.Model;
using Backend.Services;
using GUI.Functions;
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
    public partial class UserReservation : Form
    {
        private readonly User _user;
        public UserReservation(User user)
        {
            _user = user;

            InitializeComponent();
        }

        private void refreshData()
        {
            dataGridViewReservations.Rows.Clear();

            try
            {
                var reservations = Reservation.GetUserReseervations(_user.Id);

                if (reservations == null || reservations.Count == 0)
                {
                    dataGridViewReservations.Hide();
                    labelMessage.Text = "You do not have any reservations";
                    return;
                }

                foreach (var reservation in reservations)
                {
                    DataGridViewRow? existingRow = dataGridViewReservations.Rows
                            .Cast<DataGridViewRow>()
                            .Where(row => row.Cells["Title"].Value.ToString() == reservation.Title
                            && row.Cells["StartTime"].Value.ToString() == reservation.StartTime
                            && row.Cells["RoomNumber"].Value.ToString() == reservation.RoomNumber)
                            .FirstOrDefault();

                    if (existingRow == null)
                    {
                        var row = dataGridViewReservations.Rows[dataGridViewReservations.Rows.Add()];

                        row.Cells["Title"].Value = reservation.Title;
                        row.Cells["StartTime"].Value = reservation.StartTime;
                        row.Cells["RoomNumber"].Value = reservation.RoomNumber;
                        row.Cells["Seats"].Value = reservation.Seat;
                    }
                    else
                    {
                        existingRow.Cells["Seats"].Value += $", {reservation.Seat}";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured while trying to get user reservations. " + ex.Message);
            }
        }

        private void UserReservation_Load(object sender, EventArgs e)
        {
            buttonReservations.Enabled = false;
            buttonReservations.BackColor = Color.SlateGray;

            NavBarManager.SetAdminButtonVisibility(buttonAdminPanel, _user!.Role);
            NavBarManager.SetEmployeeButtonVisibility(buttonEmployeePanel, _user!.Role);

            dataGridViewReservations.AutoGenerateColumns = false;

            dataGridViewReservations.Columns.Add("Title", "Title");
            dataGridViewReservations.Columns.Add("StartTime", "Start Time");
            dataGridViewReservations.Columns.Add("RoomNumber", "Room Number");
            dataGridViewReservations.Columns.Add("Seats", "Seats");

            DataGridViewButtonColumn buttonColumnCancel = new DataGridViewButtonColumn();
            buttonColumnCancel.HeaderText = "Cancel Reservation";
            buttonColumnCancel.Text = "Cancel";
            buttonColumnCancel.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn buttonColumnGenerateFile = new DataGridViewButtonColumn();
            buttonColumnGenerateFile.HeaderText = "Confirmation";
            buttonColumnGenerateFile.Text = "Generate";
            buttonColumnGenerateFile.UseColumnTextForButtonValue = true;

            dataGridViewReservations.Columns.Add(buttonColumnCancel);
            dataGridViewReservations.Columns.Add(buttonColumnGenerateFile);

            DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();
            cellStyle.Padding = new Padding(50, 120, 50, 120);
            buttonColumnCancel.DefaultCellStyle = cellStyle;
            buttonColumnGenerateFile.DefaultCellStyle = cellStyle;

            refreshData();
        }

        private void buttonWhatsOn_Click(object sender, EventArgs e)
        {
            UserMainMenu? userMainMenu = Application.OpenForms.OfType<UserMainMenu>()
                .Where(r => r.GetLoggedInUser().Id == _user.Id)
                .FirstOrDefault();

            if (userMainMenu != null) { userMainMenu.Show(); }

            this.Close();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            StartFormLogin startFormLogin = new StartFormLogin("");
            startFormLogin.Show();
            Close();
        }

        private void dataGridViewReservations_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewReservations.Columns[e.ColumnIndex].Name == "Seats")
            {
                if (e.Value != null)
                {
                    dataGridViewReservations.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.WrapMode = DataGridViewTriState.True;
                }
            }
        }

        private void dataGridViewReservations_SelectionChanged(object sender, EventArgs e)
        {
            dataGridViewReservations.ClearSelection();
        }

        private void dataGridViewReservations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex == 5)
            {
                if (dataGridViewReservations.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex != -1)
                {
                    try
                    {
                        using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                        {
                            saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
                            saveFileDialog.RestoreDirectory = true;

                            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                            {
                                if (dataGridViewReservations.Rows[e.RowIndex].Cells["Seats"].Value.ToString() == "") throw new Exception();
                                if (dataGridViewReservations.Rows[e.RowIndex].Cells["Seats"].Value.ToString() == null) throw new Exception();

                                string filePath = saveFileDialog.FileName;
                                GenerateFilesService.GeneratePDFWithReservation(Person.GetClient(_user.Id)
                                    , Reservation.GetUserReservation(_user.Id, Screening.GetScreeningIdFromDateAndMovie(
                                        dataGridViewReservations.Rows[e.RowIndex].Cells["StartTime"].Value.ToString(),
                                        Movie.GetMovieByTitle(dataGridViewReservations.Rows[e.RowIndex].Cells["Title"].Value.ToString()).Id))
                                    , dataGridViewReservations.Rows[e.RowIndex].Cells["Seats"].Value.ToString()
                                    , filePath);

                                labelMessage.Text = "Your confirmation has been generated successfully";
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error occured while trying to generate confirmation file. " + ex.Message);
                    }
                }
            }



            if (e.RowIndex >= 0 && e.ColumnIndex == 4)
            {
                if (dataGridViewReservations.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex != -1)
                {
                    try
                    {
                        var movieTitle = dataGridViewReservations.Rows[e.RowIndex].Cells["Title"].Value.ToString();
                        var startTime = dataGridViewReservations.Rows[e.RowIndex].Cells["StartTime"].Value.ToString();

                        if (movieTitle == null || startTime == null) throw new Exception();

                        ConfirmationForm confirmationForm = new ConfirmationForm();
                        confirmationForm.ShowDialog();

                        if (confirmationForm.WasYesClicked)
                        {
                            Reservation.CancelReservation(_user.Id, movieTitle, startTime);
                            refreshData();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error occured while trying to cancel your reservation. " + ex.Message);
                    }
                }
            }
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            UserProfileForm userProfileForm = new UserProfileForm(_user);
            userProfileForm.Show();
            Close();
        }

        private void buttonAdminPanel_Click(object sender, EventArgs e)
        {
            AdminPanelMainMenu adminPanelMainMenu = new AdminPanelMainMenu(_user!);
            adminPanelMainMenu.Show();
            Close();
        }

        private void buttonEmployeePanel_Click(object sender, EventArgs e)
        {
            EmployeePanelMainMenu employeePanelMainMenu = new EmployeePanelMainMenu(_user!);
            employeePanelMainMenu.Show();
            Close();
        }
    }
}
