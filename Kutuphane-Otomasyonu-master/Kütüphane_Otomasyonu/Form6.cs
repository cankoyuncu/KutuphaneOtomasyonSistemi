using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Kütüphane_Otomasyonu
{
    public partial class Form6 : Form
    {
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ASUS\Desktop\Kutuphane-Otomasyonu-master\KütüphaneBilgileri.mdb";

        private void DisplayAgeGroupPieChart(DataTable dataTable)
        {
            OleDbConnection connection2 = new OleDbConnection(connectionString);
            Series series = new Series();

            ChartArea chartArea = new ChartArea();
            chart1.ChartAreas.Add(chartArea);

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                var row = dataTable.Rows[i];
                string query2 = "SELECT * FROM Emanetler Where ÜyeAdı = '" + Convert.ToString(row["ÜyeAdı"]) + "';";
                OleDbCommand command2 = new OleDbCommand(query2, connection2);

                OleDbDataAdapter adapter2 = new OleDbDataAdapter(command2);
                DataTable dataTable2 = new DataTable();
                adapter2.Fill(dataTable2);
                int count = dataTable2.Rows.Count;

                series.ChartType = SeriesChartType.Pie;
                series.Points.AddXY(Convert.ToString(row["ÜyeAdı"]), count);
            }

            chart1.Series.Clear();
            chart1.Titles.Clear();

            chart1.Series.Add(series);
            chart1.Titles.Add("Kullanıcıların Aldığı Kitap Adeti");
            chart1.Invalidate();
        }


        private void LoadAndDisplayPieChart()
        {

            string query = "SELECT ÜyeAdı FROM Üyeler;";


            using (OleDbConnection connection = new OleDbConnection(connectionString))
            using (OleDbCommand command = new OleDbCommand(query, connection))
            {
                try
                {

                    connection.Open();


                    OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);


                    connection.Close();


                    DisplayAgeGroupPieChart(dataTable);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            LoadAndDisplayPieChart();

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
