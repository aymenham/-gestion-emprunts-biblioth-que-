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
    public partial class AjouterMembreEtudiant : Form
    {
        public AjouterMembreEtudiant()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String numeroCarte = numero_carte_ajout.Text;
            String nomU = nom_utilisateur_ajout.Text;
            String motDP = mot_de_passe_ajout.Text;
            String nom = nom_ajout.Text;
            String prenom = prenom_ajout.Text;
            String email = email_ajout.Text;
            String speclite = specialite_ajout.Text;
            String niveau = niveau_ajout.Text;

            if(string.IsNullOrEmpty(numeroCarte) || string.IsNullOrEmpty(nomU) || string.IsNullOrEmpty(motDP)||
                string.IsNullOrEmpty(nom) || string.IsNullOrEmpty(prenom) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(speclite) || string.IsNullOrEmpty(niveau)
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
                Etudiant etudiant = new Etudiant(emprunteur, speclite, niveau);
                bool result = Session.obj.Ajouter_Membre_Etudiant(etudiant);

                if (result)
                {

                    reponse_ajout.Text = "le membre a bien été  ajouté ";
                    reponse_ajout.Visible = true;
                     numero_carte_ajout.Text = "";
                     nom_utilisateur_ajout.Text = "";
                    mot_de_passe_ajout.Text = "";
                    nom_ajout.Text = "";
                    prenom_ajout.Text = "";
                    email_ajout.Text = "";
                    specialite_ajout.Text = "";
                    niveau_ajout.Text = "";



                }
                else
                {

                    reponse_ajout.Text = "un probleme lors de l'ajout  ";
                    reponse_ajout.Visible = true;

                }
            }
        }
    }
}
