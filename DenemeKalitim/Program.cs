using System;

namespace DenemeKalitim
{
    class Program
    {
        static void Main(string[] args)
        {
            Kedi kedi = new Kedi();
            kedi.HayvanAdi = "Minnoş";
            kedi.HayvanCinsi = "scottish";
            kedi.HayvanId = 12;
            kedi.HayvanRengi = "gri";
            kedi.kedininKulakUzunluğu = "kısa";



            kedi.HayvanBilgileri();
            Console.ReadLine(); //consolu ekranda tutar.


            Köpek köpek = new Köpek();
            köpek.HayvanAdi = "kukla";
            köpek.HayvanCinsi = "pitbul";
            köpek.HayvanRengi = "siyah";

            köpek.HayvanBilgileri();
            Console.ReadLine();

        }
    }
}

