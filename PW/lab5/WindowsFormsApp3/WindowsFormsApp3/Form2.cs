using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {

        MySqlConnection connection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=komis;");

        public Form2()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO samochody (id, marka, model, pojemnosc, kolor, cena) VALUES('" + "NULL"  + "','" + model.Text + "','" + nazwa.Text + "','" + silnik.Text + "','" + kolor.Text + "','" + cena.Text + "');";
            connection.Open();
            MySqlCommand command = new MySqlCommand(insertQuery, connection);

            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Data Inserted");
                }
                else
                {
                    MessageBox.Show("Data Not Inserted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            connection.Close();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
