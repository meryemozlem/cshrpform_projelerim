using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinif_Ornek
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Araba rb_2 = new Araba();
            rb_2.renk = "Yeşil";
            rb_2.hiz = 140;
            rb_2.motor = 1220.36;
            rb_2.durum = 'İ';
            rb_2.fiyat =35850;

            rb_2.YIL = -2016;
            rb_2.MARKA = "Golf";

            rb_2.muayene = 2022;
            rb_2.plaka ="34 RTZ 445";
            rb_2.sahip ="Didem ÇAĞLAR";

            label10.Text = rb_2.renk;
            label9.Text = rb_2.hiz.ToString();
            label8.Text = rb_2.motor.ToString();
            label7.Text = rb_2.durum.ToString();
            label6.Text = rb_2.fiyat.ToString();
            pictureBox1.BackColor = Color.Green;


            label12.Text = rb_2.YIL.ToString();
            label14.Text = rb_2.MARKA;

            label15.Text = rb_2.muayene.ToString();
            label16.Text = rb_2.plaka;
            label17.Text =rb_2.sahip;

        }
    }
}
