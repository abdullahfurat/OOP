using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP.Inheritance_
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {


        }

        private void btnBase_Click(object sender, EventArgs e)
        {
            BasePhone @base = new BasePhone("Alcatel", "Kablolu");

            BasePhone phone = new BasePhone();
            phone.Brand = "Alcatel";
            phone.ConnectionType = "Kablolu";
            //phone.PhoneType = "Ahizeli";
             
            MessageBox.Show($"Telefon Markası : {phone.Brand}\nTelefon Bağlantı Türü : {phone.ConnectionType}\nTelefon Tipi : {phone.PhoneType}\nTelefon Zil Sesi : {phone.Sound()}");
        }

        private void btnMobil_Click(object sender, EventArgs e)
        {
            MobilPhone phone = new MobilPhone();
            phone.Brand = "Nokia";
            phone.ConnectionType = "Mobil";
            phone.IsTouched = false;
            phone.HasCamera = true;
             
            MessageBox.Show($"Telefon Markası : {phone.Brand}\nTelefon Bağlantı Türü : {phone.ConnectionType}\nTelefon Tipi : {phone.PhoneType}\nTelefon Zil Sesi : {phone.Sound()}\nFotoğraf : {phone.TakePhoto()}");
        }

        private void btnSmart_Click(object sender, EventArgs e)
        {
            SmartPhone phone = new SmartPhone();
            phone.Brand = "Apple";
            phone.ConnectionType = "Mobil 5G";
            phone.IsTouched = true;
            phone.HasCamera = true;
            phone.FrontCam = true;

            MessageBox.Show($"Telefon Markası : {phone.Brand}\nTelefon Bağlantı Türü : {phone.ConnectionType}\nTelefon Tipi : {phone.PhoneType}\nTelefon Zil Sesi : {phone.Sound()}\nFotoğraf : {phone.TakePhoto()}");
        }
    }
}
