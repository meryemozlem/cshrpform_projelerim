using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Extra_yapilar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Random sınıfından nesne türet.
            /*
            Random rnd = new Random ();
            int sayi1, sayi2, sayi3,sayi4,sayi5;
            sayi1 = rnd.Next(1,10);      //ilk değer dahil ikinci değer dahil değil.
            sayi2 = rnd.Next(1,5);
            sayi3 = rnd.Next(1,5);
            sayi4 = rnd.Next(1,10);
            sayi5 = rnd.Next(1,9);
            */

            //SAYISAL LOTO
            Random loto = new Random();
            int s1, s2, s3, s4, s5;
            s1 = loto.Next(1, 5);
            s2 = loto.Next(1, 5);
            s3 = loto.Next(1, 5);
            s4 = loto.Next(1, 5);
            s5 = loto.Next(1, 5);

            label1.Text = s1.ToString();
            label2.Text = s2.ToString();
            label3.Text = s3.ToString();
            label4.Text = s4.ToString();
            label5.Text = s5.ToString();
            
            //sayı1
            if (label1.Text == textBox1.Text)
            {
                textBox1.BackColor = Color.Green;
            }
            else
            {
                textBox1.BackColor = Color.Red;
            }
            //sayı2
            if (label2.Text == textBox2.Text)
            {
                textBox2.BackColor = Color.Green;
            }
            else
            {
                textBox2.BackColor = Color.Red;
            }
            //sayı3
            if (label3.Text == textBox3.Text)
            {
                textBox3.BackColor = Color.Green;
            }
            else
            {
                textBox3.BackColor = Color.Red;
            }
            //sayı4
            if (label4.Text == textBox4.Text)
            {
                textBox4.BackColor = Color.Green;
            }
            else
            {
                textBox4.BackColor = Color.Red;
            }
            //sayı5
            if (label5.Text == textBox5.Text)
            {
                textBox5.BackColor = Color.Green;
            }
            else
            {
                textBox5.BackColor = Color.Red;
            }


        }
    }
}