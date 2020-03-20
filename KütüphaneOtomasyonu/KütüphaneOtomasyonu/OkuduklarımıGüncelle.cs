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
    public partial class OkuduklarımıGüncelle : Form
    {
        static string conString = ("Data Source=KAKTUS;Initial Catalog=Kütüphane;Integrated Security=True");
        SqlConnection baglanti = new SqlConnection(conString); //Veritabanına bağlantı sağlama
        public OkuduklarımıGüncelle()
        {
            InitializeComponent();
        }

        private void BtnArama_Click(object sender, EventArgs e)
        {
            baglanti.Open();  //Textboxa girilen kitap adına göre bilgileri getirir.
            string kayit = "SELECT * from Okunanlar where KitapAdı=@KitapAdı";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            komut.Parameters.AddWithValue("@KitapAdı", TxtArama.Text);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read()) //Eğer kitap ismi bulunuyorsa textboxlara ve DateTimePickera değerlerini atama işlemi
            {
                Lblkitap.Text = dr["KitapAdı"].ToString();
                Txtyazar.Text = dr["Yazar"].ToString();
                TxtSayfa.Text = dr["SayfaSayısı"].ToString();
                dateTimePicker1.Text = dr["BaşlamaTarihi"].ToString();
                dateTimePicker2.Text = dr["BitişTarihi"].ToString();
               
            }
            else //Kitap bulunamadıysa
                MessageBox.Show("Kitap bulunamadı.");
            baglanti.Close();
        }

        private void BtnOkuGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open(); //Kitap güncelleme işlemi
            SqlCommand kayıt = new SqlCommand("update Okunanlar set KitapAdı=@KitapAdı,Yazar=@Yazar,SayfaSayısı=@SayfaSayısı,BaşlamaTarihi=@BaşlamaTarihi,BitişTarihi=@BitişTarihi where KitapAdı=@KitapAdı", baglanti);
            kayıt.Parameters.AddWithValue("@KitapAdı", TxtArama.Text);
            kayıt.Parameters.AddWithValue("@Yazar", Lblkitap.Text);
            kayıt.Parameters.AddWithValue("@SayfaSayısı", TxtSayfa.Text);
            kayıt.Parameters.AddWithValue("@BaşlamaTarihi", dateTimePicker1.Value);
            kayıt.Parameters.AddWithValue("@BitişTarihi", dateTimePicker2.Value);
            kayıt.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme işlemi tamamlandı.");
            foreach (Control item in this.Controls) //TExtboxlara girilen veriyi temizler.
            {
                if (item is TextBox)
                {
                    TextBox tbox = (TextBox)item;
                    tbox.Clear();
                }
            }
         
        }

        private void btnvazgecoku_Click(object sender, EventArgs e)
        {

        }

        private void Btngerioku_Click(object sender, EventArgs e)
        {
            this.Hide();
            KitapGüncelleme form = new KitapGüncelleme();
            form.Show();
        }
    }
}
