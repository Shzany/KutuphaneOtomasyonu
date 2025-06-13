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
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            {
                // Kitap ekleme işlemi
                Kitap yeniKitap = new Kitap
                {
                    ISBN = textBox5.Text,
                    Ad = textBox4.Text,
                    Yazar = textBox3.Text,
                    YayinTarihi = dateTimePicker1.Text,
                    Kategori = comboBox2.Text,
                    YayinEvi = textBox6.Text,
                    SayfaSayisi = int.Parse(textBox7.Text)
                };

                if (VeriIsleyici.KitapEkle(yeniKitap))
                {
                    MessageBox.Show("Kitap başarıyla eklendi.");
                    // Formu temizle
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                    textBox7.Clear();

                    // ÇalışanEkranı'ndaki listeyi güncelle
                    var parentForm = this.ParentForm as ÇalışanEkranı;
                    if (parentForm != null)
                    {
                        parentForm.listeyeYukle();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
