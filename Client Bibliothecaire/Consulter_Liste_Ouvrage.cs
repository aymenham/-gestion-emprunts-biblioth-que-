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
    public partial class Consulter_Liste_Ouvrage : Form
    {
        private BiblioService.Ouvrage[] ouvrages;

        public Consulter_Liste_Ouvrage()
        {
            InitializeComponent();

            var client = new BiblioService.ServiceWCFClient();
           ouvrages  = client.Consulter_List_Ouvrage();

            RemplirListTout(ouvrages);


        }


        private void RemplirListTout(BiblioService.Ouvrage[] result)
        {
         
            
            listOuvrage.View = View.Details;
            listOuvrage.Columns.Add("Titre", 300);
            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(100, 100);



            foreach (BiblioService.Ouvrage ouvrage in result)
            {
                imageList.Images.Add(Image.FromFile(ouvrage.Image));
            }

            listOuvrage.SmallImageList = imageList;

            for (int i = 0; i < result.Length; i++)
            {
                listOuvrage.Items.Add(result[i].Titre, i);
            }
        }

        private void listOuvrage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mouse_click(object sender, MouseEventArgs e)
        {
            int index = listOuvrage.FocusedItem.Index;
            Detaille_Ouvrage detaille = new Detaille_Ouvrage(ouvrages[index]);
            detaille.ShowDialog();
        }
    }
}
