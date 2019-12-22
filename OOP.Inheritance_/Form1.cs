using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP.Inheritance_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            //throw new Exception("asdsadsa");
            try
            {
                object a = "123";
                int b = (int)a;
            }
            catch (Exception ex)
            {
                throw new HataClassi("kullanıcı fakir", ex.Message);
            } 
        }
    }


    public class HataClassi : Exception
    {

        //private string _exeption;
        public HataClassi(string exeption, string system) : base(exeption)
        {
            //this._exeption = exeption;

            SetLog(exeption, system);
        }


        private void SetLog(string exeption, string system)
        {

            //db.Exceptions.Add(exeption, system);
            // exeption db kaydet
        }
    }

}
