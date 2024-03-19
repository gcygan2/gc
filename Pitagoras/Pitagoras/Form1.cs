using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pitagoras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            double bokA = double.Parse(txtA.Text);
            double bokB = double.Parse(txtB.Text);
            double bokC = double.Parse(txtC.Text);
            if (Math.Pow(bokA, 2) + Math.Pow(bokB, 2) == Math.Pow(bokC, 2)) { 
                MessageBox.Show("Tak, to jest trójkąt prostokątny");
            }
            else
            {
                MessageBox.Show("Nie, to nie jest trójkąt prostokątny");
            }
        }
    }
}
