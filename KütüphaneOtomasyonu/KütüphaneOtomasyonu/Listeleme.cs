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
    public partial class Listeleme : Form
    {
        static string conString = ("Data Source=KAKTUS;Initial Catalog=Kütüphane;Integrated Security=True");
        SqlConnection baglanti = new SqlConnection(conString); //Veritabanına bağlantı sağlama
        public Listeleme()
        {
            InitializeComponent();
        }

        private void Listeleme_Load(object sender, EventArgs e)
        {
            
           

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btngöster_Click(object sender, EventArgs e)
        {
            baglanti.Open();  //Textboxa girilen isme göre kayıtlı kullanıcıyı getirme işlemi
            string listele1 = "SELECT Ad,Soyad,DoğumTarihi,Kullanıcı from Giriş where Ad=@Ad ";
            SqlCommand komut1 = new SqlCommand(listele1, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut1);
            komut1.Parameters.AddWithValue("@Ad", txtgörüntüle.Text);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
            
          


        }

        private void Btntumunugoster_Click(object sender, EventArgs e)
        {
            baglanti.Open();  //Tümünügöster butonuna tıklandığında tüm kullanıcıları getir.
            string listele1 = "SELECT Ad,Soyad,DoğumTarihi,Kullanıcı,Mail,Cinsiyet from Giriş ";
            SqlCommand komut1 = new SqlCommand(listele1, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void Btngeridon_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kullanıcı form = new Kullanıcı();
            form.Show();
        }
    }
}
