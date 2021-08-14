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
using System.Text.RegularExpressions;

namespace GUIminre
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String input = inputTB.Text;
            File.WriteAllText(@"D:\Projects\virenv\Chatbot_template\Input.txt", input);
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
            process.StandardInput.WriteLine("cd D:/Projects/virenv/Chatbot_template");
            process.StandardInput.WriteLine("chatbot_implement_IO.py");
            process.StandardInput.Flush();
            process.StandardInput.Close();
            process.WaitForExit();
            Console.WriteLine(process.StandardOutput.ReadToEnd());
            Console.Read();
            //CMD_end

            //File.WriteAllText(@"D:\Projects\virenv\Sales_proce_est\scores.txt","");
            string output = File.ReadAllText(@"D:\Projects\virenv\Chatbot_template\Output.txt");

            output = Regex.Replace(output, "(.{50})", "$1\n");
            outputLbl.Text = output;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 B = new Form4();
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
