using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using ClosedXML.Excel;
using FastReport.DataVisualization.Charting;
using DGV2Printer;
using FastReport;
using FastReport.Preview;
using FastReport.Data;
using Org.BouncyCastle.Tls;
using System.Drawing;
using System.Linq;



namespace RISK
{
    public partial class Vulnerabilitati : Form
    {
        MySqlConnection con = new MySqlConnection("server=127.0.0.1; user=root; database=risk; password=");
        MySqlDataAdapter adapt;
        MySqlCommand cmd;
        DataTable dt;
        

        public Vulnerabilitati()
        {
            InitializeComponent();
            DisplayData();
            InitializeSearch();
            PopulateComboBox();
        }

        private void DisplayData()
        {
            con.Open();
            dt = new DataTable();
            adapt = new MySqlDataAdapter("select * from risk.vulnerabilitati", con);
            adapt.Fill(dt);
            tabelVulnerabilitati.DataSource = dt;
            con.Close();
        }

        private void goBackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Meniu menu = new Meniu();
            menu.Show();
            this.Hide();
        }

        private void InitializeSearch()
        {
            cautare.TextChanged += new EventHandler(cautare_TextChanged);
        }

        private void cautare_TextChanged(object sender, EventArgs e)
        {
            if (dt == null) return;

            string searchValue = cautare.Text.Replace("'", "''");
            string filterExpression = string.Format(
                "Convert(COD_BUN, 'System.String') LIKE '%{0}%' OR " +
                "VULNERABILITATE LIKE '%{0}%' OR " +
                "NIVEL LIKE '%{0}%'",
                searchValue
            );

            DataView dv = dt.DefaultView;
            dv.RowFilter = filterExpression;
            tabelVulnerabilitati.DataSource = dv.ToTable();
        }

        private void PopulateComboBox()
        {
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT cod_bun FROM bunuri", con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    codBun.Items.Add(reader["cod_bun"].ToString());
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la popularea ComboBox-ului: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string codBun = this.codBun.SelectedItem?.ToString();
            string vulnerabilitate1 = vulnerabilitate.Text;
            string nivel1 = nivel.Text;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                if (!string.IsNullOrEmpty(codBun) && !string.IsNullOrEmpty(vulnerabilitate1) && !string.IsNullOrEmpty(nivel1))
                {
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO vulnerabilitati (COD_BUN, VULNERABILITATE, NIVEL) VALUES (@codBun, @vulnerabilitate, @nivel)", con);
                    cmd.Parameters.AddWithValue("@codBun", codBun);
                    cmd.Parameters.AddWithValue("@vulnerabilitate", vulnerabilitate1);
                    cmd.Parameters.AddWithValue("@nivel", nivel1);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Successfully Added", "INSERT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisplayData();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Fill out all the information needed", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                // MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State != ConnectionState.Closed)
                {
                    con.Close();
                }
            }

        }

        private void ClearFields()
        {
            codBun.Text = "";
            vulnerabilitate.Text = "";
            nivel.Text = "";
        }

