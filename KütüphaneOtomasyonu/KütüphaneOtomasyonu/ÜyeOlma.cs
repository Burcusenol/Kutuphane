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
    public partial class ÜyeOlma : Form
    {
        static string conString = ("Data Source=KAKTUS;Initial Catalog=Kütüphane;Integrated Security=True");
        SqlConnection baglanti = new SqlConnection(conString); //Veritabanına bağlantı
        public ÜyeOlma()
        {
            InitializeComponent();
        }

        private void Btniptal_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnKayıt_Click(object sender, EventArgs e)
        {
            baglanti.Open();  //Veritabanına kullanıcı ekleme işlemi
            SqlCommand kayıt = new SqlCommand("insert into Giriş(Kullanıcı,Şifre,Ad,Soyad,DoğumTarihi,Mail,Cinsiyet) values(@Kullanıcı,@Şifre,@Ad,@Soyad,@DoğumTarihi,@Mail,@Cinsiyet)", baglanti);
            kayıt.Parameters.AddWithValue("@Kullanıcı", Txtkullanıcıad.Text);
            kayıt.Parameters.AddWithValue("@Ad", Txtad.Text);
            kayıt.Parameters.AddWithValue("@Soyad", TxtSoyad.Text);
            kayıt.Parameters.AddWithValue("@Şifre", TxtSıfreniz.Text);
            kayıt.Parameters.AddWithValue("@DoğumTarihi", dateTimePicker1.Value);
            kayıt.Parameters.AddWithValue("@Mail", Txtmail.Text);
            string cinsiyet = "";
            if(RdKadın.Checked) //Eğer RdKadın seçiliyse cinsiyeti ona göre ata
            {
                cinsiyet = RdKadın.Text;
            }
            else if (RdErkek.Checked) //Eğer RdErkek seçiliyse cinsiyeti ona göre ata
            {
                cinsiyet = RdErkek.Text;
            }
            kayıt.Parameters.AddWithValue("@cinsiyet", cinsiyet);
            kayıt.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Üye olma işlemi tamamlandı.");
            foreach (Control item in this.Controls) //Textboxları temizleme işlemi
            {
                if (item is TextBox)
                {
                    TextBox tbox = (TextBox)item;
                    tbox.Clear();
                }
            }
        }
        private void Txtmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void RdKadın_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
