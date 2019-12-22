using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP.ReferenceValueType
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
 * .NET FRAMEWORK mantigi geregi, uygulama uzerinde gecici olarak kullanilan tum nesneler RAM uzerinde kendilerine bir yer edinirler. RAM'in teknik yapisina baktigimizda ise bu nesneleri iki farkli blokta tuttugunu gorururz. Bunlardan bir tanesi Stack, bir tanesi ise Heap bolumudur....
 * Stack bolumunde "Value Type" olarak adlandirdigimiz deger tipleri tutulur. (String haric tum degiskenler, Enum, Struct)
 * Heap bolumunde ise "Reference Type" olarak adlandirdigimiz tipler bulunur. (Class, Delegate, Array, String)
 * Value Type'larin degerleri kopyalanabilme ozelligine sahipken, referans tiplerde bu is deger tasima olarak gozlemlenmektedir.
 * Bir degerin NULL olmasi demek, o degerin HEAP bolumunde karsiligi olmaması demektir. Dolayisiyla Reference tipler null gecilebilirken, deger tipler null gecilemez!
 * 
 *  NOT:
 *      Value Type: Value tipindeki bir nesne tüm veriyi kendi içinde tutar.
 *      Reference Type: Direkt olarak veriyi tutmaz bunun yerine verinin adresini gösterir bir referans tutar.
 */
        private void Form1_Load(object sender, EventArgs e)
        {

        }




        class Ogrenci
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        /*
             * Struct (Yapi) => En basit tanimiyla classlarin deger tipi (Value Type) versiyonlardir...
             * Struct'larla class arasindaki en buyuk farklardan bir tanesi struct'lar baskan bir struct'tan ya da class'tan kalitim alamaz (ancak interface implement edilebilir)
             * Eger struct ile class arasinda kalirsaniz, deger tip ile referans tip olmasi bakimindan da bir problem teskil etmiyorsa; 16 KB'dan buyuk nesneler icin CLASS, kucuk nesneler icin STRUCT kullanilmasi onerilmektedir...
             */


        struct Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }


        private void btnReference_Click(object sender, EventArgs e)
        {
            Ogrenci ogr1 = new Ogrenci();
            ogr1.FirstName = "Murat";
            ogr1.LastName = "Vuranok";


            Ogrenci ogr2 = ogr1;
            ogr2.FirstName = "Ahmet";

            MessageBox.Show($"Birinci Öğrencinin Adı : {ogr1.FirstName}\nİkinci Öğrencinin Adı : {ogr2.FirstName}");
            MessageBox.Show($"Birinci Öğrenci : {ogr1.GetHashCode()}\nİkinci Öğrenci : {ogr2.GetHashCode()}");


            int[] sayilar = { 1, 2, 3, 4, 5, 6 };
            int[] numbers = sayilar; // 1,2,3,4,5,6
            numbers[1] = 22; // 1,22,3,4,5,6

            MessageBox.Show(sayilar[1].ToString());
        }
         
        private void btnValue_Click(object sender, EventArgs e)
        {

            Student student1 = new Student();
            student1.FirstName = "Murat";
            student1.LastName = "Vuranok";


            Student student2 = student1;
            student1.FirstName = "Ahmet";
            MessageBox.Show($"Birinci Öğrencinin Adı : {student1.FirstName}\nİkinci Öğrencinin Adı : {student2.FirstName}");
            MessageBox.Show($"Birinci Öğrenci : {student1.GetHashCode()}\nİkinci Öğrenci : {student2.GetHashCode()}");

            int a = 10;
            int b = a;
            b = 20;
            MessageBox.Show(a.ToString()) ;
        }
    }
}

