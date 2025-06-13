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
    public partial class KayıtEkranı: Form
    {
        public KayıtEkranı()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // TC ve diğer alanların boş olmadığını kontrol et
            if (string.IsNullOrWhiteSpace(tc.Text))
            {
                MessageBox.Show("TC No alanı boş bırakılamaz!");
                return;
            }

            // Yeni üye oluştur
            Uye yeniUye = new Uye
            {
                Ad = ad.Text,
                Soyad = soyad.Text,
                TcNo = tc.Text,
                Cinsiyet = cinsiyet.Text,
                Sifre = sifre.Text
            };

            // Üyeyi kaydet
            if (VeriIsleyici.UyeEkle(yeniUye))
            {
                MessageBox.Show("Üyelik başarıyla oluşturuldu.");
                this.Hide(); // Kayıt ekranını gizle

                // Ana ekrana dön
                AnaEkran anaEkran = new AnaEkran();
                anaEkran.Show();
            }
            else
            {
                MessageBox.Show("Bu TC Kimlik No ile daha önce kayıt yapılmış! Lütfen kontrol ediniz.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AnaEkran anaEkran = new AnaEkran();
            anaEkran.Show();
            this.Hide(); // Kayıt ekranını gizle
        }
    }
}
