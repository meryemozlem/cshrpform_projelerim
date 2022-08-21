using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace while_dongusu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //5 kez merhaba dünya yazdır. while da yine 3 parametre tanımla.
            int i = 1;
            while (i<=5)
            {
                listBox1.Items.Add("Merhaba Dünya");
                i++; //olmazsa,sonsuz döngüye girer.
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //1-5 arasındaki sayıların toplamını bul.Yine 3 parametre etkili.başlangıç/bitiş/artış miktarı
            int i = 1;
            int toplam = 0;
            while (i<=5)
            {
                toplam += i;
                i++;
            }
            label2.Text =toplam.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //do while döngüsü ile 10 kez Merhaba Udemy yazdır.
            int i = 1; //18 olsa ve şartı sağlamasaydı bile yine de en az 1 kere yazardı.
            do
            {
                listBox2.Items.Add("Merhaba Udemy");
                i += 1;
            }
            while (i<=10); //normalde karar ve döngü sonlarına ; konmaz ama burada işlem sonlanıyor.

        }
    }
}