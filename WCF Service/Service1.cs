using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MySql.Data.MySqlClient;

namespace WCF_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
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



        public List<Ouvrage> Consulter_List_Ouvrage()
        {


            List<Ouvrage> ouvrages = new List<Ouvrage>();
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

                Ouvrage ouvrage = new Ouvrage(code_barre, titre, auteur, fiche_descriptive, theme, image, type, statut);

                ouvrages.Add(ouvrage);

            }

            connection.Close();



            return ouvrages;

        }

        public bool Reserver_Ouvrage(Ouvrage ouvrage)
        {
            throw new NotImplementedException();
        }

    }
}
