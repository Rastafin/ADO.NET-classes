using System.Data;
using System.Data.OleDb;



namespace Zajecia08._03._2024
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCzytnik_Click(object sender, EventArgs e)
        {
            lblMovies.Text = string.Empty;

            try
            {
                using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source = filmy.mdb"))
                {
                    OleDbCommand command = new OleDbCommand();

                    command.CommandText = "SELECT * FROM filmy";

                    command.Connection = conn;

                    conn.Open();

                    OleDbDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        lblMovies.Text += $"{reader.GetValue(0).ToString()} {reader.GetValue(1).ToString()} {reader.GetValue(2).ToString()}\n";

                    }
                }
            }
            catch (OleDbException olEx)
            {
                MessageBox.Show(olEx.Message.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void buttonWyswietlZParametrem_Click(object sender, EventArgs e)
        {
            lblMovies.Text = string.Empty;

            try
            {
                using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source = filmy.mdb"))
                {
                    OleDbCommand command = new OleDbCommand();

                    command.CommandText = "SELECT * FROM filmy WHERE tytul=@Title AND rodzaj=@Rodzaj";

                    command.Parameters.AddWithValue("@Title", textBoxTytul.Text);
                    command.Parameters.AddWithValue("@Rodzaj", textBoxRodzaj.Text);

                    command.Connection = conn;

                    conn.Open();

                    OleDbDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        lblMovies.Text += $"{reader.GetValue(0).ToString()} {reader.GetValue(1).ToString()} {reader.GetValue(2).ToString()}\n";

                    }
                }
            }
            catch (OleDbException olEx)
            {
                MessageBox.Show(olEx.Message.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void textBoxRodzaj_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void buttonWyswietlSchematDataTable_Click(object sender, EventArgs e)
        {
            lblMovies.Text = string.Empty;

            try
            {
                using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source = filmy.mdb"))
                {

                    DataTable dataTable = new DataTable();

                    OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM filmy", conn);

                    adapter.FillSchema(dataTable, SchemaType.Source);

                    foreach (DataColumn column in dataTable.Columns)
                    {
                        lblMovies.Text += column.ColumnName.ToString() + "\n";
                    }
                }
            }
            catch (OleDbException olEx)
            {
                MessageBox.Show(olEx.Message.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void buttonWyswietlFilmyDataAdapterDataTable_Click(object sender, EventArgs e)
        {
            lblMovies.Text = string.Empty;

            try
            {
                using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source = filmy.mdb"))
                {
                    DataTable dataTable = new DataTable();

                    OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM filmy", conn);

                    adapter.Fill(dataTable);

                    foreach(DataRow row in dataTable.Rows)
                    {
                        lblMovies.Text += row["tytul"].ToString() + " " + row["numer_plyty"].ToString() + " " + row["rodzaj"] + "\n";
                    }
                }
            }
            catch (OleDbException olEx)
            {
                MessageBox.Show(olEx.Message.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
