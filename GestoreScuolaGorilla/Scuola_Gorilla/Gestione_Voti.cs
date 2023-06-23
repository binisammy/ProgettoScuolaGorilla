using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scuola_Gorilla
{
    public partial class Gestione_Voti : Form
    {
        ApiMethods api;
        public Gestione_Voti()
        {
            InitializeComponent();
            api = new ApiMethods();
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

        private async void TxtMatricola_TextChanged_1(object sender, EventArgs e)
        {
            if (TxtMatricola.Text != "")
            {
                Studente s = await api.getStudente(TxtMatricola.Text);
                if (s.Matricola != "")
                    txtClasse.Text = s.IdClasse;
                else
                    txtClasse.Text = "";
            }
            else
            {
                txtClasse.Text = "";
            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            if (TxtMatricola.Text == "")
            {
                MessageBox.Show("Errore", "Inserire matricola", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Studente s = await api.getStudente(TxtMatricola.Text);
            if (s.Matricola == "")
            {
                MessageBox.Show("Matricola non trovata", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (CbxMateria.SelectedIndex == -1 || CbxMateria.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Scegliere una materia", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (comboBox1.SelectedIndex == -1 || comboBox1.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Scegliere un voto", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string result = await api.postVoto(CbxMateria.SelectedItem.ToString(), TxtMatricola.Text, comboBox1.Text);
            MessageBox.Show(result, "Messaggio", MessageBoxButtons.OK, MessageBoxIcon.Information);
            s = await api.getVoti(TxtMatricola.Text);
            this.DgwVoti.Rows.Clear();
            foreach (var voto in s.VotiMaterie)
            {
                List<double> voti = voto.Value.Voto;
                foreach (var v in voti)
                {
                    this.DgwVoti.Rows.Add(voto.Key.ToUpper(), v);
                }
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (TxtMatricola.Text == "")
            {
                MessageBox.Show("Errore", "Inserire matricola", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Studente s = await api.getStudente(TxtMatricola.Text);
            if (s.Matricola == "")
            {
                MessageBox.Show("Matricola non trovata", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (CbxMateria.SelectedIndex == -1 || CbxMateria.SelectedItem.ToString() == "")
            {
                DialogResult res = MessageBox.Show("Scegliere una materia", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (comboBox1.SelectedIndex == -1 || comboBox1.SelectedItem.ToString() == "")
            {
                DialogResult res = MessageBox.Show("Nessuna voto scelta.\n Eliminare tutti i voti della materia selezionata?", "Attenzione", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    string deleteVotiByMateriaRes = await api.deleteVotiByMateria(TxtMatricola.Text, CbxMateria.SelectedItem.ToString());
                    MessageBox.Show(deleteVotiByMateriaRes, "Messaggio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    return;
            }

            else
            {
                string deleteVotoRes = await api.deleteVoto(comboBox1.SelectedItem.ToString(), CbxMateria.SelectedItem.ToString(), TxtMatricola.Text);
                MessageBox.Show(deleteVotoRes, "Messaggio", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            s = await api.getVoti(TxtMatricola.Text);
            this.DgwVoti.Rows.Clear();
            foreach (var voto in s.VotiMaterie)
            {
                List<double> voti = voto.Value.Voto;
                foreach (var v in voti)
                {
                    this.DgwVoti.Rows.Add(voto.Key.ToUpper(), v);
                }
            }
        }

        private async void txtClasse_TextChanged(object sender, EventArgs e)
        {
            if (txtClasse.Text != "")
            {
                List<string> materie = await api.getMaterie(txtClasse.Text);
                CbxMateria.Items.Clear();
                foreach (var m in materie)
                {
                    CbxMateria.Items.Add(m);
                }
            }
        }
    }
}
