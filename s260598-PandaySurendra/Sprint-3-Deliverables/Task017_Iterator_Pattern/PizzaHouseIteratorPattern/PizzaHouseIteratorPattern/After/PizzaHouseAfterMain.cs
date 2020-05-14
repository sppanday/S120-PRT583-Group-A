using System;
namespace PizzaHouseIteratorPattern.After
{
    public class PizzaHouseAfterMain
    {
        public static void Main(string[] args)
        {
            PizzaVegMenuItems pizzaVegMenu = new PizzaVegMenuItems();
            PizzaNonvegMenu pizzaNonvegMenu = new PizzaNonvegMenu();

            // combine both menus together
            PizzaMenuItem pizzaMenuItem = new PizzaMenuItem(pizzaVegMenu, pizzaNonvegMenu);

            // print pizza menu items both for veg and non veg

            pizzaMenuItem.printPizzaMenu();

        }
    }
}
