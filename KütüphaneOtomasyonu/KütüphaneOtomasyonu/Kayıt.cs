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
using System.Data.SqlClient;




namespace KütüphaneOtomasyonu
{
    public partial class Kayıt : Form
    {
        static string conString = ("Data Source=KAKTUS;Initial Catalog=Kütüphane;Integrated Security=True");
        SqlConnection baglanti = new SqlConnection(conString); //Veritabanına bağlantı sağlama
        public Kayıt()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kitap form = new Kitap();
            form.Show();
        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            TxtKitap.Clear(); //Textbox ve DateTimePickera girilen verileri temizleme
            Txtyazar.Clear();
            TxtSayfa.Clear();
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
        }

        private void butonvazgec_Click(object sender, EventArgs e)
        {
            TxtOku.Clear();  //Textbox ve DateTimePickera girilen verileri temizleme
            TxtYaz.Clear();
            dateTimePicker3.Value = DateTime.Now;
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();  //Veritabanına verileri kaydetme
            SqlCommand kayıt = new SqlCommand("insert into Okunanlar(KitapAdı,Yazar,SayfaSayısı,BaşlamaTarihi,BitişTarihi) values(@KitapAdı,@Yazar,@SayfaSayısı,@BaşlamaTarihi,@BitişTarihi)", baglanti);
            kayıt.Parameters.AddWithValue("@KitapAdı", TxtKitap.Text);
            kayıt.Parameters.AddWithValue("@Yazar", Txtyazar.Text);
            kayıt.Parameters.AddWithValue("@SayfaSayısı", TxtSayfa.Text);
            kayıt.Parameters.AddWithValue("@BaşlamaTarihi", dateTimePicker1.Value);
            kayıt.Parameters.AddWithValue("@BitişTarihi", dateTimePicker2.Value);
            kayıt.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap okuduklarım listenize Eklendi.");
        }

        private void ButonKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open(); //Veritabanına kayıt işlemi
            SqlCommand kayıt = new SqlCommand("insert into Okunacaklar(KitapAdı,Yazar,TahminiBaşlamaGünü) values(@KitapAdı,@Yazar,@TahminiBaşlamaGünü)", baglanti);
            kayıt.Parameters.AddWithValue("@KitapAdı", TxtOku.Text);
            kayıt.Parameters.AddWithValue("@Yazar", TxtYaz.Text);
            kayıt.Parameters.AddWithValue("@TahminiBaşlamaGünü", dateTimePicker3.Value);
            kayıt.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap okunacaklar listenize Eklendi.");
        }
    }
}
