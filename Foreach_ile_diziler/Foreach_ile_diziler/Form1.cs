using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foreach_ile_diziler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int toplam = 0; // tüm dizi elemanları toplamı
            int adet = 0; // 4'e bölünene kaç sayı var
                          // 4'e bölünenlerin ort. = ?

            int[] sayilar = { 5, 7, 10, 12, 8, 20, 33, 6, 45, 110 };
            foreach (int s in sayilar)
            {

                listBox1.Items.Add(s);
                toplam += s;
                if (s % 4 == 0)
                {
                    listBox2.Items.Add(s);
                    adet++;
                }


            }
            int ortalama = (toplam / sayilar.Length); // tüm sayıların ortalaması.
            label3.Text = toplam.ToString();
            label6.Text = adet.ToString();
            label8.Text = ortalama.ToString();
        }
    }
}