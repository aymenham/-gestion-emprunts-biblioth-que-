using IRemoteBibliotheque;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Client_Bibliothecaire
{
    public partial class AjouterOuvrage : Form
    {
        public AjouterOuvrage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Code = int.Parse(code_bare.Text);
            string Titre = tittre.Text;
            string Auteur = auteur.Text;
            string Fiche = fiche.Text;
            string Theme = theme.Text;
            string Type = type.Text;
            string Image = imagepath.Text;

            Image.Replace("\\" , "/");

            Ouvrage ouvrage = new Ouvrage(Code, Titre, Auteur, Fiche, Theme, Image, Type, false);

            if (string.IsNullOrEmpty(code_bare.Text) || string.IsNullOrEmpty(Titre) || string.IsNullOrEmpty(Auteur) ||
           string.IsNullOrEmpty(Fiche) || string.IsNullOrEmpty(Theme) || string.IsNullOrEmpty(Type) || string.IsNullOrEmpty(Image)
           )
            {

                MessageBox.Show("il faut remplir tout les champ", "Erreur",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

                Boolean result = Session.obj.Ajouter_Ouvrage(ouvrage);

                if (result)
                {
                    reponse.Text = "ouvrage ajouté avec succès";
                    reponse.Visible = true;
                }
                else
                {
                    reponse.Text = "erreur lors de l'ajout de cet ouvrage";
                    reponse.Visible = true;
                }

            }

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files (*.jpg; *.jpeg; *.gif; *.bmp;) | *.jpg; *.jpeg; *.gif; *.bmp; ";
            open.ShowDialog();
            imagepath.Text = Path.GetFullPath(open.FileName).Replace(@"\", @"\\\");





        }
    }
}
