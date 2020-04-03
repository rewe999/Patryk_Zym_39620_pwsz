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
    public partial class Form3 : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=komis;");
        public Form3()
        {
            InitializeComponent();
        }

        private void del_Click(object sender, EventArgs e)
        {
            string insertQuery = "DELETE FROM `samochody` WHERE `samochody`.`id` = "+ id.Text+"";
            connection.Open();
            MySqlCommand command = new MySqlCommand(insertQuery, connection);

            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Data Deleted");
                }
                else
                {
                    MessageBox.Show("Data Not Deleted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            connection.Close();
        }
    }
}
