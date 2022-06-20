using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZubarskaOrdinacija.Model
{
    class Usluge
    {
        private int id_usluge;
        private string naziv_usluge;



        public int ID_Usluge
        {
            get { return id_usluge; }
            set { id_usluge = value; }
        }
        public string Naziv_Usluge
        {
            get { return naziv_usluge; }
            set { naziv_usluge = value; }
        }


        public Usluge(int id_usluge, string naziv_usluge)
        {
            this.id_usluge = id_usluge;
            this.naziv_usluge = naziv_usluge;
        }


        public Usluge()
        {
            this.id_usluge = 0;
            this.naziv_usluge = "";
        }
    }
}
