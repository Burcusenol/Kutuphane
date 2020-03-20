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
    public partial class Emanet_Kitap : Form
    {
        public Emanet_Kitap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); //Form yönlendirme işlemleri
            AnaSayfa form = new AnaSayfa();
            form.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmanetKitapAl form = new EmanetKitapAl();
            form.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmanetKitapver form = new EmanetKitapver();
            form.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmanetListe form =new EmanetListe();
            form.Show();
        }
    }
}
