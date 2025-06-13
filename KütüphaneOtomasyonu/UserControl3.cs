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
    public partial class UserControl3 : UserControl
    {
        private ÇalışanEkranı parentForm;

        public UserControl3()
        {
            InitializeComponent();
            // Find the parent form when control is loaded  
            this.Load += (s, e) =>
            {
                parentForm = this.FindForm() as ÇalışanEkranı;
            };
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string kitapAdi = textBox4.Text;
            string yazarAdı = textBox3.Text;

            // Use the existing form instance  
            if (parentForm != null)
            {
                // Fix for CS0039: Use the correct method to retrieve a list of books  
                var bulunanKitaplar = VeriIsleyici.KitapAra(kitapAdi)
                    .Where(k => string.IsNullOrEmpty(yazarAdı) || k.Yazar.Equals(yazarAdı, StringComparison.OrdinalIgnoreCase))
                    .ToList();

                if (bulunanKitaplar != null)
                {
                    parentForm.listView2.Items.Clear(); // Clear the items, not the whole ListView  

                    foreach (var kitap in bulunanKitaplar)
                    {
                        ListViewItem item = new ListViewItem(kitap.ISBN);
                        item.SubItems.Add(kitap.Ad);
                        item.SubItems.Add(kitap.Yazar);
                        item.SubItems.Add(kitap.YayinTarihi);
                        item.SubItems.Add(kitap.Kategori);
                        item.SubItems.Add(kitap.YayinEvi);
                        item.SubItems.Add(kitap.SayfaSayisi.ToString());
                        parentForm.listView2.Items.Add(item);
                    }
                }
            }
        }
    }

}
