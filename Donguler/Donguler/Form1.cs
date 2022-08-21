using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Donguler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* 10 kez Merhaba Dünya yazdır ve başında kaçıncı oldukları yazsın.
             * 
                for (int i = 1; i <= 10; i++)
                {
                    listBox1.Items.Add(i+") Merhaba Dünya");
                }
            */

            //1 den 10 a kadar olan sayıları yazdıran program

            for (int i = 1; i < 11; i++) //i<=10 da olabilirdi.
            {
                listBox1.Items.Add(i);
            }

            /*
            for(int i=1; i<11; i+=2)
            {
                listBox1.Items.Add(i);
            }
            */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            for (int i = 1; i < 11; i++)
            {
                toplam += i;

            }
            label1.Text = "Son toplam:" + toplam;
            //label1.Text = toplam.ToString(); //label string içerir toplam ise int. " " olmadan yazsam hata verirdi.


        }

        private void button3_Click(object sender, EventArgs e)
        {
            //1 ve 10 arası çift sayıların toplamı
            int toplam = 0;
            for (int i = 2; i < 11; i += 2)
            {
                toplam += i;
            }
            label3.Text = toplam.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //[1,10] arasında 3'e tam bölünen sayıları listeleyen uygulama.

            for (int i=1; i<=10; i++)
            {
                if (i % 3 == 0)
                {
                    listBox2.Items.Add(i);

                }

            
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //[1,100] arası 5e ve 7ye tam bölünen sayıları listeleyen uygulama.
            for (int i = 1; i <= 100; i++)
            {
                if (i%5==0 && i%7==0)
                {
                    listBox3.Items.Add(i);
                }
            
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // 1'den Klavyeden girilen sayıya kadar olan değerleri listeleyen uygulama. 
            int sayi = Convert.ToInt16(textBox1.Text);
            for (int i = 1; i <= sayi; i++)
            {
                listBox4.Items.Add(i);
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            int sayi1 =Convert.ToInt16(textBox2.Text);
            for (int i=1; i<=sayi1; i++)
            {
                if (sayi1%i==0)
                {
                    listBox5.Items.Add(i);
                }
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Faktöriyel hesabı.
            int deger = Convert.ToInt16(textBox3.Text);
            int sonuc=1; //0!=1 1!=1
            for (int i=1; i<=deger; i++)
            {
               sonuc *= i;
            }
            textBox4.Text ="Fact: "+ sonuc;
        }
    }
}
