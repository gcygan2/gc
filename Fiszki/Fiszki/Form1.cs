﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fiszki
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            switch (txtPoPolsku.Text.ToLower())
            {
                case "drzewo":
                    if (txtPoAngielsku.Text.ToLower() == "tree")
                    {
                        MessageBox.Show("OK");
                    }
                    break;
            }
        }
    }
}
