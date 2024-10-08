using FastReport.DataVisualization.Charting;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace RISK
{
    public partial class GraficBunuri : Form
    {
        private DataGridView tabelaBunuri;

        public GraficBunuri(DataGridView dgv)
        {
            InitializeComponent();
            this.tabelaBunuri = dgv;
            DisplayCharts();
        }

        private void DisplayCharts()
        {
            if (tabelaBunuri != null)
            {
                DisplayNumeBunDomeniuCategorieChart();
                DisplayImpactMinimMaximChart();
            }
            else
            {
                MessageBox.Show("Nu există referință la DataGridView.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayNumeBunDomeniuCategorieChart()
        {
            // Creează un panou pentru primul grafic
            Panel panelNumeBunDomeniuCategorie = new Panel();
            panelNumeBunDomeniuCategorie.Size = new Size(400, 300);
            panelNumeBunDomeniuCategorie.Location = new Point(10, 10);
            Controls.Add(panelNumeBunDomeniuCategorie);

            // Creează un obiect Chart pentru primul grafic
            Chart chartNumeBunDomeniuCategorie = new Chart();
            chartNumeBunDomeniuCategorie.Size = new Size(400, 300);
            chartNumeBunDomeniuCategorie.ChartAreas.Add("area");
            panelNumeBunDomeniuCategorie.Controls.Add(chartNumeBunDomeniuCategorie);

            // Dicționar pentru a ține evidența numărului de apariții ale fiecărui nume de bun și categorie
            Dictionary<string, int> numeDomeniuCounts = new Dictionary<string, int>();

            // Calculează numărul de apariții ale fiecărui nume de bun și categorie
            foreach (DataGridViewRow row in tabelaBunuri.Rows)
            {
                string numeBun = row.Cells["NUME_BUN"].Value?.ToString();
                string domeniuCategorie = row.Cells["DOMENIU_CATEGORIE"].Value?.ToString();

                if (!string.IsNullOrEmpty(numeBun) && !string.IsNullOrEmpty(domeniuCategorie))
                {
                    string key = numeBun + " - " + domeniuCategorie;
                    if (numeDomeniuCounts.ContainsKey(key))
                    {
                        numeDomeniuCounts[key]++;
                    }
                    else
                    {
                        numeDomeniuCounts[key] = 1;
                    }
                }
            }

            // Adaugă seria pentru datele tale
            Series series = new Series();
            series.ChartType = SeriesChartType.Column;

            // Adaugă datele la seria ta din dicționarul numeDomeniuCounts
            foreach (var pair in numeDomeniuCounts)
            {
                series.Points.AddXY(pair.Key, pair.Value);
            }

            // Adaugă seria la grafic
            chartNumeBunDomeniuCategorie.Series.Add(series);

            // Adaugă titlul și etichetele la axele x și y
            chartNumeBunDomeniuCategorie.Titles.Add("Diagramă Nume Bun - Domeniu Categorie");
            chartNumeBunDomeniuCategorie.ChartAreas["area"].AxisX.Title = "Nume Bun - Domeniu Categorie";
            chartNumeBunDomeniuCategorie.ChartAreas["area"].AxisY.Title = "Număr de Apariții";

            // Adaugă graficul la panoul corespunzător
            panelNumeBunDomeniuCategorie.Controls.Add(chartNumeBunDomeniuCategorie);
        }

        private void DisplayImpactMinimMaximChart()
        {
            // Creează un panou pentru al doilea grafic
            Panel panelImpactMinimMaxim = new Panel();
            panelImpactMinimMaxim.Size = new Size(400, 300);
            panelImpactMinimMaxim.Location = new Point(420, 10);
            Controls.Add(panelImpactMinimMaxim);

            // Creează un obiect Chart pentru al doilea grafic
            Chart chartImpactMinimMaxim = new Chart();
            chartImpactMinimMaxim.Size = new Size(400, 300);
            chartImpactMinimMaxim.ChartAreas.Add("area");
            panelImpactMinimMaxim.Controls.Add(chartImpactMinimMaxim);

            // Calculează media impactului minim și maxim
            double mediaImpactMinim = tabelaBunuri.Rows.Cast<DataGridViewRow>()
                .Where(row => row.Cells["IMPACT_MINIM"].Value != null)
                .Average(row => Convert.ToDouble(row.Cells["IMPACT_MINIM"].Value));

            double mediaImpactMaxim = tabelaBunuri.Rows.Cast<DataGridViewRow>()
                .Where(row => row.Cells["IMPACT_MAXIM"].Value != null)
                .Average(row => Convert.ToDouble(row.Cells["IMPACT_MAXIM"].Value));

            // Adaugă seria pentru datele tale
            Series series = new Series();
            series.ChartType = SeriesChartType.Pie;

            // Adaugă datele la seria ta
            series.Points.AddXY("Medie Impact Minim", mediaImpactMinim);
            series.Points.AddXY("Medie Impact Maxim", mediaImpactMaxim);

            // Adaugă seria la grafic
            chartImpactMinimMaxim.Series.Add(series);

            // Adaugă titlul la grafic
            chartImpactMinimMaxim.Titles.Add("Diagramă Medie Impact Minim și Maxim");

            // Adaugă graficul la panoul corespunzător
            panelImpactMinimMaxim.Controls.Add(chartImpactMinimMaxim);
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Dispose();
        }
    }
}
