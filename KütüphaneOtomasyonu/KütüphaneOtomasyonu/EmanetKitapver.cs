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
    public partial class EmanetKitapver : Form
    {
        static string conString = ("Data Source=KAKTUS;Initial Catalog=Kütüphane;Integrated Security=True");
        SqlConnection baglanti = new SqlConnection(conString); //Sql veritabanına bağlantı sağlama
        public EmanetKitapver()
        {
            InitializeComponent();
        }

        private void EmanetKitapver_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Emanet_Kitap form = new Emanet_Kitap();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls) //Textboxtaki verileri temizleme
            {
                if (item is TextBox)
                {
                    TextBox tbox = (TextBox)item;
                    tbox.Clear();
                }
            }
            dateTimePicker1.Value = DateTime.Now; //DateTimePickerdaki değeri bugünün tarihine eşitler.
            dateTimePicker2.Value = DateTime.Now;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open(); //Veritabanına kayıt ekleme 
            SqlCommand kayıt = new SqlCommand("insert into EmanetVer(Kullanıcı,Kullanıcıİsim,KullanıcıSoyad,KitapAd,KitapYazar,KitapSayfa,EmanetTeslim,GeriAlmaTarihi) values(@Kullanıcı,@Kullanıcıİsim,@KullanıcıSoyad,@KitapAd,@KitapYazar,@KitapSayfa,@EmanetTeslim,@GeriAlmaTarihi)", baglanti);
            kayıt.Parameters.AddWithValue("@Kullanıcı", txtkitapverkullancı.Text);
            kayıt.Parameters.AddWithValue("@Kullanıcıİsim", Txtkitapadver.Text);
            kayıt.Parameters.AddWithValue("@KullanıcıSoyad", txtkitapsoyadver.Text);
            kayıt.Parameters.AddWithValue("@KitapAd", Txtemanetokukitap.Text);
            kayıt.Parameters.AddWithValue("@KitapYazar", Txtemanetyazar.Text);
            kayıt.Parameters.AddWithValue("@KitapSayfa", Txtemanetsayfa.Text);
            kayıt.Parameters.AddWithValue("@EmanetTeslim", dateTimePicker1.Value);
            kayıt.Parameters.AddWithValue("@GeriAlmaTarihi", dateTimePicker2.Value);
            kayıt.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Emanet Verdiklerim listenize Eklendi.");
        }
    }
}
