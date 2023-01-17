using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    public class Animals    //public kullandım her yerden hayvan sınıfına erişilmesi için
    {
        public string HayvanAdi { get; set; } //farklı yollarla kullanabiliz..  1. yol ;
        public int HayvanId;            // ikinci yol.
        public string HayvanCinsi { get; set; }
        public string HayvanRengi { get; set; }


        public void HayvanBilgileri()
        {
            Console.WriteLine("Hayvanın Adı: " + HayvanAdi);
            Console.WriteLine("Hayvanın Id: " + HayvanId);
            Console.WriteLine("Hayvanın Cinsi: " + HayvanCinsi);
            Console.WriteLine("Hayvanın Rengi: " + HayvanRengi);

        }

    }
}
