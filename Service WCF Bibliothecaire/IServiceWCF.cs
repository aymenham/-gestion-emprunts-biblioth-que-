using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace IRemoteBibliotheque
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IServiceWCF
    {
        [OperationContract]
        List<Servicewcf.Ouvrage> Consulter_List_Ouvrage();
        [OperationContract]
        Boolean Reserver_Ouvrage(int codeEmprunteur , int codeOuvrage);

       
    }


   
   
}
