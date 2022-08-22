using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace extra_3_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //global alnada enum yapısını oluşturalım.
        enum sehirler { X, Adana, Adıyaman, Ağrı, Afyon, Amasya, Ankara, Antalya, Artvin }

        private void button1_Click(object sender, EventArgs e)
        {
            //veri alınsın.
            int plaka = Convert.ToInt16(textBox1.Text);
            sehirler s = (sehirler)plaka;                   //sehirler in plakanıncı değeri
            label1.Text = s.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //abs= mutlak ceil=üste yuvarlar floor=alta yuvarlar pow=üs al sqrt=kök alma
            double sayi = Convert.ToDouble(textBox2.Text);
            label3.Text = Math.Abs(sayi).ToString();
            label3.Text = Math.Ceiling(sayi).ToString();
            label3.Text = Math.Floor(sayi).ToString();
            label3.Text = Math.Pow(sayi, 2).ToString();
            label3.Text = Math.Sqrt(sayi).ToString();
            label3.Text = Math.Cos(sayi).ToString();
            //label3.Text = Math.PI.ToString();
            //label3.Text = Math.Min(10,2).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button btn = new Button();
            Point btnkonum = new Point(20, 10);
            btn.Location = btnkonum;
            btn.Name = "Button3";
            btn.Text = "Tıkla";
            btn.BackColor = Color.Green;
            btn.Height = 50;
            btn.Width = 75;

            Label lbl = new Label();
            Point lblkonum = new Point(115, 25);
            lbl.Location = lblkonum;
            lbl.Name = "Label3";
            lbl.Text = "Merhaba";
            lbl.BackColor = Color.Aquamarine;
            //lbl autosize değişsin. otomatik boyutlansın bizim Text yazısı boyutuna göre.
            lbl.AutoSize = true;


            for (int i = 1; i <= 5; i++)
            {
                TextBox txt = new TextBox();
                Point txtkonum = new Point(350, i * 30);
                txt.Location = txtkonum;
                txt.Name = "TextBox" + i;
                txt.Text = i.ToString();
                this.Controls.Add(txt);

            }
            //bu altta olursa butonun arkasında kalır yazılar.
            this.Controls.Add(lbl);
            this.Controls.Add(btn);
        }
    }
}