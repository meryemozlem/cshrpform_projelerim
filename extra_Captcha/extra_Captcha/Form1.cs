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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] sembol1 = { "a", "b", "c", "d", "e", "f", "g", "h" };
            string[] sembol2 = { "+", "-", "*", "/", "#", "@" };
            int sembol3 = 10;
            string[] sembol4 = { "S", "R", "K", "T", "C", "E", "M", "A", "B" };


            Random r = new Random();
            int s1, s2, s3, s4, s5;
            s1 = r.Next(0, sembol1.Length);
            s2 = r.Next(0, sembol2.Length);
            s3 = r.Next(0, sembol3);
            s4 = r.Next(0, sembol4.Length);
            s5 = r.Next(0, 23);

            label1.Text = sembol1[s1].ToString() + sembol2[s2].ToString() + s3.ToString() + sembol4[s4].ToString() + s5.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //diğer forma gidecek yapı
            Form2 fr = new Form2();
            fr.gonderen = textBox1.Text;
            fr.mesaj = textBox2.Text;
            fr.ozet = textBox3.Text;
            fr.Show();
            this.Hide();            //üstünde çalıştığımm formu arka plana ata.

        }
    }
}