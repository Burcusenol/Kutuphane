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
    public partial class Okuyacaklarımı_Güncelle : Form
    {
        static string conString = ("Data Source=KAKTUS;Initial Catalog=Kütüphane;Integrated Security=True");
        SqlConnection baglanti = new SqlConnection(conString); //Veritabanına bağlantı 
        public Okuyacaklarımı_Güncelle()
        {
            InitializeComponent();
        }

        private void BtnArama_Click(object sender, EventArgs e)
        {
            baglanti.Open(); //Textboxa girilen kitap ismine göre arama yapma
            string kayit = "SELECT * from Okunacaklar where KitapAdı=@KitapAdı";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            komut.Parameters.AddWithValue("@KitapAdı", TxtArama.Text);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read()) //Eğer kitap bulunuyorsa bilgilerini getirme işlemi
            {
                label1.Text = dr["KitapAdı"].ToString();
                TxtYaz.Text = dr["Yazar"].ToString();
                dateTimePicker3.Text = dr["TahminiBaşlamaGünü"].ToString();
            }
            else //Kitap yoksa bu kod bloğu çalışır.
                MessageBox.Show("Kitap bulunamadı.");
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open(); //Kitap bilgilerini güncelleme işlemi
            SqlCommand kayıt = new SqlCommand("update Okunacaklar set KitapAdı=@KitapAdı,Yazar=@Yazar,TahminiBaşlamaGünü=@TahminiBaşlamaGünü where KitapAdı=@KitapAdı", baglanti);
            kayıt.Parameters.AddWithValue("@KitapAdı", TxtArama.Text);
            kayıt.Parameters.AddWithValue("@Yazar", label1.Text);
            kayıt.Parameters.AddWithValue("@TahminiBaşlamaGünü", dateTimePicker3.Value);
            kayıt.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme işlemi tamamlandı.");
            foreach (Control item in this.Controls) //Textboxları temizleme işlemi
            {
                if (item is TextBox)
                {
                    TextBox tbox = (TextBox)item;
                    tbox.Clear();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            KitapGüncelleme form = new KitapGüncelleme();
            form.Show();
        }
    }
}
