using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUImin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.ForeColor = Color.FromArgb(this.BackColor.R, this.BackColor.G, this.BackColor.B);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        int[] targetColor = { 232, 232, 232 };
        int[] fadeRGB = new int[3];
        private void timer1_Tick(object sender, EventArgs e)
        {
            fadeIn();
        }

        //fadeouttemplate
        void fadeOut()
        {
            fadeRGB[0] = label1.ForeColor.R;
            fadeRGB[1] = label1.ForeColor.G;
            fadeRGB[2] = label1.ForeColor.B;


            if (fadeRGB[0] > this.BackColor.R)
                fadeRGB[0]--;
            else if(fadeRGB[0] < this.BackColor.R)
                    fadeRGB[0]++;


            if (fadeRGB[1] > this.BackColor.G)
                fadeRGB[1]--;
            else if (fadeRGB[1] < this.BackColor.G)
                fadeRGB[1]++;


            if (fadeRGB[2] > this.BackColor.B)
                fadeRGB[2]--;
            else if (fadeRGB[2] < this.BackColor.B)
                fadeRGB[2]++;


            if (fadeRGB[0] == this.BackColor.R && fadeRGB[1] == this.BackColor.G && fadeRGB[2] == this.BackColor.B)
                timer1.Stop();

            label1.ForeColor = Color.FromArgb(fadeRGB[0], fadeRGB[1], fadeRGB[2]);
        }

        //fadein template

        void fadeIn()
        {
            fadeRGB[0] = label1.ForeColor.R;
            fadeRGB[1] = label1.ForeColor.G;
            fadeRGB[2] = label1.ForeColor.B;


            if (fadeRGB[0] > targetColor[0])
                fadeRGB[0]--;
            else if (fadeRGB[0] < targetColor[0])
                fadeRGB[0]++;


            if (fadeRGB[1] > targetColor[1])
                fadeRGB[1]--;
            else if (fadeRGB[1] < targetColor[1])
                fadeRGB[1]++;


            if (fadeRGB[2] > targetColor[2])
                fadeRGB[2]--;
            else if (fadeRGB[2] < targetColor[2])
                fadeRGB[2]++;


            if (fadeRGB[0] == targetColor[0] && fadeRGB[1] == targetColor[1] && fadeRGB[2] == targetColor[2])
                timer1.Stop();

            label1.ForeColor = Color.FromArgb(fadeRGB[0], fadeRGB[1], fadeRGB[2]);
        }
    }
}
