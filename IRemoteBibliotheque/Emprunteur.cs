using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRemoteBibliotheque
{
    [Serializable]
    public class Emprunteur
    {
        private int numero_carte;
        private String nom_utilisateur;
        private String mot_de_passe;
        private String nom;
        private String prenom;
        private String email;
        private int reservation_non_confirme;
        private DateTime date_blocage;
        private Boolean statut; 

        public Emprunteur()
        {

        }

        public Emprunteur(int numero_carte, string nom_utilisateur, string mot_de_passe, string nom, string prenom, string email, int reservation_non_confirme, DateTime date_blocage, bool statut)
        {
            this.numero_carte = numero_carte;
            this.nom_utilisateur = nom_utilisateur;
            this.mot_de_passe = mot_de_passe;
            this.nom = nom;
            this.prenom = prenom;
            this.email = email;
            this.reservation_non_confirme = reservation_non_confirme;
            this.date_blocage = date_blocage;
            this.statut = statut;
        }


        public int Numero_carte
        {
            get { return numero_carte; }
            set { numero_carte = value; }
        }

        public string Nom_utilisateur
        {
            get { return nom_utilisateur; }
            set { nom_utilisateur = value; }
        }
        public string Mot_de_passe
        {
            get { return mot_de_passe; }
            set { mot_de_passe = value; }
        }
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public int Reservation_non_confirme
        {
            get { return reservation_non_confirme; }
            set { reservation_non_confirme = value; }
        }
        public DateTime Date_blocage 
        {
            get { return date_blocage; }
            set { date_blocage = value; }
        }
        public Boolean Statut
        {
            get { return statut; }
            set { statut = value; }
        }



    }
}
