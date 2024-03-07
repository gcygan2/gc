using OOP.KLasy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP
{
    public partial class Form1 : Form
    {
        Pojazd pojazd;
        Pojazd maluch;
        public Form1()
        {
            InitializeComponent();
            pojazd = new Pojazd();
            maluch = new Pojazd();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            pojazd.WprowadzParametry(int.Parse(txtKola.Text), int.Parse(txtSilniki.Text));
            MessageBox.Show(pojazd.PrzedstawSie());
        }
    }
}
