using System;

namespace Task35_prototype_pattern.Before
{
    public class Beers
    {
        public string beerName { set; get; };
        public string beerId { set; get; };
        public double beerPrice { set; get; };
        public void setBeerName(string beerName)
        {
            this.beerName = beerName;
        }

        internal void setBeerId(string beerId)
        {
            this.beerId = beerId;
        }

        public void setBeerPrice(double beerPrice)
        {
            this.beerPrice = beerPrice;
        }
    }
}