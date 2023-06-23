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
using System.Windows.Forms.VisualStyles;

namespace Scuola_Gorilla
{
    public partial class Gestione_Aule : Form
    {
        ApiMethods api;

        public Gestione_Aule()
        {
            InitializeComponent();
            api = new ApiMethods();
            initializeMaterie();
        }

        private async void initializeMaterie()
        {
            List<string> materie = await api.getMaterie();
            ClbListaMaterie.Items.Clear();
            foreach (string materia in materie)
            {
                ClbListaMaterie.Items.Add(materia);
            }
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
        private void TxtIDaula_Leave(object sender, EventArgs e)
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
        private void TxrNuovaMateria_Leave(object sender, EventArgs e)
        {
            if (this.TxtNuovaMateria.Text == "")
            {
                this.TxtNuovaMateria.Text = "Inserisci nuova Materia";
            }
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
        private async void BtnAddMateria_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = DialogResult.Cancel;
            BtnClearMateria.Visible = false;
            BtnAddMateria.Visible = false;
            BtnDeleteMateria.Visible = false;
            TxtNuovaMateria.Visible = false;

            // Controllo Pre-Esistenza Materia
            if (TxtNuovaMateria.Text != "" && TxtNuovaMateria.Text != "Inserisci nuova Materia")
            {
                List<string> materie = await api.getMaterie();
                if (materie.Contains(TxtNuovaMateria.Text.ToUpper()))
                {
                    dialogResult = MessageBox.Show("La materia aggiunta è già presente!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var result = await api.postMateriaInInsieme(TxtNuovaMateria.Text.ToUpper());
                    initializeMaterie();
                    MessageBox.Show(result.ToString(), "Avviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                dialogResult = MessageBox.Show("Inserire una materia valida!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Button Clear Textbox AggiungiMateria
        private void BtnClearMateria_Click(object sender, EventArgs e)
        {
            TxtNuovaMateria.Text = string.Empty;
        }

        // Button Delete Materia
        private async void BtnDeleteMateria_Click(object sender, EventArgs e)
        {
            List<string> materie = await api.getMaterie();
            if (materie.Contains(TxtNuovaMateria.Text.ToUpper()))
            {
                var result = await api.deleteMateriaFromInsieme(TxtNuovaMateria.Text.ToUpper());
                initializeMaterie();
                MessageBox.Show(result, "Avviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("La materia inserita non è presente!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ClbListaMaterie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void TxtIDaula_TextChanged(object sender, EventArgs e)
        {
            if (TxtIDaula.Text != "")
            {
                List<string> classi = await api.getClassi();
                if (classi.Contains(TxtIDaula.Text.ToUpper()))
                {
                    List<string> materie = await api.getMaterieByClasse(TxtIDaula.Text.ToUpper());

                    foreach (string materia in materie)
                    {
                        if (ClbListaMaterie.Items.Contains(materia))
                        {
                            ClbListaMaterie.SetItemChecked(ClbListaMaterie.FindStringExact(materia), true);
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < ClbListaMaterie.Items.Count; i++)
                    {
                        ClbListaMaterie.SetItemChecked(i, false);
                    }
                }

            }
            else
            {
                for (int i = 0; i < ClbListaMaterie.Items.Count; i++)
                {
                    ClbListaMaterie.SetItemChecked(i, false);
                }
            }

        }

        private async void btnCercaClasse_Click(object sender, EventArgs e)
        {
            if (TxtIDaula.Text != "")
            {
                List<string> classi = await api.getClassi();
                if (classi.Contains(TxtIDaula.Text.ToUpper()))
                {
                    List<Studente> studenti = await api.getStudenti(TxtIDaula.Text.ToUpper());
                    foreach (Studente studente in studenti)
                    {
                        dataGridView4.Rows.Add(studente.Matricola, studente.Nome, studente.Cognome);
                    }
                }
            }
        }

        private async void btnAggiungiClasse_Click(object sender, EventArgs e)
        {
            if (TxtIDaula.Text != "" && TxtIDaula.Text != "Inserisci ID classe" && TxtIDaula.Text.Length == 3)
            {
                List<string> classi = await api.getClassi();
                if (classi.Contains(TxtIDaula.Text.ToUpper()))
                {
                    MessageBox.Show("Classe già esistente!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    var result = await api.postClasse(TxtIDaula.Text.ToUpper());
                    MessageBox.Show(result, "Avviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Inserire un ID classe valido!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnModificaMaterieClasse_Click(object sender, EventArgs e)
        {
            List<string> classi = await api.getClassi();
            if (!classi.Contains(TxtIDaula.Text.ToUpper()))
            {
                MessageBox.Show("Classe non trovata!\nCrea la classe o inserisci una classe esistente", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult res = MessageBox.Show("Sei sicuro di voler modificare le materie della classe?", "Avviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No)
            {
                return;
            }
            List<string> materieDB = await api.getMaterieByClasse(TxtIDaula.Text.ToUpper());
            List<string> materieClasse = new List<string>();
            foreach (string materia in ClbListaMaterie.CheckedItems)
            {
                materieClasse.Add(materia);
            }
            foreach (string materiaDB in materieDB)
            {
                if (!materieClasse.Contains(materiaDB))
                {
                    await api.deleteMateriaFromClasse(TxtIDaula.Text.ToUpper(), materiaDB);
                }
            }
            foreach (string materiaClasse in materieClasse)
            {
                if (!materieDB.Contains(materiaClasse))
                {
                    await api.postMateriaInClasse(materiaClasse, TxtIDaula.Text.ToUpper());
                }
            }
        }

        private async void btnEliminaClasse_Click(object sender, EventArgs e)
        {
            List<string> classi = await api.getClassi();
            if (!classi.Contains(TxtIDaula.Text.ToUpper()))
            {
                MessageBox.Show("Classe non trovata!\nCrea la classe o inserisci una classe esistente", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult res = MessageBox.Show($"Sei sicuro di voler eliminare definitivamente la classe {TxtIDaula.Text.ToUpper()}?", "Avviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No)
            {
                return;
            }
            var result = await api.deleteClasse(TxtIDaula.Text.ToUpper());
            MessageBox.Show(result, "Avviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
