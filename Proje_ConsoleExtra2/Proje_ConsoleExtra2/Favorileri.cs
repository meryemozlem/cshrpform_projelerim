using System;
using System.Collections.Generic;
using System.Text;

namespace Proje_ConsoleExtra2
{
    class Favorileri
    {
        public void fav(string kitap, string film, string muzikTuru)
        {
            Console.WriteLine(kitap);
            Console.WriteLine(film);
            Console.WriteLine(muzikTuru);
        }

        public void sayi(int favsayi)
        {
            Console.WriteLine(favsayi);
        }
    }
}