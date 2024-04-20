using Backend.Entities;
using Backend.Repositories;

namespace ADO.NET_ModernCinemaApplication
{
    public partial class Form1 : Form
    {
        private readonly UserRepository _userRepository = new UserRepository();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*List<User> users = _userRepository.GetAllUsers();

            foreach (User user in users)
            {
                MessageBox.Show($"ID: {user.Id}, Login: {user.Login}, Email: {user.Email}, Status: {user.Status.ToString()}," +
                    $" Role: {user.Role}");
            }*/
        }
    }
}
