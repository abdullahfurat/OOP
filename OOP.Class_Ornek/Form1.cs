using System;
using System.Windows.Forms;

namespace OOP.Class_Ornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Form Load
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] departmanlar = {
                "Ofis",
                "Sistem",
                "Yazılım",
                "Muhasebe",
                "Web Grafik",
                "Teknik Çizim" };

            cmbPersonelDepartman.Items.AddRange(departmanlar);
        }
        #endregion

        #region Kaydet Butonu
        private void btnKaydet_Click(object sender, EventArgs e)
        {

            // Instance alma (yeni bir örnek)
            Personel personel = new Personel();
            personel.Adi = txtPersonelAdi.Text;
            personel.Mail = txtPersonelMail.Text;
            personel.Soyadi = txtPersonelSoyadi.Text;
            personel.Telefon = txtPersonelTelefon.Text;
            personel.Departman = cmbPersonelDepartman.Text;

            listBox1.Items.Add(personel);
            Temizle(this);
        }
        #endregion

        #region Temizleme Metodu
        void Temizle(Control ctrl)
        {
            foreach (Control control in ctrl.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = "";
                }
                else if (control is ComboBox)
                {
                    ComboBox cmb = (ComboBox)control;
                    cmb.SelectedIndex = -1;
                }
                else if (control is GroupBox)
                {
                    Temizle(control);
                }
            }
        }
        #endregion

        private void yeniPersonelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // nuget üzernden FakeData olarak aratıp indirebilirsiniz. Gökhan ısrar etti yoksa yazmazdım :)
            txtPersonelAdi.Text = FakeData.NameData.GetFirstName();
            txtPersonelSoyadi.Text = FakeData.NameData.GetSurname();
            txtPersonelTelefon.Text = FakeData.PhoneNumberData.GetPhoneNumber();
             
            string mail = FakeData.NetworkData.GetEmail();  
            txtPersonelMail.Text = $"{txtPersonelAdi.Text}.{txtPersonelSoyadi.Text}{mail.Remove(0, mail.IndexOf('@'))}".ToLower(); 
        } 
    }
}
