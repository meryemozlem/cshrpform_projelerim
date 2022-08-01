using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ogrenci_not_hesabi_proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad, soyad,tc;
            int vize, final, but;
            double ort_;
            ad = textBox1.Text;
            soyad = textBox2.Text;
            vize = Convert.ToInt16(maskedTextBox1.Text);
            final = Convert.ToInt16(maskedTextBox2.Text);
            but = Convert.ToInt16(maskedTextBox3.Text);
            //ort_ = (vize+final+but)/3 ;
            ort_ =(vize)*0.8+(final)*0.2 + (but)*0.2;
            tc = maskedTextBox4.Text;
            //label8.Text = ort_.ToString("0.0000");
            listBox1.Items.Add(tc+" "+ad+" "+soyad+" "+"Ortalaması: "+ort_);
        }
    }
}
