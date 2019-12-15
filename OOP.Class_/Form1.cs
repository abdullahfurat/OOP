using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP.Class_
{
    public partial class Form1 : Form
    {
        public Form1() { InitializeComponent(); }

        private void Form1_Load(object sender, EventArgs e)
        {

            FirstClass firstClass = new FirstClass();
            //firstClass.isim    = "Murat";
            //firstClass.soyisim = "Vuranok";
            //firstClass.telefon = "43535435435";
            //firstClass.mail    = "murat.vuranok@bilgeadam.com";
            //firstClass.adres   = "beşiktaş";

            firstClass.Ad = "Murat";
            firstClass.Soyad = "Vuranok";
            firstClass.Telefon = "43535435435";
            firstClass.Mail = "murat.vuranok@bilgeadam.com";
            firstClass.Adres = "beşiktaş";
            firstClass.Yas = 51;   // 0

            //firstClass.Onay = true;  sadece get metodu aktif olduğundan sadece okunabilir.


            //if (firstClass.Onay)
            //{
            //    // db.Personel.Add(firstClass);
            //    MessageBox.Show("Personel İşe Alındı!");
            //}

            MessageBox.Show(firstClass.Onay ? "Personel İşe Alındı!" : "Koşullar sağlanamadı!");
        }
    }
}
