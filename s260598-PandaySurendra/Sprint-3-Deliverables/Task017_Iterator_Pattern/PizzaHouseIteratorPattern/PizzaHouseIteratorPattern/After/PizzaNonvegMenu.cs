using System;
namespace PizzaHouseIteratorPattern.After
{
    public class PizzaNonvegMenu
    {
        static int MAX_SIZE = 10; // can have at most 10 pizzas
        int numberOfPizzaItems = 0;
        PizzaNonvegMenu[] pizzaNonvegs;

        public PizzaNonvegMenu()
        {
           
        }

        public PizzaMenuIterator createVegPizzaMenuIterator()
        {
            return PizzaVegMenuIterator(pizzaNonvegs);
        }

    }
}
