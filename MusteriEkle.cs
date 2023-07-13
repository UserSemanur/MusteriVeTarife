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
    public partial class MusteriEkle : Form
    {
        public MusteriEkle()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-VCCSGRP;Initial Catalog=Müşteri;Integrated Security=True");



        private void buttonYeniMusteriKayit_Click(object sender, EventArgs e)

        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO Musteri_table (Ad, soyad, TC, GSMno, Email) VALUES( @Ad, @soyad, @TC, @GSMno, @Email)", baglanti);
            komut.Parameters.AddWithValue("@Ad", textBox1.Text);
            komut.Parameters.AddWithValue("@soyad", textBox2.Text);
            komut.Parameters.AddWithValue("@TC", long.Parse(textBox3.Text));
            komut.Parameters.AddWithValue("@GSMno", long.Parse(textBox4.Text));



            if (!textBox5.Text.EndsWith(".com"))
            {
                MessageBox.Show("*Geçersiz mail adresi.\nLütfen geçerli bir mail adresi girin.");
            }

            else
            {
                komut.Parameters.AddWithValue("@Email", textBox5.Text);
            }

            komut.ExecuteNonQuery();

            baglanti.Close();

            baglanti.Open();    



            SqlCommand command= new SqlCommand("INSERT INTO Musteri_Tarife_table (TC,TarifeID, Baslangic, Bitis) VALUES( @TC, @TarifeID, @Baslangic, @Bitis)", baglanti);
            DateTime currentDateTime = DateTime.Now;

            command.Parameters.AddWithValue("@TC", long.Parse(textBox3.Text));
            command.Parameters.AddWithValue("@TarifeID", long.Parse(comboBox1.Text));
            command.Parameters.AddWithValue("@Baslangic", DateTime.Now);
            command.Parameters.AddWithValue("@Bitis", DateTime.Now.AddYears(1));

            command.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri başarıyla kaydedildi.!");
        }

        private void MusteriEkle_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from Tarife_table", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            textBox6.Text = DateTime.Now.ToString();
            DateTime currentDateTime = DateTime.Now;
            DateTime newDateTime = currentDateTime.AddYears(1);
            textBox7.Text = newDateTime.ToString();

            List<clsTarife> lstTarifeler = new List<clsTarife>();

            while (read.Read())
            {
                //comboBox1.Items.Add(read[.ToString());
                //comboBox1.Items.Add()

                lstTarifeler.Add(new clsTarife() { TarifeID = Convert.ToInt32(read[0]), TarifeAd = read[1].ToString() });
            }

            comboBox1.DisplayMember = "TarifeAd";
            comboBox1.ValueMember = "TarifeID";
            comboBox1.DataSource = lstTarifeler;

            baglanti.Close();
        }

       

        private void btnSec_Click_1(object sender, EventArgs e)
        {

            var secilen = (clsTarife)comboBox1.SelectedItem;

            baglanti.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Tarife_table WHERE TarifeID like '" + secilen.TarifeID.ToString() + "'", baglanti);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                textBox8.Text = read["TarifeAdi"].ToString();
                textBox9.Text = read["TarifeUcreti"].ToString();
                textBox10.Text = read["TarifeInternet"].ToString();
                textBox11.Text = read["TarifeSms"].ToString();
                textBox12.Text = read["TarifeDk"].ToString();


            }


          
            baglanti.Close();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
