using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bmr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            if ((Wzrost.Text != "") && (Masa.Text != "") && (Wiek.Text != ""))
            {
                Wynik.ForeColor = Color.Black;
                double masa = Convert.ToDouble(Masa.Text);
                double wzrost = Convert.ToDouble(Wzrost.Text);
                int wiek = Convert.ToInt32(Wiek.Text);
                double wynik;


                if (MezczyznaPlec.Checked == true)
                {
                    wynik = (9.99 * masa) + (6.26 * wzrost) + (4.92 * wiek) + 5;
                    Wynik.Text = wynik.ToString();
                }

                if (KobietaPlec.Checked == true)
                {
                    wynik = (9.99 * masa) + (6.26 * wzrost) + (4.92 * wiek) - 161;
                    Wynik.Text = wynik.ToString();
                }

            }
            else
            {
                Wynik.ForeColor = Color.Red;
                Wynik.Text = "Brak Danych!";
            }

        }


        private void Reset_Click(object sender, EventArgs e)
        {
            foreach (var item in this.Controls)
            {
                if (item.GetType().Equals(typeof(TextBox)))
                {
                    TextBox t1 = item as TextBox;
                    t1.Text = string.Empty;
                }
            }
        }
    }
}
