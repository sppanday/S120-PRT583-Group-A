using System;
namespace Task35_prototype_pattern.After
{
    public class PrototypePatternMainAfter
    {
        public static void Main(string[] args)
        {
            BeerCloneFactory beerFactory = new BeerCloneFactory();

            Beers corona = new Beers();

            Beers clonedCorona = (Beers)beerFactory.getCoronaCopy(corona);

            Console.WriteLine(clonedCorona);

            // print hashcode of created objects to show they have been created with different memory location

            Console.WriteLine("Original Corona beer hashcode is ::: " + corona.GetHashCode());
            Console.WriteLine("Cloned Corona beer hashcode is ::: " + clonedCorona.GetHashCode());

        }
    }
}
