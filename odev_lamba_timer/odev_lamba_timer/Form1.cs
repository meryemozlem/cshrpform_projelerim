using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odev_lamba_timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sayac = 0; //burada olmasaydı döngü sonsuz olurdu.  Bu kapsam alanı dışında,global alanda.
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            label1.Text =sayac.ToString();

            if(sayac==50)
            {
                //sayaç 50 ye geldiğinde dursun. ve arka plan rengi değişsin.
                timer1.Stop();
                this.BackColor = Color.PeachPuff;
            }
        }
        //Rengi değişen arka plan animasyonu.

        int sayac_1 = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            sayac_1++;
            label2.Text =sayac_1.ToString();

            if (sayac_1 == 15)
            {
                this.BackColor = Color.Red;
            }

            if (sayac_1 == 30)
            {
                this.BackColor = Color.Green;
                sayac_1 = 0;
            }
        }

        int sayac_2 = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            timer3.Start();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            sayac_2++;
            label3.Text =sayac_2.ToString();

            if (sayac_2 == 30)
            {
                this.BackColor =Color.Red;
            }
            if (sayac_2 == 40)
            {
                this.BackColor = Color.Yellow;
            }
            if (sayac_2 == 70)
            {
                this.BackColor = Color.Green;
                sayac_2 = 0;
            }

        }
    }
}
