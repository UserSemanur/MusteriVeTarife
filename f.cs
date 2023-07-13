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
    public partial class f : Form
    {



        public f()
        {
            InitializeComponent();
        }


        DataTable tblo = new DataTable();
        DataTable tablo = new DataTable();
        DataView filtrele()
        {
            DataView dv = new DataView();
            dv = tblo.DefaultView;
            dv.RowFilter = "Convert(TC, 'System.String') like '" + comboBox1.Text + "%'";

            dataGridView3.DataSource = dv;
            return dv;

        }
        DataView filtrele2()
        {
            DataView dv = new DataView();
            dv = tablo.DefaultView;
            dv.RowFilter = "Convert(TC, 'System.String') like '" + comboBox1.Text + "%'";

            dataGridView4.DataSource = dv;
            return dv;

        }



        private void buttonMusteriArama_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-VCCSGRP;Initial Catalog=Müşteri;Integrated Security=True");
        private void f_Load(object sender, EventArgs e)
        {
            
            
            SqlCommand cmd = new SqlCommand("select TC * from Musteri_table", baglanti);


            SqlCommand cmd2 = new SqlCommand("select TC * from Fatura_table", baglanti);
            SqlDataAdapter adtr2 = new SqlDataAdapter("select  *from Fatura_table", baglanti);
            adtr2.Fill(tblo);
            dataGridView3.DataSource = tblo;


            SqlCommand cmd3 = new SqlCommand("select TC * from Musteri_Tarife_table", baglanti);
            SqlDataAdapter adtr3 = new SqlDataAdapter("select  *from Musteri_Tarife_table", baglanti);
            adtr3.Fill(tablo);
            dataGridView4.DataSource = tablo;

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from Musteri_table", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboBox1.Items.Add(read[3].ToString());

            }
            baglanti.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Musteri_table WHERE TC like '" + comboBox1.Text + "'", baglanti);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                textBox11.Text = read["Ad"].ToString();
                textBox10.Text = read["Soyad"].ToString();
                textBox9.Text = read["GSMno"].ToString();
                textBox8.Text = read["MusteriID"].ToString();
                textBox2.Text = read["Email"].ToString();


            }


            baglanti.Close();
            filtrele();
            filtrele2();

        }

    }
}



   

