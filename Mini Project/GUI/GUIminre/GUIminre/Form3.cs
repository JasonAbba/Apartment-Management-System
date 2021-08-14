using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIminre
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            overview B = new overview();
            B.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form11 B = new Form11();
            B.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form12 B = new Form12();
            B.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
