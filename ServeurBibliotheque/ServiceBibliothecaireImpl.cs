using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using IRemoteBibliotheque;

namespace ServeurBibliotheque
{
    public class ServiceBibliothecaireImpl : MarshalByRefObject, IRemoteBibliotheque.IServiceBibliothecaire
    {

        private DataBaseManger manager;
        private MySqlConnection connection;

        public ServiceBibliothecaireImpl()
        {
            manager = new DataBaseManger();

            connection = manager.Connection();
        }

        public bool Ajouter_Membre_Etudiant(Etudiant etudiant)
        {
            string query = "INSERT INTO emprunteur" +
                             "(numero_carte ,nom_utilisateur , mot_de_passe , nom , prenom , email , reservastion_non_confirme , statut)" +
             "VALUES (" + etudiant.Emp.Numero_carte + " , '" + etudiant.Emp.Nom_utilisateur + "' , '" + etudiant.Emp.Mot_de_passe + "' , '" + etudiant.Emp.Nom + "' , '" + etudiant.Emp.Prenom + "' , '" + etudiant.Emp.Email + "' , 0 , 0)";
            Boolean firstResult;
            MySqlCommand command = new MySqlCommand(query, connection);
            manager.OpenConnection();

            try
            {
                firstResult = command.ExecuteNonQuery() > 0;
            }
            catch (Exception e)
            {
                manager.CloseConnection();
                firstResult = false;
            }

            if (firstResult)
            {
                string query1 = "INSERT INTO etudiant (	code_etudiant , specialite , niveau )" +
                         "VALUES (" + etudiant.Emp.Numero_carte + " , '" + etudiant.Specialite + "' , '" + etudiant.Niveau + "') ";
                MySqlCommand command2 = new MySqlCommand(query1, connection);
                try
                {

                    bool result = command2.ExecuteNonQuery() > 0;
                    manager.CloseConnection();
                    return result;


                }
                catch (Exception e)
                {
                    manager.CloseConnection();
                    return false;
                }
            }
            else
            {
                return false;
            }





        }

        public bool Ajouter_Membre_Enseignant(Enseignant enseignant)
        {

            string query = "INSERT INTO emprunteur" +
                            "(numero_carte ,nom_utilisateur , mot_de_passe , nom , prenom , email , reservastion_non_confirme , statut)" +
            "VALUES (" + enseignant.Emp.Numero_carte + " , '" + enseignant.Emp.Nom_utilisateur + "' , '" + enseignant.Emp.Mot_de_passe + "' , '" + enseignant.Emp.Nom + "' , '" + enseignant.Emp.Prenom + "' , '" + enseignant.Emp.Email + "' , 0 , 0)";
            Boolean firstResult;
            MySqlCommand command = new MySqlCommand(query, connection);
            manager.OpenConnection();

            try
            {
                firstResult = command.ExecuteNonQuery() > 0;
            }
            catch (Exception e)
            {
                manager.CloseConnection();
                firstResult = false;
            }

            if (firstResult)
            {
                string query1 = "INSERT INTO enseignant (code_engeugnant , grade)" +
                         "VALUES (" + enseignant.Emp.Numero_carte + " , '" + enseignant.Grade + "') ";
                MySqlCommand command2 = new MySqlCommand(query1, connection);
                try
                {

                    bool result = command2.ExecuteNonQuery() > 0;
                    manager.CloseConnection();
                    return result;


                }
                catch (Exception e)
                {
                    manager.CloseConnection();
                    return false;
                }
            }
            else
            {
                return false;
            }
        }


        public bool Ajouter_Ouvrage(Ouvrage ouvrage)
        {
            string query = "INSERT INTO ouvrage" +
                              "(code_barre ,titre	 , 	auteur ,	fiche_descriptive , theme , image , type , statut)" +
              "VALUES (" + ouvrage.Code_barre + " , '" + ouvrage.Titre + "' , '" + ouvrage.Auteur + "' , '" + ouvrage.Fiche_descriptive + "' , '" + ouvrage.Theme + "' , '" + ouvrage.Image + "' , '" + ouvrage.Type + "' , 0)";
            int result;
            MySqlCommand command = new MySqlCommand(query, connection);
            manager.OpenConnection();
            try
            {
                result = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                manager.CloseConnection();
                return false;
            }

            manager.CloseConnection();

            return result > 0;
        }

