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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            Session.Recuperer();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nomU = nom_utilisateur.Text;
            String motDP = mot_de_passe.Text;

            Boolean result = Session.obj.Login(nomU, motDP);
            if (result)
            {
                Accueil accueill = new Accueil();

                this.Hide();

                accueill.ShowDialog();

            }
            else
            {
                response.Text = "nom d'utiilisateur ou mot de passe incoreccte ";
                response.Visible = true;

            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void nom_utilisateur_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
