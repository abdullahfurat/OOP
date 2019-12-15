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

        #region IsNull Metodu
        bool IsNull(Control control)
        {
            errorProvider1.Clear();
            string _error = $"{control.Name} Zorunlu alandır!".Replace("txt", "").Replace("cmb", "");

            if (control is TextBox)
            {
                TextBox txt = (TextBox)control;
                if (string.IsNullOrWhiteSpace(txt.Text))
                {
                    errorProvider1.SetError(txt, _error);
                    return true;
                }
            }

            else if (control is ComboBox)
            {
                ComboBox cmb = (ComboBox)control;
                if (cmb.SelectedIndex == -1) // comboBox'dan bir eleman seçilmedi ise.
                {
                    errorProvider1.SetError(cmb, _error);
                    return true;
                }
            }
            return false;
        }
        #endregion

        #region Kaydet Butonu
        private void btnKaydet_Click(object sender, EventArgs e)
        {

            // Instance alma (yeni bir örnek)
            Personel personel = new Personel();

            //if (string.IsNullOrWhiteSpace(txtPersonelAdi.Text))
            //{
            //    errorProvider1.SetError(txtPersonelAdi, "Lütfen Personel Adı Giriniz!");
            //    return;
            //}
            //else
            //{
            //    errorProvider1.Clear();
            //    personel.Adi = txtPersonelAdi.Text;
            //}


            if (IsNull(txtPersonelAdi) || IsNull(txtPersonelSoyadi) || IsNull(cmbPersonelDepartman))
            {
                return;
            }

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

        #region Yeni Fake Personel Ekle
        private void yeniPersonelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // nuget üzernden FakeData olarak aratıp indirebilirsiniz. Gökhan ısrar etti yoksa yazmazdım :)
            txtPersonelAdi.Text = FakeData.NameData.GetFirstName();
            txtPersonelSoyadi.Text = FakeData.NameData.GetSurname();
            txtPersonelTelefon.Text = FakeData.PhoneNumberData.GetPhoneNumber();

            string mail = FakeData.NetworkData.GetEmail();
            txtPersonelMail.Text = $"{txtPersonelAdi.Text}.{txtPersonelSoyadi.Text}{mail.Remove(0, mail.IndexOf('@'))}".ToLower();
        }
        #endregion

        #region ListBox
        Personel guncellenecek;
        int index = 0;
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            index = listBox1.SelectedIndex;
            guncellenecek = (Personel)listBox1.SelectedItem;
            if (guncellenecek == null)
            {
                MessageBox.Show("Lütfen güncellenecek bir eleman seçiniz!");
                return;
            }


            txtPersonelAdi.Text = guncellenecek.Adi;
            txtPersonelSoyadi.Text = guncellenecek.Soyadi;
            txtPersonelTelefon.Text = guncellenecek.Telefon;
            txtPersonelMail.Text = guncellenecek.Mail;

            cmbPersonelDepartman.Text = guncellenecek.Departman;
        }


        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (guncellenecek == null)
            {
                MessageBox.Show("Lütfen günncellenecek bir kayıt seçiniz!");
                return;
            }

            guncellenecek.Adi = txtPersonelAdi.Text;
            guncellenecek.Soyadi = txtPersonelSoyadi.Text;
            guncellenecek.Telefon = txtPersonelTelefon.Text;
            guncellenecek.Mail = txtPersonelMail.Text;
            guncellenecek.Departman = cmbPersonelDepartman.Text;
            listBox1.Items.RemoveAt(index);
            listBox1.Items.Insert(index, guncellenecek);

            guncellenecek = null;
            Temizle(this);
        }
        #endregion

        private void tsmSil_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir eleman seçiniz!");
                return;
            }

            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }
    }
}
