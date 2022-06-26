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
        public Form1()
        {
            InitializeComponent();

        }

        // pretraga po imenu, ograniciti unos, korisniku obavestenje...
        //private void Btn_Pretraga_Click(object sender, EventArgs e)
        //{
        //    podaciBaza = new PodaciBaza();

        //    if (!(txt_Bx_Pretraga.Text == string.Empty))
        //    {
        //        dataGridView.DataSource = podaciBaza.UcitajPodatke($"Select * from Lekari where ime='{txt_Bx_Pretraga.Text}' ");
        //    }
        //    else
        //    {
        //        MessageBox.Show("Upisi ime za pretragu", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //}
    }
}