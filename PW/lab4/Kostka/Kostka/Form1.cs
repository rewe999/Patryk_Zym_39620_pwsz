﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kostka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e) {
            if (liczba.Text !="") {
                Clipboard.SetText(liczba.Text);
            }
            
        }

        private void Label1_Click(object sender, EventArgs e)
        { }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'r')
            {
                Random rand = new Random();
                int randliczba = rand.Next(1, 6);
                liczba.Text = randliczba.ToString();
            }
        }
    }
    
}
