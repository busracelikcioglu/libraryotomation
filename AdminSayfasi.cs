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
    public partial class AdminSayfasi : Form
    {
        List<Kisi> kisilerim;
        List<Kitap> kitaplarim;
        public AdminSayfasi()
        {
            InitializeComponent();
            this.kisilerim = kisilerim; 
            this.kitaplarim = kitaplarim;
        }

        public AdminSayfasi(List<Kisi> kisilerim, List<Kitap> kitaplarim)
        {
            this.kisilerim = kisilerim;
            this.kitaplarim = kitaplarim;
        }

        public AdminSayfasi(List<Kisi> kisilerim)
        {
            this.kisilerim = kisilerim;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textleriDoldur();
        }

        public void AdminSayfasi_Load(object sender, EventArgs e)
        {
           /* foreach(Kisi kisi in kisilerim)
            {
                dataGridView1.Rows.Add(kisi.getId(), kisi.getIsim(), kisi.getSoyisim(), kisi.getOlusturmaTarih(), kisi.getKullaniciAdi(), kisi.getSifre(), kisi.getYetki());
            }
            foreach (Kitap kitap in kitaplarim)
            {
                dataGridView1.Rows.Add(kitap.getKitapId(), kitap.getKitapIsim(), kitap.getkitapYazar(), kitap.getKitapDili(), kitap.getTur(), kitap.getAdet(),kitap.getSayfaSayisi(),kitap.getBasimYili()) ;
            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(Convert.ToInt32(textBox1.Text), textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
        }
        private void textleriDoldur()
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string isim = textBox2.Text;
            string soyisim = textBox3.Text;
            string tarih = textBox4.Text;
            string kullaniciAdi = textBox5.Text;
            string sifre = textBox6.Text;
            string yetki = textBox7.Text;

            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            dataGridView1.Rows.Add(id,isim,soyisim,tarih,kullaniciAdi,sifre,yetki);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for(int i=0; i<groupBox1.Controls.Count;i++)
            { if(groupBox1.Controls[i]is TextBox || groupBox1.Controls[i] is MaskedTextBox)
                {
                    groupBox1.Controls[i].Text = string.Empty;
                }
            }
        }
 

        private void button7_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(txt_kitapid.Text, txt_kitapisim.Text,txt_kitapyazar.Text,txt_dil.Text,txt_yayin.Text,txt_tur.Text,txt_adet.Text,txt_sayfa.Text,txt_basimyili.Text);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string kitapid = txt_kitapid.Text;
            string kitapİsmi = txt_kitapisim.Text;
            string kitapYazar = txt_kitapyazar.Text;
            string dil = txt_dil.Text;
            string yayinEvi = txt_yayin.Text;
            string tur = txt_tur.Text;
            string adet = txt_adet.Text;
            string sayfa = txt_sayfa.Text;
            string basımYili = txt_basimyili.Text;
            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
            dataGridView2.Rows.Add(kitapid, kitapisim, kitapYazar, dil, yayinevi, tur, adet, sayfa, basimyili);
        }
        private void dataGridWiew2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_kitapid.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString(); 
            txt_kitapisim.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
            txt_kitapyazar.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            txt_dil.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString(); 
            txt_yayin.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString();   
            txt_tur.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            txt_adet.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            txt_sayfa.Text = dataGridView2.CurrentRow.Cells[7].Value.ToString();
            txt_basimyili.Text = dataGridView2.CurrentRow.Cells[8].Value.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for(int i=0;i<groupBox2.Controls.Count;i++)
            {
                if(groupBox2.Controls[i] is TextBox || groupBox2.Controls[i] is MaskedTextBox)
                {
                    groupBox2.Controls[i].Text = string.Empty;
                }
            }
        }

        private void btn_kisiara_Click(object sender, EventArgs e)
        {
            Kisi hedefKisi = null;
            int secilenKisiID = Convert.ToInt32(textBox8.Text);
            foreach(Kisi kisi in kisilerim)
            {
                if(kisi.getId()==secilenKisiID)
                {
                    hedefKisi = kisi;
                    break;
                }
            }
            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add(hedefKisi.getId(), hedefKisi.getIsim(), hedefKisi.getSoyisim(), hedefKisi.getKullaniciAdi(), hedefKisi.getSifre(), hedefKisi.getYetki());
        }

        private void txt_yenile_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            foreach(Kisi hedefKisi in kisilerim)
            {
                dataGridView1.Rows.Add(hedefKisi.getId(), hedefKisi.getIsim(), hedefKisi.getSoyisim(), hedefKisi.getKullaniciAdi(), hedefKisi.getSifre(), hedefKisi.getYetki());
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form1 loginSayfasi = new Form1();
            loginSayfasi.Show();
            this.Hide();
            MessageBox.Show("Çıkış yapıldı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
