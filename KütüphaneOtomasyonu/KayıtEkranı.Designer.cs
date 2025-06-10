namespace KütüphaneOtomasyonu
{
    partial class KayıtEkranı
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ad = new System.Windows.Forms.TextBox();
            this.tc = new System.Windows.Forms.TextBox();
            this.soyad = new System.Windows.Forms.TextBox();
            this.cinsiyet = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.sifre = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(191, 232);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "AD :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(162, 265);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "SOYAD :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(163, 302);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "T.C NO :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(149, 335);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "CİNSİYET :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(178, 370);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Şifre :";
            // 
            // ad
            // 
            this.ad.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ad.Location = new System.Drawing.Point(234, 232);
            this.ad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(171, 20);
            this.ad.TabIndex = 5;
            // 
            // tc
            // 
            this.tc.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tc.Location = new System.Drawing.Point(234, 302);
            this.tc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tc.Name = "tc";
            this.tc.Size = new System.Drawing.Size(171, 20);
            this.tc.TabIndex = 6;
            // 
            // soyad
            // 
            this.soyad.BackColor = System.Drawing.Color.LightSteelBlue;
            this.soyad.Location = new System.Drawing.Point(234, 265);
            this.soyad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.soyad.Name = "soyad";
            this.soyad.Size = new System.Drawing.Size(171, 20);
            this.soyad.TabIndex = 7;
            // 
            // cinsiyet
            // 
            this.cinsiyet.BackColor = System.Drawing.Color.LightSteelBlue;
            this.cinsiyet.FormattingEnabled = true;
            this.cinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cinsiyet.Location = new System.Drawing.Point(234, 335);
            this.cinsiyet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cinsiyet.Name = "cinsiyet";
            this.cinsiyet.Size = new System.Drawing.Size(171, 21);
            this.cinsiyet.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(230, 119);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 87);
            this.label6.TabIndex = 10;
            this.label6.Text = "KÜTÜPHANE\r\nKAYIT EKRANI\r\n\r\n";
            // 
            // sifre
            // 
            this.sifre.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.sifre.Location = new System.Drawing.Point(235, 370);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(170, 20);
            this.sifre.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Navy;
            this.button2.Location = new System.Drawing.Point(358, 429);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 32);
            this.button2.TabIndex = 15;
            this.button2.Text = "Kayıt Ol";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Navy;
            this.button3.Location = new System.Drawing.Point(200, 429);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 32);
            this.button3.TabIndex = 14;
            this.button3.Text = "Giriş yap";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // KayıtEkranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(600, 569);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cinsiyet);
            this.Controls.Add(this.soyad);
            this.Controls.Add(this.tc);
            this.Controls.Add(this.ad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KayıtEkranı";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KayıtEkranı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ad;
        private System.Windows.Forms.TextBox tc;
        private System.Windows.Forms.TextBox soyad;
        private System.Windows.Forms.ComboBox cinsiyet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox sifre;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}