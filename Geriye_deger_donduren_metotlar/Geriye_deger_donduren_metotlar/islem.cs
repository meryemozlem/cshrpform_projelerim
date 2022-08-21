using System;
using System.Collections.Generic;
using System.Text;

namespace Geriye_deger_donduren_metotlar
{
    class islem
    {
        /*
        public int topla(int s1, int s2)
        {
            int s3 =s1+s2;
            Console.WriteLine("Sonuç: " + s3);
            return s3;
        }
        public int kare(int deger)
        {
            int sonuc = deger * deger;
            Console.WriteLine("Sonuç: " + sonuc);
            return sonuc;
        }

        */

        //Klavyeden girilen 2 sayıya 4 işlem uygulayan metot.


        public int topla(int s1, int s2)
        {
            Console.WriteLine("1.değeri giriniz.");
            s1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("2.değeri giriniz.");
            s2 =Convert.ToInt16(Console.ReadLine());
            int s3 = s1 + s2;
            Console.WriteLine("Toplama sonucu: " + s3);
            return s3;
        }
        public int cikar(int s1, int s2)
        {
            Console.WriteLine("1.değeri giriniz.");
            s1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("2.değeri giriniz.");
            s2 = Convert.ToInt16(Console.ReadLine());     
            int s3= s1 - s2;
            Console.WriteLine("Çıkarma sonucu: " + s3);
            return s3;
        }
        public int carp(int s1, int s2)
        {/*
            Console.WriteLine("1.değeri giriniz.");
            s1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("2.değeri giriniz.");
            s2 = Convert.ToInt16(Console.ReadLine());     */
            int s3= s1 * s2;
            Console.WriteLine("Çarpım sonucu: " + s3);
            return s3;
        }
        public int bol(int s1, int s2)
        {/*
            Console.WriteLine("1.değeri giriniz.");
            s1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("2.değeri giriniz.");
            s2 = Convert.ToInt16(Console.ReadLine());     */
            int s3= s1 / s2;
            Console.WriteLine("Bölme Sonucu: " + s3);
            return s3;
        }

    }
}