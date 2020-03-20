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
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide(); //Form yönlendirme
            Kitap form = new Kitap();
            form.Show();
        }

        private void PcKullanıcı_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kullanıcı form = new Kullanıcı();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PcEmanet_Click(object sender, EventArgs e)
        {
           
        }

        private void pcEmanet_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Emanet_Kitap form = new Emanet_Kitap();
            form.Show();
        }

        private void pcEmanet_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            Emanet_Kitap form =new Emanet_Kitap();
            form.Show();
        }
    }
}
