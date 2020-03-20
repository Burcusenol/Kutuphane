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
    public partial class Liste : Form
    {
        static string conString = ("Data Source=KAKTUS;Initial Catalog=Kütüphane;Integrated Security=True");
        SqlConnection baglanti = new SqlConnection(conString); //veritabanına bağlantı sağlama
        public Liste()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void butonlisteleme_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem == "Okuduklarım")  //Comboboxta seçili olan veriye göre işlem yapma
            {
                baglanti.Open();
                string listele = "SELECT * from Okunanlar ";
                SqlCommand komut = new SqlCommand(listele, baglanti);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                baglanti.Close();
            }
            else if (comboBox1.SelectedItem=="Okuyacaklarım") //Eğer comboboxtaki veri okuyacalarıma eşitse Okunacaklar listesini getir.
            {
                baglanti.Open();
                string listele1 = "SELECT * from Okunacaklar ";
                SqlCommand komut = new SqlCommand(listele1, baglanti);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                baglanti.Close();
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kitap form = new Kitap();
            form.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LBlliste_Click(object sender, EventArgs e)
        {

        }
    }
}
