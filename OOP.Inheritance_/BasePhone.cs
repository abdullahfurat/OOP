namespace OOP.Inheritance_
{
    public class BasePhone
    {
        private string _brand;
        protected string _phoneType;
        protected string _connectionType;

        public BasePhone()
        {
            _phoneType = "Ahizeli Telefon";
        }

        public BasePhone(string brand, string connectionType) : this()
        {
            //_phoneType = "Ahizeli Telefon";
            _connectionType = connectionType;
            _brand = brand;
        }

        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }

        public string PhoneType
        {
            get { return _phoneType; }
            //private set { _phoneType = value; } 
        }

        public string ConnectionType
        {
            get { return _connectionType; }
            set { _connectionType = value; }
        }

        public virtual string Sound()
        {
            return "default phone sound";
        }
    }
}
