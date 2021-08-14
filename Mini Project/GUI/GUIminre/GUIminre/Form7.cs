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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        MySqlConnection connection = new MySqlConnection("datasource=127.0.0.1;port=3307;username=root;password=;database=apartmentdb");
        MySqlConnection connection1 = new MySqlConnection("datasource=127.0.0.1;port=3307;username=root;password=;database=apartmentdb");
        private void button2_Click(object sender, EventArgs e)
        {
            String name = NameTB.Text;
            int ph = Convert.ToInt32(phTB.Text);
            String num_vis = numTB.Text;
            String vis = tenantTB.Text;
            int flat = Convert.ToInt32(flatTB.Text);
            String lic= licTB.Text;
            int pa = Convert.ToInt32(AllocTB.Text);

            String parking = "0";
            if (yesRB.Checked)
            {
                parking = "1";
            }

            int vehicle = 0;
            if (yesRB.Checked)
            {
                if (twoRB.Checked)
                {
                    vehicle = 2;
                }

                else if (fourRB.Checked)
                {
                    vehicle = 4;
                }
            }


            //File.WriteAllText(@"D:\Projects\virenv\Sales_proce_est\scores.txt","");
            //string output = File.ReadAllText(@"D:\Projects\virenv\Chatbot_template\Output.txt");




            //SQL email retrieve
            //ListViewItem it1 = new ListViewItem();
            //listView1.Items.Add(it1);

            String query = "SELECT EMAIL FROM resident WHERE FLAT_NO = " + flat + "";
            String email_ret = "";
            MySqlCommand commandDatabase = new MySqlCommand(query, connection1);
            commandDatabase.CommandTimeout = 60;

            try
            {
                connection1.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                if (myReader.HasRows)
                {
                    MessageBox.Show("Query result in console");
                    while (myReader.Read())
                    {
                        email_ret =  myReader.GetString(0);
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

            connection1.Close();




            //SQL Entry
            //Reading previous index for updation. Index updated and stored in ci variable. Uses "connection1".

            //Insertion Code. Uses "connection"
            string insertQuery = "INSERT INTO `watchman_entry`(`Name`, `Ph_no`, `num_vis`, `res_name`, `flat_no`, `Park`, `Veh_type`, `Veh_lic`, `Park_num`) VALUES ('" + name + "','" + ph + "','" + num_vis + "','" + vis + "','" + flat  + "','" + parking + "','" + vehicle + "','" + lic + "','" + pa + "');";
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





            //SMTP EXEC
            String input = name;
            File.WriteAllText(@"D:\Projects\Mini project\smtp\Input.txt", input);
            File.WriteAllText(@"D:\Projects\Mini project\smtp\em.txt", email_ret);
            //CMD_Execution
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.Start();
            process.StandardInput.WriteLine("cd D:/Projects/virenv/test/Scripts");
            process.StandardInput.WriteLine("activate");
            process.StandardInput.WriteLine("cd D:/Projects/Mini project/smtp");
            process.StandardInput.WriteLine("smtp.py");
            process.StandardInput.Flush();
            process.StandardInput.Close();
            process.WaitForExit();
            Console.WriteLine(process.StandardOutput.ReadToEnd());
            Console.Read();
            //CMD_end
            //SMTP END

        }

        private void yesRB_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            licTB.Enabled = true;
            AllocTB.Enabled = true;
        }

        private void noRB_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            licTB.Enabled = false;
            AllocTB.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 B = new Form5();
            B.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            overview B = new overview();
            B.Show();
        }
    }
}
