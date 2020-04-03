using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=komis;";
            string query = "";

            if (radioButton5.Checked == true)  query = "SELECT * FROM `samochody` ORDER BY `samochody`.`id` ASC"; 
            if (radioButton4.Checked == true)  query = "SELECT * FROM `samochody` ORDER BY `samochody`.`marka` ASC";
            if (radioButton3.Checked == true)  query = "SELECT * FROM `samochody` ORDER BY `samochody`.`model` ASC";
            if (pojemnosc.Checked == true)     query = "SELECT * FROM `samochody` ORDER BY `samochody`.`kolor` ASC";
            if (radioButton1.Checked == true)  query = "SELECT * FROM `samochody` ORDER BY `samochody`.`cena` ASC";


            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();

                reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    MessageBox.Show("Udało się!");
                    while (reader.Read())
                    {

                        string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5) };
                        
                        ListViewItem item = new ListViewItem(row);
                        

                        listView1.Items.Add(item);

                    }
                }
                else
                {
                    MessageBox.Show("Brak rekordów!");
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        { }

       
    }
}
