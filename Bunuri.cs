using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Linq;


namespace RISK
{
    public partial class Bunuri : Form
    {

        MySqlConnection con = new MySqlConnection("server=127.0.0.1; user=root; database=risk; password=");
        MySqlDataAdapter adapt;
        MySqlCommand cmd;
        DataTable dt;


        public Bunuri()
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
            adapt = new MySqlDataAdapter("select * from risk.bunuri", con);
            adapt.Fill(dt);
            tabelBunuri.DataSource = dt;
            con.Close();
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
                "Convert(COD_PROIECT, 'System.String') LIKE '%{0}%' OR " +
                "Convert(COD_BUN, 'System.String') LIKE '%{0}%' OR " +
                "NUME_BUN LIKE '%{0}%' OR " +
                "Convert(IMPACT_MINIM, 'System.String') LIKE '%{0}%' OR " +
                "Convert(IMPACT_MAXIM, 'System.String') LIKE '%{0}%' OR " +
                "DOMENIU_CATEGORIE LIKE '%{0}%' OR " +
                "Convert(COST, 'System.String') LIKE '%{0}%' OR " +
                "Convert(COST_REDUCERE, 'System.String') LIKE '%{0}%'",
                searchValue
            );

            DataView dv = dt.DefaultView;
            dv.RowFilter = filterExpression;
            tabelBunuri.DataSource = dv.ToTable();
        }


        private void PopulateComboBox()
        {
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT cod_proiect FROM proiect", con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    codProiect.Items.Add(reader["cod_proiect"].ToString());
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la popularea ComboBox-ului: " + ex.Message);
            }
        }

        private void inserare_Click(object sender, EventArgs e)
        {
            string codProiectValue = this.codProiect.SelectedItem?.ToString();
            string codBunValue = this.codBun.Text;
            string numeBunValue = this.nume.Text;
            decimal impactMinimValue = this.min.Value;
            decimal impactMaximValue = this.max.Value;
            string domeniuCategorieValue = this.domeniu.Text;
            decimal costValue = decimal.Parse(this.cost.Text);
            decimal costReducereValue = decimal.Parse(this.reducere.Text);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                if (!string.IsNullOrEmpty(codProiectValue) && !string.IsNullOrEmpty(codBunValue) &&
                    !string.IsNullOrEmpty(numeBunValue) && !string.IsNullOrEmpty(domeniuCategorieValue) &&
                    costValue >= 0 && costReducereValue >= 0)
                {
                    string query = "INSERT INTO bunuri (COD_PROIECT, COD_BUN, NUME_BUN, IMPACT_MINIM, IMPACT_MAXIM, DOMENIU_CATEGORIE, COST, COST_REDUCERE) " +
                                   "VALUES (@codProiect, @codBun, @numeBun, @impactMinim, @impactMaxim, @domeniuCategorie, @cost, @costReducere)";
                    MySqlCommand cmd = new MySqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@codProiect", codProiectValue);
                    cmd.Parameters.AddWithValue("@codBun", codBunValue);
                    cmd.Parameters.AddWithValue("@numeBun", numeBunValue);
                    cmd.Parameters.AddWithValue("@impactMinim", impactMinimValue);
                    cmd.Parameters.AddWithValue("@impactMaxim", impactMaximValue);
                    cmd.Parameters.AddWithValue("@domeniuCategorie", domeniuCategorieValue);
                    cmd.Parameters.AddWithValue("@cost", costValue);
                    cmd.Parameters.AddWithValue("@costReducere", costReducereValue);

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
                //MessageBox.Show("Eroare la inserare: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void ClearData()
        {
            codProiect.SelectedItem = null;
            codBun.Text = "";
            nume.Text = "";
            min.Value = 0;
            max.Value = 0;
            domeniu.Text = "";
            cost.Text = "";
            reducere.Text = "";
        }

        private void reîmprospatareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void stergere_Click(object sender, EventArgs e)
        {
            if (codBun.Text != "" && codProiect.Text != "")
            {
                cmd = new MySqlCommand("delete from risk.bunuri where cod_bun=@cod_bun and cod_proiect=@cod_proiect", con);
                con.Open();
                cmd.Parameters.AddWithValue("@cod_bun", codBun.Text);
                cmd.Parameters.AddWithValue("@cod_proiect", codProiect.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Successfully Deleted", "DELETE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Select the record you want to Delete", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void actualizare_Click(object sender, EventArgs e)
        {
            try
            {
                if (codBun.Text != "" && codProiect.Text != "" && nume.Text != "" && domeniu.Text != "" &&
                    min.Text != "" && max.Text != "" && cost.Text != "" && reducere.Text != "")
                {
                    using (MySqlCommand cmd = new MySqlCommand("UPDATE risk.bunuri SET  nume_bun = @numeBun, domeniu_categorie = @domeniuCategorie, impact_minim = @impactMinim, impact_maxim = @impactMaxim, cost = @cost, cost_reducere = @costReducere WHERE cod_bun = @codBun AND cod_proiect = @codProiect", con))
                    {
                        con.Open();
                        cmd.Parameters.AddWithValue("@codBun", codBun.Text);
                        cmd.Parameters.AddWithValue("@codProiect", codProiect.Text);
                        cmd.Parameters.AddWithValue("@numeBun", nume.Text);
                        cmd.Parameters.AddWithValue("@domeniuCategorie", domeniu.Text);
                        cmd.Parameters.AddWithValue("@impactMinim", min.Text);
                        cmd.Parameters.AddWithValue("@impactMaxim", max.Text);
                        cmd.Parameters.AddWithValue("@cost", cost.Text);
                        cmd.Parameters.AddWithValue("@costReducere", reducere.Text);
                       
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record Successfully Updated", "UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DisplayData();
                            ClearData();
                        }
                        else
                        {
                            MessageBox.Show("No record found with the given criteria", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        
                    }
                }
                else
                {
                    MessageBox.Show("Select the record you want to Update", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
               // MessageBox.Show("Error: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void savePDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabelBunuri.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog
                {
                    Filter = "PDF (*.pdf)|*.pdf",
                    FileName = "Bunuri.pdf"
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
                            PdfPTable pTable = new PdfPTable(tabelBunuri.Columns.Count)
                            {
                                DefaultCell = { Padding = 2 },
                                WidthPercentage = 100,
                                HorizontalAlignment = Element.ALIGN_LEFT
                            };
                            foreach (DataGridViewColumn col in tabelBunuri.Columns)
                            {
                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                                pTable.AddCell(pCell);
                            }
                            foreach (DataGridViewRow viewRow in tabelBunuri.Rows)
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
                            MessageBox.Show("Date exportate cu succes", "Informații");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Eroare la exportul datelor: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Nu există înregistrări", "Informații");
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
            if (tabelBunuri.Rows.Count > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Excel Workbook|*.xlsx",
                    Title = "Salvați un fișier Excel",
                    FileName = "Bunuri.xlsx"
                };
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (var workbook = new ClosedXML.Excel.XLWorkbook())
                        {
                            var worksheet = workbook.Worksheets.Add("Bunuri");
                            for (int i = 0; i < tabelBunuri.Columns.Count; i++)
                            {
                                worksheet.Cell(1, i + 1).Value = tabelBunuri.Columns[i].HeaderText;
                            }
                            for (int i = 0; i < tabelBunuri.Rows.Count; i++)
                            {
                                for (int j = 0; j < tabelBunuri.Columns.Count; j++)
                                {
                                    worksheet.Cell(i + 2, j + 1).Value = tabelBunuri.Rows[i].Cells[j].Value?.ToString();
                                }
                            }
                            workbook.SaveAs(saveFileDialog.FileName);
                        }
                        MessageBox.Show("Date exportate cu succes", "Informații");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Eroare la exportul datelor: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Nu există înregistrări", "Informații");
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

        private void graficToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GraficBunuri graficForm = new GraficBunuri(tabelBunuri);
            graficForm.Show();
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
                    using (var workbook = new ClosedXML.Excel.XLWorkbook(openFileDialog.FileName))
                    {
                        var worksheet = workbook.Worksheet(1);
                        var rows = worksheet.RangeUsed().RowsUsed().Skip(1); // Skip header row

                        con.Open();
                        foreach (var row in rows)
                        {
                            int codBun = row.Cell(1).GetValue<int>();
                            int codProiect = row.Cell(2).GetValue<int>();
                            string numeBun = row.Cell(3).GetString();
                            decimal impactMinim = row.Cell(4).GetValue<decimal>();
                            decimal impactMaxim = row.Cell(5).GetValue<decimal>();
                            string domeniuCategorie = row.Cell(6).GetString();
                            decimal cost = row.Cell(7).GetValue<decimal>();
                            decimal costReducere = row.Cell(8).GetValue<decimal>();

                            using (MySqlCommand cmd = new MySqlCommand("INSERT INTO bunuri (COD_BUN, COD_PROIECT, NUME_BUN, IMPACT_MINIM, IMPACT_MAXIM, DOMENIU_CATEGORIE, COST, COST_REDUCERE) VALUES (@codBun, @codProiect, @numeBun, @impactMinim, @impactMaxim, @domeniuCategorie, @cost, @costReducere)", con))
                            {
                                cmd.Parameters.AddWithValue("@codBun", codBun);
                                cmd.Parameters.AddWithValue("@codProiect", codProiect);
                                cmd.Parameters.AddWithValue("@numeBun", numeBun);
                                cmd.Parameters.AddWithValue("@impactMinim", impactMinim);
                                cmd.Parameters.AddWithValue("@impactMaxim", impactMaxim);
                                cmd.Parameters.AddWithValue("@domeniuCategorie", domeniuCategorie);
                                cmd.Parameters.AddWithValue("@cost", cost);
                                cmd.Parameters.AddWithValue("@costReducere", costReducere);
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
