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
    public partial class Form1 : Form
    {
        PodaciBaza podaciBaza;
        DodavanjeNovog frm_novi;

        public Form1()
        {
            InitializeComponent();
            frm_novi = new DodavanjeNovog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            podaciBaza = new PodaciBaza();

            dataGridView.DataSource = podaciBaza.UcitajPodatke("Select * from Lekari");
        }

        // pretraga po imenu, ograniciti unos, korisniku obavestenje...
        private void Btn_Pretraga_Click(object sender, EventArgs e)
        {
            podaciBaza = new PodaciBaza();

            if (!(txt_Bx_Pretraga.Text == string.Empty))
            {
                dataGridView.DataSource = podaciBaza.UcitajPodatke($"Select * from Lekari where ime='{txt_Bx_Pretraga.Text}'");
            }
            else
            {
                MessageBox.Show("Upisi ime za pretragu", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void lekarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_novi = new DodavanjeNovog();

            if (lekarToolStripMenuItem.Text == "Lekar")
            {
                frm_novi.Text = "Novi lekar";
                frm_novi.Icon = new Icon("../../Ikone/doctor.ico");
                frm_novi.Show();
            }
        }


        private void pacijentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_novi = new DodavanjeNovog();

            if (pacijentToolStripMenuItem.Text == "Pacijent")
            {
                frm_novi.Text = "Novi pacijent";
                frm_novi.Icon = new Icon("../../Ikone/person.ico");
                frm_novi.Show();
            }
        }

        private void OsveziToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = podaciBaza.UcitajPodatke("Select * from Lekari");
        }

        private void ObrisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PodaciBaza podaciBaza = new PodaciBaza();

            string upitObrisi = "DELETE FROM Lekari WHERE IDLekar=" + dataGridView.CurrentRow.Cells[0].Value;

            podaciBaza.ObrisiLekara(upitObrisi);
        }
    }
}