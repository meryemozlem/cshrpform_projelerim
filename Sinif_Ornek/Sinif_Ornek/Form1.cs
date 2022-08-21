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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Araba sınıfı içinden nesneler türet.
            Araba rb = new Araba();
            rb.renk = "Kırmızı";
            rb.hiz = 160;
            rb.motor = 1245.56;
            rb.durum = 'S';
            rb.fiyat = 50000;

            rb.YIL = -2016;
            rb.MARKA ="Golf";

            //kalıtım sayesinde rb. kullanrak diğer sınıf verilerine eriştik.
            rb.muayene = 2017;
            rb.plaka = "06 TC 657";
            rb.sahip ="Meryem Özlem AYDOĞAN";

            label10.Text = rb.renk;
            label9.Text = rb.hiz.ToString();
            label8.Text = rb.motor.ToString();
            label7.Text = rb.durum.ToString();
            label6.Text = rb.fiyat.ToString();
            pictureBox1.BackColor = Color.Red;


            label12.Text = rb.YIL.ToString();
            label14.Text = rb.MARKA;

            label15.Text =rb.muayene.ToString();
            label16.Text =rb.plaka;
            label17.Text =rb.sahip;

        }
    }
}
