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
        private PodaciBaza podaciBaza;
        private DodavanjeNovog frm_novi;


        public OsnovnaForma()
        {
            InitializeComponent();
            podaciBaza = new PodaciBaza();
            UcitajPacijente();
        }


        // prikaz pacijenata sa DANASNJIM DATUMOM
        public void UcitajPacijente()
        {
            dataGridView1.DataSource = podaciBaza.UcitajPodatke("select pac.Ime, pac.Prezime, lek.Ime + ' ' + lek.Prezime AS 'Lekar' , zak.ZastoPacijentDolazi AS 'Razlog dolaska', zak.DatumIVremeDolaska AS 'DATUM' from Pacijenti pac inner join Zakazivanje zak  on pac.IDPacijent = zak.FK_Pacijent inner join Lekari lek on zak.FK_Lekar = lek.IDLekar where CAST(DatumIVremeDolaska AS date) = CAST(GETDATE() AS date)");
        }




        private void Btn_Forma_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }



        // pozivanje forme 'Dodavanje novog sa arg(Form1 'this')' i izmena teksta forme i izmena ikone za lekara
        private void noviPacijentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_novi = new DodavanjeNovog(this);

            frm_novi.Text = "Novi pacijent";
            frm_novi.Icon = new Icon("../../Ikone/person.ico");

            frm_novi.Show();
        }




        // context menu item 'osvezi' ucitava glavnu formu iznova
        private void OsveziToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PodaciBaza podaciBaza = new PodaciBaza();

            // postaviti uslov koga osvezavam



            podaciBaza.UcitajPodatke("");
        }






        // context menu item 'obrisi', desnim klikom na 'obrisi' brise izabranu vrednost iz dataGridView-a i ponovo se ucitavaju podaci iz baze
        private void ObrisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PodaciBaza podaciBaza = new PodaciBaza();

            string upitObrisi = "DELETE FROM Pacijenti WHERE IDPacijent=" + dataGridView1.CurrentRow.Cells[0].RowIndex;

            podaciBaza.Obrisi(upitObrisi, "Pacijenti");
        }



        // pretraga i za lekare i za pacijente... procedura 
        private void Btn_pretraga_Click(object sender, EventArgs e)
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



        // dva event-a spojena u jednom: objektom 'sender' se hvata vrednost klik-a, prikaz svih PACIJENTA I LEKARA su registrovani na ovu metodu
        private void osobe_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = podaciBaza.UcitajPodatke($"select ime, prezime, Email, telefon, grad.NazivGrada from {sender.ToString()} l inner join Gradovi grad ON grad.IDGrad = l.FK_Grad");
        }
    }
}
