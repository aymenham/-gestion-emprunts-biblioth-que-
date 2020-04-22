using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRemoteBibliotheque
{
    [Serializable]
    public class Enseignant
    {


        private Emprunteur emprunteur;
        private string grade;

        public Enseignant(Emprunteur emprunteur, string grade)
        {
            this.emprunteur = emprunteur;
            this.grade = grade;
        }

        public Emprunteur Emp
        {
            get { return emprunteur; }
            set { emprunteur = value; }
        }

        public string Grade
        {
            get { return grade; }
            set { grade = value; }
        }
    }
}
