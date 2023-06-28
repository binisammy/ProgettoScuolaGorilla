using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace Scuola_Gorilla
{
    public partial class Gestione_Studenti : Form
    {
        ApiMethods api;

        public Gestione_Studenti()
        {
            InitializeComponent();
            api = new ApiMethods();
            initializeClassi();
        }

        private async void initializeClassi()
        {
            cbClassi.Items.Clear();
            var classi = await api.getClassi();
            foreach (var classe in classi)
            {
                this.cbClassi.Items.Add(classe);
            }
        }

        // TextBox Nome
        private void TxtNome_MouseClick(object sender, MouseEventArgs e)
        {
            this.TxtNome.Text = "";
        }
        private void TxtNome_Leave(object sender, EventArgs e)
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
        private void TxtCognome_Leave(object sender, EventArgs e)
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
        private void TxtMatricola_Leave(object sender, EventArgs e)
        {
            if (this.TxtMatricola.Text == "")
            {
                this.TxtMatricola.Text = "Inserisci Matricola";
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
        }

        private async void btnAddStudente_Click(object sender, EventArgs e)
        {
            if (this.TxtNome.Text == "Inserisci Nome" || this.TxtNome.Text == "")
            {
                MessageBox.Show("Inserisci un nome valido", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (this.TxtCognome.Text == "Inserisci Cognome" || this.TxtCognome.Text == "")
            {
                MessageBox.Show("Inserisci un cognome valido", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (this.TxtMatricola.Text == "Inserisci Matricola" || this.TxtMatricola.Text == "")
            {
                MessageBox.Show("Inserisci una matricola valida", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (this.cbClassi.SelectedIndex == -1)
            {
                MessageBox.Show("Seleziona una classe", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Studente s = await api.getStudente(TxtMatricola.Text);
            if (s.Matricola != "")
            {
                MessageBox.Show("Matricola già presente!\nSceglierne un'altra", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            List<string> studente = new List<string>
            {
                TxtNome.Text.ToUpper(),
                TxtCognome.Text.ToUpper(),
                TxtMatricola.Text.ToUpper(),
                cbClassi.SelectedItem.ToString()
            };
            var res = await api.postStudente(studente);
            MessageBox.Show(res, "Messaggio", MessageBoxButtons.OK, MessageBoxIcon.Information);
            List<Studente> studenti = await api.getStudenti(cbClassi.SelectedItem.ToString());
            dgwStudenti.Rows.Clear();
            foreach (var studente1 in studenti)
            {
                this.dgwStudenti.Rows.Add(studente1.Nome, studente1.Cognome, studente1.Matricola);
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.TxtNome.Text == "Inserisci Nome" || this.TxtNome.Text == "")
            {
                MessageBox.Show("Inserisci un nome valido", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (this.TxtCognome.Text == "Inserisci Cognome" || this.TxtCognome.Text == "")
            {
                MessageBox.Show("Inserisci un cognome valido", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (this.TxtMatricola.Text == "Inserisci Matricola" || this.TxtMatricola.Text == "")
            {
                MessageBox.Show("Inserisci una matricola valida", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (this.cbClassi.SelectedIndex == -1)
            {
                MessageBox.Show("Seleziona una classe", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            List<Studente> s = await api.getStudenti(cbClassi.SelectedItem.ToString());
            if (s.Count == 0)
            {
                MessageBox.Show("Non ci sono studenti da eliminare", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (var studente in s)
            {
                if (studente.Matricola == TxtMatricola.Text && studente.Cognome == TxtCognome.Text.ToUpper() && studente.Nome == TxtNome.Text.ToUpper())
                {
                    var res = await api.deleteStudente(studente.Matricola);
                    MessageBox.Show(res, "Messaggio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgwStudenti.Rows.Clear();
                    s.Remove(studente);
                    foreach (var studente1 in s)
                    {
                        this.dgwStudenti.Rows.Add(studente1.Nome, studente1.Cognome, studente1.Matricola);
                    }
                    return;

                }
            }
            MessageBox.Show("Studente non presente", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        private void Gestione_Studenti_Load(object sender, EventArgs e)
        {
            dgwStudenti.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }
    }
}
