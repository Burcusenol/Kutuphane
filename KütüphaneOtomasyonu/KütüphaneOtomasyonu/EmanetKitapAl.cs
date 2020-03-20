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
    public partial class EmanetKitapAl : Form
    {
        static string conString = ("Data Source=KAKTUS;Initial Catalog=Kütüphane;Integrated Security=True");
        SqlConnection baglanti = new SqlConnection(conString); //Sql veritabanına bağlantı sağlama
        public EmanetKitapAl()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Emanet_Kitap form = new Emanet_Kitap();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open(); //Veritabanına bilgileri kaydetme
            SqlCommand kayıt = new SqlCommand("insert into EmanetKitapAl(KullanıcıAd,Kullanıcıİsim,KullanıcıSoyad,KitapAd,KitapYazar,KitapSayfa,TeslimAlmaTarihi,İadeTarihi) values(@KullanıcıAd,@Kullanıcıİsim,@KullanıcıSoyad,@KitapAd,@KitapYazar,@KitapSayfa,@TeslimAlmaTarihi,@İadeTarihi)", baglanti);
            kayıt.Parameters.AddWithValue("@KullanıcıAd", txtkitapalkullancı.Text);
            kayıt.Parameters.AddWithValue("@Kullanıcıİsim", Txtkitapad.Text);
            kayıt.Parameters.AddWithValue("@KullanıcıSoyad", txtkitapsoyad.Text);
            kayıt.Parameters.AddWithValue("@KitapAd", Txtokukitap.Text);
            kayıt.Parameters.AddWithValue("@KitapYazar", Txtteslimyazar.Text);
            kayıt.Parameters.AddWithValue("@KitapSayfa", Txtteslimsayfa.Text);
            kayıt.Parameters.AddWithValue("@TeslimAlmaTarihi", dateTimePicker1.Value);
            kayıt.Parameters.AddWithValue("@İadeTarihi", dateTimePicker2.Value);
            kayıt.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Emanet Kitaplarım listenize Eklendi.");
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls) //Textboxtaki verieri temizleme işlemi
            {
                if (item is TextBox)
                {
                    TextBox tbox = (TextBox)item;
                    tbox.Clear();
                }
            }
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
        }
    }
}
