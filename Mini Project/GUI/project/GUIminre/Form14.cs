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

namespace GUIminre
{
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        MySqlConnection connection = new MySqlConnection("datasource=127.0.0.1;port=3307;username=root;password=;database=apartmentdb");
        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            //ListViewItem it1 = new ListViewItem();
            //listView1.Items.Add(it1);

            String query = "SELECT* FROM resident";
            MySqlCommand commandDatabase = new MySqlCommand(query, connection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                connection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                if (myReader.HasRows)
                {
                    MessageBox.Show("Query result in console");
                    while (myReader.Read())
                    {
                        ListViewItem it = new ListViewItem(myReader.GetString(0));
                        it.SubItems.Add(myReader.GetString(1));
                        it.SubItems.Add(myReader.GetString(2));
                        it.SubItems.Add(myReader.GetString(3));
                        it.SubItems.Add(myReader.GetString(4));
                        it.SubItems.Add(myReader.GetString(5));
                        it.SubItems.Add(myReader.GetString(6));

                        listView1.Items.Add(it);
                        Console.WriteLine(myReader.GetString(0) + "-" + myReader.GetString(1) + "-" + myReader.GetString(2) + "-" + myReader.GetString(3) + "-" + myReader.GetString(4) + "-" + myReader.GetString(5) + "-" + myReader.GetString(6));
                    }
                }

                else
                {
                    MessageBox.Show("Query executed");
                }

            }

            catch (Exception e1)
            {
                MessageBox.Show("Query not executed" + e1.Message);
            }

            connection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            overview B = new overview();
            B.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 B = new Form4();
            B.Show();
        }
    }
}
