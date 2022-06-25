using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZubarskaOrdinacija.Model
{
    class IzvrsenPregled : Osoba
    {
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


        public IzvrsenPregled()
        {
            datum = new DateTime();
            id_izvrsen_pregled = ID_Izvseni_Pregledi;
            cena_pregleda = Cena_Pregleda;
            dijagnoza = Dijagnoza;
            anamneza = Anamneza;
        }


        public IzvrsenPregled(int id_izvrsen_pregled, DateTime datum, string anamneza, string dijagnoza, double cena_pregleda)
        {
            id_izvrsen_pregled = 0;
            datum = new DateTime();
            anamneza = "";
            dijagnoza = "";
            cena_pregleda = 0;
        }
    }
}
