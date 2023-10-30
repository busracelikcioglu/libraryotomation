using kutuphaneotomasyonu.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphaneotomasyonu
{
    public partial class Form1 : Form
    {
        List<Kisi> kisilerim = new List<Kisi>();
        List<Kitap> kitaplarim = new List<Kitap>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciAdi, sifre = "";
            kullaniciAdi = textBox1.Text;
            sifre = textBox2.Text;
            bool kontrol = false;

            foreach(Kisi kisi in kisilerim)
            {
                if (kullaniciAdi.ToLower() == kisi.getKullaniciAdi() && sifre.ToLower() == kisi.getSifre() && kisi.getYetki() == "admin")
                {
                   //admin sayfasına yönlendirir 
                    AdminSayfasi adminSayfasi = new AdminSayfasi(kisilerim);
                    adminSayfasi.Show();
                    this.Hide();
                    kontrol = true;
                    break;
                 

                }
                
                else if (kullaniciAdi.ToLower() == kisi.getKullaniciAdi() && sifre.ToLower() == kisi.getSifre() && kisi.getYetki() == "uye")
                {
                    UyeSayfasi uyeSayfasi = new UyeSayfasi(kitaplarim);
                    uyeSayfasi.Show();
                    this.Hide();
                    kontrol = true;
                    break; 
                    
                }
                            
            }
            if(!kontrol)
            {
                MessageBox.Show("Hatalı Giriş", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kisilerim.Add(new Kisi(1, "Büşra", "Çelikçioğlu", DateTime.Now, "busra", "1", "admin"));
           

            kisilerim.Add(new Kisi(2, "Nur", "Çelik", DateTime.Now, "nur", "2", "uye"));

            kitaplarim.Add(new Kitap(1, "İçimizdeki Şeytan", "Sabahattin Ali", "Türkçe", "Yapı Kredi Yayınları", "Roman", 100, 250, 2016));

            kitaplarim.Add(new Kitap(2, "Tutunamayanlar", "Oğuz Atay", "Türkçe", "İletişim Yayınları", "Roman", 350, 760, 2015));

            kitaplarim.Add(new Kitap(3, "Uçurtma Avcısı", "Khaled Hosseini", "İngilizce", "Everest Yayınları", "Roman", 100, 350, 2010));

            kitaplarim.Add(new Kitap(4, "Küçük Prens", "Antoine de Saint-Exupery","İngilizce ","Can Çocuk Yayınları","Roman", 50, 60, 2018));

            kitaplarim.Add(new Kitap(5, "Kürk Mantolu Madonna", "Sabahattin Ali", "Türkçe", "Yapı Kredi Yayınları", "Roman", 650, 220, 2015));
            kitaplarim.Add(new Kitap(6, "Tehlikeli Oyunlar", "Oğuz Atay", "Türkçe", "İletişim Yayınları", "Roman", 420, 500, 2018));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
