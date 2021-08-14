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
    public partial class MngtFaceRec : Form
    {
        public MngtFaceRec()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            {
                Process p = new Process();
                p.StartInfo = new ProcessStartInfo(@"D:\Projects\facerec\fr\Scripts\python.exe", "D:/Projects/facerec/minifacerecogfldr/minifacerecog.py")
                {
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };
                p.Start();

                p.WaitForExit();
                string output = p.StandardOutput.ReadToEnd();

                string res = output.Replace("\n", "").Replace("\r", "");

                opLabel.Text = "Hi " + output;

                if (res.ToLower() == "deepak")
                {
                    button2.Enabled = true;
                    button2.BackColor = Color.FromArgb(2, 127, 155);
                    button2.ForeColor = Color.White;
                    button1.Enabled = false;
                    button1.BackColor = Color.LightGray;
                    button1.ForeColor = Color.White;
                }

                Console.ReadLine();
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 A = new Form5();
            A.Show();
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
        
        MySqlConnection connection = new MySqlConnection("datasource=127.0.0.1;port=3307;username=root;password=;database=apartmentdb");
        private void button5_Click(object sender, EventArgs e)
        {
            String username = unTB.Text;
            String pass = pwTB.Text;

            connection.Open();
            //MySqlCommand command1 = new MySqlCommand("SELECT FROM FROM R_TD WHERE UN =" + username + "AND PW = " + pass + ";", connection);
            string query = "SELECT * FROM mngt_login WHERE UN ='" + username.Trim() + "'AND PW = '" + pass.Trim() + "';";
            MySqlDataAdapter sda = new MySqlDataAdapter(query, connection);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            Console.WriteLine(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                button2.Enabled = true;
                button2.BackColor = Color.FromArgb(185, 5, 4);
                button2.ForeColor = Color.White;
                button5.Enabled = false;
                button5.BackColor = Color.LightGray;
                button5.ForeColor = Color.White;
                button1.Enabled = false;
                button1.BackColor = Color.LightGray;
                button1.ForeColor = Color.White;
            }

            else
            {
                MessageBox.Show("Check username and password");
                connection.Close();
            }
        }
    }
}
