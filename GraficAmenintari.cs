using FastReport.DataVisualization.Charting;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace RISK
{
    public partial class GraficAmenintari : Form
    {
        private DataGridView tabelaAmenintari;

        public GraficAmenintari(DataGridView dgv)
        {
            InitializeComponent();
            this.tabelaAmenintari = dgv;
            DisplayChart();
        }

        public GraficAmenintari()
        {
            InitializeComponent();
        }

        private void DisplayChart()
        {
            if (tabelaAmenintari != null)
            {
                // Creează un obiect Chart
                Chart chart = new Chart();
                chart.Size = new Size(800, 600);
                chart.ChartAreas.Add("area");

                // Dicționar pentru a ține evidența mediei nivelului pentru fiecare amenințare
                Dictionary<string, double> mediiNivel = new Dictionary<string, double>();

                // Calculează media nivelului pentru fiecare amenințare
                foreach (DataGridViewRow row in tabelaAmenintari.Rows)
                {
                    if (row.Cells["AMENINTARE"].Value != null &&
                        row.Cells["NIVEL_MINIM"].Value != null &&
                        row.Cells["NIVEL_MAXIM"].Value != null)
                    {
                        string amenintare = row.Cells["AMENINTARE"].Value.ToString();
                        double nivelMin = Convert.ToDouble(row.Cells["NIVEL_MINIM"].Value);
                        double nivelMax = Convert.ToDouble(row.Cells["NIVEL_MAXIM"].Value);

                        double media = (nivelMin + nivelMax) / 2;
                        mediiNivel[amenintare] = media;
                    }
                }

                // Adaugă seria pentru datele tale
                Series series = new Series();
                series.ChartType = SeriesChartType.Pie;

                // Adaugă datele la seria ta din dicționarul mediiNivel
                foreach (var pair in mediiNivel)
                {
                    series.Points.AddXY(pair.Key, pair.Value);
                }

                // Adaugă seriile la grafic
                chart.Series.Add(series);

                // Adaugă titlul la grafic
                chart.Titles.Add("Medii Niveluri de Amenințare");

                // Configurează legenda
                chart.Legends.Add(new Legend("Legenda")
                {
                    Docking = Docking.Bottom,
                    Alignment = StringAlignment.Center
                });

                // Adaugă graficul la fereastra curentă
                Controls.Add(chart);
            }
            else
            {
                MessageBox.Show("Nu există referință la DataGridView.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
