using ConsoleApp4;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace UrunGosterApp
{
    public partial class Form1 : Form
    {
        // Form bileşenlerini burada tanımlıyoruz
        private Button btnGoster;
        private ListBox listBoxUrunler;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            try
            {
                string jsonPath = "urunler.json";

                if (!File.Exists(jsonPath))
                {
                    MessageBox.Show("JSON dosyası bulunamadı!");
                    return;
                }

                string jsonString = File.ReadAllText(jsonPath);
                List<Urun> urunler = JsonSerializer.Deserialize<List<Urun>>(jsonString);

                listBoxUrunler.Items.Clear();

                if (urunler != null)
                {
                    foreach (Urun urun in urunler)
                    {
                        listBoxUrunler.Items.Add($"{urun.UrunAdi} - {urun.Fiyat} TL");
                    }
                }
                else
                {
                    MessageBox.Show("JSON dosyası boş veya hatalı formatta.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:\n" + ex.Message);
            }
        }

        // InitializeComponent metodunu burada yeniden yazıyoruz
        private void InitializeComponent()
        {
            this.btnGoster = new Button();
            this.listBoxUrunler = new ListBox();
            this.SuspendLayout();

            // btnGoster
            this.btnGoster.Location = new System.Drawing.Point(30, 30);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(150, 30);
            this.btnGoster.Text = "Ürünleri Göster";
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);

            // listBoxUrunler
            this.listBoxUrunler.FormattingEnabled = true;
            this.listBoxUrunler.ItemHeight = 15;
            this.listBoxUrunler.Location = new System.Drawing.Point(30, 80);
            this.listBoxUrunler.Name = "listBoxUrunler";
            this.listBoxUrunler.Size = new System.Drawing.Size(300, 150);

            // Form1
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.btnGoster);
            this.Controls.Add(this.listBoxUrunler);
            this.Name = "Form1";
            this.Text = "Ürün Listesi";
            this.ResumeLayout(false);
        }
    }
}
