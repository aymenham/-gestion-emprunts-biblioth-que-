using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using IRemoteBibliotheque;

namespace Client_Bibliothecaire
{
    public static class Session
    {
        public static IServiceBibliothecaire obj;


        public static void Recuperer()
        {


            try
            {
                TcpChannel chl = new TcpChannel();
                ChannelServices.RegisterChannel(chl, false);
                Console.WriteLine("Client: Canal enregistré");
                obj = (IServiceBibliothecaire)Activator.GetObject(typeof(IServiceBibliothecaire), "tcp://localhost:1234/ObjBibliothecaire");

            }
            catch (Exception ex)
            {
                Console.WriteLine("ERREUR :" + ex.Message);
                Console.ReadLine();
            }
        }

    }
}
