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
    public partial class UserMessagesForm : Form
    {
        private readonly User _user;
        public UserMessagesForm(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void UserMessagesForm_Load(object sender, EventArgs e)
        {
            dataGridViewMessages.AutoGenerateColumns = false;

            dataGridViewMessages.Columns.Add("Date", "Date");
            dataGridViewMessages.Columns.Add("Message", "Message");

            dataGridViewMessages.Columns["Date"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;

            loadMessagesToDGV();
        }

        private void loadMessagesToDGV()
        {
            try
            {
                List<Backend.Model.Message> userMessages = Backend.Model.Message.GetNotReadUserMessages(_user.Id);

                if (userMessages == null || userMessages.Count == 0)
                {
                    Close();
                    return;
                }

                dataGridViewMessages.Rows.Clear();

                foreach (Backend.Model.Message message in userMessages)
                {
                    var row = dataGridViewMessages.Rows[dataGridViewMessages.Rows.Add()];

                    row.Cells["Date"].Value = message.Date;
                    row.Cells["Message"].Value = message.Contents;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while trying to load messages. " + ex.Message);
            }
        }

        private void dataGridViewMessages_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewMessages.Columns[e.ColumnIndex].Name == "Message")
            {
                if (e.Value != null)
                {
                    dataGridViewMessages.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.WrapMode = DataGridViewTriState.True;
                }
            }
        }

        private void buttonDeleteScreening_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewMessages.SelectedRows.Count > 0)
                {
                    var selectedRow = dataGridViewMessages.SelectedRows[0];

                    if (selectedRow.Cells["Date"].Value != null &&
                        selectedRow.Cells["Message"].Value != null)
                    {
                        Backend.Model.Message.MarkMessageAsRead(selectedRow.Cells["Date"].Value.ToString()!,
                            selectedRow.Cells["Message"].Value.ToString()!, _user.Id);

                        loadMessagesToDGV();
                    }
                    else
                    {
                        throw new Exception("Invalid role cell or value is null. ");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while trying to . " + ex.Message);
            }
        }
    }
}
