using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Pesel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Wynik_Click(object sender, EventArgs e)
        {
            String pesel = Pesel.Text;
            int d = pesel.Length;
            int[] tab = new int[11];
            

            for(int i=0;i<11;i++){
            tab[i] = (int)Char.GetNumericValue(pesel[i]);
            }


            try {
                Debug.WriteLine(tab[0]);
                Debug.WriteLine("asdasasdasd");
                Debug.WriteLine("asdasasdasd");
                Debug.WriteLine("asdasasdasd");
                int A = 1 * tab[0];
                int B = 3 * tab[1];
                int C = 7 * tab[2];
                int D = 9 * tab[3];
                int E = 1 * tab[4];
                int F = 3 * tab[5];
                int G = 7 * tab[6];
                int H = 9 * tab[7];
                int I = 1 * tab[8];
                int J = 3 * tab[9];
                int Suma = tab[10];


                Debug.WriteLine(C);


                int wynik = A + B + C + D + E + F + G + H + I + J;
                Wyswietl.Text = wynik.ToString();
                int dlugosc = wynik.ToString().Length - 1;
                int Lastnumber = wynik.ToString().ElementAt(dlugosc);
            }
            catch(Exception ex) {
                Wyswietl.Text = "Nieprawidłowa ilość liczb";
            }
               

            
        }
    }
}
