using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using IRemoteBibliotheque;

namespace Client_Emprunteur
{
    public static  class Session
    {

        public static  string nom_utilisateur;

        public static int numero_carte;

      public static IServiceEmprunteur obj;


        public static  void Recuperer()
        {


            try
            {
                TcpChannel chl = new TcpChannel();
                ChannelServices.RegisterChannel(chl, false);
                Console.WriteLine("Client: Canal enregistré");
                obj = (IServiceEmprunteur)Activator.GetObject(typeof(IServiceEmprunteur), "tcp://localhost:1234/ObjEmprunteur");

            }
            catch (Exception ex)
            {
                Console.WriteLine("ERREUR :" + ex.Message);
                Console.ReadLine();
            }
        }
    }
}
