using IRemoteBibliotheque;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Client_Emprunteur
{
    public partial class Modifier_profile : Form
    {
        public Modifier_profile()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nomU = nouveau_nom_utilisateur.Text.ToString().Trim();
            String motDP = nouveau_mot_de_passe.Text.ToString().Trim();
           
            Emprunteur emprunteur = new Emprunteur();
            emprunteur.Nom_utilisateur = nomU;
            emprunteur.Mot_de_passe = motDP;
            emprunteur.Numero_carte = Session.numero_carte;


            if(nomU.Length==0 && motDP.Length == 0)
            {
                MessageBox.Show("il faut remplir au moin un champ", "Erreur",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {

                Boolean result = Session.obj.Modifier_Information(emprunteur);

                if (result)
                {
                    resultat_modifcation.Text = "modification  avec succes ";
                }

                else
                {

                    resultat_modifcation.Text = "problème lors de la modification  ";

                }

            }

           

        
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
