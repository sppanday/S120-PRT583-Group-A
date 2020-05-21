using System;
using System.Collections.Generic;

namespace Task35_prototype_pattern.Before
{
    public class BottleShop
    {
        public string beerName;
        public double beerPrice;
        public double alcoholPercent;
        // a list of beers
        List<Beers> beers = new List<Beers>();
        public BottleShop()
        {
        }


        // beer name

        public string findBeerName
        {
            private set
            {
                this.beerName = value;
            }

            get
            {
                return beerName;
            }

        }

        // beer price

        public double findBeerPrice
        {
            private set
            {
                this.beerPrice = value;
            }

            get
            {
                return beerPrice;
            }
        }
        public double findAlcoholLevel
        {
            private set
            {
                this.alcoholPercent = value;
            }
            get
            {
                return alcoholPercent;
            }
        }

        public string ToString()
        {
            return "BottleShop [beerName=" + beerName + "beers=" + beers + "]";
        }

        // print a list of beers 
        public void displayAllBeers()
        {
            for (int i = 0; i < 10; i++)
            {
                Beers beer = new Beers();
                beer.setBeerName("Beer "+ i);
                beer.setBeerId("Beer ID: " + i);

            }

        }

    }
}
