using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev_String
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string adSoyad, yas, meslek, cinsiyet;
            adSoyad = textBox1.Text;
            yas = maskedTextBox1.Text;
            meslek = textBox2.Text;
            cinsiyet = comboBox1.Text;
            /*listBox1.Text = adSoyad;
            listBox1.Text=yas;
            listBox1.Text=meslek;
            listBox1.Text=cinsiyet;*/
            listBox1.Items.Add(adSoyad+" "+yas+" "+meslek+" "+cinsiyet);
        }
    }
}
