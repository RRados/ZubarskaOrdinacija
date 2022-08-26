using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZubarskaOrdinacija.Model
{
    public class PodaciBaza
    {

        private Osoba osoba;
        private Zakazivanje zakazivanje;
        private SqlDataAdapter adapter;
        private DataSet dataSet;


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


        public void UnosPodatka(string upit)
        {
            SqlConnection connection = new SqlConnection(CnnString.cnn);

            try
            {
                using (SqlCommand command = new SqlCommand(upit, connection))
                {
                    connection.Open();

                    command.CommandType = CommandType.Text;

                    command.ExecuteNonQuery();

                    MessageBox.Show("Podaci uspesno uneti!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }




        public void Obrisi(string upitObrisi)
        {
            if (MessageBox.Show("Ovim ce te zbrisati podatak!\nDa li to zelite ?", "Upozorenje", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                SqlConnection connection = new SqlConnection(CnnString.cnn);
                try
                {
                    using (SqlCommand command = new SqlCommand(upitObrisi, connection))
                    {
                        connection.Open();

                        command.ExecuteNonQuery();

                        MessageBox.Show("Uspesno obrisano!", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Greska!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
            else
            {
                return;
            }
        }


    }
}

