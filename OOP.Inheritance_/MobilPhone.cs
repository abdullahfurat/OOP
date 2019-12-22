namespace OOP.Inheritance_
{
    public class MobilPhone : BasePhone
    {
        public bool HasCamera { get; set; }
        public bool IsTouched { get; set; }

        public MobilPhone()
        {
            base._phoneType = "Mobil Phone";
        }


        // this => bağlı bulunduğu sınıfı işaret eder.
        // base => miras aldığı sınıfı işaret eder.
        public MobilPhone(bool hasCamera, bool isTouched, string brand, string connectionType) : base(brand, connectionType)
        {
            this.HasCamera = hasCamera;
            this.IsTouched = isTouched;
            //base.Brand = brand;
            //base.ConnectionType = connectionType;

            base._phoneType = "Mobil Phone";
        }

        public string TakePhoto()
        {
            if (this.HasCamera)
            {
                return "You can take photo";
            }
            return "there is no camera!";
        }



        public override string Sound()
        {
            return "polifonik telefon sesi";
        }
    }
}
