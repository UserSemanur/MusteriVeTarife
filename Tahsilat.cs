using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MusteriVeTarife
{
    public partial class Tahsilat : Form
    {
        public Tahsilat()
        {
            InitializeComponent();
        }
        DataTable tabloTahsilat = new DataTable();
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-VCCSGRP;Initial Catalog=Müşteri;Integrated Security=True");
        DataView filtrele4()
        {
            DataView dv = new DataView();
            dv = tabloTahsilat.DefaultView;
            dv.RowFilter = "Convert(TC, 'System.String') like '" + textBoxTc.Text + "%'";

            dataGridViewTahsilat.DataSource = dv;
            return dv;

        }
        private void Tahsilat_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adtrTahsilat = new SqlDataAdapter("select  *from Tahsilat_table", baglanti);
            adtrTahsilat.Fill(tabloTahsilat);
            dataGridViewTahsilat.DataSource = tabloTahsilat;


        }

        private void textBoxTc_TextChanged(object sender, EventArgs e)
        {
            filtrele4();
        }
    }
}
