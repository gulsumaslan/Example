using System;

namespace Example1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.AnimalName = "Minnoş";
            cat.AmimalGenus = "scottish";
            cat.AnimalId = 12;
            cat.AnimalColour = "gray";
            cat.catsearlength = "short";



            cat.AnimalInformation();
            Console.ReadLine(); //consolu ekranda tutar.


            Dog dog = new Dog();
            dog.AnimalName = "blue";
            dog.AmimalGenus= "pitbul";
            dog.AnimalColour = "black";

            dog.AnimalInformation();
            Console.ReadLine();

        }
    }
}

