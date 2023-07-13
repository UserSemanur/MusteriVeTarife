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
using System.Net.Mail;

namespace MusteriVeTarife
{
    public partial class FaturaOde : Form
    {
        public FaturaOde()
        {
            InitializeComponent();
        }
        DataTable tblo = new DataTable();
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-VCCSGRP;Initial Catalog=Müşteri;Integrated Security=True");

        DataView filtrele()
        {
            DataView dv = new DataView();
            dv = tblo.DefaultView;
            dv.RowFilter = "Convert(TC, 'System.String') like '" + textBoxTC.Text + "%'";

            dataGridViewFaturaOde.DataSource = dv;
            return dv;

        }
        int count;
        private void güncelle()
        {
            baglanti.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT COUNT(*) AS count FROM Fatura_table WHERE OdendiMi = 0", baglanti);
            int count = Convert.ToInt32(cmd1.ExecuteScalar());
            labelCount.Text = count.ToString();
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM Fatura_table ORDER BY odendimi ASC", baglanti);
            SqlDataAdapter adtr2 = new SqlDataAdapter(cmd2);
            DataTable tblo = new DataTable();
            adtr2.Fill(tblo);
            dataGridViewFaturaOde.DataSource = tblo;
            baglanti.Close();
        }
        private void FaturaOde_Load(object sender, EventArgs e)
        {
            güncelle();
        }


        private void textBoxTC_TextChanged(object sender, EventArgs e)
        {
            filtrele();
        }

        private void dataGridViewFaturaOde_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {



        }
        bool durum;
        private void kontrolet()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from Tahsilat_table", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (labelFaturaAtanacak.Text == read["FaturaID"].ToString())
                {
                    durum = false;
                }
            }
            baglanti.Close();

        }

        private void buttonOde_Click(object sender, EventArgs e)
        {
            kontrolet();
            if (durum == true)
            {
                DateTime currentDateTime = DateTime.Now;

                baglanti.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO [Tahsilat_table] (FaturaID,TarifeID,TarifeUcreti,TahsilTarihi,TC) VALUES (@FaturaID,@TarifeID,@TarifeUcreti,@TahsilTarihi,@TC)", baglanti);

                komut.Parameters.AddWithValue("@TC", long.Parse(labelTCatanacak.Text));
                komut.Parameters.AddWithValue("@FaturaID", Convert.ToInt32(labelFaturaAtanacak.Text));
                komut.Parameters.AddWithValue("@TarifeID", Convert.ToInt32(labelTarifeIDatanacak.Text));
                komut.Parameters.AddWithValue("@TarifeUcreti", float.Parse(labelUcretAtanacak.Text));
                komut.Parameters.AddWithValue("@TahsilTarihi", currentDateTime);

                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Fatura Ödemesi Yapıldı.");
                labelTCatanacak.Visible = false;
                labelFaturaAtanacak.Visible = false;
                labelUcretAtanacak.Visible = false;
                labelTarifeIDatanacak.Visible = false;
                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("UPDATE Fatura_table SET OdendiMi='1' WHERE FaturaID=" + Convert.ToInt32(labelFaturaAtanacak.Text), baglanti);
                komut2.ExecuteNonQuery();

                baglanti.Close();

                MailMessage email = new MailMessage();
                email.From = new MailAddress("semanurtopal@yandex.com");
                email.To.Add(Mail.Text);
                email.Subject = ("Fatura Bilgilendirme!");
                email.Body = (currentDateTime.ToString() + " tarihinde 2" + Donem.Text.ToString() + " döneminin fatura ödemesi alındı. Ödemeniz için teşekkür ederiz.\n                                                                                               MOONCELL");
                SmtpClient smtp = new SmtpClient();
                smtp.Credentials = new System.Net.NetworkCredential("semanurtopal@yandex.com", "ngnuesyxcgjrffrk");
                smtp.Port = 587;
                smtp.Host = "smtp.yandex.com";
                smtp.EnableSsl = true;
                smtp.Send(email);
                MessageBox.Show("gönderildi");

                güncelle();
            }
            else
            {
                MessageBox.Show("Fatura daha önce ödendi.!");
            }


        }

        private void dataGridViewFaturaOde_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            labelTCatanacak.Visible = true;
            labelFaturaAtanacak.Visible = true;
            labelUcretAtanacak.Visible = true;
            labelTarifeIDatanacak.Visible = true;
            baglanti.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM Musteri_table WHERE TC like '" + labelTCatanacak.Text + "'", baglanti);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                Mail.Text = read["Email"].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand command2 = new SqlCommand("SELECT * FROM Fatura_table WHERE TC like '" + labelTCatanacak.Text + "'", baglanti);
            SqlDataReader read2 = command2.ExecuteReader();
            while (read2.Read())
            {
                Donem.Text = read2["donemadi"].ToString();


            }




            labelTCatanacak.Text = dataGridViewFaturaOde.CurrentRow.Cells["TC"].Value.ToString();
            labelFaturaAtanacak.Text = dataGridViewFaturaOde.CurrentRow.Cells["FaturaID"].Value.ToString();
            labelUcretAtanacak.Text = dataGridViewFaturaOde.CurrentRow.Cells["DonemUcreti"].Value.ToString();
            labelTarifeIDatanacak.Text = dataGridViewFaturaOde.CurrentRow.Cells["TarifeID"].Value.ToString();
            baglanti.Close();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
