using System;
namespace Task35_prototype_pattern.After
{
    public class BeerCloneFactory
    {
        // we clone a bunch of beers in this class
        public BeerCloneFactory()
        {
        }

        public BottleShop getCoronaCopy(BottleShop beerSample)
        {
            return beerSample.copyBeer();
        }
      
    }
}
