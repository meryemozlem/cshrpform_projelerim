using System;
using System.Collections.Generic;
using System.Text;

namespace constructor_metot
{
    class ogrenci
    {
        //yapıcı metodu oluşturalım.
        /*C# Constructor, nesne yönelimli programlama kavramı içerisinde bulunan sınıf yapılarının
        nesne olarak tanımlanmasında alt yapıyı hazırlayan,
        kurucu rolü üstlenen, sınıf ismi ile aynı isime sahip olan, geriye değer döndürmeyen fonksiyon türleridir.*/

        /* 
            public ogrenci()
        {
         c.w("Ad: Baran"+"\n"+"Soyadı: Öz" + "\n" + "Meslek: Öğretmen");
        }
         */
        // klavyeden veri girişi al.
        public ogrenci(string kulup,string ad, string soyad, int yas, string meslek)
        {
            Console.WriteLine("Kulüp: " + kulup + "\n" + "Ad: " +ad+ " " + "Soyad: " + soyad + "\n" + "Yaş: " + yas + "\n" + "Meslek: " + meslek);

        }
    }
}