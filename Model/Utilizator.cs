﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema1_PS.Model
{
    public enum UserType
    {
        PARTICIPANT,
        ORGANIZATOR,
        ADMINISTRATOR
    }

    internal class Utilizator
    {
        private int id;
        private String nume;
        private String email;
        private String parola;
        private UserType userType;
        private String telefon;


        public Utilizator(int id, string nume, string email, string parola, UserType userType, string telefon)
        {
            this.id = id;
            this.nume = nume;
            this.email = email;
            this.parola = parola;
            this.userType = userType;
            this.telefon = telefon;
        }

        public Utilizator(Utilizator utilizator)
        {
            this.id = utilizator.id;
            this.nume = utilizator.nume;
            this.email = utilizator.email;
            this.parola = utilizator.parola;
            this.userType = utilizator.userType;
            this.telefon = utilizator.telefon;
        }

        public Utilizator()
        {
            this.id = 0;
            this.nume = "";
            this.email = "";
            this.parola = "";
            this.userType = UserType.PARTICIPANT;
            this.telefon = "";
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public String Nume
        {
            get { return nume; }
            set { nume = value; }
        }
        public String Email
        {
            get { return email; }
            set { email = value; }
        }
        public String Parola
        {
            get { return parola; }
            set { parola = value; }
        }
        public UserType UserType
        {
            get { return userType; }
            set { userType = value; }
        }
        public String Telefon
        {
            get { return telefon; }
            set { telefon = value; }
        }

    }
}
