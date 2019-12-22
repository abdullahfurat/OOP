using System;

namespace OOP.Constructor_
{
    public class Personel
    {
        // https://api.ipify.org/?format=json

        public Personel()
        {
            // ActiveDirectory
            this.CreatedADUsername = System.Environment.UserName;
            this.CreatedComputerName = System.Environment.MachineName;
            this.CreatedDate = DateTime.Now;
            this.CreatedIP = "195.142.153.74";
            this.CreatedBy = 1;
        }


        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Log Datalar
        public DateTime  CreatedDate { get;  private set; }
        public string    CreatedComputerName { get; private set; }
        public string    CreatedADUsername { get; private set; }
        public string    CreatedIP { get; private set; }
        public int       CreatedBy { get; private set; }


        // modified 
        public Nullable<DateTime> ModifiedDate { get; set; }        // value
        public string ModifiedComputerName { get; set; }  // reference
        public string ModifiedADUsername { get; set; }    // reference
        public string ModifiedIP { get; set; }            // reference
        public int? ModifiedBy { get; set; }               // value
    }
}

