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
    public partial class Detaille_Ouvrage : Form
    {
        private int CodeBarre;

        public Detaille_Ouvrage(BiblioService.Ouvrage ouvrage)
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile(ouvrage.Image);
            Code.Text = Convert.ToString( ouvrage.Code_barre);
            Titre.Text =  ouvrage.Titre;
            Auteur.Text =  ouvrage.Auteur;
            Fiche.Text =  ouvrage.Fiche_descriptive;
            Theme.Text =  ouvrage.Theme;
            Type.Text =  ouvrage.Type;
            CodeBarre = ouvrage.Code_barre;
        }

        private void Detaille_Ouvrage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(Code.Text) || string.IsNullOrEmpty(Titre.Text) || string.IsNullOrEmpty(Auteur.Text) ||

                string.IsNullOrEmpty(Fiche.Text) || string.IsNullOrEmpty(Theme.Text) || string.IsNullOrEmpty(Type.Text))
            {
                MessageBox.Show("il faut remplir tout les champs");
            }

            else
            {
                IRemoteBibliotheque.Ouvrage ouvrage = new IRemoteBibliotheque.Ouvrage();

                ouvrage.Code_barre = int.Parse(Code.Text.ToString().Trim());
                ouvrage.Titre = Titre.Text.ToString().Trim();
                ouvrage.Auteur = Auteur.Text.ToString().Trim();
                ouvrage.Fiche_descriptive = Fiche.Text.ToString().Trim();
                ouvrage.Theme = Theme.Text.ToString().Trim();
                ouvrage.Type = Type.Text.ToString().Trim();

                bool update = Session.obj.Modifier_Ouvrage(ouvrage, CodeBarre);

                if (update)
                {
                    MessageBox.Show("ouvrage modifié avec succès");
                    Code.Text = Convert.ToString(ouvrage.Code_barre);
                    Titre.Text = ouvrage.Titre;
                    Auteur.Text = ouvrage.Auteur;
                    Fiche.Text = ouvrage.Fiche_descriptive;
                    Theme.Text = ouvrage.Theme;
                    Type.Text = ouvrage.Type;
                    CodeBarre = ouvrage.Code_barre;
                }

                else
                {
                    MessageBox.Show("erreur lors de la modification de cet ouvrage ");
                }

            }
        }
    }
}
