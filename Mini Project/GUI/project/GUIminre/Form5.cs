using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIminre
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 A = new Form6();
            A.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 A = new Form7();
            A.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            overview B = new overview();
            B.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form13 B = new Form13();
            B.Show();
        }
    }
}
