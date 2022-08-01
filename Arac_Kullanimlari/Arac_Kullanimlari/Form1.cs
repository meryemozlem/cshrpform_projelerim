using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arac_Kullanimlari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("MerhabaDünya");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text="Beril";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label6.Text = "Burcu";
            label7.Text = "Aslanoğlu";
            label8.Text = "Diş Hekimi";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "Bu bir deneme test yazısıdır. Bunu görüyorsan şanslısın. ";
            label9.Text = textBox1.Text;
        }
    }
}
