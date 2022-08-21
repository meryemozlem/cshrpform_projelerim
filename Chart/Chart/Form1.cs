using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            chart1.Series["Kitaplar"].Points.AddXY("Akdeniz",5);
            chart1.Series["Kitaplar"].Points.AddXY("Ege", 8);
            chart1.Series["Kitaplar"].Points.AddXY("İç Anadolu", 7);
            chart1.Series["Kitaplar"].Points.AddXY("Marmara", 10);
            chart1.Series["Kitaplar"].Points.AddXY("Karadeniz", 3);
            chart1.Series["Kitaplar"].Points.AddXY("Doğu Anadolu", 1);
            chart1.Series["Kitaplar"].Points.AddXY("Güneydoğu Anadolu", 2);

        }
    }
}
