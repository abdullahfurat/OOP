namespace OOP.Class_
{
    // class'ın access modifier'ı belirtilmediyse, default değeri nedir ?  cevap veriyorum :) internal'dır
    class FirstClass
    {
        // class içerisinde eğer herhangi bir nesneye access modifier belirtilmediyse, default değeri PRIVATE olarak belirtilir.

        // private sadece kendi içerisinden ulaşılabilir.
        //string isim = "";
        //string soyisim = "";
        //string mail = "";
        //string telefon = "";
        //string adres = "";
        //int yas = 0;

        // public => heryerden ulaşılabilir.
        //public string isim = "";
        //public string soyisim = "";
        //public string mail = "";
        //public string telefon = "";
        //public string adres = "";
        //public int yas = 0;

        // prop (tab * 2)
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Mail { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
        public bool Onay { get; private set; } // private set;  => sınıf içerisinden ulaşabilirsiniz, dışarıdan müdahale edemezsiniz!
         

        // encapsulation
        private int _yas; 
        public int Yas
        {
            get // okunabilir.
            {
                return _yas;
            }

            set  // yazılabilir.
            {
                if (value >= 18 && value <= 50)
                {
                    this.Onay = true;
                    _yas = value;
                }
            }
        }

    }
}
