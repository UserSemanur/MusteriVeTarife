using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusteriVeTarife
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

      

        
       

        private void buttonMusteriKAyıt_Click_1(object sender, EventArgs e)
        {
            MusteriEkle m1 = new MusteriEkle();
            m1.ShowDialog();
        }

        private void buttonMusteriIslemleri_Click(object sender, EventArgs e)
        {
            f m2 = new f();
            m2.ShowDialog();
        }

        private void buttonTarifeISlemleri_Click(object sender, EventArgs e)
        {
            Tarife tarife = new Tarife();   
            tarife.ShowDialog();

        }

        private void buttonFaturalandırma_Click(object sender, EventArgs e)
        {
            Faturalandırma faturalandırma = new Faturalandırma();
            faturalandırma.ShowDialog();
        }

        private void buttonFaturaOde_Click(object sender, EventArgs e)
        {
            FaturaOde faturaOde = new FaturaOde();
            faturaOde.ShowDialog();
        }

        private void buttonTahsilat_Click(object sender, EventArgs e)
        {
            Tahsilat tahsilat = new Tahsilat(); 
            tahsilat.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MusteriGuncelleSil musteriGuncelle =   new MusteriGuncelleSil();
            musteriGuncelle.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EskiMusteriYeniTarife eskiMusteriYeniTarife = new EskiMusteriYeniTarife();
            eskiMusteriYeniTarife.ShowDialog();
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {
        }
    }
}
