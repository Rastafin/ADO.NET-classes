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
    public partial class EmployeePanelMainMenu : Form
    {
        private readonly User _user;
        private readonly string _imagesPath = @"..\..\..\..\Backend\Data\Pictures\";
        public EmployeePanelMainMenu(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void EmployeePanelMainMenu_Load(object sender, EventArgs e)
        {
            buttonUsersReservations.Enabled = false;
            buttonUsersReservations.BackColor = Color.SlateGray;

            dataGridViewReservations.AutoGenerateColumns = false;

            dataGridViewReservations.Columns.Add("ID", "ID");
            dataGridViewReservations.Columns.Add("Email", "Email");
            dataGridViewReservations.Columns.Add("Name", "Name");
            dataGridViewReservations.Columns.Add("Lastname", "Last name");
            dataGridViewReservations.Columns.Add("StartTime", "Start Time");
            dataGridViewReservations.Columns.Add("Title", "Title");
            dataGridViewReservations.Columns.Add("RoomNumber", "Room number");
            dataGridViewReservations.Columns.Add("Seats", "Seats");

            DataGridViewImageColumn dataGridViewImageColumn = new DataGridViewImageColumn();
            dataGridViewImageColumn.HeaderText = "Received";
            dataGridViewImageColumn.Name = "IsReceived";
            dataGridViewImageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;

            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.HeaderText = "IsReceivedValueColumn";
            column.Name = "IsReceivedValueColumn";
            column.Visible = false;

            dataGridViewReservations.Columns.Add(column);

            dataGridViewReservations.Columns.Add(dataGridViewImageColumn);

            dataGridViewReservations.Columns["Email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewReservations.Columns["StartTime"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewReservations.Columns["Seats"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewReservations.Columns["IsReceived"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

            dataGridViewReservations.Columns["Seats"].MinimumWidth = 100;

            loadReservationsToDGV();
        }

        private void loadReservationsToDGV(string filter = "")
        {
            dataGridViewReservations.Show();
            labelMessage.Text = String.Empty;

            try
            {
                List<Reservation> reservations = Reservation.GetNotDeletedReservations();

                if (reservations == null || reservations.Count == 0)
                {
                    dataGridViewReservations.Hide();
                    labelMessage.Text = "There are not any reservations";
                    return;
                }

                dataGridViewReservations.Rows.Clear();

                foreach (Reservation reservation in reservations)
                {
                    Person client = Person.GetClient((int)reservation.UserId);

                    if (string.IsNullOrEmpty(filter)
                        || (reservation.Id.ToString().Contains(filter, StringComparison.OrdinalIgnoreCase))
                        || (client.Name != null && client.Name.Contains(filter, StringComparison.OrdinalIgnoreCase))
                        || (client.LastName != null && client.LastName.Contains(filter, StringComparison.OrdinalIgnoreCase)))
                    {


                        DataGridViewRow? existingRow = dataGridViewReservations.Rows
                            .Cast<DataGridViewRow>()
                            .Where(row => row.Cells["Title"].Value.ToString() == reservation.Screening!.Movie.Title
                            && row.Cells["StartTime"].Value.ToString() == reservation.Screening.StartTime
                            && row.Cells["Email"].Value.ToString() == client.User.Email
                            && row.Cells["RoomNumber"].Value.ToString() == reservation.Screening.Room.RoomNumber
                            && row.Cells["IsReceivedValueColumn"].Value.ToString() == reservation.IsReceived.ToString())
                            .FirstOrDefault();

                        if (existingRow == null)
                        {
                            var row = dataGridViewReservations.Rows[dataGridViewReservations.Rows.Add()];

                            row.Cells["ID"].Value = reservation.Id;
                            row.Cells["Email"].Value = client.User.Email;
                            row.Cells["Name"].Value = client.Name;
                            row.Cells["Lastname"].Value = client.LastName;
                            row.Cells["StartTime"].Value = reservation.Screening!.StartTime;
                            row.Cells["Title"].Value = reservation.Screening.Movie.Title;
                            row.Cells["RoomNumber"].Value = reservation.Screening.Room.RoomNumber;
                            row.Cells["Seats"].Value = reservation.Seat;
                            row.Cells["IsReceivedValueColumn"].Value = reservation.IsReceived.ToString();

                            if (reservation.IsReceived == false)
                            {
                                row.Cells["IsReceived"].Value = Image.FromFile(_imagesPath + "NotReceived.png");
                            }
                            else if (reservation.IsReceived == true)
                            {
                                row.Cells["IsReceived"].Value = Image.FromFile(_imagesPath + "Received.png");
                            }

                        }
                        else if (existingRow != null)
                        {
                            existingRow.Cells["Seats"].Value += $", {reservation.Seat}";
                        }

                    }
                }

                if (dataGridViewReservations.Rows.Count < 1)
                {
                    labelMessage.Text = "Cannot find any reservation";
                    dataGridViewReservations.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while trying to load reservations. " + ex.Message);
            }
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

        private void textBoxFilter_TextChanged(object sender, EventArgs e)
        {
            string filter = textBoxFilter.Text.Trim();
            loadReservationsToDGV(filter);
        }

        private void buttonConfirmReservation_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewReservations.SelectedRows.Count > 0)
                {
                    var selectedRow = dataGridViewReservations.SelectedRows[0];

                    if (selectedRow.Cells["Email"].Value != null &&
                        selectedRow.Cells["StartTime"].Value != null &&
                        selectedRow.Cells["RoomNumber"].Value != null &&
                        selectedRow.Cells["IsReceivedValueColumn"].Value != null)
                    {
                        if (selectedRow.Cells["IsReceivedValueColumn"].Value.ToString() == "True")
                        {
                            labelMessage.Text = "This reservation has been \nalready received";
                            return;
                        }

                        List<Reservation> reservations = Reservation.GetUserReservationsListByStartTimeAndRoomNumber(
                            selectedRow.Cells["Email"].Value.ToString(), selectedRow.Cells["StartTime"].Value.ToString(),
                            selectedRow.Cells["RoomNumber"].Value.ToString());

                        ConfirmReservationForm confirmReservationForm = new ConfirmReservationForm();
                        confirmReservationForm.ShowDialog();

                        if (confirmReservationForm.ConfrimationNumber == string.Empty) return;

                        string inputConfirmationNumber = confirmReservationForm.ConfrimationNumber;

                        foreach (var reservation in reservations)
                        {
                            if (inputConfirmationNumber != string.Empty && inputConfirmationNumber != null
                            && inputConfirmationNumber == reservation.ConfirmationNumber)
                            {
                                Reservation.ConfirmReservation(reservation.Id);
                                labelMessageConfirmation.Text = string.Empty;
                            }
                            else
                            {
                                labelMessageConfirmation.Text = "Wrong Confirmation Number";
                                buttonBack.Enabled = false;

                                System.Threading.Timer timer = null;
                                timer = new System.Threading.Timer((state) =>
                                {
                                    labelMessageConfirmation.Invoke((MethodInvoker)(() => labelMessageConfirmation.Text = ""));
                                    buttonBack.Invoke((MethodInvoker)(() => buttonBack.Enabled = true));
                                    timer.Dispose();
                                }, null, 3000, System.Threading.Timeout.Infinite);

                            }
                        }

                        loadReservationsToDGV();
                    }
                    else
                    {
                        throw new Exception("Invalid role cell or value is null. ");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error occurred while trying to confirm your reservation. " + ex.Message);
            }
        }

        private void buttonMovies_Click(object sender, EventArgs e)
        {
            EmployeePanelMovies employeePanelMovies = new EmployeePanelMovies(_user);
            employeePanelMovies.Show();
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

        private void buttonScreenings_Click(object sender, EventArgs e)
        {
            EmployeePanelScreenings employeePanelScreenings = new EmployeePanelScreenings(_user);
            employeePanelScreenings.Show();
            Close();
        }
    }
}
