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


        public PodaciBaza()
        {
            this.lekari = new Lekar();
            this.pacijenti = new Pacijent();
            this.usluge = new Usluge();
            this.zakazivanje = new Zakazivanje();
            this.izvrseniPregledi = new IzvrsenPregled();
            this.gradovi = new Grad();
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
