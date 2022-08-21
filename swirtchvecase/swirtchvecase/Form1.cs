using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace swirtchvecase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ay = Convert.ToInt16(textBox1.Text);//int = int
            switch (ay)
            {
                case 1:
                    //Console.WriteLine("Ocak");
                    label2.Text = "Ocak";
                    break;
                case 2:
                    label2.Text = "Şubat";
                    break;
                case 3:
                    label2.Text = "Mart";
                    break;
                case 4:
                    label2.Text ="Nisan";
                    break;
                case 5:
                    label2.Text ="Mayıs";
                    break;
                case 6:
                    label2.Text = "Haziran";
                    break;
                case 7:
                    label2.Text = "Temmuz";
                    break;
                case 8:
                    label2.Text = "Ağustos";
                    break;
                case 9:
                    label2.Text = "Eylül";
                    break;
                case 10:
                    label2.Text = "Ekim";
                    break;
                case 11:
                    label2.Text = "Kasım";
                    break;
                case 12:
                    label2.Text = "Aralık";
                    break;
                default: label2.Text = "Hatalı Ay girişi"; break;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string mevsim = textBox2.Text;
            switch(mevsim)
            {
                case "ilkbahar": textBox3.Text = "Mart, Nisan ve Mayıs"; 
                    break;
                case "yaz": textBox3.Text = "Haziran, Temmuz ve Ağustos"; 
                    break;
                case "sonbahar": textBox3.Text = "Eylül, Ekim ve Kasım"; 
                    break;
                case "kış": textBox3.Text = "Aralık, Ocak, Şubat"; 
                    break;
                default: textBox3.Text = "Yanlış mevsim girdin";
                    break;
            }
                 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sonuc;
            string islem=textBox6.Text;
            sayi1 = Convert.ToInt16(textBox4.Text);
            sayi2 = Convert.ToInt16(textBox5.Text);
            switch (islem)
            {
                //sonuc = Convert.ToInt16(label8.Text);
                case "+": sonuc = (sayi1 + sayi2); label8.Text = sonuc.ToString(); 
                    break;
                case "-": sonuc = (sayi1 - sayi2); label8.Text = sonuc.ToString(); 
                    break;
                case "*": sonuc = (sayi1 * sayi2); label8.Text = sonuc.ToString(); 
                    break;
                case "/": sonuc = (sayi1 / sayi2); label8.Text = sonuc.ToString(); 
                    break;

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sayi_1, sayi_2,cikti;
            sayi_1=Convert.ToInt16(textBox7.Text);
            sayi_2=Convert.ToInt16(textBox8.Text);
            string islemim=comboBox1.Text;
            switch (islemim)
            {
                case "+":
                    cikti = (sayi_1 + sayi_2);          label13.Text = cikti.ToString();
                    //label13.Text =(sayi_1+sayi_2).ToString();
                    break;
                case "-":
                    cikti = (sayi_1 - sayi_2); label13.Text = cikti.ToString();
                    break;
                case "*":
                    cikti = (sayi_1 * sayi_2); label13.Text = cikti.ToString();
                    break;
                case "/":
                    cikti = (sayi_1 / sayi_2); label13.Text = cikti.ToString();
                    break;
                default:
                    label13.Text = "Hatalı değer girdiniz.";
                    break;

            }


        }
    }
}