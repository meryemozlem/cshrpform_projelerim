using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace extra_Captcha
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //public string mesaj, gonderen, ozet;
        public string mesaj;
        public string gonderen;
        public string ozet;
        private void Form2_Load(object sender, EventArgs e)
        {
            //label1.Text = gonderen;
            //label2.Text = mesaj;
            comboBox1.Items.Add(gonderen+mesaj+ozet);
            /*comboBox1.Items.Add(gonderen);
            comboBox1.Items.Add(mesaj);
            comboBox1.Items.Add(ozet);*/
        }
    }
}
