using System;

namespace Console_OrnekM
{
    class Program
    {
        static void Main(string[] args)
        {
            // mesaj sınıfından nesne türet
            Mesaj msj = new Mesaj();
            //bu nesneyi sınıf içinde kullanılan metotla kullan
            msj.metin();

            Kisilercs kisi = new Kisilercs();
            //kisi.kisilistesi("Bilgisayar Mühendisi");

            //kisi.kisilistesi("Murat Yücedağ");
            //kisi.kisilistesi("Eylül Yücedağ");

            //değerleri klavyeden alsın
            Console.Write("Ad Soyad girin");
            string ads = Console.ReadLine();
            kisi.kisilistesi(ads);

            Console.Read();
        }
    }
}
