using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu_strip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void maviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void griToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
        }

        private void turuncuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Orange;
        }

        private void pembeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Pink;
        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu proje Meryem Özlem Aydoğan tarafından oluşturulmuştur." , "Bilgi" ,MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void madMaxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=hEJnMQG9ev8");
            label1.Text ="Mad Max";
        }

        private void psILoveYouToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=b3BubMQtgJU");
            label1.Text = "psILoveYou";
        }

        private void aynıYıldızınAltındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=aQnlngjZG48");
            label1.Text = "aynıYıldızınAltında";
        }

        private void korkuSeansıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=wltrI-YZXrk");
            label1.Text = "korkuSeansı";
        }

        private void uzayYocularıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=8GKyQ1S5594");
            label1.Text = "uzayYocuları";
        }

        private void kaçışOdasıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=8b73Ajy7Yww");
            label1.Text = "kaçışOdası";
        }
    }
}