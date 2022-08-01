using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ınteger_degiskenler_klavyeden_veri_girisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            int sayi; //değişken tanımlanır.
            sayi = Convert.ToInt16(textBox1.Text); //int olan sayi değşkeni textboxa girilen değeri alacak. bu değer string. Ama benim değişkenim int bunu çevirdim.
            label2.Text = sayi.ToString();  //label2 ye yazdırmak için de str e çevirdim çünkü o alan str kabul ediyor.
            */



        }

        private void button2_Click(object sender, EventArgs e)
        {
            int deger,sonuc;
            deger = Convert.ToInt32(textBox2.Text);
            sonuc = (deger * deger * deger);
            label5.Text = sonuc.ToString();

        }
    }
}
