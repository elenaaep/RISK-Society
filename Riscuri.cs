using ClosedXML.Excel;
using iTextSharp.text.pdf;
using iTextSharp.text;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Office.Word;
using System.Linq;
using ClosedXML.Excel;

namespace RISK
{
    public partial class Riscuri : Form
    {
        MySqlConnection con = new MySqlConnection("server=127.0.0.1; user=root; database=risk; password=");
        MySqlDataAdapter adapt;
        MySqlCommand cmd;
        DataTable dt;

        public Riscuri()
        {
            InitializeComponent();
            DisplayData();
            InitializeSearch();
            PopulateComboBox();
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
            dt = new DataTable();
            adapt = new MySqlDataAdapter("select * from risk.riscuri", con);
            adapt.Fill(dt);
            tabelRiscuri.DataSource = dt;
            con.Close();
        }

        private void InitializeSearch()
        {
            cautare.TextChanged += new EventHandler(cautare_TextChanged);
        }

        private void cautare_TextChanged(object sender, EventArgs e)
        {
            string searchValue = cautare.Text.Replace("'", "''");
            string filterExpression = string.Format(
                "Convert(COD_RISC, 'System.String') LIKE '%{0}%' OR " +
                "Convert(COD_BUN, 'System.String') LIKE '%{0}%' OR " +
                "NUME_RISC LIKE '%{0}%' OR " +
                "Convert(NIVELUL_RISCULUI, 'System.String') LIKE '%{0}%' OR " +
                "Convert(PROBABILITATE_APARITIE, 'System.String') LIKE '%{0}%' OR " +
                "NATURA_RISCULUI LIKE '%{0}%'",
                searchValue
            );

            DataView dv = dt.DefaultView;
            dv.RowFilter = filterExpression;
            tabelRiscuri.DataSource = dv.ToTable();
        }

        private void reîmprospatareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login logout = new Login();
            logout.Show();
            this.Hide();
        }

