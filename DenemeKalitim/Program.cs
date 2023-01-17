using System;

namespace DenemeKalitim
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.HayvanAdi = "Minnoş";
            cat.HayvanCinsi = "scottish";
            cat.HayvanId = 12;
            cat.HayvanRengi = "gri";
            cat.kedininKulakUzunluğu = "kısa";



            cat.HayvanBilgileri();
            Console.ReadLine(); //consolu ekranda tutar.


            Dog dog = new Dog();
            dog.HayvanAdi = "kukla";
            dog.HayvanCinsi = "pitbul";
            dog.HayvanRengi = "siyah";

            dog.HayvanBilgileri();
            Console.ReadLine();

        }
    }
}

