using System;
namespace PizzaHouseIteratorPattern.Before
{
    // Pizza menu object

    public class PizzaMenuItem
    {
        // passing two types of objects
        PizzaHouseNonVegMenu pizzaHouseNonVeg;
        PizzaHouseVegetarianMenu pizzaHouseVegetarianMenu;
        // parameters for passing pizza items ( not necessary, just for fun)
        public string pizzaName;
        public string description;
        public bool vegetarian;
        public double price;
        public PizzaMenuItem(string pizzaName, string description, bool vegetarian, double price)
        {
            this.pizzaName = pizzaName;
            this.description = description;
            this.vegetarian = vegetarian;
            this.price = price;
        }
        //necessary section
        public PizzaMenuItem(PizzaHouseNonVegMenu pizzaHouseNonVeg,
        PizzaHouseVegetarianMenu pizzaHouseVegetarianMenu)
        {
            this.pizzaHouseNonVeg = pizzaHouseNonVeg;
            this.pizzaHouseVegetarianMenu = pizzaHouseVegetarianMenu;
        }
    }
}
