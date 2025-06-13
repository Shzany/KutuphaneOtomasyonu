using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KütüphaneOtomasyonu
{
    public partial class UserControl4: UserControl
    {
        public UserControl4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1 == null || textBox2 == null)
                {
                    MessageBox.Show("Uygulama hatası: Form kontrolleri düzgün yüklenemedi.");
                    return;
                }

                string tcNo = textBox1.Text.Trim();
                string isbn = textBox2.Text.Trim();

                // Input validation
                if (string.IsNullOrEmpty(tcNo) || string.IsNullOrEmpty(isbn))
                {
                    MessageBox.Show("TC No ve ISBN alanları boş bırakılamaz!");
                    return;
                }

                var uye = VeriIsleyici.UyeBul(tcNo);
                if (uye == null)
                {
                    MessageBox.Show("Belirtilen TC No'ya sahip üye bulunamadı!");
                    return;
                }

                var kitap = VeriIsleyici.KitapBul(isbn);
                if (kitap == null)
                {
                    MessageBox.Show("Belirtilen ISBN'ye sahip kitap bulunamadı!");
                    return;
                }

                if (kitap.OduncDurumu())
                {
                    MessageBox.Show("Bu kitap şu anda başka bir üyede ödünç durumunda!");
                    return;
                }

                if (VeriIsleyici.KitapOduncVer(isbn, tcNo))
                {
                    var iadeTarihi = DateTime.Now.AddDays(15).ToString("dd.MM.yyyy");
                    MessageBox.Show($"Kitap başarıyla ödünç verildi. İade tarihi: {iadeTarihi}");
                    
                    // Clear input fields
                    textBox1.Clear();
                    textBox2.Clear();
                    
                    // Update list in ÇalışanEkranı if available
                    var parentForm = this.ParentForm as ÇalışanEkranı;
                    if (parentForm != null)
                    {
                        parentForm.listeyeYukle();
                        parentForm.UyeleriListeyeYukle();
                    }
                }
                else
                {
                    MessageBox.Show("Kitap ödünç verme işlemi başarısız oldu!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
