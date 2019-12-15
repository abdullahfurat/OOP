namespace OOP.Class_Ornek
{
    public class Personel
    {
        // prop + (tab * 2) property oluşturma 
        // tab basarsanız key value arasında dolaşır.

        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Telefon { get; set; }
        public string Mail { get; set; }
        public string Departman { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
