using System;

namespace constructor_metot
{
    class Program
    {
        static void Main(string[] args)
        {
            // bu metot sınıftan sadece nesne oluşturarak kullanılıyor, ek bir çağırma durumu yok.
            // o niteliği çağırmak için, metotla beraber niteliği çağırmaya gerek kalmadı. Nesneyi çağır yeter.
            
            //ogrenci new ogrenci();

            Console.Write("KULÜP: ");
            string klp = Console.ReadLine();
            Console.Write("AD: ");
            string ad = Console.ReadLine();
            Console.Write("SOYAD: ");
            string syd = Console.ReadLine();
            Console.Write("YAŞ: ");
            int yas = Convert.ToInt16(Console.ReadLine());
            Console.Write("Meslek: ");
            string mslk = Console.ReadLine();
            //ogrenci ogr = new ogrenci("Ece-Yeşilay");
            ogrenci ogr = new ogrenci(klp,ad, syd, yas, mslk);

        }
    }
}