using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diziler_eleman_listele
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // dizinin tüm elemanlarını tek tek listboxa döngüyle yazdır.

            string[] sehirler = {"hatay","ankara","sivas","çanakkale","giresun"};
            for (int i=0; i<sehirler.Length;i++)
            {
                listBox1.Items.Add(sehirler[i]);
            }
            
            // dizideki çift sayı elemanlarını yazdır.

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] sayilar = {5,6,8,9,12,3,2,7};
            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i] % 2 == 0)
                {
                    listBox2.Items.Add(sayilar[i]);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] sayilar = {8,10,7,4,5,9,19,1,14,22};
            for (int i=0; i<sayilar.Length; i++)
            {
                if (sayilar[i] % 2 == 0 && sayilar[i] >= 10) 
                {
                    listBox3.Items.Add(sayilar[i]);
                }
                
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string[] kisiler = {"Ali","Ahmet","Mehmet","Mesut","Pınar","Berna"};
            foreach (string k in kisiler)
            {
                listBox4.Items.Add(k);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            int[] notlar = {85,70,15,30,91,100};

            foreach (int n in notlar)
            {
                listBox5.Items.Add(n);
                toplam += n;   
            }
            label1.Text = toplam.ToString();
            int ortalama = (toplam/notlar.Length);
            label2.Text = ortalama.ToString();
        }
    }
}