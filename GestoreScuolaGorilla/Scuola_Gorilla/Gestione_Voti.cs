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
        private void TxtMatricola_MouseLeave(object sender, EventArgs e)
        {
            if (this.TxtMatricola.Text == "")
            {
                this.TxtMatricola.Text = "Inserisci Matricola";
            }
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            if (TxtMatricola.Text.Equals(""))
            {
                MessageBox.Show("Matricola mancante", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Studente s = await api.getVoti(TxtMatricola.Text);
            this.DgwVoti.Rows.Clear();
            foreach (var voto in s.VotiMaterie)
            {
                List<double> voti = voto.Value.Voto;
                foreach (var v in voti)
                {
                    if (CbxMateria.SelectedIndex == -1 || CbxMateria.SelectedItem.ToString() == voto.Key.ToUpper())
                        this.DgwVoti.Rows.Add(voto.Key.ToUpper(), v);
                }
            }

        }

<<<<<<< HEAD
        private void DgwVoti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DgwVoti_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

=======
        private async void TxtMatricola_TextChanged(object sender, EventArgs e)
        {
            if (TxtMatricola.Text == "" || TxtMatricola.Text.Length == 0) return;
            List<string> materie = await api.getMaterieByMatricola(TxtMatricola.Text);
            CbxMateria.Items.Clear();
            foreach (var m in materie)
            {
                CbxMateria.Items.Add(m);
            }
>>>>>>> 2981f7bdfa72bcf55e025db2b9dbe258d02db7bc
        }
    }
}
