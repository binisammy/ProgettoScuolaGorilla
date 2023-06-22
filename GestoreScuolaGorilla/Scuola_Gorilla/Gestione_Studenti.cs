using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scuola_Gorilla
{
    public partial class Gestione_Studenti : Form
    {
        private const string BaseUrl = "http://192.168.11.66:10212/values";
        private readonly HttpClient client;

        public Gestione_Studenti()
        {
            InitializeComponent();
            client = new HttpClient();
        }

        // TextBox Nome
        private void TxtNome_MouseClick(object sender, MouseEventArgs e)
        {
            this.TxtNome.Text = "";
        }
        private void TxtNome_MouseLeave(object sender, EventArgs e)
        {
            if (this.TxtNome.Text == "")
            {
                this.TxtNome.Text = "Inserisci Nome";
            }
        }

        // TextBox Cognome
        private void TxtCognome_MouseClick(object sender, MouseEventArgs e)
        {
            this.TxtCognome.Text = "";
        }
        private void TxtCognome_MouseLeave(object sender, EventArgs e)
        {
            if (this.TxtCognome.Text == "")
            {
                this.TxtCognome.Text = "Inserisci Cognome";
            }
        }

        // TextBox Matricola
        private void TxtMatricola_MouseClick(object sender, MouseEventArgs e)
        {
            this.TxtMatricola.Text = "";
        }
        private void TxtMatricola_MouseLeave(object sender, EventArgs e)
        {
            if (this.TxtMatricola.Text == "")
            {
                this.TxtMatricola.Text = "Inserisci Matricola";
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
