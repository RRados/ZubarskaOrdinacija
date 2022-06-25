using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZubarskaOrdinacija.Model;

namespace ZubarskaOrdinacija
{
    public partial class OsnovnaForma : Form
    {
        PodaciBaza podaci;
        public OsnovnaForma()
        {
            InitializeComponent();
            podaci = new PodaciBaza();
        }

        private void OsnovnaForma_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = podaci.UcitajPodatke("select pac.IDPacijent, pac.Ime, pac.Prezime, lek.Ime,lek.Prezime, zak.ZastoPacijentDolazi, zak.DatumIVremeDolaska from Pacijenti pac inner join Zakazivanje zak on pac.IDPacijent = zak.FK_Pacijent inner join Lekari lek on zak.FK_Lekar = lek.IDLekar where CAST(DatumIVremeDolaska AS date) = CAST(GETDATE() AS date)");
        }


        private void Btn_pretraga2_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(CnnString.cnn);

            try
            {
                using (SqlCommand command = new SqlCommand("PretragaZakazivanjaPoImenu", connection))
                {
                    connection.Open();

                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@imePacijenta", txtBx_pretraga.Text);
                    DataTable dataTable = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
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
    }
}
