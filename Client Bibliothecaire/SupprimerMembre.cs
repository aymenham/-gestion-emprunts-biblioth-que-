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
    public partial class SupprimerMembre : Form
    {
        public SupprimerMembre()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int code = int.Parse(supprimer.Text);

            bool result = Session.obj.Supprimer_Membre(code);

            if (result)
            {
                reponse.Text = "le membre a éte bien supprimé";
                reponse.Visible = true;
                supprimer.Text = "";
            }

            else
            {
                reponse.Text = "le membre "+code+" n'existe pas ";
                reponse.Visible = true;
            }
        }
    }
}
