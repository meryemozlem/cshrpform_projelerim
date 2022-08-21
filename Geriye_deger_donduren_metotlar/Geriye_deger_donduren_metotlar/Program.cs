using System;

namespace Geriye_deger_donduren_metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            islem isl = new islem();
            isl.topla(5,3);
            //isl.topla(4,5);
            //isl.topla(7, 6);
            isl.topla(7,3);

            Console.WriteLine("/n/n/n/n/n");

            isl.kare(5);
            isl.kare(10);

            */
            int s1,s2;
            Console.WriteLine("1.değeri giriniz.");
            s1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("2.değeri giriniz.");
            s2 = Convert.ToInt16(Console.ReadLine());
            islem deger = new islem();
            deger.topla(s1, s2);
            deger.cikar(s1, s2);
            deger.carp(s1, s2);
            deger.bol(s1, s2);

         // deger.bol(7, 1);

        }
    }
}
