using System;
namespace PizzaHouseIteratorPattern.After
{
    public class PizzaVegMenuIterator: PizzaMenuIterator
    {
        public PizzaVegMenuItems[] pizzaMenuItems;
        int position = 0;

        public PizzaVegMenuIterator()
        {
        }

        public PizzaVegMenuIterator(PizzaVegMenuItems[] pizzaMenuItems)
        {
            this.pizzaMenuItems = pizzaMenuItems;
        }

        public Object NextPizzaItem()
        {
            PizzaVegMenuItems pizzaMenuItems = pizzaMenuItems[position];
            position = position + 1;
            return pizzaMenuItems;
        }

        public bool hasNextPizzaItem()
        {
            if (position >= pizzaMenuItems.Length || pizzaMenuItems[position] == null)
            {
                return false;
            } else
            {
                return true;
            }
        }
    }
}
