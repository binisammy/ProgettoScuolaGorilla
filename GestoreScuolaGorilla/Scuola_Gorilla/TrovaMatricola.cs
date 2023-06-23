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
        }

        private async void btnCerca_Click(object sender, EventArgs e)
        {
            if (txtClasse.Text == "" || txtCognome.Text == "" || txtNome.Text == "")
                MessageBox.Show("Riempire tutti i campi!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                txtMatricola.Text = await api.getMatricola(txtClasse.Text, txtNome.Text, txtCognome.Text);
        }
    }
}