        public bool Confirmer_Demande_Rerservation(int idReservation)
        {
            string query = "UPDATE reservation r , ouvrage o   SET r.statut = 'EnCours' , o.statut = 1  WHERE r.code_ouvrage = o.code_barre AND id_Reservation = " + idReservation + "";

            MySqlCommand command = new MySqlCommand(query, connection);

            manager.OpenConnection();

            int result = command.ExecuteNonQuery();

            manager.CloseConnection();

          // this.RefuserToutLesAutresReservastion(idReservation);

            return result > 0;

        }

       

        public List<Reservation> consulter_list_reservation()
        {
            List<Reservation> reserations = new List<Reservation>();

            string query = "SELECT * FROM reservation";

            MySqlCommand command = new MySqlCommand(query, connection);

            manager.OpenConnection();

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int id = int.Parse(reader["id_Reservation"].ToString());
                int codeouvrage = int.Parse(reader["code_ouvrage"].ToString());
                int numeroemprunteur = int.Parse(reader["numero_emprunteur"].ToString());
                DateTime dateReservastion = DateTime.Parse(reader["date_reservastion"].ToString());
                string statut = reader["statut"].ToString();

                Reservation resevastion = new Reservation(id, codeouvrage, numeroemprunteur, dateReservastion, statut);

                reserations.Add(resevastion);
            }
            manager.CloseConnection();
            return reserations;
        }

        public bool Login(string username, string password)
        {
            string query = "SELECT *" +
                            " FROM bibliothecaire" +
                            " WHERE nom_utilisateur = '" + username + "' AND mot_de_passe = '" + password + "'";

            manager.OpenConnection();

            MySqlCommand command = new MySqlCommand(query, connection);

            MySqlDataReader redader = command.ExecuteReader();

            if (redader.Read())
            {

                manager.CloseConnection();
                return true;

            }

            manager.CloseConnection();


            return false;


        }

        public bool Supprimer_Membre(int numero)
        {
            String query = "DELETE FROM emprunteur WHERE numero_carte = " + numero + " ";
            int result;
            MySqlCommand command = new MySqlCommand(query, connection);
            manager.OpenConnection();
            result = command.ExecuteNonQuery();
            manager.CloseConnection();
            return result > 0;

        }


        public Boolean Modifier_Ouvrage(Ouvrage ouvrage , int CodeBarre)
        {

            string query = " UPDATE ouvrage " +
                            "SET code_barre = " + ouvrage.Code_barre + " , titre = '" + ouvrage.Titre + "' , auteur = '" + ouvrage.Auteur + "' , fiche_descriptive = '" + ouvrage.Fiche_descriptive + "' , theme = '" + ouvrage.Theme + "' , type = '" + ouvrage.Type + "'" +
                            "WHERE code_barre = " + CodeBarre + "";

            MySqlCommand command = new MySqlCommand(query, connection);
            manager.OpenConnection();

            int result = command.ExecuteNonQuery();

            manager.CloseConnection();

            return result > 0;

        }

        public bool Liberer_Reservation(int idReservation)
        {


            string query = "UPDATE reservation r , ouvrage o   SET r.statut = 'Fini' , o.statut = 0  WHERE r.code_ouvrage = o.code_barre AND id_Reservation = " + idReservation + "";

            MySqlCommand command = new MySqlCommand(query, connection);

            manager.OpenConnection();

            int result = command.ExecuteNonQuery();

            manager.CloseConnection();

            this.RefuserToutLesAutresReservastion(idReservation);

            return result > 0;

        }


        private void RefuserToutLesAutresReservastion(int idReservastion)
        {

            string query = "SELECT code_ouvrage , date_reservastion FROM reservation WHERE id_Reservation = " + idReservastion + "";
            string date_reservastion="";
            string code_ouvrage="";
            connection.Open();

            MySqlCommand command = new MySqlCommand(query, connection);

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                date_reservastion = reader["date_reservastion"].ToString();
                Console.WriteLine(date_reservastion);
                code_ouvrage = reader["code_ouvrage"].ToString();
            }

            connection.Close();

            string queryRefuser = "UPDATE reservation SET statut = 'Refuser' WHERE date_reservastion = '" + date_reservastion + "' AND code_ouvrage = " + code_ouvrage + " AND statut = 'EnAttente'";

            connection.Open();

            MySqlCommand command1 = new MySqlCommand(queryRefuser, connection);

            command1.ExecuteNonQuery();


        }
    }
}
