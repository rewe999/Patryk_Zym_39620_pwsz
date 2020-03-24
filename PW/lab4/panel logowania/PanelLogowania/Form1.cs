using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PanelLogowania
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Form2 f = new Form2();

        private void Submit_Click(object sender, EventArgs e)
        {
            string Log = login.Text;
            string Has = haslo.Text;

            bool validacja=false;

            string[] loginy = new string[2];
            loginy[0] = "adam123";
            loginy[1] = "Kasia234";

            string[] hasla = new string[2];
            hasla[0] = "adam321";
            hasla[1] = "Kasia432";


            for (int i = 0; i < 2; i++) {
                if (Log == loginy[i] && Has == hasla[i]) {
                    validacja = true;
                    
                    f.login = loginy[i];
                }
                else {
                    error.Visible = true;
                }
            }

            if (validacja == true) {
                error.Visible = false;
                f.Show();
            }
        }

        

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
