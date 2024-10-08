using FastReport.DataVisualization.Charting;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace RISK
{
    public partial class GraficContramasuri : Form
    {
        private DataGridView tabelaContramasuri;
        private Panel scrollPanel;

        public GraficContramasuri(DataGridView dgv)
        {
            InitializeComponent();
            this.tabelaContramasuri = dgv;
            InitializeScrollPanel();
            DisplayCharts();
        }

        private void InitializeScrollPanel()
        {
            scrollPanel = new Panel
            {
                AutoScroll = true,
                Dock = DockStyle.Fill
            };
            Controls.Add(scrollPanel);
        }

        private void DisplayCharts()
        {
            if (tabelaContramasuri != null)
            {
                DisplayCategorieContramasuriChart();
                DisplayEvolutieRiscuriChart();
                DisplayRelatieRiscuriMetodeChart();
            }
            else
            {
                MessageBox.Show("Nu există referință la DataGridView.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayCategorieContramasuriChart()
        {
            Panel panel = CreatePanel(new Point(10, 10));
            Chart chart = CreateChart();

            Dictionary<string, int> categorieCounts = new Dictionary<string, int>();

            foreach (DataGridViewRow row in tabelaContramasuri.Rows)
            {
                string categorie = row.Cells["CATEGORIE_CONTRAMASURI"].Value?.ToString();
                if (!string.IsNullOrEmpty(categorie))
                {
                    if (categorieCounts.ContainsKey(categorie))
                    {
                        categorieCounts[categorie]++;
                    }
                    else
                    {
                        categorieCounts[categorie] = 1;
                    }
                }
            }

            Series series = new Series { ChartType = SeriesChartType.Column };

            foreach (var pair in categorieCounts)
            {
                series.Points.AddXY(pair.Key, pair.Value);
            }

            chart.Series.Add(series);
            chart.Titles.Add("Distribuția contramăsurilor pe categorii");
            chart.ChartAreas[0].AxisX.Title = "Categorie Contramăsuri";
            chart.ChartAreas[0].AxisY.Title = "Număr de Apariții";

            panel.Controls.Add(chart);
            scrollPanel.Controls.Add(panel);
        }


        private void DisplayEvolutieRiscuriChart()
        {
            Panel panel = CreatePanel(new Point(420, 10));
            Chart chart = CreateChart();

            // Simulăm date pentru evoluția riscurilor în timp (acest exemplu presupune că ai o coloană de dată)
            // Date fictive pentru demonstrație
            Dictionary<DateTime, int> dateCounts = new Dictionary<DateTime, int>
            {
                { new DateTime(2023, 1, 1), 5 },
                { new DateTime(2023, 2, 1), 8 },
                { new DateTime(2023, 3, 1), 12 },
                { new DateTime(2023, 4, 1), 10 },
                { new DateTime(2023, 5, 1), 15 }
            };

            Series series = new Series { ChartType = SeriesChartType.Line };

            foreach (var pair in dateCounts)
            {
                series.Points.AddXY(pair.Key, pair.Value);
            }

            chart.Series.Add(series);
            chart.Titles.Add("Evoluția riscurilor tratate în timp");
            chart.ChartAreas[0].AxisX.Title = "Dată";
            chart.ChartAreas[0].AxisY.Title = "Număr de Riscuri";

            panel.Controls.Add(chart);
            scrollPanel.Controls.Add(panel);
        }

        private void DisplayRelatieRiscuriMetodeChart()
        {
            Panel panel = CreatePanel(new Point(10, 320));
            Chart chart = CreateChart();

            // Simulăm date pentru relația între tipurile de riscuri și metodele de tratare
            // Date fictive pentru demonstrație
            Dictionary<string, int> relatieCounts = new Dictionary<string, int>
            {
                { "Risc1 - MetodaA", 5 },
                { "Risc2 - MetodaB", 8 },
                { "Risc3 - MetodaC", 12 }
            };

            Series series = new Series { ChartType = SeriesChartType.Point };

            foreach (var pair in relatieCounts)
            {
                series.Points.AddXY(pair.Key, pair.Value);
            }

            chart.Series.Add(series);
            chart.Titles.Add("Relația între tipurile de riscuri și metodele de tratare");
            chart.ChartAreas[0].AxisX.Title = "Tip de Risc - Metodă de Tratare";
            chart.ChartAreas[0].AxisY.Title = "Număr de Apariții";

            panel.Controls.Add(chart);
            scrollPanel.Controls.Add(panel);
        }

        private Panel CreatePanel(Point location)
        {
            Panel panel = new Panel
            {
                Size = new Size(400, 300),
                Location = location
            };
            return panel;
        }

        private Chart CreateChart()
        {
            Chart chart = new Chart { Size = new Size(400, 300) };
            chart.ChartAreas.Add(new ChartArea("area"));
            return chart;
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Dispose();
        }
    }
}
