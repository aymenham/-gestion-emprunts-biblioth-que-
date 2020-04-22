using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Servicewcf
{
    [DataContract]
    public class Enseignant
    {


        private Emprunteur emprunteur;
        private string grade;

        public Enseignant(Emprunteur emprunteur, string grade)
        {
            this.emprunteur = emprunteur;
            this.grade = grade;
        }
        [DataMember]
        public Emprunteur Emp
        {
            get { return emprunteur; }
            set { emprunteur = value; }
        }
        [DataMember]
        public string Grade
        {
            get { return grade; }
            set { grade = value; }
        }
    }
}
