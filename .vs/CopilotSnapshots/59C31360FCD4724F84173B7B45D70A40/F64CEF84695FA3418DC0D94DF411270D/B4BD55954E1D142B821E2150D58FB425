using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KütüphaneOtomasyonu
{
    public partial class AnaEkran: Form
    {
        public AnaEkran()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AnaEkran_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            KayıtEkranı kytekr = new KayıtEkranı();
            kytekr.Show();
            this.Hide(); // Ana ekranı gizle
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string girilenTc = tc.Text;
            string girilenSifre = sifre.Text;

            List<Uye> uyeler = VeriIsleyici.UyeleriYukle();

            var girisYapanUye = uyeler.FirstOrDefault(u => u.TcNo == girilenTc && u.Sifre == girilenSifre);

            if (girisYapanUye != null)
            {
                ÇalışanEkranı  kullanıcıEkranı = new ÇalışanEkranı();
                kullanıcıEkranı.Show();
                this.Hide(); // Ana ekranı gizle
            }
            else
            {
                MessageBox.Show("TC veya şifre yanlış!");
            }
          
        }

        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
