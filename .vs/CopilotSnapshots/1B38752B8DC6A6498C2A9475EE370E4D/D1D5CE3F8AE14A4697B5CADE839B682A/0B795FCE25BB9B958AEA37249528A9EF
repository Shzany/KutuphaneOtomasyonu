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
            VeriIsleyici.KitapEkle(new Kitap
            {
                ISBN = textBox5.Text,
                Ad = textBox4.Text,
                Yazar = textBox3.Text,
                YayinEvi = textBox2.Text,
                YayinTarihi = dateTimePicker1.Text,
                Kategori = comboBox2.Text,
            });
            ÇalışanEkranı çalışanEkranı = new ÇalışanEkranı();
            çalışanEkranı.listeyeYukle();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
