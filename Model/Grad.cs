using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZubarskaOrdinacija.Model
{
    class Grad
    {
        private int id_grad;
        private string naziv_grad;


        public string Naziv_Grad
        {
            get { return naziv_grad; }
            set { naziv_grad = value; }
        }


        public int ID_Grad
        {
            get { return id_grad; }
            set { id_grad = value; }
        }


        public Grad(int id_grad, string naziv_grad)
        {
            this.id_grad = id_grad;
            this.naziv_grad = naziv_grad;
        }

        public Grad()
        {
            this.id_grad = 0;
            this.naziv_grad = "";
        }
    }
}