        private void reToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (codBun.Text != "" && vulnerabilitate.Text != "" && nivel.Text != "")
            {
                cmd = new MySqlCommand("delete from risk.vulnerabilitati where cod_bun=@cod_bun and vulnerabilitate=@vulnerabilitate", con);
                con.Open();
                cmd.Parameters.AddWithValue("@cod_bun", codBun.Text);
                cmd.Parameters.AddWithValue("@vulnerabilitate", vulnerabilitate.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Successfully Deleted", "DELETE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisplayData();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Select the record you want to Delete", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (codBun.Text != "" && vulnerabilitate.Text != "" && nivel.Text != "")
            {
                cmd = new MySqlCommand("update risk.vulnerabilitati set cod_bun=@codBun, vulnerabilitate=@vulnerabilitate where nivel=@nivel", con);
                con.Open();
                cmd.Parameters.AddWithValue("@codBun", codBun.Text);
                cmd.Parameters.AddWithValue("@vulnerabilitate", vulnerabilitate.Text);
                cmd.Parameters.AddWithValue("@nivel", nivel.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Successfully Updated", "UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                DisplayData();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Select the record you want to Update", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void savePDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabelVulnerabilitati.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog
                {
                    Filter = "PDF (*.pdf)|*.pdf",
                    FileName = "Result.pdf"
                };
                bool ErrorMessage = false;
                if (save.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(save.FileName))
                    {
                        try
                        {
                            File.Delete(save.FileName);
                        }
                        catch (Exception ex)
                        {
                            ErrorMessage = true;
                            MessageBox.Show("Unable to write data to disk: " + ex.Message);
                        }
                    }
                    if (!ErrorMessage)
                    {
                        try
                        {
                            PdfPTable pTable = new PdfPTable(tabelVulnerabilitati.Columns.Count)
                            {
                                DefaultCell = { Padding = 2 },
                                WidthPercentage = 100,
                                HorizontalAlignment = Element.ALIGN_LEFT
                            };
                            foreach (DataGridViewColumn col in tabelVulnerabilitati.Columns)
                            {
                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                                pTable.AddCell(pCell);
                            }
                            foreach (DataGridViewRow viewRow in tabelVulnerabilitati.Rows)
                            {
                                foreach (DataGridViewCell dcell in viewRow.Cells)
                                {
                                    if (dcell.Value != null)
                                    {
                                        pTable.AddCell(dcell.Value.ToString());
                                    }
                                }
                            }
                            using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
                            {
                                Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);
                                PdfWriter.GetInstance(document, fileStream);
                                document.Open();
                                document.Add(pTable);
                                document.Close();
                                fileStream.Close();
                            }
                            MessageBox.Show("Data Exported Successfully", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error while exporting data: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record Found", "Info");
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login logout = new Login();
            logout.Show();
            this.Hide();
        }

        private void saveExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabelVulnerabilitati.Rows.Count > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Excel Workbook|*.xlsx",
                    Title = "Save an Excel File",
                    FileName = "Result.xlsx"
                };
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (var workbook = new XLWorkbook())
                        {
                            var worksheet = workbook.Worksheets.Add("Vulnerabilitati");
                            for (int i = 0; i < tabelVulnerabilitati.Columns.Count; i++)
                            {
                                worksheet.Cell(1, i + 1).Value = tabelVulnerabilitati.Columns[i].HeaderText;
                            }
                            for (int i = 0; i < tabelVulnerabilitati.Rows.Count; i++)
                            {
                                for (int j = 0; j < tabelVulnerabilitati.Columns.Count; j++)
                                {
                                    worksheet.Cell(i + 2, j + 1).Value = tabelVulnerabilitati.Rows[i].Cells[j].Value?.ToString();
                                }
                            }
                            workbook.SaveAs(saveFileDialog.FileName);
                        }
                        MessageBox.Show("Data Exported Successfully", "Info");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error while exporting data: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record Found", "Info");
            }
        }

        private void graficToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GraficForm graficForm = new GraficForm(tabelVulnerabilitati);
            graficForm.Show();
            
        }

       
        private void rapoarteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
            // Creați un nou raport
            Report report = new Report();

            // Încărcați datele din DataGridView într-un DataTable
            DataTable dataTable = (DataTable)tabelVulnerabilitati.DataSource;

            // Adăugați DataTable-ul ca sursă de date pentru raport
            report.RegisterData(dataTable, "Vulnerabilitati");

            // Încărcați fișierul de raport (*.frx)
            report.Load("C:\\Users\\elena\\Desktop\\PAOO\\test1.frx");

            // Exportați raportul în format HTML
            FastReport.Export.Html.HTMLExport htmlExport = new FastReport.Export.Html.HTMLExport();
            htmlExport.SinglePage = true;
            htmlExport.EmbedPictures = true;
            htmlExport.PageBreaks = true;
            htmlExport.Export(report, "temp.html");

            // Afișați raportul într-un WebBrowser control
            string tempHtmlFilePath = Path.Combine(Application.StartupPath, "temp.html");
            WebBrowser webBrowser = new WebBrowser();
            webBrowser.Url = new Uri(tempHtmlFilePath);

            // Afișăm formularul cu WebBrowser control
            Form reportForm = new Form();
            reportForm.Text = "Raport";
            reportForm.Size = new Size(800, 600);
            reportForm.Controls.Add(webBrowser);
            reportForm.ShowDialog();
            */


        }

        private void Vulnerabilitati_Load(object sender, EventArgs e)
        {
            //this.ordersTableAdapter.Fill(this.northwindDataSet.Orders);
        }

        private void istoricToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string action = "Accesare istoric";
                DateTime timestamp = DateTime.Now;
                string interfaceName = this.Name; // Obține numele interfeței

                string connectionString = "server=127.0.0.1; user=root; database=risk; password=";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO istoric (Action, Timestamp, Interfata) VALUES (@action, @timestamp, @interface)";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@action", action);
                    command.Parameters.AddWithValue("@timestamp", timestamp);
                    command.Parameters.AddWithValue("@interface", interfaceName);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Acțiunea a fost înregistrată în istoric.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la înregistrarea în istoric: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void importExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    Filter = "Excel Files|*.xls;*.xlsx;*.xlsm",
                    Title = "Select an Excel File"
                };

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (var workbook = new XLWorkbook(openFileDialog.FileName))
                    {
                        var worksheet = workbook.Worksheet(1);
                        var rows = worksheet.RangeUsed().RowsUsed().Skip(1); // Skip header row

                        con.Open();
                        foreach (var row in rows)
                        {
                            string codBun = row.Cell(1).GetString();
                            string vulnerabilitate = row.Cell(2).GetString();
                            string nivel = row.Cell(3).GetString();

                            using (MySqlCommand cmd = new MySqlCommand("INSERT INTO vulnerabilitati (COD_BUN, VULNERABILITATE, NIVEL) VALUES (@codBun, @vulnerabilitate, @nivel)", con))
                            {
                                cmd.Parameters.AddWithValue("@codBun", codBun);
                                cmd.Parameters.AddWithValue("@vulnerabilitate", vulnerabilitate);
                                cmd.Parameters.AddWithValue("@nivel", nivel);
                                cmd.ExecuteNonQuery();
                            }
                        }
                        con.Close();
                        MessageBox.Show("Data Imported Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DisplayData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while importing data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

    }
}
