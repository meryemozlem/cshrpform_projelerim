using System;
using System.Collections.Generic;
using System.Text;

namespace Proje_ConsoleExtra2
{
    class KisiBilgileri
    {
        public void kisiBilg (string ad, string soyad, string meslek, string memleket)
        {
            Console.Write(ad+" ");
            Console.WriteLine(soyad);
            Console.WriteLine(meslek);
            Console.WriteLine(memleket);
        }

        public void deger(int yas)
        {
            Console.WriteLine(yas);
        }
    }
}