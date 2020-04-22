using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRemoteBibliotheque
{
    public interface IServiceEmprunteur
    {
        List<Ouvrage> Rechercher_Ouvrage(String mot);

        Boolean Modifier_Information(Emprunteur emprunteur);

        Emprunteur Login(String username  , String password);

        Boolean Inscription_List_Attente(int numeroEmprunteur , int codeOuvrage);

    }
}
