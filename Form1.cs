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

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            podaciBaza = new PodaciBaza();

            dataGridView.DataSource = podaciBaza.UzmiPodatke("Select * from Lekari");
        }




        // pretraga po imenu, ograniciti unos, korisniku obavestenje...
        private void btn_Pretraga_Click(object sender, EventArgs e)
        {
            podaciBaza = new PodaciBaza();

            dataGridView.DataSource = podaciBaza.UzmiPodatke($"Select * from Lekari where ime='{txt_Bx_Pretraga.Text}'");
        }
    }
}