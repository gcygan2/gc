using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp40
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            float koszt = float.Parse(txtKosztFilamentu.Text);
            float zuzyty = float.Parse (txtZuzytyFilament.Text);
            float cena = koszt * zuzyty / 1000;
            lblWynik.Text = cena.ToString();
        }
    }
}
