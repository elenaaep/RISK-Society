using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RISK
{
    public partial class Login : Form
    {
        MySqlConnection connection = new MySqlConnection("server=127.0.0.1; user=root; database=risk; password=");
        MySqlCommand command;
        MySqlDataReader mdr;

        public Login()
        {
            InitializeComponent();

    
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void contNou_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            Inregistrare form2 = new Inregistrare(); 
            form2.Show();

            this.Hide();
        }

        private void Autentificare_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Username.Text) || string.IsNullOrEmpty(Password.Text))
            {
                MessageBox.Show("Please input Username and Password", "Error");
            }
            else
            {
                string connectionString = "server=127.0.0.1; user=root; database=risk; password=";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string selectQuery = "SELECT * FROM register WHERE Username = @username AND Password = @password";
                    MySqlCommand command = new MySqlCommand(selectQuery, connection);
                    command.Parameters.AddWithValue("@username", Username.Text);
                    command.Parameters.AddWithValue("@password", Password.Text);

                    try
                    {
                        connection.Open();
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                MessageBox.Show("Login Successful!");
                                this.Hide();
                                
                                Meniu meniu = new Meniu();
                                meniu.Show();
                            }
                            else
                            {
                                MessageBox.Show("Incorrect Login Information! Try again.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }


    
}
}
