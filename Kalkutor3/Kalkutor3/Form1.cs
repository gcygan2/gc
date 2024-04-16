using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkutor3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double wynik = 0;
            double l1 = double.Parse(txtLiczba1.Text);
            double l2 = double.Parse(txtLiczba2.Text);
            switch (txtLDzialanie.Text)
            {
                case "+":
                    wynik = l1 + l2;
                    break;
                case "-":
                    wynik = l1 - l2;
                    break;
                case "*":
                    wynik = l1 * l2;
                    break;
                case "/":
                    wynik = l1 / l2;
                    break;
                case "^":
                    wynik = Math.Pow (l1, l2);
                    break;
            }
            MessageBox.Show(wynik.ToString());
        }
    }
}
