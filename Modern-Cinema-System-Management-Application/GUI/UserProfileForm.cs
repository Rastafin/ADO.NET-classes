using Backend.Model;
using Backend.Model.Enums;
using Backend.Services;
using GUI.Functions;
using iTextSharp.text.pdf;
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
    public partial class UserProfileForm : Form
    {
        private readonly Person _client;
        public UserProfileForm(User user)
        {
            _client = Person.GetClient(user.Id);
            InitializeComponent();
        }

        private void buttonWhatsOn_Click(object sender, EventArgs e)
        {
            UserMainMenu? userMainMenu = Application.OpenForms.OfType<UserMainMenu>()
                .Where(r => r.GetLoggedInUser().Id == _client.UserId)
                .FirstOrDefault();

            if (userMainMenu != null) { userMainMenu.Show(); }

            this.Close();
        }

        private void UserProfileForm_Load(object sender, EventArgs e)
        {
            buttonProfile.Enabled = false;
            buttonProfile.BackColor = Color.SlateGray;

            NavBarManager.SetAdminButtonVisibility(buttonAdminPanel, _client.User!.Role);
            NavBarManager.SetEmployeeButtonVisibility(buttonEmployeePanel, _client.User.Role);

            try
            {
                textBoxLogin.Text = _client.User.Login;
                textBoxEmail.Text = _client.User.Email;
                textBoxName.Text = _client.Name;
                textBoxLastname.Text = _client.LastName;
                maskedTextBoxBirthday.Text = _client.Birthday;
                comboBoxSex.Text = _client.Sex.ToString();
                textBoxPhoneNumber.Text = _client.PhoneNumber;
                textBoxCountry.Text = _client.Country;
                textBoxCity.Text = _client.City;
                textBoxStreet.Text = _client.Street;
                textBoxHouseNumber.Text = _client.HouseNumber;
                maskedTextBoxZipCode.Text = _client.ZipCode;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured while trying to load user data. " + ex.Message);
                return;
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            StartFormLogin startFormLogin = new StartFormLogin("");
            startFormLogin.Show();
            Close();
        }

        private void buttonReservations_Click(object sender, EventArgs e)
        {
            UserReservation userReservation = new UserReservation(_client.User!);
            userReservation.Show();
            Close();
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            Sex parsedSex;

            if (!Enum.TryParse(comboBoxSex.Text, out parsedSex))  // need to make some change and put it to validationService
            {
                labelMessage.Text = "Bad Sex format";
                return;
            }

            if (!ValidationService.ValidatePersonalDataChange(_client, textBoxLogin.Text, textBoxEmail.Text, textBoxName.Text, textBoxLastname.Text, maskedTextBoxBirthday.Text, comboBoxSex.Text, textBoxPhoneNumber.Text,
                textBoxCountry.Text, textBoxCity.Text, textBoxStreet.Text, textBoxHouseNumber.Text, maskedTextBoxZipCode.Text, out string message))
            {
                labelMessage.Text = message;
                return;
            }

            try
            {
                _client.User.Login = textBoxLogin.Text;
                _client.User.Email = textBoxEmail.Text;
                _client.Name = textBoxName.Text;
                _client.LastName = textBoxLastname.Text;
                _client.Birthday = maskedTextBoxBirthday.Text;
                _client.Sex = parsedSex;
                _client.PhoneNumber = textBoxPhoneNumber.Text;
                _client.Country = textBoxCountry.Text;
                _client.City = textBoxCity.Text;
                _client.Street = textBoxStreet.Text;
                _client.HouseNumber = textBoxHouseNumber.Text;
                _client.ZipCode = maskedTextBoxZipCode.Text;

                Person.UpdateClient(_client);
                labelMessageSuccess.Text = "Your data has been changed successfully";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured while trying to save changed data. " + ex.Message);
            }
        }

        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            ChangePasswordForm changePasswordForm = new ChangePasswordForm(_client.User);
            changePasswordForm.ShowDialog();
        }

        public void ChangeLabelMessage(string message)
        {
            if (message != null)
            {
                labelMessageSuccess.Text = message;
                buttonLogout.Enabled = false;
            }

            System.Threading.Timer timer = null;
            timer = new System.Threading.Timer((state) =>
            {
                labelMessage.Invoke((MethodInvoker)(() => labelMessageSuccess.Text = ""));
                buttonLogout.Invoke((MethodInvoker)(() => buttonLogout.Enabled = true));
                timer.Dispose();
            }, null, 1500, System.Threading.Timeout.Infinite);
        }

        private void buttonAdminPanel_Click(object sender, EventArgs e)
        {
            AdminPanelMainMenu adminPanelMainMenu = new AdminPanelMainMenu(_client.User!);
            adminPanelMainMenu.Show();
            Close();
        }

        private void buttonEmployeePanel_Click(object sender, EventArgs e)
        {
            EmployeePanelMainMenu employeePanelMainMenu = new EmployeePanelMainMenu(_client.User!);
            employeePanelMainMenu.Show();
            Close();
        }
    }
}
