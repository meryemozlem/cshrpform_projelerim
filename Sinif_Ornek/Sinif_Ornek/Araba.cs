using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinif_Ornek
{
    class Araba: ArabaDetay
    {   // araba sınıfına arabadetay sınıfı özellikleri aktarıldı. Kalıtımla.
        // erişim tip değişken;
        public string renk;
        public int hiz;
        public double motor;
        public char durum;
        public int fiyat;

        //KAPSÜLLEME
        private int yil;
        private string marka;

        public int YIL
        {
            get { return yil ; }
            set { yil = Math.Abs(value); }
        }

        public string MARKA
        {
            get { return marka; }
            set { marka = value.ToUpper(); }
        }
    }
}