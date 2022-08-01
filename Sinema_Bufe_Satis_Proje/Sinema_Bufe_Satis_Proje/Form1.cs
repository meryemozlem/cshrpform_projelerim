using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Bufe_Satis_Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Global alan
        //Burada tanımlandığı için döngüye girebilecek.
        int kasaTutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int misir, su, cay, kola, bilet, toplam;
            misir = Convert.ToInt16(TxtMisir.Text);
            su = Convert.ToInt16(TxtSu.Text);
            cay = Convert.ToInt16(TxtCay.Text);
            kola = Convert.ToInt16(TxtKola.Text);
            bilet = Convert.ToInt16(TxtBilet.Text);
            toplam = (misir*15+su*5+cay*3+kola*5+bilet*20);
            LblToplam.Text =toplam.ToString() + " TL";
            //kasaTutar = kasaTutar + toplam;
            //kasa değişkenine eklemek
            kasaTutar += toplam;
            LblKasa.Text = kasaTutar.ToString() + " TL";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //TextBox1... kafa karışıklığı oluşturduğu için design name kısmından yeniden isimlendirdik.TxtMisir
            TxtMisir.Text = ""; //"" olsaydı 1 satır mavi boşluk bırakırdı.
            TxtSu.Text = "";//temizleme işlemi
            TxtCay.Text = " ";
            TxtKola.Text = " ";
            TxtBilet.Text =" ";
            //textboxları temizler ve imleci yeniden misira atar.
            TxtMisir.Focus();

        }
    }
}
