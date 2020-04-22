using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Servicewcf
{

    [DataContract]
    public  class Ouvrage
    {
        private int code_barre;
        private String titre;
        private String auteur;
        private String fiche_descriptive;
        private String theme;
        private String image;
        private String type;
        private Boolean statut;

        public Ouvrage()
        {

        }

        public Ouvrage(int code_barre,String titre, String auteur,
            String fiche_descriptive,String theme, String image,String type,Boolean statut)
        {
            this.code_barre=code_barre;
            this.titre=titre;
            this.auteur=auteur;
            this.fiche_descriptive=fiche_descriptive;
            this.theme=theme;
            this.image=image;
            this.type=type;
            this.statut=statut;
    }
        [DataMember]
        public int Code_barre
        {
            get { return code_barre; }
            set { code_barre = value; }
        }
        [DataMember]
        public string Titre
        {
            get { return titre; }
            set { titre = value; }
        }
        [DataMember]
        public string Auteur
        {
            get { return auteur; }
            set { auteur = value; }
        }
        [DataMember]
        public string Fiche_descriptive
        {
            get { return fiche_descriptive; }
            set { fiche_descriptive = value; }
        }
        [DataMember]
        public string Theme
        {
            get { return theme; }
            set { theme = value; }
        }
        [DataMember]
        public string Image
        {
            get { return image; }
            set { image = value; }
        }
        [DataMember]
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        [DataMember]
        public Boolean Statut 
        {
            get { return statut; }
            set { statut = value; }
        }
    }
}
