using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP.Struct_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Kitap kitap;
        private void btnClass_Click(object sender, EventArgs e)
        {
            kitap = new Kitap(); 
            kitap.KitapAdi = "Fakirler";
            kitap.YayinEvi = "Türkiye";
            kitap.YazarAdi = "Tesla";
            kitap.SayfaSayisi = 1;


            Kitap k1 = new Kitap("sefiller", "apple", "komedi", 1, DateTime.Now);
            Kitap k2 = new Kitap(null, null, "roman", 0, DateTime.Now);

            Kitap k3 = new Kitap("Matematik 1");
            k3.YayinTarihi = DateTime.Now;
            k3.SayfaSayisi = 100;


        }
        Book book;
        private void btnStrcut_Click(object sender, EventArgs e)
        {
            book = new Book();

            book.KitapAdi = "Züğürtler";
            book.YayinEvi = "Apple";
            book.YazarAdi = "Mac Pro";
            book.SayfaSayisi = 1;
        }
    }
}
