namespace OOP.Inheritance_
{
    public class SmartPhone : MobilPhone
    {
        public bool FrontCam { get; set; }

        public SmartPhone()
        {
            base._phoneType = "Smart Phone";
        }

        public SmartPhone(bool frontcam, bool hasCamera, bool isTouched, string brand, string connectionType)
            : base(hasCamera, isTouched, brand, connectionType)
        {
            this.FrontCam = frontcam;
            base._phoneType = "Smart Phone";
        }

        public string VideoCall()
        {
            return "Calling...";
        }

        public override string Sound()
        {
            return "mp3 telefon sesi";
        }
         
    }
}
