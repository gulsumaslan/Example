using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    public class Animals    //public kullandım her yerden hayvan sınıfına erişilmesi için
    {
        public string AnimalName { get; set; } //farklı yollarla kullanabiliz..  1. yol ;
        public int AnimalId;            // ikinci yol.
        public string AnimalGenus { get; set; }
        public string AnimalColour { get; set; }


        public void AnimalInformation()
        {
            Console.WriteLine(" Name: " +AnimalName);
            Console.WriteLine(" Id: " + AnimalId);
            Console.WriteLine("Genus: " + AnimalGenus);
            Console.WriteLine("Colour: " + AnimalColour);

        }

    }
}
