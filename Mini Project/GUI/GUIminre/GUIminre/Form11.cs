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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        MySqlConnection connection = new MySqlConnection("datasource=127.0.0.1;port=3307;username=root;password=;database=apartmentdb");
        MySqlConnection connection1 = new MySqlConnection("datasource=127.0.0.1;port=3307;username=root;password=;database=apartmentdb");
        MySqlConnection connection2 = new MySqlConnection("datasource=127.0.0.1;port=3307;username=root;password=;database=apartmentdb");
        MySqlConnection connection3 = new MySqlConnection("datasource=127.0.0.1;port=3307;username=root;password=;database=apartmentdb");
        MySqlConnection connection4 = new MySqlConnection("datasource=127.0.0.1;port=3307;username=root;password=;database=apartmentdb");

        private void button1_Click(object sender, EventArgs e)
        {
            
        }


        private void button2_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            //ListViewItem it1 = new ListViewItem();
            //listView1.Items.Add(it1);

            String query = "SELECT* FROM resident";
            MySqlCommand commandDatabase = new MySqlCommand(query, connection2);
            commandDatabase.CommandTimeout = 60;

            try
            {
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

                        listView2.Items.Add(it);
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

            connection2.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Reading previous index for updation. Index updated and stored in ci variable. Uses "connection1".
            connection1.Open();
            int ci = 0;
            MySqlCommand command1 = new MySqlCommand("SELECT * FROM resident", connection1);
            MySqlDataReader myReader = command1.ExecuteReader();
            if (myReader.HasRows)
            {
                while (myReader.Read())
                {
                    //force Reader to read all values
                }
                ci = Convert.ToInt32(myReader.GetString(0));
                ci = ++ci;
                Console.WriteLine(ci);
            }
            connection1.Close();

            //"connection1" is closed

            //Insertion Code. Uses "connection"
            String gender = "Male";
            if (femaleRB.Checked)
            {
                gender = "Female";
            }
            long ph = Convert.ToInt64(phTB.Text);
            string insertQuery = "INSERT INTO resident VALUES('" + ci + "','" + fnTB.Text + "','" + lnTB.Text + "','" + gender + "','" + flatTB.Text + "','" + ph + "','" + emailTB.Text + "');";
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
            //"connection" closed.



            showlv();

            fnTB.Clear();
            lnTB.Clear();
            flatTB.Clear();
            phTB.Clear();
            emailTB.Clear();
            maleRB.Checked = false;
            femaleRB.Checked = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string delQuery = "DELETE FROM resident WHERE R_ID = @ID";
            MySqlCommand delcmd = new MySqlCommand(delQuery, connection3);
            delcmd.Parameters.AddWithValue("@ID", listView2.SelectedItems[0].Text);


            connection3.Open();
            try
            {
                delcmd.ExecuteNonQuery();
            }
            catch (Exception e2)
            {
                MessageBox.Show("Query not executed" + e2.Message);
            }
            connection3.Close();

            showlv();
        }

        private void showlv()
        {
            //_____________________________________________
            listView2.Items.Clear();
            String query = "SELECT* FROM resident";
            MySqlCommand commandDatabase = new MySqlCommand(query, connection4);
            connection4.Open();
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

                    listView2.Items.Add(it);
                    Console.WriteLine(myReader.GetString(0) + "-" + myReader.GetString(1) + "-" + myReader.GetString(2) + "-" + myReader.GetString(3) + "-" + myReader.GetString(4) + "-" + myReader.GetString(5) + "-" + myReader.GetString(6));
                }
            }

            else
            {
                MessageBox.Show("Query executed");
            }
            connection4.Close();
            //___________________________

        }

        private void button9_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            overview B = new overview();
            B.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 B = new Form3();
            B.Show();
        }
    }
}
