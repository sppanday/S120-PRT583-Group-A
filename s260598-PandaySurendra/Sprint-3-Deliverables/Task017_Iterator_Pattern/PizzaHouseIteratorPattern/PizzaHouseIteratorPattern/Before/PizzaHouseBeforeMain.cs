using System;
using System.Collections;

namespace PizzaHouseIteratorPattern.Before
{
    public class PizzaHouseBeforeMain
    {
        public static void Main(string[] args)
        {
            // Vegetarian menu object and array list accessed
            PizzaHouseVegetarianMenu pizzaHouseVegetarianMenu  = new PizzaHouseVegetarianMenu();
            ArrayList vegItems = pizzaHouseVegetarianMenu.getPizzaMenuItem();

            // non vegetarian menu object and array accessed
            PizzaHouseNonVegMenu pizzaHouseNonVegMenu = new PizzaHouseNonVegMenu();
            var nonVegItems = pizzaHouseNonVegMenu.getPizzaMenuItems();

            // looping through veg menu

            foreach(var vegItem in vegItems)
            {
                // print all veg items from menu
                Console.WriteLine(vegItem); 
            }

            // looping through non veg menu and print all non veg items

            foreach(var nonVegItem in nonVegItems)
            {
                // print all non veg items from menu
                Console.WriteLine(nonVegItem);
            }

            // print both
            var allPizzas = new ServiceStaff(vegItems, nonVegItems);
        }
    }
}
