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
    public partial class EmanetListe : Form
    {
        static string conString = ("Data Source=KAKTUS;Initial Catalog=Kütüphane;Integrated Security=True");
        SqlConnection baglanti = new SqlConnection(conString); //Sql veritabanına bağlantı
        public EmanetListe()
        {
            InitializeComponent();
        }

        private void button1Geri_Click(object sender, EventArgs e)
        {
            this.Hide();
            Emanet_Kitap form =new Emanet_Kitap();
            form.Show();
        }

        private void butonlistelemeEmanet_Click(object sender, EventArgs e)
        {
            if (comboBox1Emanet.SelectedItem == "Emanet Aldıklarım") //Comboboxtaki seçili olan değere göre işlem yapma
            {
                baglanti.Open();
                string listele = "SELECT * from EmanetKitapAl "; //EmanetKitapAl tablosunu listeleme
                SqlCommand komut = new SqlCommand(listele, baglanti);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1Emanet.DataSource = dt;
                baglanti.Close();
            }
            else if (comboBox1Emanet.SelectedItem == "Emanet Verdiklerim") //Comboboxtaki seçili olan değere göre işlem yapma
            {
                baglanti.Open();
                string listele1 = "SELECT * from EmanetVer "; //EmanetVer tablosunu listeleme
                SqlCommand komut = new SqlCommand(listele1, baglanti);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1Emanet.DataSource = dt;
                baglanti.Close();
            }
            
        }
    }
}
