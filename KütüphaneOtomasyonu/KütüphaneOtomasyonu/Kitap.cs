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
    public partial class Kitap : Form
    {
        public Kitap()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();  //Forma yönlendirme işlemi
            Kayıt form = new Kayıt();
            form.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Liste form = new Liste();
            form.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            KitapGüncelleme form = new KitapGüncelleme();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnaSayfa form = new AnaSayfa();
            form.Show();
        }
    }
}
