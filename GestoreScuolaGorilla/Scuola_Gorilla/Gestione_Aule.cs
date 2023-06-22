using ClassLibrary1;
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
    public partial class Gestione_Aule : Form
    {
        private const string BaseUrl = "http://192.168.11.66:10212/values";
        private readonly HttpClient client;

        public Gestione_Aule()
        {
            InitializeComponent();
            client = new HttpClient();
        }

        // Form Principale
        private void Gestione_Aule_Load(object sender, EventArgs e)
        {
            BtnAddMateria.Visible = false;
            BtnClearMateria.Visible = false;
            BtnDeleteMateria.Visible = false;
            TxtNuovaMateria.Visible = false;
        }

        // TextBox IDaula
        private void TxtIDaula_MouseClick(object sender, MouseEventArgs e)
        {
            this.TxtIDaula.Text = "";
        }
        private void TxtIDaula_MouseLeave(object sender, EventArgs e)
        {
            if (this.TxtIDaula.Text == "")
            {
                this.TxtIDaula.Text = "Inserisci ID aula";
            }
        }

        // TextBox NuovaMateria
        private void TxtNuovaMateria_MouseClick(object sender, MouseEventArgs e)
        {
            this.TxtNuovaMateria.Text = "";
        }
        private void TxtNuovaMateria_MouseLeave(object sender, EventArgs e)
        {
            if (this.TxtNuovaMateria.Text == "")
            {
                this.TxtNuovaMateria.Text = "Inserisci nuova Materia";
            }
        }
        private void TxtNuovaMateria_TextChanged(object sender, EventArgs e)
        {

        }

        // Button AggiungiMateria
        private void button5_Click(object sender, EventArgs e)
        {
            BtnClearMateria.Visible = true;
            BtnAddMateria.Visible = true;
            BtnDeleteMateria.Visible = true;
            TxtNuovaMateria.Visible = true;
        }

        // Button Conferma Aggiunta Materia
        private void BtnAddMateria_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = DialogResult.Cancel;
            BtnClearMateria.Visible = false;
            BtnAddMateria.Visible = false;
            BtnDeleteMateria.Visible = false;
            TxtNuovaMateria.Visible = false;

            // Controllo Pre-Esistenza Materia
            if (ClbListaMaterie.Items.Contains(TxtNuovaMateria.Text))
            {
                dialogResult = MessageBox.Show("La materia aggiunta è già presente!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ClbListaMaterie.Items.Add(TxtNuovaMateria.Text);
            }
        }

        // Button Clear Textbox AggiungiMateria
        private void BtnClearMateria_Click(object sender, EventArgs e)
        {
            TxtNuovaMateria.Text = string.Empty;
        }

        // Button Delete Materia
        private void BtnDeleteMateria_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = DialogResult.Cancel;

            // Controllo Esistenza Materia da Eliminare
            if (ClbListaMaterie.FindStringExact(TxtNuovaMateria.Text) == -1)
            {
                dialogResult = MessageBox.Show("La materia da eliminare non è presente", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ClbListaMaterie.Items.RemoveAt(ClbListaMaterie.FindStringExact(TxtNuovaMateria.Text));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
