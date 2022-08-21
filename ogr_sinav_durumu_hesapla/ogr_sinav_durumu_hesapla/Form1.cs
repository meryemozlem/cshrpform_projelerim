using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ogr_sinav_durumu_hesapla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad, soyad;
            int vize, final, prj;
            double ort_;
            ad =textBox1.Text;
            soyad =textBox2.Text;

            vize =Convert.ToInt16(textBox3.Text);
            final = Convert.ToInt16(textBox4.Text);
            prj=Convert.ToInt16(textBox3.Text);
            ort_ =(vize+final+prj)/3;
            label6.Text = "Ortalama: " + ort_;

            if (ort_ >= 50)
            {
                //MessageBox.Show("Tebrikler,dersten geçtin!");
                listBox1.Items.Add(ad+" " +soyad+""+ort_);
            }
            else
            {
                //MessageBox.Show("Maalesef,dersten kadlın!");
                listBox1.Items.Add(ad + " " + soyad + "" + ort_);
            }

            /*
            int s1,s2,prj;
            double ort;
            string durum;
            s1=Convert.ToDouble(textBox1.Text);
            s2=;
            prj=;
            ort=(s1+s2+prj)/3;

            if(ort>=50)
            {
            durum="Geçti";
            }
            else
            {
            durum="kaldı";
            }
            textBox4.Text=ort.ToString("0.00")+"/"+durum;
             */
            
        }


    }
}
