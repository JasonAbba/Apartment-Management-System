using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace pythonExecuter
{
    public partial class Form1 : Form
    {
        string filePath = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
        public void openB_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "D:\\Projects\\Mini project\\Facial Recognition\\facerecog-20201008T095030Z-001\\facerecog\\minifacerecogfldr";
                openFileDialog.Filter = "Python Files (*.py)|*.py|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    Console.WriteLine("res: " + filePath);                   
                }
            }

        }

        private void runB_Click(object sender, EventArgs e)
        {
            //C:\Users\JasonPC\AppData\Local\Programs\Python\Python37-32\python.exe
            Process p = new Process();
            p.StartInfo = new ProcessStartInfo(@"D:\Projects\facerec\fr\Scripts\python.exe", "D:/Projects/facerec/minifacerecogfldr/minifacerecog.py")
            {
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = false
            };
            p.Start();

            string output = p.StandardOutput.ReadToEnd();
            p.WaitForExit();

            Console.WriteLine(output);
            opLabel.Text = output;

            Console.ReadLine();
        }
    }
}
