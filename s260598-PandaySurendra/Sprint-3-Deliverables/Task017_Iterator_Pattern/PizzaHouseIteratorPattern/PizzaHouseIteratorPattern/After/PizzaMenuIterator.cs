using System;
namespace PizzaHouseIteratorPattern.After
{
    public interface PizzaMenuIterator
    {
        bool hasNextPizzaItem();
        Object NextPizzaItem();
    }
}
