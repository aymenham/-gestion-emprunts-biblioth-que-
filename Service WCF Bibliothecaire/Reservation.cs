using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Servicewcf
{   
    [DataContract]
    public class Reservation
    {
        private int id_Reservation;
        private int code_ouvrage;
        private int numero_emprunteur;
        private DateTime date_reservation;
        private DateTime date_recuperation;
        private string statut;

        public Reservation(int id_Reservation, int code_ouvrage, int numero_emprunteur, DateTime date_reservation, DateTime date_recuperation, string statut)
        {
            this.id_Reservation = id_Reservation;
            this.code_ouvrage = code_ouvrage;
            this.numero_emprunteur = numero_emprunteur;
            this.date_reservation = date_reservation;
            this.date_recuperation = date_recuperation;
            this.statut = statut;
        }

        [DataMember]
        public int Id_Reservation
        {
            get { return id_Reservation; }
            set { id_Reservation = value; }
        }
        [DataMember]
        public int Code_ouvrage
        {
            get { return code_ouvrage; }
            set { code_ouvrage = value; }
        }
        [DataMember]
        public int Numero_emprunteur
        {
            get { return numero_emprunteur; }
            set { numero_emprunteur = value; }
        }
        [DataMember]
        public DateTime Date_reservation
        {
            get { return date_reservation; }
            set { date_reservation = value; }
        }
        [DataMember]
        public DateTime Date_recuperation
        {
            get { return date_recuperation; }
            set { date_recuperation = value; }
        }
        [DataMember]
        public String Statut
        {
            get { return statut; }
            set { statut = value; }
        }
    }
}
