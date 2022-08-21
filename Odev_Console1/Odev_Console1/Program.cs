
using System;

namespace Odev_Console1
{
    class Program
    {
        static void Main(string[] args)
        {
            //kişi ad soyad yaş ve meslek bilgilerini tanımlanan metot parametreleriyle al ve ekrana yazdır. 
            //öbür sınftan nesne türet.

            KisiBilgileri kisi = new KisiBilgileri();
            Console.WriteLine("ADINIZI SOYADINIZI YAŞINIZI VE MESLEĞİNİZİ GİRİNİZ");
            string ad =Console.ReadLine();
            string soyad = Console.ReadLine();
            string yas =Console.ReadLine();
            string meslek = Console.ReadLine();
            Console.WriteLine(ad+soyad+yas+meslek);
           // kisi.degerler(ad,soyad,yas,meslek);
            Console.Read();




            /*Class bölümü;

public void Adam(string Kisi)
        {
            for (int i = 1; i <2; i++)
            {
                Console.WriteLine(Kisi);
            }
        }
Console bölümü;

Kisiler ks = new Kisiler();
            string isim,soyad,yas,meslek;
            Console.Write("İsim Girin: ");
            isim = Console.ReadLine();
            ks.Adam(isim);
 
            Console.Write("Soyad Girin: ");
            soyad = Console.ReadLine();
            ks.Adam(soyad);
 
            Console.Write("Yas Girin: " );
            yas = Console.ReadLine();
            ks.Adam(yas);
 
            Console.Write("Meslek Girin: ");
            meslek = Console.ReadLine();
            ks.Adam(meslek);
 
            Console.Read();*/
        }
    }
}