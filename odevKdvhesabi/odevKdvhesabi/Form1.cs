using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odevKdvhesabi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string isim;
            double ucret, kdv_8,yeni_fiyat;
            isim =textBox1.Text;
            ucret = Convert.ToDouble(textBox2.Text);
            kdv_8 =(ucret*0.08);
            yeni_fiyat = (ucret + kdv_8);

            listBox1.Items.Add(isim+" "+ucret+" "+"%8 KDV'lik tutar: "+yeni_fiyat);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string isim;
            double ucret, kdv_18,yeni_fiyat;
            isim = textBox1.Text;
            ucret = Convert.ToDouble(textBox2.Text);
            kdv_18 = (ucret*0.18);
            yeni_fiyat = (ucret + kdv_18);
            listBox1.Items.Add(isim+" "+ucret+" "+ "%18 KDV'lik tutar: "+yeni_fiyat);
        }
    }
}
