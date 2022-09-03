using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Return_metot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // private int Toplam()

        int Toplam(int s1, int s2)
        {
            int s3 = s1 + s2;
            return s3;
        }

        int Carpim(int sa1, int sa2, int sa3)
        {
            int sonuc = sa1 * sa2 * sa3;
            return sonuc;
        }


        int Kup(int sayi)
        {
            int deger = sayi * sayi * sayi;
            return deger;
        }

        int KlavyeToplam(int deger1 , int deger2)
        {
            int Ktoplam =deger1+deger2;
            return Ktoplam;
        }

        int KlavyeCarpim(int dgr1, int dgr2, int dgr3)
        {
            int Kcarp = dgr1 * dgr2 * dgr3;
            return Kcarp;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = Toplam(4, 6).ToString();
            label2.Text = Toplam(2, 3).ToString();
            label3.Text = Toplam(4, 8).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label4.Text = Carpim(4, 8, 2).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt16(textBox1.Text);
            label7.Text = Kup(sayi).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int deger1 = Convert.ToInt16(textBox2.Text);
            int deger2 = Convert.ToInt16(textBox3.Text);

            label8.Text = KlavyeToplam(deger1,deger2).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt16(textBox4.Text);
            int b = Convert.ToInt16(textBox5.Text);
            int c = Convert.ToInt16(textBox6.Text);

            label9.Text = KlavyeCarpim(a,b,c).ToString();
        }
    }
}