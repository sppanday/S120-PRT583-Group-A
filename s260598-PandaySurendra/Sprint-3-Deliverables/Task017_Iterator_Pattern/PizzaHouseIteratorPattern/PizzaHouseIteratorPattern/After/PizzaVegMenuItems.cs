using System;
namespace PizzaHouseIteratorPattern.After
{
    public class PizzaVegMenuItems
    {
        static int MAX_SIZE = 10; // can have at most 10 pizzas
        int numberOfPizzaItems = 0;
        PizzaVegMenuItems[] pizzaMenuItems;
        public PizzaVegMenuItems()
        {
        }

        public PizzaVegMenuIterator createIterator()
        {
            PizzaVegMenuIterator pizzaVegMenuIterator = new PizzaVegMenuIterator(pizzaMenuItems);
            return pizzaVegMenuIterator;
        }
    }
}
