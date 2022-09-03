using System;
using System.Collections.Generic;
using System.Text;

namespace Odev_Console1
{
    public class KisiBilgileri
    {
        //Metodumu tanımladım.
        public string ad;
        public string soyad;
        public int yas;
        public string meslek;
        public KisiBilgileri(string ad, string soyad, int yas, string meslek)
        {
            this.ad = ad;
            this.soyad = soyad;
            this.yas = yas;
            this.meslek = meslek;
        }

      /*  public void degerler()
        {

            Console.WriteLine(this.ad, this.soyad, this.yas, this.meslek);

        }*/

        public void degerler(string ad,string soyad, int yas, string meslek)
        {

            Console.WriteLine("ad: {0} soyad {1}  yas{2} meslek{3}" ,ad,soyad,yas,meslek);

        }



    }
}