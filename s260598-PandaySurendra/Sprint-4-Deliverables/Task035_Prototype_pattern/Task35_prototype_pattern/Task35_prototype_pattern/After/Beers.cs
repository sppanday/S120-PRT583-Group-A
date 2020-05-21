using System;
namespace Task35_prototype_pattern.After
{
    public class Beers : BottleShop
    {
        public Beers()
        {
            Console.WriteLine("Beer has been transferred");
        }

         public BottleShop copyBeer()
        {

            Console.WriteLine("Beer is being transferred..");

            Beers makeBeer = null;

            try
            {
                // make a copy of existing object Beers
                makeBeer = (Beers)base.MemberwiseClone();
            }
            catch (AccessViolationException e)
            {
                if (e != null)
                {
                    e.StackTrace();
                }
            }
            return makeBeer;
        }

        public String ToString()
        {
            return "You have successfully created beer...";
        }
    }
}

