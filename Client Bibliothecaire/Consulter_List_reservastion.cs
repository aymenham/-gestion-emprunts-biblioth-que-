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
    public partial class Consulter_List_reservastion : Form
    {
        private List<IRemoteBibliotheque.Reservation> reservastions;

        public Consulter_List_reservastion()
        {
            InitializeComponent();

            reservastions = Session.obj.consulter_list_reservation();

            list_reservation.DataSource = reservastions;
        }

        private void list_reservation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int rowindex = list_reservation.CurrentCell.RowIndex;
            int idReservastion = int.Parse(list_reservation.Rows[rowindex].Cells[0].Value.ToString());

            Boolean result = Session.obj.Confirmer_Demande_Rerservation(idReservastion);

            if (result)
            {

                MessageBox.Show("reservation confirmée avec succès");
                this.list_reservation.DataSource = null;
                list_reservation.Rows.Clear();
                reservastions = Session.obj.consulter_list_reservation();
                list_reservation.DataSource = reservastions;
                list_reservation.Refresh();

            }

            else
            {

                MessageBox.Show("un probléme lors de la confirmation de reservastion");


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rowindex = list_reservation.CurrentCell.RowIndex;
            int idReservastion = int.Parse(list_reservation.Rows[rowindex].Cells[0].Value.ToString());

            Boolean result = Session.obj.Liberer_Reservation(idReservastion);

            if (result)
            {

                MessageBox.Show("reservation liberée  avec succès");
                this.list_reservation.DataSource = null;
                list_reservation.Rows.Clear();
                reservastions = Session.obj.consulter_list_reservation();
                list_reservation.DataSource = reservastions;
                list_reservation.Refresh();

            }

            else
            {

                MessageBox.Show("un probléme lors de la libération du reservastion");


            }
        }
    }
}
