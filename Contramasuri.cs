using iTextSharp.text.pdf;
using iTextSharp.text;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Office.Word;
using System.Linq;

namespace RISK
{
    public partial class Contramasuri : Form
    {
        MySqlConnection con = new MySqlConnection("server=127.0.0.1; user=root; database=risk; password=");
        MySqlDataAdapter adapt;
        MySqlCommand cmd;
        DataTable dt; // Class-level dt

        public Contramasuri()
        {
            InitializeComponent();
            DisplayData();
            InitializeSearch();
            PopulateComboBox();
        }

        private void PopulateComboBox()
        {
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT cod_risc FROM riscuri", con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    codRisc.Items.Add(reader["cod_risc"].ToString());
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la popularea ComboBox-ului: " + ex.Message);
            }
        }
        private void goBackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Meniu menu = new Meniu();
            menu.Show();
            this.Hide();
        }

        private void DisplayData()
        {
            con.Open();
            dt = new DataTable(); // Assign to class-level dt
            adapt = new MySqlDataAdapter("select * from risk.contramasuri", con);
            adapt.Fill(dt);
            tabelContramasuri.DataSource = dt;
            con.Close();
        }

        private void InitializeSearch()
        {
            cautare.TextChanged += new EventHandler(cautare_TextChanged);
        }

        private void cautare_TextChanged(object sender, EventArgs e)
        {
            if (dt == null) return; // Ensure dt is initialized

            string searchValue = cautare.Text.Replace("'", "''");
            string filterExpression = string.Format(
                "Convert(COD_RISC, 'System.String') LIKE '%{0}%' OR " +
                "METODA_TRATARE LIKE '%{0}%' OR " +
                "CATEGORIE_CONTRAMASURI LIKE '%{0}%' OR " +
                "TRATAT LIKE '%{0}%'",
                searchValue
            );

            DataView dv = dt.DefaultView;
            dv.RowFilter = filterExpression;
            tabelContramasuri.DataSource = dv.ToTable();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login logout = new Login();
            logout.Show();
            this.Hide();
        }

        private void savePDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabelContramasuri.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog
                {
                    Filter = "PDF (*.pdf)|*.pdf",
                    FileName = "Contramasuri.pdf"
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
                            PdfPTable pTable = new PdfPTable(tabelContramasuri.Columns.Count)
                            {
                                DefaultCell = { Padding = 2 },
                                WidthPercentage = 100,
                                HorizontalAlignment = Element.ALIGN_LEFT
                            };

                            foreach (DataGridViewColumn col in tabelContramasuri.Columns)
                            {
                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                                pTable.AddCell(pCell);
                            }

                            foreach (DataGridViewRow viewRow in tabelContramasuri.Rows)
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

        private void saveExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabelContramasuri.Rows.Count > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Excel Workbook|*.xlsx",
                    Title = "Save an Excel File",
                    FileName = "Contramasuri.xlsx"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (var workbook = new XLWorkbook())
                        {
                            var worksheet = workbook.Worksheets.Add("Contramasuri");

                            // Adaugă header-ul coloanelor
                            for (int i = 0; i < tabelContramasuri.Columns.Count; i++)
                            {
                                worksheet.Cell(1, i + 1).Value = tabelContramasuri.Columns[i].HeaderText;
                            }

                            // Adaugă datele
                            for (int i = 0; i < tabelContramasuri.Rows.Count; i++)
                            {
                                for (int j = 0; j < tabelContramasuri.Columns.Count; j++)
                                {
                                    worksheet.Cell(i + 2, j + 1).Value = tabelContramasuri.Rows[i].Cells[j].Value?.ToString();
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

        private void Contramasuri_Load(object sender, EventArgs e)
        {

        }

        private void insert_Click(object sender, EventArgs e)
        {
            string codRiscValue = codRisc.SelectedItem?.ToString() ?? ""; ;
            string metTratareValue = metTratare.Text;
            string categContramasuriValue = categContramasuri.Text;
            string tratatValue = tratat.SelectedItem?.ToString() ?? "";

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                if (!string.IsNullOrEmpty(codRiscValue) &&
                    !string.IsNullOrEmpty(metTratareValue) &&
                    !string.IsNullOrEmpty(categContramasuriValue) &&
                    !string.IsNullOrEmpty(tratatValue))
                {
                    // Updated table name
                    string query = "INSERT INTO contramasuri (COD_RISC, METODA_TRATARE, CATEGORIE_CONTRAMASURI, TRATAT) " +
                                   "VALUES (@codRisc, @metTratare, @categContramasuri, @tratat)";
                    MySqlCommand cmd = new MySqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@codRisc", codRiscValue);
                    cmd.Parameters.AddWithValue("@metTratare", metTratareValue);
                    cmd.Parameters.AddWithValue("@categContramasuri", categContramasuriValue);
                    cmd.Parameters.AddWithValue("@tratat", tratatValue);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Successfully Added", "INSERT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisplayData();
                    ClearData();
                    
                }
                else
                {
                    MessageBox.Show("Fill out all the information needed", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // MessageBox.Show("Error while inserting data: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void reîmprospătareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (codRisc.Text != "" && metTratare.Text != "" && categContramasuri.Text != "" && tratat.Text!="")
            {
                try
                {
                    cmd = new MySqlCommand("DELETE FROM risk.contramasuri WHERE cod_risc=@cod_risc AND metoda_tratare=@metoda_tratare AND categorie_contramasuri=@categorie_contramasuri AND tratat=@tratat", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@cod_risc", codRisc.Text);
                    cmd.Parameters.AddWithValue("@metoda_tratare", metTratare.Text);
                    cmd.Parameters.AddWithValue("@categorie_contramasuri", categContramasuri.Text);
                    cmd.Parameters.AddWithValue("@tratat", tratat.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Successfully Deleted", "DELETE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisplayData();
                    ClearData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while deleting data: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Select the record you want to Delete", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearData()
        {
            codRisc.SelectedItem = null;
            metTratare.Text = "";
            categContramasuri.Text = "";
            tratat.SelectedItem = null;
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (codRisc.Text != "" && metTratare.Text != "" && categContramasuri.Text != "" && tratat.Text != "" )
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("UPDATE risk.contramasuri SET cod_risc=@codRisc, metoda_tratare=@metTratare, categorie_contramasuri=@categorie, tratat=@tratat WHERE cod_risc=@codRisc ", con);
                    cmd.Parameters.AddWithValue("@codRisc", codRisc.Text);
                    cmd.Parameters.AddWithValue("@metTratare", metTratare.Text);
                    cmd.Parameters.AddWithValue("@categorie", categContramasuri.Text);
                    cmd.Parameters.AddWithValue("@tratat", tratat.Text);
                   
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Successfully Updated", "UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    DisplayData();
                    ClearData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while updating data: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Select the record you want to Update", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void graficToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GraficContramasuri graficForm = new GraficContramasuri(tabelContramasuri);
            graficForm.Show();
        }

        private void importExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Excel Files|*.xls;*.xlsx;*.xlsm"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string excelFilePath = openFileDialog.FileName;
                string connectionString = "server=127.0.0.1; user=root; database=risk; password=";

                using (XLWorkbook workbook = new XLWorkbook(excelFilePath))
                {
                    IXLWorksheet worksheet = workbook.Worksheet(1);
                    DataTable dataTable = new DataTable();

                    // Adaugă coloanele în tabel
                    foreach (IXLColumn column in worksheet.Columns())
                    {
                        dataTable.Columns.Add(column.Cell(1).Value.ToString());
                    }

                    // Adaugă datele din Excel în tabel
                    foreach (IXLRow row in worksheet.RowsUsed().Skip(1))
                    {
                        DataRow dataRow = dataTable.NewRow();
                        for (int i = 0; i < row.Cells().Count(); i++)
                        {
                            dataRow[i] = row.Cell(i + 1).Value.ToString();
                        }
                        dataTable.Rows.Add(dataRow);
                    }

                    // Inserează datele în baza de date folosind instrucțiuni SQL
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        foreach (DataRow row in dataTable.Rows)
                        {
                            string query = "INSERT INTO contramasuri (cod_risc, metoda_tratare, categorie_contramasuri, tratat) " +
                                           "VALUES (@codRisc, @metodaTratare, @categorieContramasuri, @tratat)";
                            MySqlCommand command = new MySqlCommand(query, connection);
                            command.Parameters.AddWithValue("@codRisc", row["cod_risc"]);
                            command.Parameters.AddWithValue("@metodaTratare", row["metoda_tratare"]);
                            command.Parameters.AddWithValue("@categorieContramasuri", row["categorie_contramasuri"]);
                            command.Parameters.AddWithValue("@tratat", row["tratat"]);
                            command.ExecuteNonQuery();
                        }

                        connection.Close();
                    }
                }

                MessageBox.Show("Data Imported Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
