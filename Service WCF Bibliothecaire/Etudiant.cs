using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Servicewcf
{   
    [DataContract]
    public class Etudiant
    {

        private Emprunteur emprunteur;

        private string specialite;

        private string niveau;

        public Etudiant(Emprunteur emprunteur, string specialite, string niveau)
        {
            this.emprunteur = emprunteur;
            this.specialite = specialite;
            this.niveau = niveau;
        }
        [DataMember]
        public string Specialite
        {
            get { return specialite; }
            set { specialite = value; }
        }
        [DataMember]
        public string Niveau
        {
            get { return niveau; }
            set { niveau = value; }
        }
        [DataMember]
        public Emprunteur Emp
        {
            get { return emprunteur; }
            set { emprunteur = value; }
        }
    }
}
