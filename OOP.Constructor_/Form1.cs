using System;
using System.Windows.Forms;

namespace OOP.Constructor_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) { }

        private void btnForm_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2("bilge adam");
            //frm.label1.Text = "Bilge Adam";
            this.Hide();
            frm.ShowDialog();
        }

        private void btnRenk_Click(object sender, EventArgs e)
        {
            int red   = Convert.ToInt32(nmrRed.Value);
            int green = Convert.ToInt32(nmrGreen.Value);
            int blue  = Convert.ToInt32(nmrBlue.Value);


            Form2 frm = new Form2(red, green, blue);
            this.Hide();
            frm.ShowDialog();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Personel personel = new Personel();
            //personel.CreatedIP = "432432";

            personel.FirstName = "murat";
            personel.LastName = "vuranok";

            // 78	Kola 1	NULL	NULL	NULL	5.00	500	NULL	NULL	0
            int? cID = null;

            int b = 0;

            int? categoryID =  cID;
            if (categoryID.HasValue)
            {

                // kategoriye ait ürünleri listele

                if (true) // kategoriye ait ürün varmı ?
                {
                    // ürün listesi
                }
                else
                {
                    // kategori listesi
                }
            }
            else
            {
                // anasayfa
            }
             
        }
    }
}
