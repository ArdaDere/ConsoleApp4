using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    private System.Windows.Forms.Button btnGoster;
    private System.Windows.Forms.ListBox listBoxUrunler;

    private void InitializeComponent()
    {
        this.btnGoster = new System.Windows.Forms.Button();
        this.listBoxUrunler = new System.Windows.Forms.ListBox();
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
