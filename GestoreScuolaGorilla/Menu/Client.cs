using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Scuola_Gorilla;
using System.Net.Http.Json;
using static System.Net.WebRequestMethods;

namespace Menu
{
    public partial class Client : Form
    {
        private const string BaseUrl = "http://192.168.11.66:10212/values";
        public readonly HttpClient client;

        public Client()
        {
            InitializeComponent();
            customizeDesing();
        }
        private void customizeDesing()
        {
            panelAggiungiMenu.Visible = false;
            panelVisuaizza.Visible = false;

        }
        private void hideSubMenu()
        {
            if (panelAggiungiMenu.Visible == true)
            {
                panelAggiungiMenu.Visible = false;
            }
            if (panelVisuaizza.Visible == true)
            {
                panelVisuaizza.Visible = false;
            }
        }
        private void showSubMenu(Panel subMenuu)
        {
            if (subMenuu.Visible == false)
            {
                hideSubMenu();
                subMenuu.Visible = true;
            }
            else
                subMenuu.Visible = false;
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            showSubMenu(panelAggiungiMenu);
        }

        private void btnClasse_Click(object sender, EventArgs e)
        {
            openChildForm(new Gestione_Aule());
        }

        private void btnMateria_Click(object sender, EventArgs e)
        {
            openChildForm(new Gestione_Voti());

        }

        private void btnStudente_Click(object sender, EventArgs e)
        {
            openChildForm(new Gestione_Studenti());
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {

            if (activeForm != null)
            {
                activeForm.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Confermi di voler uscire?", "Richiesta Conferma", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnVisualizza_Click(object sender, EventArgs e)
        {
            showSubMenu(panelVisuaizza);
        }

        private void btnCerca_Click(object sender, EventArgs e)
        {
            openChildForm(new TrovaMatricola());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openChildForm(new VisualizzaVoti());
        }










        /*private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }*/
    }
}
