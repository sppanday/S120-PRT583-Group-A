using System;
namespace PizzaHouseIteratorPattern.After
{
    public class PizzaMenuItem
    {
        PizzaNonvegMenu pizzaHouseNonVeg;
        PizzaVegMenuItems pizzaHouseVegetarianMenu;
        public PizzaMenuItem(PizzaNonvegMenu pizzaHouseNonVeg,
        PizzaVegMenuItems pizzaHouseVegetarianMenu)
        {
            this.pizzaHouseNonVeg = pizzaHouseNonVeg;
            this.pizzaHouseVegetarianMenu = pizzaHouseVegetarianMenu;
        }

        public void printPizzaMenu()
        {
            PizzaMenuIterator vegMenuIterator = pizzaHouseNonVeg.createIterator();
            PizzaMenuIterator nonvegMenuIterator = pizzaHouseVegetarianMenu.createIterator();
        }
    }
}
