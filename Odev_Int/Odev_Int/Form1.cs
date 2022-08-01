using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev_Int
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int vize, final, but, ortalama;
            vize = 50;
            final = 90;
            but = 85;
            ortalama = (vize + final + but) / 3;
            label1.Text="Ortalama:" + ortalama;
            //label1.Text = ortalama.ToString();
        }
    }
}
