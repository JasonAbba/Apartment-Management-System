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


namespace GUIminre
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        MySqlConnection connection = new MySqlConnection("datasource=127.0.0.1;port=3307;username=root;password=;database=apartmentdb");
        private void button2_Click(object sender, EventArgs e)
        {
            String username = textBox1.Text;
            String pass = textBox2.Text;
            //if (textBox1.Text == "john")
            //{
                //if (textBox2.Text == "password")
               // {
                   // this.Hide();
                   // Form4 A = new Form4();
                   // A.Show();
                //}
            //}

                connection.Open();
                //MySqlCommand command1 = new MySqlCommand("SELECT FROM FROM R_TD WHERE UN =" + username + "AND PW = " + pass + ";", connection);
                string query = "SELECT * FROM resident_login WHERE UN ='" + username.Trim() + "'AND PW = '" + pass.Trim() + "';";
                MySqlDataAdapter sda = new MySqlDataAdapter(query, connection);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                Console.WriteLine(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                this.Hide();
                Form4 B = new Form4();
                B.Show();
            }

            else
            {
                MessageBox.Show("Check username and password");
                connection.Close();
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            overview B = new overview();
            B.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
