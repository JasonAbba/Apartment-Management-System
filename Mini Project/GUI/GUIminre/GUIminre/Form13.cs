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
using System.IO;
using MySql.Data.MySqlClient;

namespace GUIminre
{
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        MySqlConnection connection = new MySqlConnection("datasource=127.0.0.1;port=3307;username=root;password=;database=apartmentdb");
        MySqlConnection connection1 = new MySqlConnection("datasource=127.0.0.1;port=3307;username=root;password=;database=apartmentdb");
        MySqlConnection connection2 = new MySqlConnection("datasource=127.0.0.1;port=3307;username=root;password=;database=apartmentdb");

        private void button1_Click(object sender, EventArgs e)
        {
            {
                listView1.Items.Clear();
                //ListViewItem it1 = new ListViewItem();
                //listView1.Items.Add(it1);

                String query = "SELECT* FROM watchman_entry";
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
                            it.SubItems.Add(myReader.GetString(7));
                            it.SubItems.Add(myReader.GetString(8));
                            it.SubItems.Add(myReader.GetString(9));

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
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            overview B = new overview();
            B.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 B = new Form5();
            B.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string delQuery = "DELETE FROM watchman_entry WHERE sl_no = @Sl.no";
            MySqlCommand delcmd = new MySqlCommand(delQuery, connection1);
            delcmd.Parameters.AddWithValue("@Sl.no", listView1.SelectedItems[0].Text);


            connection1.Open();
            try
            {
                delcmd.ExecuteNonQuery();
            }
            catch (Exception e2)
            {
                MessageBox.Show("Query not executed" + e2.Message);
            }
            connection1.Close();

            showlv();
        }

        private void showlv()
        {
            //_____________________________________________
            listView1.Items.Clear();
            String query = "SELECT* FROM watchman_entry";
            MySqlCommand commandDatabase = new MySqlCommand(query, connection2);
            connection2.Open();
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
                    it.SubItems.Add(myReader.GetString(7));
                    it.SubItems.Add(myReader.GetString(8));
                    it.SubItems.Add(myReader.GetString(9));

                    listView1.Items.Add(it);
                    Console.WriteLine(myReader.GetString(0) + "-" + myReader.GetString(1) + "-" + myReader.GetString(2) + "-" + myReader.GetString(3) + "-" + myReader.GetString(4) + "-" + myReader.GetString(5) + "-" + myReader.GetString(6));
                }
            }

            else
            {
                MessageBox.Show("Query executed");
            }
            connection2.Close();
            //___________________________

        }

    }
}
