using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RISK
{
    public partial class Inregistrare : Form
    {

        MySqlConnection connection = new MySqlConnection("server=127.0.0.1; user=root; database=risk; password=");
        MySqlCommand command;
        MySqlDataReader mdr;

        public Inregistrare()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (confirmare.Text != parola.Text)
            {
                MessageBox.Show("Password doesn't match!", "Error");
                return;
            }

            if (string.IsNullOrEmpty(nume.Text) || string.IsNullOrEmpty(prenume.Text) || string.IsNullOrEmpty(gen.Text) || string.IsNullOrEmpty(utilizator.Text) || string.IsNullOrEmpty(parola.Text) || string.IsNullOrEmpty(confirmare.Text))
            {
                MessageBox.Show("Please fill out all information!", "Error");
                return;
            }

            try
            {
                connection.Open();

                // Verificam daca exista deja un utilizator cu acelasi username
                string selectQuery = "SELECT * FROM register WHERE Username = @UserName";
                MySqlCommand cmd1 = new MySqlCommand(selectQuery, connection);
                cmd1.Parameters.AddWithValue("@UserName", utilizator.Text);

                bool userExists = false;

                using (var dr1 = cmd1.ExecuteReader())
                {
                    userExists = dr1.HasRows;
                    if (userExists)
                        MessageBox.Show("Username not available!");
                }

                if (!userExists)
                {
                    // Inseram un nou utilizator în baza de date
                    string insertQuery = "INSERT INTO register (nume, prenume, gen, zi_nastere, username, password) VALUES (@Nume, @Prenume, @Gen, @ZiNastere, @UserName, @Password)";
                    MySqlCommand cmd2 = new MySqlCommand(insertQuery, connection);
                    cmd2.Parameters.AddWithValue("@Nume", nume.Text);
                    cmd2.Parameters.AddWithValue("@Prenume", prenume.Text);
                    cmd2.Parameters.AddWithValue("@Gen", gen.Text);
                    cmd2.Parameters.AddWithValue("@ZiNastere", data.Value.Date);
                    cmd2.Parameters.AddWithValue("@UserName", utilizator.Text);
                    cmd2.Parameters.AddWithValue("@Password", parola.Text);

                    cmd2.ExecuteNonQuery();

                    MessageBox.Show("Account Successfully Created!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }


            Login form = new Login();
            form.Show();

            this.Hide();



        }

        private void Inregistrare_Load(object sender, EventArgs e)
        {
            

        }
    }
}
