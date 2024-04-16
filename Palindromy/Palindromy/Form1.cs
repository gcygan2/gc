using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Palindromy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string slowo = txtSlowo.Text.ToLower();
            lblPalindrom.Text = "Słowo jest palindromem";
            for (int i = 0; i < slowo.Length; i++)
            {
                if (slowo[i] != slowo[slowo.Length - 1 - i])
                {
                    lblPalindrom.Text = "Słowo nie jest palindromem";
                    break;
                }
            }
        }
    }
}
