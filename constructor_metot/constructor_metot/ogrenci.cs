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


        // klavyeden veri girişi al.
        public ogrenci(string bilgi, string soyad, int yas, string meslek)
        {
            Console.WriteLine("Ad- Kulüp: " + bilgi + "\n" + "Soyad: " + soyad + "\n" + "Yaş: " + yas + "\n" + "Meslek: " + meslek);
            //  Console.WriteLine("Adı: Baran"+"\n"+"Soyadı: Yücedağ"+"\n"+"Meslek: Öğretmen");
        }
    }
}