        private void savePDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabelRiscuri.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog
                {
                    Filter = "PDF (*.pdf)|*.pdf",
                    FileName = "Riscuri.pdf"
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
                            PdfPTable pTable = new PdfPTable(tabelRiscuri.Columns.Count)
                            {
                                DefaultCell = { Padding = 2 },
                                WidthPercentage = 100,
                                HorizontalAlignment = Element.ALIGN_LEFT
                            };
                            foreach (DataGridViewColumn col in tabelRiscuri.Columns)
                            {
                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                                pTable.AddCell(pCell);
                            }
                            foreach (DataGridViewRow viewRow in tabelRiscuri.Rows)
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
            if (tabelRiscuri.Rows.Count > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Excel Workbook|*.xlsx",
                    Title = "Save an Excel File",
                    FileName = "Riscuri.xlsx"
                };
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (var workbook = new XLWorkbook())
                        {
                            var worksheet = workbook.Worksheets.Add("Riscuri");
                            for (int i = 0; i < tabelRiscuri.Columns.Count; i++)
                            {
                                worksheet.Cell(1, i + 1).Value = tabelRiscuri.Columns[i].HeaderText;
                            }
                            for (int i = 0; i < tabelRiscuri.Rows.Count; i++)
                            {
                                for (int j = 0; j < tabelRiscuri.Columns.Count; j++)
                                {
                                    worksheet.Cell(i + 2, j + 1).Value = tabelRiscuri.Rows[i].Cells[j].Value?.ToString();
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
            GraficRiscuri risc = new GraficRiscuri(tabelRiscuri);
            risc.Show();
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

        private void insert_Click(object sender, EventArgs e)
        {
            string codRiscValue = this.codRisc.Text;
            string codBunValue = this.codBun.SelectedItem?.ToString();
            string numeRiscValue = this.numeRisc.Text;
            string naturaRiscValue = this.naturaRisc.Text;
            string nivelulRiscValue = this.nivRisc.Text;
            string probabilitateAparitieValue = this.probAparitie.Text;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                if (!string.IsNullOrEmpty(codRiscValue)&&
                    !string.IsNullOrEmpty(codBunValue) &&
                    !string.IsNullOrEmpty(numeRiscValue) &&
                    !string.IsNullOrEmpty(naturaRiscValue))
                {
                    string query = "INSERT INTO riscuri (COD_RISC, COD_BUN, NUME_RISC, NATURA_RISCULUI, NIVELUL_RISCULUI, PROBABILITATE_APARITIE) " +
                                   "VALUES (@codRisc, @codBun, @numeRisc, @naturaRisc, @nivelRisc, @probabilitateAparitie)";
                    MySqlCommand cmd = new MySqlCommand(query, con);


                    cmd.Parameters.AddWithValue("@codRisc", codRiscValue);
                    cmd.Parameters.AddWithValue("@codBun", codBunValue);
                    cmd.Parameters.AddWithValue("@numeRisc", numeRiscValue);
                    cmd.Parameters.AddWithValue("@naturaRisc", naturaRiscValue);
                    cmd.Parameters.AddWithValue("@nivelRisc", nivelulRiscValue);
                    cmd.Parameters.AddWithValue("@probabilitateAparitie", probabilitateAparitieValue);

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
                con.Close();
            }
        }

        private void ClearData()
        {
            codRisc.Text = "";
            codBun.SelectedIndex = -1;
            numeRisc.Text = "";
            naturaRisc.Text = "";
            nivRisc.Text = "";
            probAparitie.Text = "";
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (codRisc.Text!="" && codBun.Text != "" && numeRisc.Text != "")
            {
                try
                {
                    cmd = new MySqlCommand("DELETE FROM risk.riscuri WHERE cod_risc=@cod_risc AND cod_bun=@cod_bun AND nume_risc=@nume_risc", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@cod_risc", codRisc.Text);
                    cmd.Parameters.AddWithValue("@cod_bun", codBun.Text);
                    cmd.Parameters.AddWithValue("@nume_risc", numeRisc.Text);
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

        private void update_Click(object sender, EventArgs e)
        {
            if (codRisc.Text != "" && codBun.Text != "" && numeRisc.Text != "" && nivRisc.Text != "" && probAparitie.Text != "" && naturaRisc.Text != "")
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("UPDATE risk.riscuri SET cod_risc=@codRisc, cod_bun=@codBun, nume_risc=@numeRisc, nivelul_riscului=@nivelRisc, probabilitate_aparitie=@probabilitateAparitie, natura_riscului=@naturaRisc WHERE cod_risc=@codRisc AND COD_BUN=@codBun AND NUME_RISC=@numeRisc", con);
                    cmd.Parameters.AddWithValue("@codRisc", codRisc.Text);
                    cmd.Parameters.AddWithValue("@codBun", codBun.Text);
                    cmd.Parameters.AddWithValue("@numeRisc", numeRisc.Text);
                    cmd.Parameters.AddWithValue("@nivelRisc", nivRisc.Text);
                    cmd.Parameters.AddWithValue("@probabilitateAparitie", probAparitie.Text);
                    cmd.Parameters.AddWithValue("@naturaRisc", naturaRisc.Text);
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

        private void rapoarteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
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
                            string query = "INSERT INTO riscuri (cod_risc, cod_bun, nume_risc, nivelul_riscului, probabilitate_aparitie, natura_riscului) " +
                                           "VALUES (@codRisc, @codBun, @numeRisc, @nivelRisc, @probabilitateAparitie, @naturaRisc)";
                            MySqlCommand command = new MySqlCommand(query, connection);
                            command.Parameters.AddWithValue("@codRisc", row["cod_risc"]);
                            command.Parameters.AddWithValue("@codBun", row["cod_bun"]);
                            command.Parameters.AddWithValue("@numeRisc", row["nume_risc"]);
                            command.Parameters.AddWithValue("@nivelRisc", row["nivelul_riscului"]);
                            command.Parameters.AddWithValue("@probabilitateAparitie", row["probabilitate_aparitie"]);
                            command.Parameters.AddWithValue("@naturaRisc", row["natura_riscului"]);
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
