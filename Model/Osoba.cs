using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZubarskaOrdinacija.Model
{
    class Osoba
    {
        private int id_osoba;
        private string ime;
        private string prezime;
        private string email;
        private string telefon;
        private int grad;



        public int ID_Osoba
        {
            get { return id_osoba; }
            set { id_osoba = value; }
        }

        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }

        public string Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Telefon
        {
            get { return telefon; }
            set { telefon = value; }
        }

        public int Grad
        {
            get { return grad; }
            set { grad = value; }
        }



        public Osoba(int id_osoba, string ime, string prezime, string email, string telefon, int grad)
        {
            this.id_osoba = id_osoba;
            this.ime = ime;
            this.prezime = prezime;
            this.email = email;
            this.telefon = telefon;
            this.grad = grad;
        }



        public Osoba()
        {
            id_osoba = 0;
            ime = "";
            prezime = "";
            email = "";
            telefon = "";
            grad = 0;
        }
    }
}
