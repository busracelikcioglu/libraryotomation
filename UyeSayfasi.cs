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
    public partial class UyeSayfasi : Form
    {
        List<Kitap> kitaplarim;
        public UyeSayfasi(List<Kitap> kitaplarim)
        {
            InitializeComponent();
            this.kitaplarim = kitaplarim;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 loginSayfasi = new Form1();
            loginSayfasi.Show();
            this.Hide();


        }

        private void UyeSayfasi_Load(object sender, EventArgs e)
        {
            foreach(Kitap kitap in kitaplarim)
            {
                dataGridView2.Rows.Add(kitap.getKitapId(), kitap.getKitapIsim(), kitap.getkitapYazar(), kitap.getKitapDili(), kitap.getTur(), kitap.getSayfaSayisi(), kitap.getBasimYili());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kitapID = Convert.ToInt32(textBox1.Text);
            Kitap hedefKitap = null;
            foreach(Kitap kitap in kitaplarim )
            {
                if(kitap.getKitapId()==kitapID)
                { hedefKitap = kitap; }
            }
            dataGridView2.Rows.Clear();
            dataGridView2.Rows.Add(hedefKitap.getKitapId(), hedefKitap.getKitapIsim(), hedefKitap.getkitapYazar(), hedefKitap.getKitapDili(), hedefKitap.getTur(), hedefKitap.getSayfaSayisi(), hedefKitap.getBasimYili());
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
            foreach(Kitap hedefKitap in kitaplarim)
            { dataGridView2.Rows.Add(hedefKitap.getKitapId(), hedefKitap.getKitapIsim(), hedefKitap.getkitapYazar(), hedefKitap.getKitapDili(), hedefKitap.getTur(), hedefKitap.getSayfaSayisi(), hedefKitap.getBasimYili()); }

        }
    }
}
