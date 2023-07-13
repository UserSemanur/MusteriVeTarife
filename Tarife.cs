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
    public partial class Tarife : Form
    {
        public Tarife()
        {
            InitializeComponent();
            GetList();
        }

        SqlCommandBuilder CommandBuilder = new SqlCommandBuilder();
        SqlDataAdapter PubAdapter;
        DataTable PubTable = new DataTable();


        
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-VCCSGRP;Initial Catalog=Müşteri;Integrated Security=True");
        private void Tarife_Load(object sender, EventArgs e)
        {

            //SqlDataAdapter adtr2 = new SqlDataAdapter("select  *from Tarife_table", baglanti);
            //adtr2.Fill(PubTable);
            //dataGridView1.DataSource = PubTable;

        }

       
        DataTable GetList()
        {

            PubTable.Clear();
            PubAdapter = new SqlDataAdapter("SELECT * From Tarife_table", baglanti);
            PubAdapter.Fill(PubTable);
            dataGridView1.DataSource = PubTable;
            return PubTable;
             
        }

        private void buttonTarifeKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO Tarife_table (TarifeAdi, TarifeUcreti, TarifeInternet, TarifeSms, TarifeDk, TarifeSuresi) VALUES (@TarifeAdi, @TarifeUcreti, @TarifeInternet, @TarifeSms, @TarifeDk, @TarifeSuresi)", baglanti);
           
            komut.Parameters.AddWithValue("@TarifeAdi", textBoxTarAdı.Text);
            komut.Parameters.AddWithValue("@TarifeUcreti", float.Parse(textBoxTarUcret.Text));
            komut.Parameters.AddWithValue("@TarifeInternet", Convert.ToInt32(textBoxTarInt.Text));
            komut.Parameters.AddWithValue("@TarifeSms", Convert.ToInt32(textBoxSMS.Text));
            komut.Parameters.AddWithValue("@TarifeDk", Convert.ToInt32(textBoxDK.Text));
            komut.Parameters.AddWithValue("@TarifeSuresi", Convert.ToInt32(textBoxSure.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();


            MessageBox.Show("Başarıyla Kaydedildi");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            CommandBuilder = new SqlCommandBuilder(PubAdapter);
            PubAdapter.Update(PubTable);
            GetList();

            MessageBox.Show("Değişiklikler başarıyla kaydedildi");
        }
        
    }
}
