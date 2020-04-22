using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRemoteBibliotheque
{
    public interface IServiceBibliothecaire
    {

        Boolean Ajouter_Ouvrage(Ouvrage ouvrage);
        Boolean Ajouter_Membre_Etudiant(Etudiant emprunteur);
        Boolean Ajouter_Membre_Enseignant(Enseignant enseignant);
        Boolean Supprimer_Membre(int numero);
        Boolean Confirmer_Demande_Rerservation(int idReservation);
        Boolean Liberer_Reservation(int idReservation);
        Boolean Login(String username, String  password);
        List<Reservation> consulter_list_reservation();
        Boolean Modifier_Ouvrage(Ouvrage ouvrage , int CodeBarre);
    }
}
