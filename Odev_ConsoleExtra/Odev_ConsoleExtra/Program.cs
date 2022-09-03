using System;

namespace Odev_ConsoleExtra
{
    class Program
    {
        static void Main(string[] args)
        {
            // SInıftan nesneler türet.
            KisiBilgileri kisi = new KisiBilgileri();
            //KisiBilgileri kisib = new KisiBilgileri();

            Console.Write("Adınız: ");
            string ad = Console.ReadLine();

            Console.Write("Soyadınız: ");
            string soyad = Console.ReadLine();

            Console.Write("Yaşınız: ");
            int yas = Convert.ToInt32(Console.ReadLine());

            Console.Write("Mesleğiniz: ");
            string meslek = Console.ReadLine();

            // Kisi nesnesi, metot ve değişken parametrelerle bağlantı sağladı.

            kisi.kisiler(ad,soyad,meslek);
            kisi.deger(yas);

            //Console.WriteLine(ad, soyad, yas, meslek);
            // "ad: " + ad,"soyad: " + soyad, "Meslek: " + meslek


            //kişi ad soyad yaş ve meslek bilgilerini tanımlanan metot parametreleriyle al ve ekrana yazdır. 
            //öbür sınftan nesne türet.

            /* KisiBilgileri kisi = new KisiBilgileri();
             Console.WriteLine("ADINIZI SOYADINIZI YAŞINIZI VE MESLEĞİNİZİ GİRİNİZ");
             string ad = Console.ReadLine();
             string soyad = Console.ReadLine();
             string yas = Console.ReadLine();
             string meslek = Console.ReadLine();
             Console.WriteLine(ad + soyad + yas + meslek);
             // kisi.degerler(ad,soyad,yas,meslek);
             Console.Read();
            */

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