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
    public partial class Detaille_Ouvrage : Form
    {

        private EmpService.Ouvrage ouvrageReservastion;

        public Detaille_Ouvrage(EmpService.Ouvrage ouvrage)
        {
            InitializeComponent();

            RemplirDetaille(ouvrage);
        }


        public Detaille_Ouvrage(IRemoteBibliotheque.Ouvrage ouvrage)
        {
            InitializeComponent();

            RemplirDetailleFromSearch(ouvrage);
        }




        private void RemplirDetaille(EmpService.Ouvrage ouvrage)
        {

            ouvrageReservastion = ouvrage;

            pictureBox1.Image = Image.FromFile(ouvrage.Image);

            Titre.Text = "Titre : " + ouvrage.Titre;
            Auteur.Text = "Auteur : " + ouvrage.Auteur;
            Fiche.Text = "Fiche descriptive : " + ouvrage.Fiche_descriptive;
            Theme.Text = "Theme  : " + ouvrage.Theme;
            Type.Text = "Type d'ouvrage : " + ouvrage.Type;
            string stat;
            if (ouvrage.Statut)
            {
                stat = "Ouvrage Reservé";
            }
            else
            {
                stat = "Ouvrage Disponible";
            }
            statut.Text = "Statut : " + stat;

            if (ouvrage.Statut)
            {
                reserver.Text = "Inscrire a la liste d'attente ";
            }

            else
            {
                reserver.Text = "Reserver";
            }
        }


        private void RemplirDetailleFromSearch(IRemoteBibliotheque.Ouvrage ouvrage)
        {

            pictureBox1.Image = Image.FromFile(ouvrage.Image);

            Titre.Text = "Titre : " + ouvrage.Titre;
            Auteur.Text = "Auteur : " + ouvrage.Auteur;
            Fiche.Text = "Fiche descriptive : " + ouvrage.Fiche_descriptive;
            Theme.Text = "Theme  : " + ouvrage.Theme;
            Type.Text = "Type d'ouvrage : " + ouvrage.Type;
            string stat;
            if (ouvrage.Statut)
            {
                stat = "Ouvrage Reservé";
            }
            else
            {
                stat = "Ouvrage Disponible";
            }
            statut.Text = "Statut : " + stat;

            if (ouvrage.Statut)
            {
                reserver.Text = "Inscrire a la liste d'attente ";
            }

            else
            {
                reserver.Text = "Reserver";
            }
        }

        private EmpService.Ouvrage TransoformerOuvrage(IRemoteBibliotheque.Ouvrage ouvrage)
        {
            EmpService.Ouvrage result = new EmpService.Ouvrage();
            result.Code_barre = ouvrage.Code_barre;
            result.Titre = ouvrage.Titre;
            result.Auteur = ouvrage.Auteur;
            result.Fiche_descriptive = ouvrage.Fiche_descriptive;
            result.Theme = ouvrage.Theme;
            result.Image = ouvrage.Image;
            result.Type = ouvrage.Type;
            result.Statut = ouvrage.Statut;

            return result;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            var client = new EmpService.ServiceWCFClient();
            if (ouvrageReservastion.Statut)
            {

                DialogResult dialogResult1 = MessageBox.Show("voulez vraiment s'inscrire a liste d'attente de cet ouvrage ", "Confimer Reservastion", MessageBoxButtons.YesNo);
                if (dialogResult1 == DialogResult.Yes)
                {

                    bool resultInscription = Session.obj.Inscription_List_Attente(Session.numero_carte, ouvrageReservastion.Code_barre);

                    if (resultInscription)
                    {
                        MessageBox.Show("vous serez informer  dés que l'ouvrage sera  disponible via un email  ");
                    }

                    else
                    {
                        MessageBox.Show("un probléme lors de l'inscription a la liste d'attente  ");
                    }

                }
            }

            else
            {
                DialogResult dialogResult = MessageBox.Show("voulez vraiment reserver cet ouvrage ", "Confimer Reservastion", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    bool resultReservastion = client.Reserver_Ouvrage(Session.numero_carte, ouvrageReservastion.Code_barre);

                    if (resultReservastion)
                    {
                        MessageBox.Show("Merci d'avoire réserver cet ouvrage \n Vous devez vous présenter demain au maximum \n le " + DateTime.Now.AddDays(1).ToString("yyyy-MM-dd") + "\n pour confirmer votre réservation  ");
                    }

                    else
                    {
                        MessageBox.Show("un probléme lors de la reservastion ");
                    }
                }

            }


            }

        }
    }


