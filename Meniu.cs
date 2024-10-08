using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace RISK
{
    public partial class Meniu : Form
    {
        public Meniu()
        {
            InitializeComponent();
        }

        private void Meniu_Load(object sender, EventArgs e)
        {
            
        }

     

        private void button2_Click(object sender, EventArgs e)
        {
            Amenintari amenintari = new Amenintari();
            amenintari.Show();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Bunuri bun = new Bunuri();
            bun.Show();

            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Vulnerabilitati vulnerabilitati = new Vulnerabilitati();
            vulnerabilitati.Show();

            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Riscuri risc = new Riscuri();
            risc.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Contramasuri contramasuri = new Contramasuri();
            contramasuri.Show();
            this.Hide();
        }
    }
}
