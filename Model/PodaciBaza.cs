using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZubarskaOrdinacija.Model
{
    public class PodaciBaza
    {

        private Osoba osoba;
        private Zakazivanje zakazivanje;
        private SqlDataAdapter adapter;
        private DataSet dataSet;
        public string tabela;

        public PodaciBaza()
        {
            osoba = new Osoba();
            zakazivanje = new Zakazivanje();
        }



        public DataTable UcitajPodatke(string upit)
        {
            dataSet = new DataSet();

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




        public DataTable UnosPodatka(string upit)
        {
            dataSet = new DataSet();

            using (SqlConnection connection = new SqlConnection(CnnString.cnn))
            {
                connection.Open();

                using (adapter = new SqlDataAdapter(upit, connection))
                {
                    adapter.Update(dataSet, tabela.ToString());

                    return dataSet.Tables[0];
                }
            }
        }

    }
}

