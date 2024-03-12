using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SrednieOcen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            float polski = float.Parse(txtPolski.Text);
            float obcy = float.Parse(txtObcy.Text);
            float miesl = float.Parse(txtMIESL.Text);
            float utk = float.Parse(txtUTK.Text);
            float programowanie = float.Parse(txtProg.Text);

            float srednia = (polski + obcy + miesl + utk + programowanie) / 5;
            txtWynik.Text = srednia.ToString();
        }
    }
}
