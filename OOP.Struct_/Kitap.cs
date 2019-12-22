using System;

namespace OOP.Struct_
{
    class Kitap
    {

        public Kitap()   //.ctor void bir metot 
        {
            this.YayinTarihi = DateTime.Now;
        }

        public Kitap(string kitapAdi)
        {
            this.KitapAdi = kitapAdi;
        }


        public Kitap(string kitapAdi, string yazarAdi)
        {
            this.KitapAdi = kitapAdi;
            this.YazarAdi = yazarAdi;
        }


        public Kitap(string kitapAdi, string yazarAdi, string tur)
        {
            this.KitapAdi = kitapAdi;
            this.YazarAdi = yazarAdi;
            this.Tur = tur;
        }
        public Kitap(string kitapAdi, string yazarAdi, string tur, int sayfaSayisi)
        {
            this.KitapAdi = kitapAdi;
            this.YazarAdi = yazarAdi;
            this.Tur = tur;
            this.SayfaSayisi = sayfaSayisi;
        }
        public Kitap(string kitapAdi, string yazarAdi, string tur, int sayfaSayisi, DateTime yayinTarihi)
        {
            this.KitapAdi = kitapAdi;
            this.YazarAdi = yazarAdi;
            this.Tur = tur;
            this.SayfaSayisi = sayfaSayisi;
            this.YayinTarihi = yayinTarihi;
        }



        public string KitapAdi { get; set; }
        public string YazarAdi { get; set; }
        public string Tur { get; set; }
        public string YayinEvi { get; set; }
        public int SayfaSayisi { get; set; }
        public DateTime YayinTarihi { get; set; }
    }


    /*
 * Struct yapı gereği değer tipli olduğundan Ram üzerinde Stack alanda tutulmaktadır. Her ne kadar Class'a yapı olarak benzesede, özellikleriyle ayrılmaktadır.

    1) struct yapılarda bos yapıcı (Cunstructur) tanımlanamaz.
    2) Eğer yapıcı metot tanımlanacak ise, mutlaka parametre almak zorundadır.
    3) Parametreli tanımlanan yapıcı metot içerisinde, değerlere başlangıç değerleri atanmak zorundadır.
    4) Struct yapılarda boş yapıcı metot tanımlanamadığından dolayı new anahtar kelimesi kullanılamaz diye bir kavram yoktur. Class yapılarından yapı derlendiğinde eğer siz default boş bir yapıcı metot oluşturmadıysanız, yapı derlendiğinde otomatik olarak " void .ctor() " metodu çalışarak oluşturacaktır.


    Eğer yapı olarak inceler isek, IL(Intermediate Language) koduna göre class için " newobj " olarak yapılandırılır iken, struct için " initobj " yapısı çalışmaktadır.

    Bir başka deyişle initobj çağrısının uygulandığı Struct içerisindeki Primitive tipler için, varsayılan ilk değer atamaları gerçekleştirilmektedir. Buna göre sayısal değerler için 0 veya 0.0, bool için false ve referans türleri için de null değerlerin atanması söz konusudur. Açıkça ifade etmek gerekirse Struct' lar için varsayılan bir yapıcı metod söz konusu olmasa dahi, IL tarafında bu fonksiyonelliği üstelenen bir çağrı yapılmaktadı
 */

    struct Book
    { 
        public Book(string kitapAdi)
        {
            this.KitapAdi = kitapAdi;
            this.YazarAdi = "default değer";
            this.Tur = "default değer";
            this.YayinEvi = "default değer";
            this.SayfaSayisi = 0;
            this.YayinTarihi = DateTime.Now;
        }

        public Book(string kitapAdi, string yazarAdi)
        {
            this.KitapAdi = kitapAdi;
            this.YazarAdi = yazarAdi;
            this.Tur = "default değer";
            this.YayinEvi = "ada";
            this.SayfaSayisi = 0;
            this.YayinTarihi = null;
        }


        public string KitapAdi { get; set; }
        public string YazarAdi { get; set; }
        public string Tur { get; set; }
        public string YayinEvi { get; set; }
        public int? SayfaSayisi { get; set; }
        public DateTime? YayinTarihi { get; set; }
    }
}
