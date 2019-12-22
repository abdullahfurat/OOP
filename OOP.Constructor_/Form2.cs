using System.Drawing;
using System.Windows.Forms;

namespace OOP.Constructor_
{
    public partial class Form2 : Form
    {


        public Form2() // yapıcı metot
        {
            InitializeComponent();
        }

        public Form2(string param) : this()
        {
            label1.Text = param;
        }


        private int _red;
        private int _green;
        private int _blue;

        public Form2(int red, int green, int blue) : this()
        {
            this._red = red;
            this._green = green;
            this._blue = blue;
        }

        private void Form2_Load(object sender, System.EventArgs e)
        {
            this.BackColor = Color.FromArgb(_red, _green, _blue);
        }
    }
}
