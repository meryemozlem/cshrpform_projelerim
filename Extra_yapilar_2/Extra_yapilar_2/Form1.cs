using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Extra_yapilar_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Point konum = new Point();
            konum.X = 100;
            konum.Y = 228;
            pictureBox1.Location = konum;








            /* ASANSOR PROJE
             public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Point konum = new Point();
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "1";
            if (konum.Y < 303)
            {
                timer2.Start();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            konum.Y -= 1;
            pictureBox1.Location = konum;
            if (konum.Y == 198 && label1.Text == "2")
            {
                timer1.Stop();
            }
            if (konum.Y == 86 && label1.Text == "3")
            {
                timer1.Stop();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {   konum.Y = 303;
            konum.X = 12;
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            konum.Y += 1;
            pictureBox1.Location = konum;
            if (konum.Y == 303 && label1.Text == "1")
            {
                timer2.Stop();
            }
            if (konum.Y == 198 && label1.Text == "2")
            {
                timer2.Stop();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "2";
            if (konum.Y > 198)
            {
                timer1.Start();
            }
            if (konum.Y <= 86)
            {
                timer2.Start();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "3";
            if (konum.Y > 86)
            {
                timer1.Start();
            }
        }

    }       private void button1_Click(object sender, EventArgs e)

        {
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)

        {
            Random rnd = new Random();
            Point konum = new Point();
            konum.X = rnd.Next(0, 500);
            konum.Y = rnd.Next(0, 500);
            pictureBox1.Location = konum;
        }
            */
        }
    }
}
