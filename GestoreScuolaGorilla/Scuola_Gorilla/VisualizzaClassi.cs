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
    public partial class VisualizzaClassi : Form
    {
        ApiMethods api;

        public VisualizzaClassi()
        {
            InitializeComponent();
            api = new ApiMethods();
            initializeClassi();
        }

        private async void initializeClassi()
        {
            cbxClasse.Items.Clear();
            var classi = await api.getClassi();
            foreach (var classe in classi)
            {
                this.cbxClasse.Items.Add(classe);
            }
        }

        private void VisualizzaClassi_Load(object sender, EventArgs e)
        {
            dgwMateria.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgwStudenti.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void cbxMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxClasse.SelectedItem.ToString() != "")
            {
                dgwStudenti.Rows.Clear();
                dgwMateria.Rows.Clear();
                List<string> materie = await api.getMaterieByClasse(cbxClasse.SelectedItem.ToString());
                foreach (var materia in materie)
                {
                    dgwMateria.Rows.Add(materia);
                }
                List<Studente> studenti = await api.getStudenti(cbxClasse.SelectedItem.ToString());
                foreach (var studente in studenti)
                {
                    dgwStudenti.Rows.Add(studente.Matricola + " " + studente.Cognome + " " + studente.Nome);
                }
            }
        }
    }
}
