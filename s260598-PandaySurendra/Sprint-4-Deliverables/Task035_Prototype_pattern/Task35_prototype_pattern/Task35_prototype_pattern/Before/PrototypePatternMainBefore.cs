using System;
using Task35_prototype_pattern.Before;

namespace Task35_prototype_pattern
{
    class MainClass
    {
        /*
         * An implementation without cloning object by using regular objects
         */
        public static void Main(string[] args)
        {
            // bottle shop 1
            var corona = new BottleShop { beerName = "Corona", beerPrice= "$4.25" };

            // print corona beer
            Console.WriteLine(corona);

            var fatYak = new BottleShop { beerName = "Fat Yak", beerPrice = "$5.95" };

            Console.WriteLine(fatYak);
        }
    }
}
