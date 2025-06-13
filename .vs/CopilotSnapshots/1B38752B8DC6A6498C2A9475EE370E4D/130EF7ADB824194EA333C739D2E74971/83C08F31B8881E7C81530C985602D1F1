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
            Uye yeniUye = new Uye
            {
                Ad = ad.Text,
                Soyad = soyad.Text,
                TcNo = tc.Text,
                Cinsiyet = cinsiyet.Text,
                Sifre = sifre.Text
            };
            this.Hide(); // Kayıt ekranını gizle
            VeriIsleyici.UyeEkle(yeniUye);
            MessageBox.Show("Üye başarıyla kaydedildi.");
            AnaEkran anaEkran = new AnaEkran();
            anaEkran.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AnaEkran anaEkran = new AnaEkran();
            anaEkran.Show();
            this.Hide(); // Kayıt ekranını gizle
        }
    }
}
