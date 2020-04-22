using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using IRemoteBibliotheque;

namespace Client_Emprunteur
{
    public partial class Login : Form
    {

       // IServiceEmprunteur obj;

        public Login()
        {
            InitializeComponent();
          Session.Recuperer();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            String nomU = nom_utilisateur.Text;
            String motDP = mot_de_passe.Text;

            Emprunteur result = Session.obj.Login(nomU, motDP);

            if (result!=null)
            {

                Session.nom_utilisateur = result.Nom_utilisateur;
                Session.numero_carte = result.Numero_carte;

                Accueil accueill = new Accueil();

                this.Hide();

                accueill.ShowDialog();

            }
            else
            {

                reponse_login.Text = "nom d'utiilisateur ou mot de passe incoreccte ";
                reponse_login.Visible = true;


            }

        }

        private void nom_utilisateur_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
