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
    public partial class ÇalışanEkranı: Form
    {
        public ÇalışanEkranı()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UserControl1());
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UserControl2());
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UserControl4());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UserControl3());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UserControl5());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UserControl6());
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoadUserControl(UserControl uc)
        {
            panelMain.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            LoadUserControl(new UserControl6());
        }

        private void ÇalışanEkranı_Load(object sender, EventArgs e)
        {
            List<Uye> uyeler = VeriIsleyici.UyeleriYukle();
            listView1.Items.Clear(); // varsa önce temizle
            listView2.Items.Clear(); // varsa önce temizle

            listView1.Columns.Add("Ad", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Soyad", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("TC No", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Cinsiyet", 100, HorizontalAlignment.Left);

            listView2.Columns.Add("ISBN", 100, HorizontalAlignment.Left);
            listView2.Columns.Add("Ad", 100, HorizontalAlignment.Left);
            listView2.Columns.Add("Yazar", 100, HorizontalAlignment.Left);
            listView2.Columns.Add("Yayın Tarihi", 100, HorizontalAlignment.Left);
            listView2.Columns.Add("Kategori", 100, HorizontalAlignment.Left);
            listView2.Columns.Add("Yayınevi", 100, HorizontalAlignment.Left);
            listView2.Columns.Add("Sayfa Sayısı", 100, HorizontalAlignment.Left);


            foreach (var uye in uyeler)
            {
                ListViewItem item = new ListViewItem(uye.Ad); // İlk sütun
                item.SubItems.Add(uye.Soyad);
                item.SubItems.Add(uye.TcNo);
                item.SubItems.Add(uye.Cinsiyet);
                item.SubItems.Add(uye.Sifre);
                listView1.Items.Add(item);
            }

            // İlk UserControl'ü yükle
            listeyeYukle();
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void listeyeYukle()
        {
            List<Kitap> kitaplar = VeriIsleyici.KitaplariYukle();
            if (listView2.InvokeRequired)
            {
                listView2.Invoke(new MethodInvoker(() => listeyeYukle()));
                return;
            }
            
            listView2.Items.Clear(); // varsa önce temizle
            foreach (var kitap in kitaplar)
            {
                ListViewItem item = new ListViewItem(kitap.ISBN); // İlk sütun
                item.SubItems.Add(kitap.Ad);
                item.SubItems.Add(kitap.Yazar);
                item.SubItems.Add(kitap.YayinTarihi.ToString());
                item.SubItems.Add(kitap.Kategori);
                item.SubItems.Add(kitap.YayinEvi);
                item.SubItems.Add(kitap.SayfaSayisi.ToString());
                listView2.Items.Add(item);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
