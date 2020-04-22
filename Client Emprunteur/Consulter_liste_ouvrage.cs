using Client_Emprunteur.EmpService;
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
    public partial class Consulter_liste_ouvrage : Form
    {

        private  Ouvrage[] ouvrages;
        private List<IRemoteBibliotheque.Ouvrage> result;
        private EmpService.ServiceWCFClient client;
        private Boolean IsSearched=false;
        public Consulter_liste_ouvrage()
        {
            InitializeComponent();


             client = new EmpService.ServiceWCFClient();

            ouvrages = client.Consulter_List_Ouvrage();

            RemplirListTout(ouvrages);

          
           

            

            
        }


        private void RemplirListTout(Ouvrage [] result)
        {
            IsSearched = false;
           listOuvrage.Items.Clear();
            listOuvrage.View = View.Details;
            listOuvrage.Columns.Add("Titre", 300);
            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(100, 100);

            

            foreach(Ouvrage ouvrage in result)
            {
                imageList.Images.Add(Image.FromFile(ouvrage.Image));
            }

            listOuvrage.SmallImageList = imageList;

            for(int i = 0; i < result.Length; i++)
            {
                listOuvrage.Items.Add(result[i].Titre, i);
            }
        }

        private void RemplirListCherche(List<IRemoteBibliotheque.Ouvrage> result)
        {
            IsSearched = true;
            listOuvrage.Items.Clear();
            listOuvrage.View = View.Details;
            listOuvrage.Columns.Add("Titre", 300);
            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(100, 100);



            foreach (IRemoteBibliotheque.Ouvrage ouvrage in result)
            {
                imageList.Images.Add(Image.FromFile(ouvrage.Image));
            }

            listOuvrage.SmallImageList = imageList;

            for (int i = 0; i < result.Count; i++)
            {
                listOuvrage.Items.Add(result[i].Titre, i);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ouvrages = client.Consulter_List_Ouvrage();

            RemplirListTout(ouvrages);
        }

        private void listOuvrage_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string motCherche = rechercheMot.Text.ToString().Trim();

           result = Session.obj.Rechercher_Ouvrage(motCherche);

            RemplirListCherche(result);

                
        }

        private void mouse_click(object sender, MouseEventArgs e)
        {
            if (IsSearched)
            {
                int index = listOuvrage.FocusedItem.Index;
                Detaille_Ouvrage detaille = new Detaille_Ouvrage(result.ElementAt(index));
                detaille.ShowDialog();
            }

            else
            {
                int index = listOuvrage.FocusedItem.Index;
                Detaille_Ouvrage detaille = new Detaille_Ouvrage(ouvrages[index]);
                detaille.ShowDialog();
            }
        }
    }
}
