using FastReport.DataVisualization.Charting;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace RISK
{
    public partial class GraficRiscuri : Form
    {
        private DataGridView tabelRiscuri;

        public GraficRiscuri(DataGridView dgv)
        {
            InitializeComponent();
            this.tabelRiscuri = dgv;
            DisplayChart();
        }

        public GraficRiscuri()
        {
            InitializeComponent();
        }

        private void DisplayChart()
        {
            if (tabelRiscuri != null)
            {
                // Creează un obiect Chart
                Chart chart = new Chart();
                chart.Size = new Size(800, 600);
                chart.ChartAreas.Add("area");

                // Adaugă seria pentru datele tale
                Series series = new Series
                {
                    ChartType = SeriesChartType.Line,
                    XValueType = ChartValueType.String,
                    YValueType = ChartValueType.Double
                };

                // Adaugă datele din tabelRiscuri
                foreach (DataGridViewRow row in tabelRiscuri.Rows)
                {
                    string numeRisc = row.Cells["NUME_RISC"].Value?.ToString(); // Presupunând că "NUME_RISC" este numele coloanei pentru numele riscului
                    if (double.TryParse(row.Cells["PROBABILITATE_APARITIE"].Value?.ToString(), out double probabilitate))
                    {
                        series.Points.AddXY(numeRisc, probabilitate);
                    }
                }

                // Adaugă seria la grafic
                chart.Series.Add(series);

                // Adaugă titlul și etichetele la axele x și y
                chart.Titles.Add("Evoluția Probabilității de Apariție pentru Riscuri");
                chart.ChartAreas["area"].AxisX.Title = "Nume Risc";
                chart.ChartAreas["area"].AxisY.Title = "Probabilitate de Apariție";

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
