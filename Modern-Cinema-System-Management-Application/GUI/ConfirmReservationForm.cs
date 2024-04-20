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
    public partial class ConfirmReservationForm : Form
    {
        public string ConfrimationNumber { get; private set; } = "";
        public ConfirmReservationForm()
        {
            InitializeComponent();
        }

        private void ConfirmReservationForm_Load(object sender, EventArgs e)
        {
            labelWarning.Hide();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonConfirmation_Click(object sender, EventArgs e)
        {
            if (textBoxConfirmationNumber.Text.Length < 1)
            {
                labelWarning.Show();
                return;
            }

            ConfrimationNumber = textBoxConfirmationNumber.Text;
            Close();
        }

        private void textBoxConfirmationNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
        }
    }
}
