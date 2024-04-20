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

namespace GUI
{
    public partial class ChangePasswordForm : Form
    {
        private readonly User _user;
        public ChangePasswordForm(User user)
        {
            InitializeComponent();
            _user = User.GetUserByUserId(user.Id);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            try
            {
                if (!PasswordHasher.VerifyPassword(textBoxPassword.Text, _user.Password))
                {
                    labelMessage.Text = "Incorrect password";
                    return;
                }

                if (!ValidationService.ValidateUserPassword(textBoxNewPassword.Text, out string message))
                {
                    labelMessage.Text = message;
                    return;
                }

                User.ChangePassword(_user, PasswordHasher.HashPassword(textBoxNewPassword.Text));

                UserProfileForm? userProfileForm = Application.OpenForms.OfType<UserProfileForm>().FirstOrDefault();

                if (userProfileForm != null) { userProfileForm.ChangeLabelMessage("Your password has been changed"); }

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured while trying to change password. " + ex.Message);
                Close();
            }
        }

        private void ChangePasswordForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = labelMessage;
        }
    }
}
