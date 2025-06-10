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
    public partial class UserControl2: UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string isbnDegeri = textBox4.Text;
            if (string.IsNullOrEmpty(isbnDegeri))
            {
                MessageBox.Show("Lütfen ISBN değerini giriniz.");
                return;
            }
            else
            {
                VeriIsleyici.KitapSil(isbnDegeri);
                // Get the parent ÇalışanEkranı form and refresh its list
                var parentForm = this.ParentForm as ÇalışanEkranı;
                if (parentForm != null)
                {
                    parentForm.listeyeYukle();
                    MessageBox.Show("Kitap başarıyla silindi.");
                }
            }
        }
    }
}
