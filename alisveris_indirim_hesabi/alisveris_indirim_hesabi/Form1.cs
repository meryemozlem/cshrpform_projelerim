using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alisveris_indirim_hesabi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int adet;
            double toplam;
            adet = Convert.ToInt16(textBox1.Text);

            if (adet >= 0 && adet <= 20)
            {
                toplam =(adet*8)-(adet*8*0.20);
                label3.Text =toplam+" TL";
            }

            if (adet >= 21 && adet <= 40)
            {
                toplam = (adet * 8) - (adet * 8 * 0.40);
                label3.Text = toplam + " TL";
            }

            if (adet >= 41 && adet<=60)
            {
                toplam = (adet * 8) - (adet * 8 * 0.50);
                label3.Text = toplam + " TL";
            }

            if (adet >= 61)
            {
                toplam = (adet * 8) - (adet * 8 * 0.70);
                label3.Text = toplam + " TL";
            }
        }
    }
}
