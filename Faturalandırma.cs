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
    public partial class Faturalandırma : Form
    {
        public Faturalandırma()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-VCCSGRP;Initial Catalog=Müşteri;Integrated Security=True");




        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Musteri_table WHERE TC like '" + comboBox1.Text + "'", baglanti);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                textBoxAd.Text = read["Ad"].ToString();
                textBoxSoyad.Text = read["Soyad"].ToString();


            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand command2 = new SqlCommand("SELECT * FROM Fatura_table WHERE TC like '" + comboBox1.Text + "'", baglanti);
            SqlDataReader read2 = command2.ExecuteReader();
            while (read2.Read())
            {
                textBoxTarifeID.Text = read2["TarifeID"].ToString();
                textBoxMusteriTarifeID.Text = read2["MusteriTarifeID"].ToString();
                textBoxDonemUcreti.Text = read2["DonemUcreti"].ToString();


            }
            baglanti.Close();





        }

        private void button1_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand command3 = new SqlCommand("INSERT INTO Fatura_table (TarifeID,TC,MusteriTarifeID, DonemUcreti, DonemAdi,OdendiMi) VALUES(@TarifeID, @TC, @MusteriTarifeID, @DonemUcreti, @DonemAdi, @OdendiMi)", baglanti);

            command3.Parameters.AddWithValue("@TarifeID", long.Parse(textBoxTarifeID.Text));
            command3.Parameters.AddWithValue("@TC", long.Parse(comboBox1.Text));
            command3.Parameters.AddWithValue("@MusteriTarifeID", long.Parse(textBoxMusteriTarifeID.Text));
            command3.Parameters.AddWithValue("@DonemUcreti", float.Parse(textBoxDonemUcreti.Text));
            command3.Parameters.AddWithValue("@DonemAdi", DonemAdi.Text);
            command3.Parameters.AddWithValue("@OdendiMi", 0);

            command3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show(comboBox1.Text + " TC'li " + textBoxAd.Text + " " + textBoxSoyad.Text + " Kişisine ait  Ücreti "+ textBoxDonemUcreti.Text + " olan " + DonemAdi.Text + " ayı faturanız oluşturulmuştur.");

        }

        private void Faturalandırma_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from Musteri_table", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboBox1.Items.Add(read[3].ToString());

            }
            baglanti.Close();

        }
    }
}
