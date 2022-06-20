using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZubarskaOrdinacija.Model
{
    class Zakazivanje
    {
        private int id_Zakazivanje;
        private Pacijent id_pacijent;
        private Lekar id_lekari;
        private DateTime datum_vreme_dolaska;
        private string razlog_dolaska;



        public string RazlogDolaska
        {
            get { return razlog_dolaska; }
            set { razlog_dolaska = value; }
        }
        public DateTime DatumVremeDolaska
        {
            get { return datum_vreme_dolaska; }
            set { datum_vreme_dolaska = value; }
        }
        public Lekar IdLekari
        {
            get { return id_lekari; }
            set { id_lekari = value; }
        }
        public Pacijent IdPacijent
        {
            get { return id_pacijent; }
            set { id_pacijent = value; }
        }
        public int IdZakazivanje
        {
            get { return id_Zakazivanje; }
            set { id_Zakazivanje = value; }
        }



        public Zakazivanje(int id_Zakazivanje, Pacijent id_pacijent, Lekar id_lekari, DateTime datum_vreme_dolaska, string razlog_dolaska)
        {
            this.id_Zakazivanje = id_Zakazivanje;
            this.id_pacijent = id_pacijent;
            this.id_lekari = id_lekari;
            this.datum_vreme_dolaska = datum_vreme_dolaska;
            this.razlog_dolaska = razlog_dolaska;
        }


        public Zakazivanje()
        {
            this.id_Zakazivanje = 0;
            this.id_pacijent = null;
            this.id_lekari = null;
            this.datum_vreme_dolaska = new DateTime();
            this.razlog_dolaska = "";
        }
    }
}
