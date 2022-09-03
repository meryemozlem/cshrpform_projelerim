using System;

namespace Proje_ConsoleExtra2
{
    class Program
    {
        static void Main(string[] args)
        {
            KisiBilgileri kisi = new KisiBilgileri();
            Favorileri favori = new Favorileri();

            Console.Write("Adınız: ");
            string ad = Console.ReadLine();
            Console.Write("Soyadınız: ");
            string soyad = Console.ReadLine();
            Console.Write("Yaşınız: ");
            int yas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Mesleğiniz: ");
            string meslek = Console.ReadLine();
            Console.Write("Memleketiniz: ");
            string memleket = Console.ReadLine();

            Console.Write("Favori kitabınız: ");
            string kitap = Console.ReadLine();
            Console.Write("Favori filminiz: ");
            string film = Console.ReadLine();
            Console.Write("Favori müzik türünüz: ");
            string muzikTuru = Console.ReadLine();
            Console.Write("Favori sayınız: ");
            int favsayi = Convert.ToInt32(Console.ReadLine());


            kisi.kisiBilg(ad,soyad,meslek,memleket);
            kisi.deger(yas);
            favori.fav(kitap,film,muzikTuru);
            favori.sayi(favsayi);

        }
    }
}