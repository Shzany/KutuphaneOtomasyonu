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
    public partial class UserControl6: UserControl
    {
        private ÇalışanEkranı parentForm;
        public UserControl6()
        {
            InitializeComponent();
            this.Load += (s, e) =>
            {
                parentForm = this.FindForm() as ÇalışanEkranı;
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VeriIsleyici.UyeSil(textBox2.Text);
            
            // Refresh the ListView in the parent form
            if (parentForm != null)
            {
                List<Uye> uyeler = VeriIsleyici.UyeleriYukle();
                parentForm.listView1.Items.Clear();
                
                foreach (var uye in uyeler)
                {
                    ListViewItem item = new ListViewItem(uye.Ad);
                    item.SubItems.Add(uye.Soyad);
                    item.SubItems.Add(uye.TcNo);
                    item.SubItems.Add(uye.Cinsiyet);
                    item.SubItems.Add(uye.Sifre);
                    parentForm.listView1.Items.Add(item);
                }
            }
        }
    }
}
