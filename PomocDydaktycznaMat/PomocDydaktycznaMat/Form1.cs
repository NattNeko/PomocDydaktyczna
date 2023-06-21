using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PomocDydaktycznaMat
{
    public partial class Form1 : Form
    {
        double n1, n2, sum, roznica, iloczyn, iloraz;
        public Form1()
        {
            InitializeComponent();
        }
       

        private void dodawanie_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(textBox1.Text);
            n2 = Convert.ToDouble(textBox2.Text);
            sum = n1 + n2;
                wynik.Text = sum.ToString();
        }

        private void odejmowanie_Click(object sender, EventArgs e)
        {
            roznica = Convert.ToDouble(textBox1.Text) - Convert.ToDouble(textBox2.Text);
                wynik.Text = roznica.ToString();
        }

        private void mnozenie_Click(object sender, EventArgs e)
        {
            iloczyn = Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox2.Text); ;
                wynik.Text = iloczyn.ToString();
        }

        private void dzielenie_Click(object sender, EventArgs e)
        {
            iloraz = Convert.ToDouble(textBox1.Text) / Convert.ToDouble(textBox2.Text); ;
                wynik.Text = iloraz.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

      
    }
}
