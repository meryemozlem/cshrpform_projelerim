using System;
using System.Collections.Generic;
using System.Text;

namespace Console_OrnekM
{
    class Kisilercs
    {
        // metot tanımla
        /*
        public void kisilistesi()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i + ". kişi");
            }
        }
        */

        /*
        public void kisilistesi(string ad)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i+ad);
            }
        }
        */

        //klavyeden girilen değeri 10 kez yazdıran metot. ads yerine adsoyad da olurdu.

        public void kisilistesi(string ads)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(ads);
            }

        }

    }
}