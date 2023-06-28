using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace Scuola_Gorilla
{
    public partial class VisualizzaVoti : Form
    {
        ApiMethods api;
        public VisualizzaVoti()
        {
            InitializeComponent();
            api = new ApiMethods();
        }

        private async void initializeMaterie(string matricola)
        {
            List<string> materie = await api.getMaterieByMatricola(matricola);
            cbxMateria.Items.Clear();
            if (materie.Count > 0)
            {
                foreach (string m in materie)
                {
                    cbxMateria.Items.Add(m);
                }
            }
        }

        private async void btnVisualizza_Click(object sender, EventArgs e)
        {
            dgwVoti.Rows.Clear();
            if (TxtMatricola.Text == "")
            {
                MessageBox.Show("Inserisci una matricola valida!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            List<string> matricole = await api.getAllMatricole();
            if (!matricole.Contains(TxtMatricola.Text))
            {
                MessageBox.Show("Matricola non trovata!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbxMateria.SelectedIndex == -1)
            {
                MessageBox.Show("Seleziona una materia!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Studente s = await api.getVoti(TxtMatricola.Text);
            if (s.VotiMaterie != null)
            {
                foreach (var voto in s.VotiMaterie)
                {
                    if (voto.Key.ToUpper() == cbxMateria.SelectedItem.ToString())
                        foreach (var v in voto.Value.Voto)
                        {
                            dgwVoti.Rows.Add(v);
                        }
                }
            }
        }

        private void TxtMatricola_TextChanged(object sender, EventArgs e)
        {
            if (TxtMatricola.Text == "" || TxtMatricola.Text == "Inserisci Matricola")
            {
                dgwVoti.Rows.Clear();
                cbxMateria.Items.Clear();
                cbxMateria.Text = "";
                return;
            }
            dgwVoti.Rows.Clear();
            initializeMaterie(TxtMatricola.Text);
        }

        private void TxtMatricola_MouseClick(object sender, MouseEventArgs e)
        {
            TxtMatricola.Text = "";
        }

        private void TxtMatricola_Leave(object sender, EventArgs e)
        {
            if (TxtMatricola.Text == "")
                TxtMatricola.Text = "Inserisci Matricola";
        }

        private void btnClearRows_Click(object sender, EventArgs e)
        {
            dgwVoti.Rows.Clear();
        }

        private void btnVisualizza_MouseEnter(object sender, EventArgs e)
        {
            btnVisualizza.BackColor = Color.FromArgb(23, 21, 32);
        }

        private void btnVisualizza_MouseLeave(object sender, EventArgs e)
        {
            btnVisualizza.BackColor = Color.FromArgb(32, 30, 45);
        }

        private void btnClearRows_MouseEnter(object sender, EventArgs e)
        {
            btnClearRows.BackColor = Color.FromArgb(23, 21, 32);
        }

        private void btnClearRows_MouseLeave(object sender, EventArgs e)
        {
            btnClearRows.BackColor = Color.FromArgb(32, 30, 45);
        }

        private void VisualizzaVoti_Load(object sender, EventArgs e)
        {
            dgwVoti.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }
    }
}
