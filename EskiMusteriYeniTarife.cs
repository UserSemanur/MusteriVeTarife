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
    public partial class EskiMusteriYeniTarife : Form
    {
        public EskiMusteriYeniTarife()
        {
            InitializeComponent();
            GetList();
            GetList2();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-VCCSGRP;Initial Catalog=Müşteri;Integrated Security=True");
        SqlCommandBuilder CommandBuilder = new SqlCommandBuilder();
        SqlDataAdapter PubAdapter;
        SqlDataAdapter PubAdapter2;
        DataTable PubTable = new DataTable();
        DataTable PubTable2 = new DataTable();
        SqlCommandBuilder CommandBuilder2 = new SqlCommandBuilder();


        DataTable GetList()
        {

            PubTable.Clear();
            PubAdapter = new SqlDataAdapter("SELECT * From Musteri_Tarife_table", baglanti);
            PubAdapter.Fill(PubTable);
            dataGridView1.DataSource = PubTable;
            return PubTable;

        }
        DataTable GetList2()
        {

            PubTable2.Clear();
            PubAdapter2 = new SqlDataAdapter("SELECT * From TARİFE_table", baglanti);
            PubAdapter2.Fill(PubTable2);
            dataGridView2.DataSource = PubTable2;
            return PubTable2;

        }





        DataView filtrele()
        {
            DataView dv = new DataView();
            dv = PubTable.DefaultView;
            dv.RowFilter = "Convert(TC, 'System.String') like '" + textBoxTC.Text + "%'";

            dataGridView1.DataSource = dv;
            return dv;

        }


        private void textBoxTC_TextChanged(object sender, EventArgs e)
        {
            filtrele();


        }

        private void buttonYeniTarifeyiAta_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update Musteri_Tarife_table set TarifeID=@TarifeID,Baslangic=@Baslangic ,Bitis=@Bitis where tc=@tc", baglanti);
            komut.Parameters.AddWithValue("@TarifeID", long.Parse(TarifeIDAtanacaktextBox.Text));
            komut.Parameters.AddWithValue("@Baslangic", DateTime.Now);
            komut.Parameters.AddWithValue("@tc", label5.Text);
            komut.Parameters.AddWithValue("@Bitis", DateTime.Now.AddYears(1));
            komut.ExecuteNonQuery();
            MessageBox.Show("Değişiklikler başarıyla kaydedildi.!");
            baglanti.Close();
            GetList();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            TarifeIDAtanacaktextBox.Text = dataGridView1.CurrentRow.Cells["TarifeID"].Value.ToString();
            label5.Text = dataGridView1.CurrentRow.Cells["tc"].Value.ToString();
        }

        private void TarifeIDAtanacaktextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EskiMusteriYeniTarife_Load(object sender, EventArgs e)
        {

        }
    }


  }






