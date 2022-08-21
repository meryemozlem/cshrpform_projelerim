using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace karar_yapilari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad=textBox1.Text;
            if (ad == "ali")
            {
                MessageBox.Show("Hoş geldin " + ad);
                //label2.Text="Hoş geldin" + ad;
                //label2.Text="doğru";
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı, tekrar deneyiniz.");
                //label2.Text = "Hatalı kullanıcı, tekrar deneyiniz.";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt16(textBox2.Text);
            if (sayi == 5)
            {
                MessageBox.Show("Doğru");
            }
            else 
            {
                MessageBox.Show("Yanlış");
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int deger = Convert.ToInt16(textBox3.Text);
            if (deger % 2 == 0)
            {
                MessageBox.Show("Tam bölünür.Yani çift sayı.");
                label4.Text ="Çift";
            }
            else 
            {
                MessageBox.Show("Tam bölünmez.Yani tek sayı.");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sayi2 = Convert.ToInt16(textBox4.Text);
            if (sayi2 >= 10 && sayi2 % 2 == 0)
            {
                label6.Text ="10 dan büyük ve çift sayıdır.";
                //label6.Text = "Doğru tercih";
                //MessageBox.Show("10 dan büyük ve çift sayıdır.");
            }
            else
            {
                label6.Text = "10 dan küçük ya da Tek sayı";
                //label6.Text ="Yanlış tercih";
                //MessageBox.Show("10 dan küçük ya da Tek sayı");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int sayi3 = Convert.ToInt16(textBox5.Text);
            if (sayi3%2==0 || sayi3>=10)
            {
                MessageBox.Show("Sayı 10 dan büyük veya çift");
            }
            else 
            {
                MessageBox.Show("Sayı 10 dan küçük ve tek");
            }
        }
    }
}