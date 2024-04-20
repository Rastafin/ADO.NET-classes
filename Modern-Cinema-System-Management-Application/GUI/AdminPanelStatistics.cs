using Backend.Model;
using Backend.Services;
using Org.BouncyCastle.Asn1.Crmf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GUI
{
    public partial class AdminPanelStatistics : Form
    {
        private readonly User _user;
        public AdminPanelStatistics(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void AdminPanelStatistics_Load(object sender, EventArgs e)
        {
            AdminPanelStatistics_Load(sender, e, Controls);

            createChartSexCount();
            createChartMovieCategory();
            createAgeChart();
        }

        private void AdminPanelStatistics_Load(object sender, EventArgs e, Control.ControlCollection controls)
        {
            buttonStatistics.Enabled = false;
            buttonStatistics.BackColor = Color.SlateGray;

        }

        private void createChartSexCount()
        {
            ChartArea chartArea = new ChartArea();
            chartArea.Name = "PieSexChartArea";
            chartArea.Position.Auto = false;
            chartArea.Position.Width = 80;
            chartArea.Position.Height = 80;
            chartArea.Position.X = 10;

            chartArea.Position.Y = 10;
            chartArea.BackColor = Color.FromArgb(14, 14, 14);

            chartSex.ChartAreas.Add(chartArea);

            try
            {
                var (malePercentage, femalePercentage, otherPercentage) = ChartDataCalculator.GetUsersSexDataCounts();

                Series series = new Series("Sex count");
                series.ChartType = SeriesChartType.Pie;
                series.Points.AddXY("Males", malePercentage);
                series.Points.AddXY("Females", femalePercentage);
                series.Points.AddXY("Others", otherPercentage);
                series.Font = new Font("Arial", 12f, FontStyle.Bold);

                chartSex.Series.Add(series);
                series.ChartArea = "PieSexChartArea";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while trying to load chartSex data. " + ex.Message);
            }

            chartSex.Legends.Add(new Legend("Legend"));
            chartSex.Legends[0].Docking = Docking.Bottom;
        }

        private void createChartMovieCategory()
        {
            ChartArea chartArea = new ChartArea();
            chartArea.Name = "PieMovieCategoryChartArea";
            chartArea.Position.Auto = false;
            chartArea.Position.Width = 80;
            chartArea.Position.Height = 80;
            chartArea.Position.X = 10;

            chartArea.Position.Y = 10;
            chartArea.BackColor = Color.FromArgb(14, 14, 14);

            chartMovieCategory.ChartAreas.Add(chartArea);

            try
            {
                var (comedyPercentage, actionPercentage, adventurePercentage, dramaPercentage, horrorPercentage,
                    thrillerPercentage) = ChartDataCalculator.GetMoviesCategoryDataCounts();

                Series series = new Series("MovieCategory count");
                series.ChartType = SeriesChartType.Pie;
                series.Points.AddXY("Comedy", comedyPercentage);
                series.Points.AddXY("Action", actionPercentage);
                series.Points.AddXY("Adventure", adventurePercentage);
                series.Points.AddXY("Drama", dramaPercentage);
                series.Points.AddXY("Horror", horrorPercentage);
                series.Points.AddXY("Thriller", thrillerPercentage);

                series.Font = new Font("Arial", 12f, FontStyle.Bold);

                chartMovieCategory.Series.Add(series);
                series.ChartArea = "PieMovieCategoryChartArea";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while trying to load chartMovieCategory data. " + ex.Message);
            }

            chartMovieCategory.Legends.Add(new Legend("Legend"));
            chartMovieCategory.Legends[0].Docking = Docking.Bottom;
        }

        private void createAgeChart()
        {
            ChartArea chartArea = new ChartArea();
            chartArea.Name = "AgeChartArea";
            chartArea.Position.Auto = false;
            chartArea.Position.Width = 80;
            chartArea.Position.Height = 80;
            chartArea.Position.X = 10;

            chartArea.Position.Y = 10;
            chartArea.BackColor = Color.FromArgb(14, 14, 14);

            chartArea.AxisX.LineColor = Color.Coral;
            chartArea.AxisY.LineColor = Color.Coral;
            chartArea.AxisX.MajorGrid.LineColor = Color.Coral;
            chartArea.AxisY.MajorGrid.LineColor = Color.Coral;

            chartArea.AxisY.LabelStyle.ForeColor = Color.Coral;

            chartAge.ChartAreas.Add(chartArea);

            chartAge.Series.Clear();

            try
            {
                var ageGroupsDistribution = ChartDataCalculator.GetAgeGroupsDistribution();

                foreach (var ageGroup in ageGroupsDistribution)
                {
                    Series series = new Series(ageGroup.Key);
                    series.ChartType = SeriesChartType.Column;
                    series.Points.Add(ageGroup.Value);

                    chartAge.Series.Add(series);
                    series.ChartArea = "AgeChartArea";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while trying to load chartAge data. " + ex.Message);
            }

            chartAge.Legends.Add(new Legend("Legend"));
            chartAge.Legends[0].Docking = Docking.Bottom;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            UserMainMenu? userMainMenu = Application.OpenForms.OfType<UserMainMenu>()
                .Where(r => r.GetLoggedInUser().Id == _user.Id)
                .FirstOrDefault();

            if (userMainMenu != null) { userMainMenu.Show(); }

            this.Close();
        }

        private void buttonUsers_Click(object sender, EventArgs e)
        {
            AdminPanelMainMenu adminPanelMainMenu = new AdminPanelMainMenu(_user);
            adminPanelMainMenu.Show();
            this.Close();
        }

        private void chartSex_MouseClick(object sender, MouseEventArgs e)
        {
            resetChartFonts();

            var results = chartSex.HitTest(e.X, e.Y, false, ChartElementType.DataPoint);

            foreach (var result in results)
            {
                if (result.ChartElementType == ChartElementType.DataPoint)
                {
                    var dataPoint = chartSex.Series[result.Series.Name].Points[result.PointIndex];
                    labelMessage.Text = $"{dataPoint.AxisLabel} make up {dataPoint.YValues[0]:F2} percent \nof all app users";
                    dataPoint.Font = new Font(dataPoint.Font.FontFamily, dataPoint.Font.Size + 4, dataPoint.Font.Style);

                    dataPoint.BorderColor = Color.White;
                    dataPoint.BorderWidth = 6;
                }
            }
        }

        private void resetChartFonts()
        {
            labelMessage.Text = string.Empty;

            foreach (var series in chartSex.Series)
            {
                foreach (var point in series.Points)
                {
                    point.Font = new Font("Arial", 12f, FontStyle.Bold);
                    point.BorderColor = Color.Empty;
                    point.BorderWidth = 0;
                }
            }

            foreach (var series in chartMovieCategory.Series)
            {
                foreach (var point in series.Points)
                {
                    point.Font = new Font("Arial", 12f, FontStyle.Bold);
                    point.BorderColor = Color.Empty;
                    point.BorderWidth = 0;
                }
            }

            foreach (var series in chartAge.Series)
            {
                foreach (var point in series.Points)
                {
                    point.BorderColor = Color.Empty;
                    point.BorderWidth = 0;
                }
            }
        }

        private void chartMovieCategory_MouseClick(object sender, MouseEventArgs e)
        {
            resetChartFonts();

            var results = chartMovieCategory.HitTest(e.X, e.Y, false, ChartElementType.DataPoint);

            foreach (var result in results)
            {
                if (result.ChartElementType == ChartElementType.DataPoint)
                {
                    var dataPoint = chartMovieCategory.Series[result.Series.Name].Points[result.PointIndex];
                    labelMessage.Text = $"{dataPoint.AxisLabel} makes up {dataPoint.YValues[0]:F2} percent \nof all movie categories";
                    dataPoint.Font = new Font(dataPoint.Font.FontFamily, dataPoint.Font.Size + 4, dataPoint.Font.Style);

                    dataPoint.BorderColor = Color.White;
                    dataPoint.BorderWidth = 6;
                }
            }
        }

        private void chartAge_MouseClick(object sender, MouseEventArgs e)
        {
            resetChartFonts();

            var results = chartAge.HitTest(e.X, e.Y, false, ChartElementType.DataPoint);

            foreach (var result in results)
            {
                if (result.ChartElementType == ChartElementType.DataPoint)
                {
                    var dataPoint = chartAge.Series[result.Series.Name].Points[result.PointIndex];
                    labelMessage.Text = $"There is/are {dataPoint.YValues[0]} user/s in this\n group of age";

                    dataPoint.BorderColor = Color.White;
                    dataPoint.BorderWidth = 6;
                }
            }
        }
    }
}
