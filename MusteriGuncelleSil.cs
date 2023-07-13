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
    public partial class MusteriGuncelleSil : Form
    {
        public MusteriGuncelleSil()
        {
            InitializeComponent();
            GetList();

        }



        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-VCCSGRP;Initial Catalog=Müşteri;Integrated Security=True");
        SqlCommandBuilder CommandBuilder = new SqlCommandBuilder();
        SqlDataAdapter PubAdapter;
        DataTable PubTable = new DataTable();
        SqlCommandBuilder CommandBuilder2 = new SqlCommandBuilder();

        SqlDataAdapter Pub2Adapter;
        DataTable Pub2Table = new DataTable();

        DataTable GetList()
        {

            PubTable.Clear();
            PubAdapter = new SqlDataAdapter("SELECT * From Musteri_table", baglanti);
            PubAdapter.Fill(PubTable);
            dataGridView1.DataSource = PubTable;
            return PubTable;

        }




        DataView filtrele()
        {
            DataView dv = new DataView();
            dv = PubTable.DefaultView;
            dv.RowFilter = "Convert(TC, 'System.String') like '" + textBox1.Text + "%'";

            dataGridView1.DataSource = dv;
            return dv;

        }




        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            filtrele();


        }

        private void button1_Click(object sender, EventArgs e)
        {

            //CommandBuilder = new SqlCommandBuilder(PubAdapter);
            //PubAdapter.Update(PubTable);
            //
            //MessageBox.Show("Değişiklikler başarıyla kaydedildi");

            //textBoxAdAtanacak.Text = dataGridView1.CurrentRow.Cells["Ad"].Value.ToString();
            //textBoxSoyAdAtanacak.Text = dataGridView1.CurrentRow.Cells["Soyad"].Value.ToString();
            //textBoxGSM_Atanacak.Text = dataGridView1.CurrentRow.Cells["GSMno"].Value.ToString();
            //textBoxEmailAtanacak.Text = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();

            baglanti.Open();
            SqlCommand komut = new SqlCommand("update Musteri_table set email=@email,ad=@ad,soyad=@soyad,gsmno=@gsmno where tc=@tc", baglanti);
            komut.Parameters.AddWithValue("@email", textBoxEmailAtanacak.Text);
            komut.Parameters.AddWithValue("@ad", textBoxAdAtanacak.Text);
            komut.Parameters.AddWithValue("@soyad", textBoxSoyAdAtanacak.Text);
            komut.Parameters.AddWithValue("@gsmno", long.Parse(textBoxGSM_Atanacak.Text));
            komut.Parameters.AddWithValue("@tc", long.Parse(label5.Text));
            komut.ExecuteNonQuery();
            MessageBox.Show("Değişiklikler başarıyla kaydedildi.!");
            baglanti.Close();
            GetList();




        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            textBoxAdAtanacak.Text = dataGridView1.CurrentRow.Cells["Ad"].Value.ToString();
            textBoxSoyAdAtanacak.Text = dataGridView1.CurrentRow.Cells["Soyad"].Value.ToString();
            textBoxGSM_Atanacak.Text = dataGridView1.CurrentRow.Cells["GSMno"].Value.ToString();
            textBoxEmailAtanacak.Text = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();
            label5.Text = dataGridView1.CurrentRow.Cells["tc"].Value.ToString();


        }

        private void MusteriGuncelleSil_Load(object sender, EventArgs e)
        {

        }

    }
}
