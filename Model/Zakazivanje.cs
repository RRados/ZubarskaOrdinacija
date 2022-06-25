using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZubarskaOrdinacija.Model
{
    class Zakazivanje : IzvrsenPregled
    {
        private Osoba id_osoba;

        private int id_Zakazivanje;
        private DateTime datum_vreme_dolaska;
        private string razlog_dolaska;



        public int IdZakazivanje
        {
            get { return id_Zakazivanje; }
            set { id_Zakazivanje = value; }
        }



        public string RazlogDolaska
        {
            get { return razlog_dolaska; }
            set { razlog_dolaska = value; }
        }




        public DateTime DatumVremeDolaska
        {
            get { return datum_vreme_dolaska; }
            set { datum_vreme_dolaska = new DateTime(); }
        }




        public Zakazivanje(int id_Zakazivanje, Osoba id_osoba, DateTime datum_vreme_dolaska, string razlog_dolaska)
        {
            id_osoba = new Osoba();
            this.id_Zakazivanje = id_Zakazivanje;
            this.datum_vreme_dolaska = datum_vreme_dolaska;
            this.razlog_dolaska = razlog_dolaska;
        }



        public Zakazivanje()
        {
            id_osoba = new Osoba();
            this.id_Zakazivanje = 0;
            this.id_osoba = null;
            this.datum_vreme_dolaska = new DateTime();
            this.razlog_dolaska = "";
        }
    }
}
