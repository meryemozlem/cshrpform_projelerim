using System;

namespace COnstructor_metot_2
{
    class Program
    {
        static void Main(string[] args)
        {
            kimlik kml = new kimlik();
            //ilk değerler ata
            kml.AD = "Murat";
            kml.SOYAD ="Yücedağ";
            kml.MEMLEKET ="Elazığ";                 //varsayılan değer gitti. girilen değer atandı.
            //yazdır. ilk dğerler olmazsa default.
            Console.WriteLine(kml.AD+"\n"+kml.SOYAD+"\n"+kml.MEMLEKET+"\n"+kml.YAS+"\n"+kml.CINSIYET);
        }
    }
}