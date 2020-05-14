using System;
namespace PizzaHouseIteratorPattern.After
{ 
    // after refactor of nonveg pizza menu

    public class NonVegPizzaMenuAfter: PizzaMenuIterator
    {
        static int MAX_PIZZA_ITEMS = 10;
        int numberOfPizzaItems = 0;
        PizzaMenuNonvegItems[] pizzaMenuNonVegItems;

        public NonVegPizzaMenuAfter()
        {
        }

        public PizzaMenuIterator createIterator()
        {
            return new PizzaNonvegMenuIterator(pizzaMenuNonVegItems);
        }
    }
}
