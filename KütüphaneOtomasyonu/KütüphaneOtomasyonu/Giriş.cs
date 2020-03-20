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
    public partial class Giriş : Form
    {
        static string conString = ("Data Source=KAKTUS;Initial Catalog=Kütüphane;Integrated Security=True");
        SqlConnection baglanti = new SqlConnection(conString); //Veritabanı bağlatısı kurma
        public Giriş()
        {
            InitializeComponent();
            LblHata.Hide();
        }

        private void BtnGırıs_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sorgula = new SqlCommand("Select *from Giriş where Kullanıcı=@Kullanıcı and Şifre=@Şifre", baglanti);
            SqlParameter sqlParameter1 = sorgula.Parameters.Add("@Kullanıcı", TxtKullanıcı.Text);
            SqlParameter sqlParameter = sorgula.Parameters.Add("@Şifre", TxtSıfre.Text); //Kullanıcıdan biilgilerini alma
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sorgula);
            da.Fill(dt);
            if (dt.Rows.Count == 1)
            {

                this.Hide();
                AnaSayfa form = new AnaSayfa();
                form.Show();
            }
            else
            {
                LblHata.Show();
            }
            baglanti.Close();
        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnUye_Click(object sender, EventArgs e)
        {
            ÜyeOlma form = new ÜyeOlma();
            form.Show();
        }

        private void LblHata_Click(object sender, EventArgs e)
        {

        }
    }
}
