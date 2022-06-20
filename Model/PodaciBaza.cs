using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZubarskaOrdinacija.Model
{
    class PodaciBaza
    {

        private Lekar lekari;
        private Pacijent pacijenti;
        private Usluge usluge;
        private Zakazivanje zakazivanje;
        private IzvrsenPregled izvrseniPregledi;
        private Grad gradovi;
        private SqlDataAdapter adapter;


        public PodaciBaza(Lekar lekari, Pacijent pacijenti, Usluge usluge, Zakazivanje zakazivanje, IzvrsenPregled izvrseniPregledi, Grad gradovi)
        {
            this.lekari = lekari;
            this.pacijenti = pacijenti;
            this.usluge = usluge;
            this.zakazivanje = zakazivanje;
            this.izvrseniPregledi = izvrseniPregledi;
            this.gradovi = gradovi;
        }

        public PodaciBaza()
        {
            this.lekari = null;
            this.pacijenti = null;
            this.usluge = null;
            this.zakazivanje = null;
            this.izvrseniPregledi = null;
            this.gradovi = null;
        }




        public DataTable UzmiPodatke(string upit)
        {
            DataSet dataSet = new DataSet();

            using (SqlConnection connection = new SqlConnection(CnnString.cnn))
            {
                connection.Open();


                using (adapter = new SqlDataAdapter(upit, connection))
                {
                    adapter.Fill(dataSet);

                    return dataSet.Tables[0];
                }

            }
        }


    }
}
