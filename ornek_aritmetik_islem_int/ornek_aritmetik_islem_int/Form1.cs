using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ornek_aritmetik_islem_int
{
    public partial class Form1 : Form
    {
        private void button5_Click(object sender, EventArgs e)
        {
            int deger1, deger2, topla, cikar, carp, bol;
            deger1 = Convert.ToInt16(textBox3.Text);
            deger2 = Convert.ToInt16(textBox4.Text);
            topla = (deger1 + deger2);
            cikar = (deger1 - deger2);
            carp = (deger1 * deger2);
            bol = (deger1 / deger2);
            //label9.Text = "Topla" + topla + "Çıkart" + cikar + "Çarp" + carp + "Böl" + bol;
            MessageBox.Show("Toplam:" + topla + "\n" + "Çıkart:" + cikar + "\n" + "Çarpma:" + carp + "\n" + "Bölme:" + bol);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, toplam;
            sayi1 = Convert.ToInt16(textBox1.Text);
            sayi2 = Convert.ToInt16(textBox2.Text);
            toplam = (sayi1 + sayi2);
            label3.Text = toplam.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, cikar;
            sayi1 = Convert.ToInt16(textBox1.Text);
            sayi2 = Convert.ToInt16(textBox2.Text);
            cikar = (sayi1 - sayi2);
            label4.Text = cikar.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, carpma;
            sayi1 = Convert.ToInt16(textBox1.Text);
            sayi2 = Convert.ToInt16(textBox2.Text);
            carpma = (sayi1 * sayi2);
            label5.Text = carpma.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, bolme;
            sayi1 = Convert.ToInt16(textBox1.Text);
            sayi2 = Convert.ToInt16(textBox2.Text);
            bolme = (sayi1 / sayi2);
            label6.Text = bolme.ToString();

        }











    }
}

