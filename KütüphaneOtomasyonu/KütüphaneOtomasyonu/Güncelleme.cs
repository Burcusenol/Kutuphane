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
    public partial class Güncelleme : Form
    {
        static string conString = ("Data Source=KAKTUS;Initial Catalog=Kütüphane;Integrated Security=True");
        SqlConnection baglanti = new SqlConnection(conString);
        public Güncelleme()
        {
            InitializeComponent();
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
          
            baglanti.Open();
            SqlCommand kayıt = new SqlCommand("update Giriş set Kullanıcı=@Kullanıcı,Şifre=@Şifre,Ad=@Ad,Soyad=@Soyad,DoğumTarihi=@DoğumTarihi,Mail=@Mail,Cinsiyet=@Cinsiyet where Ad=@Ad", baglanti);
            kayıt.Parameters.AddWithValue("@Kullanıcı", Txtkullanıcıad.Text);
            kayıt.Parameters.AddWithValue("@Ad", label2.Text);
            kayıt.Parameters.AddWithValue("@Soyad", TxtSoyad.Text);
            kayıt.Parameters.AddWithValue("@Şifre", TxtSıfreniz.Text);
            kayıt.Parameters.AddWithValue("@DoğumTarihi", dateTimePicker1.Value);
            kayıt.Parameters.AddWithValue("@Mail", Txtmail.Text);
            string cinsiyet = "";
            if (RdKadın.Checked==true)
            {
                cinsiyet = RdKadın.Text;
            }   
            else if (RdErkek.Checked==true)
            {
                cinsiyet = RdErkek.Text;
            }
            kayıt.Parameters.AddWithValue("@cinsiyet", cinsiyet);
            kayıt.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme işlemi tamamlandı.");
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox tbox = (TextBox)item;
                    tbox.Clear();
                }
            }
            RdErkek.Checked = false;
            RdKadın.Checked = false;
            

        }

        private void BtnGeridön_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kullanıcı form = new Kullanıcı();
            form.Show();
        }

        private void BtnArama_Click(object sender, EventArgs e)
        {
            //Textboxa girilen veriye göre Giriş tablosunda arama yapma işlemi
            baglanti.Open();
            string kayit = "SELECT * from Giriş where Ad=@Ad"; 
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            komut.Parameters.AddWithValue("@Ad", TxtArama.Text);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())  //Tablo okunduğunda veri bulunduysa textboxlara atama işlemi yapılıyor.
            {
                label2.Text = dr["Ad"].ToString();
                Txtkullanıcıad.Text = dr["Kullanıcı"].ToString();
                TxtSoyad.Text = dr["Soyad"].ToString();
                TxtSıfreniz.Text = dr["Şifre"].ToString();
                dateTimePicker1.Text = dr["DoğumTarihi"].ToString();
                Txtmail.Text = dr["Mail"].ToString();
                if (RdKadın.Checked) //Eğer RdKadın RadioButonu seçiliyse cinsiyeti ona göre ata.
                {
                    RdKadın.Text = dr["Cinsiyet"].ToString();
                }
                else if (RdErkek.Checked) //Eğer RdErkek RadioButonu seçiliyse cinsiyeti ona göre ata.
                {
                    RdErkek.Text = dr["Cinsiyet"].ToString();
                }
               
            }
            else
                MessageBox.Show("Kullanıcı bulunamadı.");
            baglanti.Close();
        }

        private void TxtArama_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lblgüncelad_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kullanıcı form = new Kullanıcı();
            form.Show();
        }
    }
    
}
