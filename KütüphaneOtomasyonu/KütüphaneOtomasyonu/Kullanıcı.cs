/************************************************************
|              SAKARYA ÜNİVERSİTESİ                         |
|       BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ           |
|            BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ                |
|                  2019-2020 BAHAR DÖNEMİ                   |
|            NESNEYE DAYALI PROGRAMLAMA ÖDEVİ               |
|                                                           |
|                                                           |
|                                                           |
|  Ödev Numarası:1                                          | 
|  Öğrenci Numarası:161200041                               |
|  Öğrenci Adı-Soyadı:Burcu ŞENOL                           |
|  Dersin Alındığı Grup:A                                   |
|                                                           |
************************************************************/



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace KütüphaneOtomasyonu
{
    public partial class Kullanıcı : Form
    {
        public Kullanıcı()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();   //Forma yönlendirme işlemi
            Güncelleme form = new Güncelleme();
            form.Show();
        }

        private void BTnAnaMenü_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnaSayfa form = new AnaSayfa();
            form.Show();
        }

        private void PcListe_Click(object sender, EventArgs e)
        {
            this.Hide();
            Listeleme form = new Listeleme();
            form.Show();
        }
    }
}
