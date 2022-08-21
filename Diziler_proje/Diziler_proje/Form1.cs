using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diziler_proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*string[] kisiler = {"Ali","Ayşe","Fatma","Saliha","Hayriye","Betül","Olcay"};
            label1.Text=kisiler[4];
            */

            int[] sayilar = {5,4,3,2,1,100,95,89};
            //label1.Text=sayilar[0].ToString();
            label1.Text = Convert.ToString(sayilar[5]);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            double[] list = {5.5,6.8,7.3,8.8,9.2};
            label2.Text = list[3].ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            char[] karakterler = {'a','b','z','t','k','b','y','s','k','o'};
            label3.Text = karakterler[2].ToString();
        }
    }
}
