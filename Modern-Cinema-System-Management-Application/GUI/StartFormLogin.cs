using Backend.Data;
using Backend.Model;

namespace GUI
{
    public partial class StartFormLogin : Form
    {
        private readonly string _message = String.Empty;
        public StartFormLogin(string message)
        {
            InitializeComponent();
            _message = message;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelMessage.Text = _message;
            try
            {
                Reservation.DeleteOldReservations();
                Movie.ArchiveMoviesToWithdraw();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while trying to\ncarry out starting jobs. " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;

            try
            {
                if (User.CheckUserData(login, password, out int userId))
                {
                    UserMainMenu userMainMenu = new UserMainMenu(userId);
                    userMainMenu.Show();
                    Hide();
                }
                else
                {
                    labelMessage.Text = "        Incorrect data. Try again";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured while trying to log in you");
            }
        }
    }
}