
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using MySql.Data.MySqlClient;

namespace IRemoteBibliotheque
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IServiceWCF
    {
        private string server;
        private string dbName;
        private string username;
        private string password;
        private MySqlConnection connection;


        public Service1()
        {

            server = "localhost";
            dbName = "mini_projet_bibliotheque";
            username = "root";
            password = "aymen1234";

            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            dbName + ";" + "UID=" + username + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

       

        public List<Servicewcf.Ouvrage> Consulter_List_Ouvrage()
        {


            List<Servicewcf.Ouvrage> ouvrages = new List<Servicewcf.Ouvrage>();
            string query = "SELECT * FROM ouvrage";
            MySqlCommand command = new MySqlCommand(query, connection);

            connection.Open();

            MySqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                int code_barre = int.Parse(dataReader["code_barre"].ToString());
                string titre = dataReader["titre"].ToString();
                string auteur = dataReader["auteur"].ToString();
                string fiche_descriptive = dataReader["fiche_descriptive"].ToString();
                string theme = dataReader["theme"].ToString();
                string image = dataReader["image"].ToString();
                string type = dataReader["type"].ToString();
                bool statut = dataReader["statut"].ToString().Equals("1");

                Servicewcf.Ouvrage ouvrage = new Servicewcf.Ouvrage(code_barre, titre, auteur, fiche_descriptive, theme, image, type, statut);

                ouvrages.Add(ouvrage);

            }

            connection.Close();

            

            return ouvrages;

        }

        public bool Reserver_Ouvrage(int CodeEmprunteur , int CodeOuvrage)
        {


            string verifier = "SELECT * FROM reservation WHERE code_ouvrage = " + CodeOuvrage + " AND numero_emprunteur = " + CodeEmprunteur + " AND statut = 'EnAttente'";

            connection.Open();

            MySqlCommand command = new MySqlCommand(verifier, connection);

            MySqlDataReader redaer = command.ExecuteReader();

            if (redaer.Read())
            {
                connection.Close();
                return false;
            }

            else
            {

                connection.Close();


                string query = "INSERT INTO reservation" +
             "(id_Reservation, code_ouvrage, numero_emprunteur, date_reservastion,statut)" +
             "VALUES (NULL, " + CodeOuvrage + ", " + CodeEmprunteur + ", '" + DateTime.Now.ToString("yyyy-MM-dd") + "', 'EnAttente');";

                MySqlCommand command1 = new MySqlCommand(query, connection);

                connection.Open();



                int result = command1.ExecuteNonQuery();

                return result > 0;

            }







        }
    }
}
