using FastReport.DataVisualization.Charting;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RISK
{
    public partial class GraficForm : Form
    {
        private DataGridView tabelaVulnerabilitati;

        public GraficForm(DataGridView dgv)
        {
            InitializeComponent();
            this.tabelaVulnerabilitati = dgv;
            DisplayChart();
        }

        public GraficForm()
        {
            InitializeComponent();
        }

        private void DisplayChart()
        {
            if (tabelaVulnerabilitati != null)
            {
                // Creează un obiect Chart
                Chart chart = new Chart();
                chart.Size = new Size(800, 600);
                chart.ChartAreas.Add("area");

                // Dicționar pentru a ține evidența numărului de apariții ale fiecărui nivel de vulnerabilitate
                Dictionary<string, int> nivelCounts = new Dictionary<string, int>();

                // Calculează numărul de apariții ale fiecărui nivel de vulnerabilitate
                foreach (DataGridViewRow row in tabelaVulnerabilitati.Rows)
                {
                    string nivel = row.Cells["NIVEL"].Value?.ToString(); // Presupunând că "NIVEL" este numele coloanei pentru Nivelul de Vulnerabilitate

                    if (!string.IsNullOrEmpty(nivel))
                    {
                        if (nivelCounts.ContainsKey(nivel))
                        {
                            nivelCounts[nivel]++;
                        }
                        else
                        {
                            nivelCounts[nivel] = 1;
                        }
                    }
                }

                // Adaugă seria pentru datele tale
                Series series = new Series();
                series.ChartType = SeriesChartType.Column;

                // Adaugă datele la seria ta din dicționarul nivelCounts
                foreach (var pair in nivelCounts)
                {
                    series.Points.AddXY(pair.Key, pair.Value);
                }

                // Adaugă seria la grafic
                chart.Series.Add(series);

                // Adaugă titlul și etichetele la axele x și y
                chart.Titles.Add("Diagramă Niveluri de Vulnerabilitate");
                chart.ChartAreas["area"].AxisX.Title = "Nivel de Vulnerabilitate";
                chart.ChartAreas["area"].AxisY.Title = "Număr de Apariții";

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
