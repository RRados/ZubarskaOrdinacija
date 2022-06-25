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

                    command.Parameters.AddWithValue("@ime", osoba.Ime);
                    command.Parameters.AddWithValue("@prezime", osoba.Prezime);
                    command.Parameters.AddWithValue("@email", osoba.Email);
                    command.Parameters.AddWithValue("@telefon", Convert.ToString(osoba.Telefon));
                    command.Parameters.AddWithValue("@idGrad", Convert.ToInt32(osoba.Grad));

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


        public void Obrisi(string upitObrisi, string staBrisem)
        {
            if (MessageBox.Show("Da li zelis da obrises " + staBrisem + " ? ", "Upozorenje", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                SqlConnection connection = new SqlConnection(CnnString.cnn);
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(upitObrisi, connection))
                    {
                        command.ExecuteScalar();

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

