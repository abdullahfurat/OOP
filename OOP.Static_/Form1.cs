using System;
using System.Windows.Forms;

namespace OOP.Static_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Class static olarak işaretli ise, içerideki tüm elemanlar statik olmak zorundadır.
            // Class static olarak işaretli değil ise, içerideki seçili elemanları static olarak işaretleyebilirsiniz.
            //FizikKutuphanesi fizikKutuphanesi = new FizikKutuphanesi();
            //fizikKutuphanesi.PI; class içerisinde yer alan static bir elemana instance alarak ulaşamazsınız.

            double pi = FizikKutuphanesi.PI;
            FizikKutuphanesi.PI = 12321321321;
            //FizikKutuphanesi.connection = "bilge adam server";

            string con = FizikKutuphanesi.connection;
            string connection = FizikKutuphanesi.connectionstring;
            //FizikKutuphanesi.server = "wqeewrewrew";

            //fizikKutuphanesi.Hesapla(5, 5);

            Personel p = new Personel();
            p.Adi = "";
            p.Soyadi = "";

            //Personel p1 = new Personel();
            //p1.Adi = "dsf";
            //p1.Soyadi = "asd";

            //Personel.Adi = "Murat";
            //Personel.Soyadi = "";

            //Personel.Adi = "Ahmet";


            //Utility utility = new Utility();
            //utility.Temizle(this);

            Utility.Temizle(this);

            //Utility utility = new Utility();
            "".Replace("", "").Replace("", "").ToLower().ToUpper();
            string a = 1.ToString();


            "".Replace("$", "");
            "".Mail();
       
        }
    }
     
    public class Utility
    {
        private Utility() { }
        public static void Temizle(Control control)
        {
            foreach (Control ctrl in control.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = "";
                }
            }
        }
    }
     
    public static class Clear // bu metodu extention metot yapın :)
    { 
        public static string Mail(this string param)
        { 
            param = param.ToLower()
                .Replace("ğ", "g")
                .Replace("ç", "c")
                .Replace("ü", "u")
                .Replace("ı", "i")
                .Replace("ö", "o")
                .Replace("ş", "s")
                .Replace("$", "")
                .Replace("'", "");

            return param;
        } 
    }
     
    public static class FizikKutuphanesi
    {
        public static double PI = 3.1415926535897931;

        // readonly sadece okunabilir kılar.
        public static readonly string connection = "server=.;database=northiwnd;uid=sa;pwd=123";
        public static string connectionstring { get; } = "bilge adam server";

        // const => kendiliğinden static olma özelliğine sahiptir ve sadece okunabilir bir değerdir.
        public const string server = "127.0.0.1";

        // static sınıf içerisinde, static olmayan nesne tanımlayamazsınız.
        //public int Hesapla(int s1, int s2)
        //{
        //    return s1 + s2;
        //}

       
    }

    public class Personel
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
    }
}


// geriye string teslim edecek. tüm harfler küçük ve turkçe karakterler dahil replace edilecek, özel karakterler (bosluk, !'^)vs.. "" ile replace edilecek ve geriye dönecek 