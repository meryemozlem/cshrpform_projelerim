using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Degiskenler_Int
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*int sayi = 36;
            label1.Text = sayi.ToString();*/

            /*int sayi1 = 10;
            int sayi2 = 90;
            label1.Text = (sayi1 + sayi2).ToString();*/

            /*int sayi1, sayi2, toplam;
            sayi1 = 10;
            sayi2 = 90;
            toplam = sayi1 + sayi2;
            label1.Text = toplam.ToString();*/

            int kenar, alan, cevre;
            kenar = 5;
            alan = (kenar * kenar);
            cevre = (kenar*4);
            label1.Text ="Alan:"+ alan +" Çevre"+ cevre;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int u_kenar, k_kenar, alan, cevre;
            u_kenar = 20;
            k_kenar = 10;
            alan = (u_kenar * k_kenar);
            cevre = 2 * (u_kenar + k_kenar);
            label2.Text = "Alan:" + alan + " Çevre:" + cevre;
        }
    }
}
