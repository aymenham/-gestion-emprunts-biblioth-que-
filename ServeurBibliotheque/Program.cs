using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using IRemoteBibliotheque;

namespace ServeurBibliotheque
{
    class Program
    {
       public  static void Main(string[] args)
        {

            try
            {
                TcpChannel chn1 = new TcpChannel(1234);
                ChannelServices.RegisterChannel(chn1, false);
                RemotingConfiguration.RegisterWellKnownServiceType(typeof(ServiceEmprunteurImpl), "ObjEmprunteur", WellKnownObjectMode.Singleton
                    );
                RemotingConfiguration.RegisterWellKnownServiceType(typeof(ServiceBibliothecaireImpl), "ObjBibliothecaire", WellKnownObjectMode.Singleton
                    );

                Console.WriteLine("Serveur démarré...");
                Console.ReadLine();

            }
            catch (Exception e)
            {
                Console.WriteLine("erreur " + e.Message);
                Console.ReadLine();
            }
        }
    }
}
