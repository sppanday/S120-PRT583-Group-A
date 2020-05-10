using System;
namespace PizzaHouseIteratorPattern.After
{
    public class PizzaMenuItem
    {
        PizzaHouseAfter pizzaHouseNonVeg;
        PizzaNonvegetarianMenu pizzaHouseVegetarianMenu;
        public PizzaMenuItem(PizzaHouseAfter pizzaHouseNonVeg,
            PizzaNonvegetarianMenu pizzaHouseVegetarianMenu)
        {
            this.pizzaHouseNonVeg = pizzaHouseNonVeg;
            this.pizzaHouseVegetarianMenu = pizzaHouseVegetarianMenu;
        }
    }
}
