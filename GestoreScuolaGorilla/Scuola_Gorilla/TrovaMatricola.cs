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
    public partial class TrovaMatricola : Form
    {
        ApiMethods api;
        public TrovaMatricola()
        {
            InitializeComponent();
            api = new ApiMethods();
            initializeClasse();
        }

        private async void initializeClasse()
        {
            var classi = await api.getClassi();
            foreach (var classe in classi)
            {
                this.cbClasse.Items.Add(classe);
            }
        }

        private async void btnCerca_Click(object sender, EventArgs e)
        {
            if (cbClasse.SelectedIndex == -1 || txtCognome.Text == "" || txtNome.Text == "")
                MessageBox.Show("Riempire tutti i campi!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                txtMatricola.Text = await api.getMatricola(cbClasse.SelectedItem.ToString(), txtNome.Text.ToUpper(), txtCognome.Text.ToUpper());
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            txtMatricola.Text = "";
        }

        private void txtCognome_TextChanged(object sender, EventArgs e)
        {
            txtMatricola.Text = "";
        }

        private void cbClasse_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMatricola.Text = "";
        }
    }
}
