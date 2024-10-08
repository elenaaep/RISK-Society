using DocumentFormat.OpenXml.Spreadsheet;
using iTextSharp.text.pdf;
using iTextSharp.text;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace RISK
{
    public partial class Amenintari : Form
    {
        MySqlConnection con = new MySqlConnection("server=127.0.0.1; user=root; database=risk; password=");
        MySqlDataAdapter adapt;
        DataTable dt;

        public Amenintari()
        {
            InitializeComponent();
            DisplayData();
            InitializeSearch();
            PopulateComboBox();
        }

        private void Amenintari_Load(object sender, EventArgs e)
        {
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
            adapt = new MySqlDataAdapter("select * from risk.amenintari", con);
            adapt.Fill(dt);
            tabelAmenintari.DataSource = dt;
            con.Close();
        }

        private void InitializeSearch()
        {
            cautare.TextChanged += new EventHandler(cautare_TextChanged);
        }

        private void cautare_TextChanged(object sender, EventArgs e)
        {
            string searchValue = cautare.Text;
            string filterExpression = string.Format(
                "CONVERT(COD_BUN, 'System.String') LIKE '%{0}%' OR " +
                "CONVERT(AMENINTARE, 'System.String') LIKE '%{0}%' OR " +
                "CONVERT(NIVEL_MINIM, 'System.String') LIKE '%{0}%' OR " +
                "CONVERT(NIVEL_MAXIM, 'System.String') LIKE '%{0}%'",
                searchValue
            );

            DataView dv = dt.DefaultView;
            dv.RowFilter = filterExpression;
            tabelAmenintari.DataSource = dv.ToTable();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login logout = new Login();
            logout.Show();
            this.Hide();
        }

        private void reîmprospatareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayData();
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

        private void insert_Click(object sender, EventArgs e)
        {
            string codBunValue = this.codBun.SelectedItem?.ToString();
            string amenintareValue = this.amenintare.Text;
            decimal nivelMinimValue = this.nivMin.Value;
            decimal nivelMaximValue = this.nivMax.Value;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                if (!string.IsNullOrEmpty(codBunValue) &&
                    !string.IsNullOrEmpty(amenintareValue) &&
                    nivelMinimValue < nivelMaximValue)
                {
                    string query = "INSERT INTO amenintari (COD_BUN, AMENINTARE, NIVEL_MINIM, NIVEL_MAXIM) " +
                                   "VALUES (@codBun, @amenintare, @nivelMinim, @nivelMaxim)";
                    MySqlCommand cmd = new MySqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@codBun", codBunValue);
                    cmd.Parameters.AddWithValue("@amenintare", amenintareValue);
                    cmd.Parameters.AddWithValue("@nivelMinim", nivelMinimValue);
                    cmd.Parameters.AddWithValue("@nivelMaxim", nivelMaximValue);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Successfully Added", "INSERT", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DisplayData();
                    ClearData();
                }
                else
                {
                    MessageBox.Show("Fill out all the information needed and ensure that Min Level is less than Max Level", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // MessageBox.Show("Eroare la inserare: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void ClearData()
        {
            codBun.SelectedItem = null;
            amenintare.Text = "";
            nivMin.Value = 0;
            nivMax.Value = 0;
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

        private void savePDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabelAmenintari.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog
                {
                    Filter = "PDF (*.pdf)|*.pdf",
                    FileName = "Amenintari.pdf"
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
                            PdfPTable pTable = new PdfPTable(tabelAmenintari.Columns.Count)
                            {
                                DefaultCell = { Padding = 2 },
                                WidthPercentage = 100,
                                HorizontalAlignment = Element.ALIGN_LEFT
                            };
                            foreach (DataGridViewColumn col in tabelAmenintari.Columns)
                            {
                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                                pTable.AddCell(pCell);
                            }
                            foreach (DataGridViewRow viewRow in tabelAmenintari.Rows)
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
            if (tabelAmenintari.Rows.Count > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Excel Workbook|*.xlsx",
                    Title = "Save an Excel File",
                    FileName = "Amenintari.xlsx"
                };
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (var workbook = new XLWorkbook())
                        {
                            var worksheet = workbook.Worksheets.Add("Amenintari");
                            for (int i = 0; i < tabelAmenintari.Columns.Count; i++)
                            {
                                worksheet.Cell(1, i + 1).Value = tabelAmenintari.Columns[i].HeaderText;
                            }
                            for (int i = 0; i < tabelAmenintari.Rows.Count; i++)
                            {
                                for (int j = 0; j < tabelAmenintari.Columns.Count; j++)
                                {
                                    worksheet.Cell(i + 2, j + 1).Value = tabelAmenintari.Rows[i].Cells[j].Value?.ToString();
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
            GraficAmenintari graficForm = new GraficAmenintari(tabelAmenintari);
            graficForm.Show();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (codBun.Text != "" && amenintare.Text != "")
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM risk.amenintari WHERE COD_BUN=@codBun AND AMENINTARE=@amenintare", con);
                    cmd.Parameters.AddWithValue("@codBun", codBun.Text);
                    cmd.Parameters.AddWithValue("@amenintare", amenintare.Text);
                    cmd.ExecuteNonQuery();
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
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Select the record you want to Delete", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (codBun.Text != "" && amenintare.Text != "" && nivMin.Text != "" && nivMax.Text != "")
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("UPDATE risk.amenintari SET AMENINTARE=@amenintare, NIVEL_MINIM=@nivelMin, NIVEL_MAXIM=@nivelMax WHERE COD_BUN=@codBun", con);
                    cmd.Parameters.AddWithValue("@codBun", codBun.Text);
                    cmd.Parameters.AddWithValue("@amenintare", amenintare.Text);
                    cmd.Parameters.AddWithValue("@nivelMin", nivMin.Text);
                    cmd.Parameters.AddWithValue("@nivelMax", nivMax.Text);
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
                            string query = "INSERT INTO amenintari (cod_bun, amenintare, nivel_minim, nivel_maxim) " +
                                           "VALUES (@codBun, @amenintare, @nivelMinim, @nivelMaxim)";
                            MySqlCommand command = new MySqlCommand(query, connection);
                            command.Parameters.AddWithValue("@codBun", row["cod_bun"]);
                            command.Parameters.AddWithValue("@amenintare", row["amenintare"]);
                            command.Parameters.AddWithValue("@nivelMinim", row["nivel_minim"]);
                            command.Parameters.AddWithValue("@nivelMaxim", row["nivel_maxim"]);
                            command.ExecuteNonQuery();
                        }

                        connection.Close();
                    }
                }

                MessageBox.Show("Data Imported Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void rapoarteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
