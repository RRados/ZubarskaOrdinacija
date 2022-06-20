using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZubarskaOrdinacija.Model
{
    class IzvrsenPregled
    {
        private Usluge id_usluge;
        private Lekar id_lekar;
        private Pacijent id_pacijent;

        private int id_izvrsen_pregled;
        private DateTime datum;
        private string anamneza;
        private string dijagnoza;
        private double cena_pregleda;



        public double Cena_Pregleda
        {
            get { return cena_pregleda; }
            set { cena_pregleda = value; }
        }
        public string Dijagnoza
        {
            get { return dijagnoza; }
            set { dijagnoza = value; }
        }
        public string Anamneza
        {
            get { return anamneza; }
            set { anamneza = value; }
        }
        public DateTime Datum
        {
            get { return datum; }
            set { datum = value; }
        }
        public int ID_Izvseni_Pregledi
        {
            get { return id_izvrsen_pregled; }
            set { id_izvrsen_pregled = value; }
        }
        public Lekar ID_Lekari
        {
            get { return id_lekar; }
            set { id_lekar = value; }
        }
        public Pacijent ID_Pacijenti
        {
            get { return id_pacijent; }
            set { id_pacijent = value; }
        }
        public Usluge ID_Usluge
        {
            get { return id_usluge; }
            set { id_usluge = value; }
        }


        public IzvrsenPregled(Usluge id_usluge, Lekar id_lekari, Pacijent id_pacijent, int id_izvrsen_pregled, DateTime datum, string anamneza, string dijagnoza, double cena_pregleda)
        {
            this.id_usluge = id_usluge;
            this.id_lekar = id_lekari;
            this.id_pacijent = id_pacijent;
            this.id_izvrsen_pregled = id_izvrsen_pregled;
            this.datum = datum;
            this.anamneza = anamneza;
            this.dijagnoza = dijagnoza;
            this.cena_pregleda = cena_pregleda;
        }


        public IzvrsenPregled()
        {
            this.id_usluge = null;
            this.id_lekar = null;
            this.id_pacijent = null;
            this.id_izvrsen_pregled = 0;
            this.datum = new DateTime();
            this.anamneza = "";
            this.dijagnoza = "";
            this.cena_pregleda = 0;
        }
    }
}
