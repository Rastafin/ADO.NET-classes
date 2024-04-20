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
    public partial class RoomSmallSeatsChoice : Form
    {
        private List<bool> _buttonStatusList = new List<bool>();
        private readonly int _screeningId;
        private readonly User _user;
        private readonly int _numberOfSeatsForReservation;
        private void listOfButtonsInitialization()
        {
            try
            {
                for (int i = 0; i < 20; i++)
                {
                    _buttonStatusList.Add(false);
                }

                List<string> reservedSeats = Reservation.GetReservedSeatsForScreening(_screeningId);

                if (reservedSeats == null) return;

                foreach (string reservedSeat in reservedSeats)
                {
                    string buttonName = "button" + (reservedSeat);
                    Control[] foundButtons = this.Controls.Find(buttonName, true);

                    if (foundButtons.Length > 0 && foundButtons[0] is Button)
                    {
                        Button button = (Button)foundButtons[0];

                        button.BackColor = Color.Red;
                        button.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured while trying to load seats. " + ex.Message);
            }
        }

        private bool buttonClicked(string buttonText)
        {
            int idButtonInList = int.Parse(buttonText) - 1;
            try
            {


                for (int i = 0; i < 20; i++)
                {
                    if (i == idButtonInList)
                    {
                        _buttonStatusList[i] = !_buttonStatusList[i];
                        return _buttonStatusList[i];
                    }
                }

                throw new Exception();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured while trying to find this button");
                return false;
            }
        }

        public RoomSmallSeatsChoice(int screeningId, User user, int numberOfSeatsForReservation)
        {
            _screeningId = screeningId;
            _user = user;
            _numberOfSeatsForReservation = numberOfSeatsForReservation;

            InitializeComponent();
            listOfButtonsInitialization();

            labelMessage.Hide();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RoomSmallSeatsChoice_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (buttonClicked(buttonA1.Text))
            {
                buttonA1.BackColor = Color.Blue;
            }
            else
            {
                buttonA1.BackColor = Color.FromArgb(128, 255, 128);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (buttonClicked(buttonA2.Text))
            {
                buttonA2.BackColor = Color.Blue;
            }
            else
            {
                buttonA2.BackColor = Color.FromArgb(128, 255, 128);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (buttonClicked(buttonA3.Text))
            {
                buttonA3.BackColor = Color.Blue;
            }
            else
            {
                buttonA3.BackColor = Color.FromArgb(128, 255, 128);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (buttonClicked(buttonA4.Text))
            {
                buttonA4.BackColor = Color.Blue;
            }
            else
            {
                buttonA4.BackColor = Color.FromArgb(128, 255, 128);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (buttonClicked(buttonA5.Text))
            {
                buttonA5.BackColor = Color.Blue;
            }
            else
            {
                buttonA5.BackColor = Color.FromArgb(128, 255, 128);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (buttonClicked(buttonB6.Text))
            {
                buttonB6.BackColor = Color.Blue;
            }
            else
            {
                buttonB6.BackColor = Color.FromArgb(128, 255, 128);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (buttonClicked(buttonB7.Text))
            {
                buttonB7.BackColor = Color.Blue;
            }
            else
            {
                buttonB7.BackColor = Color.FromArgb(128, 255, 128);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (buttonClicked(buttonB8.Text))
            {
                buttonB8.BackColor = Color.Blue;
            }
            else
            {
                buttonB8.BackColor = Color.FromArgb(128, 255, 128);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (buttonClicked(buttonB9.Text))
            {
                buttonB9.BackColor = Color.Blue;
            }
            else
            {
                buttonB9.BackColor = Color.FromArgb(128, 255, 128);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (buttonClicked(buttonB10.Text))
            {
                buttonB10.BackColor = Color.Blue;
            }
            else
            {
                buttonB10.BackColor = Color.FromArgb(128, 255, 128);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (buttonClicked(buttonC11.Text))
            {
                buttonC11.BackColor = Color.Blue;
            }
            else
            {
                buttonC11.BackColor = Color.FromArgb(128, 255, 128);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (buttonClicked(buttonC12.Text))
            {
                buttonC12.BackColor = Color.Blue;
            }
            else
            {
                buttonC12.BackColor = Color.FromArgb(128, 255, 128);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (buttonClicked(buttonC13.Text))
            {
                buttonC13.BackColor = Color.Blue;
            }
            else
            {
                buttonC13.BackColor = Color.FromArgb(128, 255, 128);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (buttonClicked(buttonC14.Text))
            {
                buttonC14.BackColor = Color.Blue;
            }
            else
            {
                buttonC14.BackColor = Color.FromArgb(128, 255, 128);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (buttonClicked(buttonC15.Text))
            {
                buttonC15.BackColor = Color.Blue;
            }
            else
            {
                buttonC15.BackColor = Color.FromArgb(128, 255, 128);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (buttonClicked(buttonD16.Text))
            {
                buttonD16.BackColor = Color.Blue;
            }
            else
            {
                buttonD16.BackColor = Color.FromArgb(128, 255, 128);
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (buttonClicked(buttonD17.Text))
            {
                buttonD17.BackColor = Color.Blue;
            }
            else
            {
                buttonD17.BackColor = Color.FromArgb(128, 255, 128);
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (buttonClicked(buttonD18.Text))
            {
                buttonD18.BackColor = Color.Blue;
            }
            else
            {
                buttonD18.BackColor = Color.FromArgb(128, 255, 128);
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (buttonClicked(buttonD19.Text))
            {
                buttonD19.BackColor = Color.Blue;
            }
            else
            {
                buttonD19.BackColor = Color.FromArgb(128, 255, 128);
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (buttonClicked(buttonD20.Text))
            {
                buttonD20.BackColor = Color.Blue;
            }
            else
            {
                buttonD20.BackColor = Color.FromArgb(128, 255, 128);
            }
        }

        private void buttonChooseBook_Click(object sender, EventArgs e)
        {
            int numberOfSelectedSeats = _buttonStatusList.Count(status => status);

            if (numberOfSelectedSeats != _numberOfSeatsForReservation)              
            {
                labelMessage.Show();
                return;
            }
            try
            {
                Reservation.MakeReservationForScreening(_user.Id, _screeningId, getSelectedSeats());
                UserTicketsAmountChoice? userTicketsAmountChoice = Application.OpenForms.OfType<UserTicketsAmountChoice>().FirstOrDefault();
                UserMainMenu? userMainMenu = Application.OpenForms.OfType<UserMainMenu>()
                    .Where(r => r.GetLoggedInUser().Id == _user.Id)
                    .FirstOrDefault();

                if (userTicketsAmountChoice != null) userTicketsAmountChoice.Close();
                if (userMainMenu != null) { userMainMenu.ChangeLabelMessage("Your reservation has been made"); }

                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error occured while trying to make reservation. " + ex.Message);    
            }
        }

        private List<string> getSelectedSeats()
        {
            List<string> listOfSeats = new List<string>();

            try
            {
                List<int> selectedButtonsIndexes = _buttonStatusList
                    .Select((status, index) => new { Status = status, Index = index })
                    .Where(item => item.Status)
                    .Select(item => item.Index + 1)
                    .ToList();

                foreach (int index in selectedButtonsIndexes)
                {
                    switch ((index - 1) / 5)
                    {
                        case 0:
                            listOfSeats.Add("A" + index.ToString());
                            break;
                        case 1:
                            listOfSeats.Add("B" + index.ToString());
                            break;
                        case 2:
                            listOfSeats.Add("C" + index.ToString());
                            break;
                        case 3:
                            listOfSeats.Add("D" + index.ToString());
                            break;
                    }
                }

                return listOfSeats;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured while trying to get selected seats. " + ex.Message);
                return listOfSeats;
            }
        }
    }
}
