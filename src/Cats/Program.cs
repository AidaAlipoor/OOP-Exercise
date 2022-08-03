using System;

namespace Cats
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var wildCat = new WildCat();
            Console.WriteLine(Info(nameof(wildCat), wildCat.CatFood, wildCat.CatColor, wildCat.Walk()));
            var domesticCat = new DomesticCat();
            Console.WriteLine(Info(nameof(domesticCat), domesticCat.CatFood, domesticCat.CatColor));
            var cityCat = new CityCat();
            Console.WriteLine(Info(nameof(cityCat), cityCat.CatFood, cityCat.CatColor, cityCat.Walk()));

            Console.Read();
        }

        static string Info(string name, string catFood, string catColor, string walk = "no")
            => $"{name} info: \r\nFood: {catFood}, Color: {catColor}, Can walk? {walk}";
    }
}
