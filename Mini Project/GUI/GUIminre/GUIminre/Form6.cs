using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIminre
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String furnish = "0";
            String scenery = "0";
            if (String.IsNullOrEmpty(furnishTB.Text) == false)
            {
                if (Convert.ToInt32(furnishTB.Text) <= 4 && Convert.ToInt32(furnishTB.Text) > 0)
                {
                    furnish = furnishTB.Text;
                }
            }
            else
            {
                furnishTB.Text = "0";
            }

            if (String.IsNullOrEmpty(SceneryTB.Text) == false)
            {
                if (Convert.ToInt32(SceneryTB.Text) <= 10 && Convert.ToInt32(SceneryTB.Text) > 0)
                {
                    scenery = SceneryTB.Text;
                }
            }

            else
            {
                SceneryTB.Text = "0";
            }

            String ac = "0";
            if (yaRB.Checked)
            {
                ac = "1";
            }

            String bathroom = "0";
            if (ybRB.Checked)
            {
                bathroom = "1";
            }

            File.WriteAllText(@"D:\Projects\virenv\Sales_proce_est\scores.txt", furnish +"\n" + ac + "\n" + scenery + "\n" + bathroom + Environment.NewLine);

            

            if (Convert.ToInt32(furnishTB.Text) <= 4 && Convert.ToInt32(furnishTB.Text) > 0)
            {
                if (Convert.ToInt32(SceneryTB.Text) <= 10 && Convert.ToInt32(SceneryTB.Text) > 0)
                {
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
                    process.StandardInput.WriteLine("cd D:/Projects/virenv/Sales_proce_est");
                    process.StandardInput.WriteLine("Sales_price_est.py");
                    process.StandardInput.Flush();
                    process.StandardInput.Close();
                    process.WaitForExit();
                    Console.WriteLine(process.StandardOutput.ReadToEnd());
                    Console.Read();
                    //CMD_end

                    //File.WriteAllText(@"D:\Projects\virenv\Sales_proce_est\scores.txt","");
                    string salesPrice = File.ReadAllText(@"D:\Projects\virenv\Sales_proce_est\prediction.txt");
                    spTB.Text = salesPrice;
                }
            }

            else 
            {
                spTB.Text = "Invalid input";
            }

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
