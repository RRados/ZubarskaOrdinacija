using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZubarskaOrdinacija.Model
{
    class Pacijent
    {
        private int id_pacijent;
        private string ime;
        private string prezime;
        private string email;
        private int telefon;
        private Grad grad;


        public int ID_Pacijent
        {
            get { return id_pacijent; }
            set { id_pacijent = value; }
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




        public Pacijent(int id_pacijenti, string ime, string prezime, string email, int telefon, Grad grad)
        {
            this.id_pacijent = id_pacijenti;
            this.ime = ime;
            this.prezime = prezime;
            this.email = email;
            this.telefon = telefon;
            this.grad = grad;
        }

        public Pacijent()
        {
            this.id_pacijent = 0;
            this.ime = "";
            this.prezime = "";
            this.email = "";
            this.telefon = 0;
            this.grad = null;
        }
    }
}
