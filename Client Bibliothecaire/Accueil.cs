using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_Bibliothecaire
{
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AjouterOuvrage ouvrage = new AjouterOuvrage();

            ouvrage.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AjouterMembreEtudiant membre = new AjouterMembreEtudiant();

            membre.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            AjouterMembreEnseignant enseignant = new AjouterMembreEnseignant();

            enseignant.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SupprimerMembre supprimer = new SupprimerMembre();

            supprimer.ShowDialog();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new Consulter_Liste_Ouvrage().ShowDialog();
        }

        private void listreservastion_Click(object sender, EventArgs e)
        {
            new Consulter_List_reservastion().ShowDialog();
        }
    }
}
