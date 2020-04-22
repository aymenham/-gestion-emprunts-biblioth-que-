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

namespace Client_Bibliothecaire
{
    public partial class AjouterMembreEnseignant : Form
    {
        public AjouterMembreEnseignant()
        {
            InitializeComponent();
        }

        private void reponse_ajout_enseignant_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            String numeroCarte = numero_de_carte_.Text;
            String nomU = nom_utilisateur_.Text;
            String motDP = mot_de_passe_.Text;
            String nom = nom_.Text;
            String prenom = prenom_.Text;
            String email = email_.Text;
            String grade = grade_.Text;


            if (string.IsNullOrEmpty(numeroCarte) || string.IsNullOrEmpty(nomU) || string.IsNullOrEmpty(motDP) ||
                string.IsNullOrEmpty(nom) || string.IsNullOrEmpty(prenom) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(grade)
                )
            {

                MessageBox.Show("il faut remplir tout les champ", "Erreur",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else
            {

                Emprunteur emprunteur = new Emprunteur();
                emprunteur.Numero_carte = int.Parse(numeroCarte);
                emprunteur.Nom_utilisateur = nomU;
                emprunteur.Mot_de_passe = motDP;
                emprunteur.Nom = nom;
                emprunteur.Prenom = prenom;
                emprunteur.Email = email;
                Enseignant enseignant = new Enseignant(emprunteur, grade);
                bool result = Session.obj.Ajouter_Membre_Enseignant(enseignant);

                if (result)
                {

                    reponse_ajout_enseignant.Text = "le membre a bien été  ajouté ";
                    reponse_ajout_enseignant.Visible = true;
                    numero_de_carte_.Text = "";
                    nom_utilisateur_.Text = "";
                    mot_de_passe_.Text = "";
                    nom_.Text = "";
                    prenom_.Text = "";
                    email_.Text = "";
                    grade_.Text = "";



                }
                else
                {

                    reponse_ajout_enseignant.Text = "un probleme lors de l'ajout  ";
                    reponse_ajout_enseignant.Visible = true;

                }
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
