using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRemoteBibliotheque
{   
    [Serializable]
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

        public string Specialite
        {
            get { return specialite; }
            set { specialite = value; }
        }

        public string Niveau
        {
            get { return niveau; }
            set { niveau = value; }
        }

        public Emprunteur Emp
        {
            get { return emprunteur; }
            set { emprunteur = value; }
        }
    }
}
