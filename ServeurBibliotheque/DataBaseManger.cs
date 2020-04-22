using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ServeurBibliotheque
{
    public class DataBaseManger
    {

        private string server;
        private string dbName;
        private string username;
        private string password;
        private MySqlConnection connection;

        public DataBaseManger()
        {
           
        }

        public MySqlConnection Connection()
        {
            server = "localhost";
            dbName = "mini_projet_bibliotheque";
            username = "root";
            password = "aymen1234";

            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            dbName + ";" + "UID=" + username + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);

            return connection;
        }

        public Boolean OpenConnection()
        {

            try
            {

                connection.Open();
                return true;

            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {

                    case 0:
                        Console.Write("probleme serveur ");
                        break;

                    case 1045:
                        Console.Write("login invalide");
                        break;
                }

                return false;

            }
        }

        public  Boolean CloseConnection()
        {
            try
            {

                connection.Close();
                return true;

            }
            catch (MySqlException ex)
            {

                Console.WriteLine("erreur lors de la fermeture de la connexion " + ex.Message);
                return false;
            }
        }


    }
}
