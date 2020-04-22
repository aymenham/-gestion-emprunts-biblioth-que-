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
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Consulter_liste_ouvrage consulter = new Consulter_liste_ouvrage();

            this.Hide();

            consulter.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Modifier_profile modifier = new Modifier_profile();



            modifier.ShowDialog();



            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Consulter_liste_ouvrage consulter = new Consulter_liste_ouvrage();



            consulter.ShowDialog();


        }
    }
}
