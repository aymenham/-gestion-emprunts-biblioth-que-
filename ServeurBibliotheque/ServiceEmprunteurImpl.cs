using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IRemoteBibliotheque;
using MySql.Data.MySqlClient;
using System.Collections;

namespace ServeurBibliotheque
{
    public class ServiceEmprunteurImpl : MarshalByRefObject, IRemoteBibliotheque.IServiceEmprunteur
    {
        private DataBaseManger manager;
        private MySqlConnection connection;

        public ServiceEmprunteurImpl()
        {
             manager = new DataBaseManger();

            connection = manager.Connection();
        }

        public bool Inscription_List_Attente(int numeroEmprunteur, int codeOuvrage)
        {
            string VerifierQuery = "SELECT * FROM liste_attente WHERE code_ouvrage = " + codeOuvrage + " AND numero_emprunteur = " + numeroEmprunteur + "";
                                   
                     

            MySqlCommand command = new MySqlCommand(VerifierQuery, connection);

            manager.OpenConnection();

            MySqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                
                reader.Close();
                manager.CloseConnection();
                return false;
            }

            else
            {
                reader.Close();
                string query = "INSERT INTO liste_attente " +
                                "(code_ouvrage , numero_emprunteur )" +
                                "VALUES (" + codeOuvrage + " , " + numeroEmprunteur + ")";

                MySqlCommand command1 = new MySqlCommand(query, connection);

                try
                {
                    int result = command1.ExecuteNonQuery();
                    manager.CloseConnection();
                    return result > 0;
                }
                catch(Exception e)
                {
                    manager.CloseConnection();
                    return false;

                }
              
                
            }

           

            
        }

        public Emprunteur Login(string username, string password)
        {
           string query = "SELECT *" +
                           " FROM emprunteur"+
                           " WHERE nom_utilisateur = '"+username+ "' AND mot_de_passe = '"+password+ "' AND statut = 0";

            manager.OpenConnection();

            MySqlCommand command = new MySqlCommand(query, connection);

            MySqlDataReader redader = command.ExecuteReader();

            if (redader.Read())
            {
                int numero_carte = int.Parse((redader["numero_carte"].ToString()));

                string nom_utilisateur = redader["nom_utilisateur"].ToString();

                Emprunteur emprunteur = new Emprunteur();

                emprunteur.Numero_carte = numero_carte;
                emprunteur.Nom_utilisateur = nom_utilisateur;
                redader.Close();
                manager.CloseConnection();

                return emprunteur;
               
            }

            manager.CloseConnection();

            return null;
            
             

        }

        public bool Modifier_Information(Emprunteur emprunteur)
        {
            string query;

            if (emprunteur.Nom_utilisateur.Length==0 && emprunteur.Mot_de_passe.Length > 0)
            {

                query = "UPDATE emprunteur" +
                          " SET mot_de_passe = '" + emprunteur.Mot_de_passe + "' " +
                          "WHERE numero_carte = " + emprunteur.Numero_carte + "";

            }

            else if(emprunteur.Nom_utilisateur.Length>0 && emprunteur.Mot_de_passe.Length == 0)
            {
                query = "UPDATE emprunteur" +
                          " SET nom_utilisateur = '" + emprunteur.Nom_utilisateur + "' " +
                          "WHERE numero_carte = " + emprunteur.Numero_carte + "";

            }

            else
            {

                query = "UPDATE emprunteur" +
                        " SET nom_utilisateur = '" + emprunteur.Nom_utilisateur + "' " +
                        " , mot_de_passe = '" + emprunteur.Mot_de_passe + "' " +
                        "WHERE numero_carte = " + emprunteur.Numero_carte + "";

            }

          

            manager.OpenConnection();

            MySqlCommand command = new MySqlCommand(query, connection);
            int result;

            try
            {
                 result = command.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                manager.CloseConnection();
                return false;
            }
           
         
            manager.CloseConnection();

            return result>0;

        }

        public List<Ouvrage> Rechercher_Ouvrage(string mot)
        {

            List<Ouvrage> ouvrages = new List<Ouvrage>();

            string query = "SELECT * FROM ouvrage WHERE titre LIKE '%"+mot+"%' OR auteur LIKE '%"+mot+"%' OR fiche_descriptive LIKE '%"+mot+"%' OR theme LIKE '%"+mot+"%'";
                            

            MySqlCommand command = new MySqlCommand(query, connection);

            manager.OpenConnection();


            MySqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                int code_barre =int.Parse( dataReader["code_barre"].ToString());
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
            dataReader.Close();
            manager.CloseConnection();


            return ouvrages;
        }
    }
}
