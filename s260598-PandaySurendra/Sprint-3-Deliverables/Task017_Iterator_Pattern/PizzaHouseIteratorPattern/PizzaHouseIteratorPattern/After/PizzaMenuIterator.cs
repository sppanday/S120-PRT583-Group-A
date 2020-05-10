using System;
namespace PizzaHouseIteratorPattern.After
{   // an interface which is implemented by vegetarian menu and non vegetarian menu
    public interface PizzaMenuIterator
    {
        bool hasNextPizzaItem();
        Object NextPizzaItem();
    }
}
