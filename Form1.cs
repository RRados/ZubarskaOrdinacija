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
        private PodaciBaza podaciBaza;
        private DodavanjeNovog frm_novi;
        string osoba = "";

        public Form1()
        {
            InitializeComponent();
            frm_novi = new DodavanjeNovog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            podaciBaza = new PodaciBaza();

            dataGridView.DataSource = podaciBaza.UcitajPodatke("Select * from Lekari");

            //if (lekarToolStripMenuItem.Selected)
            //frm_novi.UnosPodataka("Lekari");

            //if (pacijentToolStripMenuItem.Selected)
            //frm_novi.UnosPodataka("Pacijenti");
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
                MessageBox.Show("Popuni prazno polje za pretragu", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lekarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_novi = new DodavanjeNovog();

            if (lekarToolStripMenuItem.Text == "Lekar")
            {
                frm_novi.Text = "Lekar";
                Icon icon = new Icon("../../Ikone/doctor.ico");
                frm_novi.Icon = icon;

                frm_novi.Show();

                MessageBox.Show(osoba.ToString()).ToString();
            }

        }

        private void pacijentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_novi = new DodavanjeNovog();
            Icon icon = new Icon("../../Ikone/person.ico");
            frm_novi.Icon = icon;
            frm_novi.Text = "Pacijent";
            frm_novi.Show();
        }
    }
}