using System;
using System.Collections.Generic;
using System.Text;

namespace COnstructor_metot_2
{
    class kimlik
    {
        string ad, soyad, memleket;
        int yas;
        char cinsiyet;
        //Bunları direkt kullanamayız. kapsülleme uygularım.

        public string AD
        {
            get { return ad; }
            set { ad = value.ToLower(); }
        }

        public string SOYAD
        {
            get { return soyad; }
            set { soyad = value.ToUpper(); }
        }

        public string MEMLEKET
        {
            get { return memleket; }
            set { memleket = value; }
        }

        public int YAS
        {
            get { return yas; }
            set { yas = Math.Abs(value); }
        }

        public char CINSIYET
        {
            get { return cinsiyet; }
            set { cinsiyet = value; }
        }
        //kapsülleme tamam. constructor ile ilk değerlerini ata. Sınıf ismi ile aynı olacak.

        public kimlik()
        {
            //kapsülleme isimleri değil ilk tanımlananlar (default) kullanılacak.
            ad = "";
            //herhangi bir veri girilmezse boş sayılsın.
            soyad = "";
            memleket = "Ankara";
            yas = 18;
            cinsiyet = 'K';
        }
    }
}