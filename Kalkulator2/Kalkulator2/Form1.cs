using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator2
{
    public partial class Kalkulator : Form
    {
        public Kalkulator()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double liczba1 = double.Parse(liczba1txt.Text);
            double liczba2 = double.Parse(txtLiczba2.Text);
            char dzialanie = char.Parse(txtDzialanie.Text);
            double wynik = 0;
            if (dzialanie == '+')
            {
                wynik = liczba1 + liczba2;
            }
            else if (dzialanie == '^')
            {
                wynik = Math.Pow(liczba1, liczba2);
            }
            txtWynik.Text = wynik.ToString();
        }
    }
}
