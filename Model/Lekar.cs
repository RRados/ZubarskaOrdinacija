using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZubarskaOrdinacija.Model
{
    class Lekar
    {
        private int id_lekar;
        private string ime;
        private string prezime;
        private string email;
        private int telefon;
        private Grad grad;




        public int ID_Lekar
        {
            get { return id_lekar; }
            set { id_lekar = value; }
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
        public int Telefon
        {
            get { return telefon; }
            set { telefon = value; }
        }
        public Grad Grad
        {
            get { return grad; }
            set { grad = value; }
        }




        public Lekar(int id_lekar, string ime, string prezime, string email, int telefon, Grad grad)
        {
            this.id_lekar = id_lekar;
            this.ime = ime;
            this.prezime = prezime;
            this.email = email;
            this.telefon = telefon;
            this.grad = grad;
        }

        public Lekar()
        {
            this.id_lekar = 0;
            this.ime = "";
            this.prezime = "";
            this.email = "";
            this.telefon = 0;
            this.grad = null;
        }

    }
}
