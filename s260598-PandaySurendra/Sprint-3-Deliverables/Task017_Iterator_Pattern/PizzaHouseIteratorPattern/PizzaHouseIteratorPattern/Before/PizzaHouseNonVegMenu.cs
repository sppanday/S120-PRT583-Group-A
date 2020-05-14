using System;
namespace PizzaHouseIteratorPattern.Before
{
    public class PizzaHouseNonVegMenu
    /**
     * Array implementation of pizza menu
     * authored by Surendra Panday
     * pizza menu names/ingridient credit goes to https://www.dominos.com.au/menu-pizza  
     */
    {
        static int MAX_ITEMS = 10; // maximum 10 pizzas in list
        int numberOfPizzaIems = 0;
        PizzaHouseNonVegMenuItems[] pizzaMenuItems;
        public PizzaHouseNonVegMenu()
        {
            PizzaMenuItems = new PizzaHouseNonVegMenuItems(MAX_ITEMS);

            // list of non vegetarian pizzas 

            addPizzaMenuItem("Chicken Parmy", "22 crumbled chicken bites, crispy rasher bacon, creamy mozzarella and rich tomato sauce", false, 9.95);
            addPizzaMenuItem("Big Ham and Pineapple", "Ham, Pineapple, mozzarella, wheat flour", false, 12.95);
            addPizzaMenuItem("The Big Three Meats", "pepperoni, ground beef, italian sauce, wheat flour", false, 8.95);
            addPizzaMenuItem("Garlic Chicken and Bacon Ranch", "Succulent chicken, crispy rasher bacon, Spinach, Red Onions", false, 7.95);
        }

        public PizzaHouseNonVegMenuItems[] PizzaMenuItems { get => pizzaMenuItems; set => pizzaMenuItems = value; }

        public void addPizzaMenuItem(String name, String description, Boolean vegetarian, double price)
        {
             PizzaMenuItems = new PizzaHouseNonVegMenuItems(name, description, vegetarian, price);
            if (numberOfPizzaIems >= MAX_ITEMS)
            {
                Console.WriteLine("Sorry, menu is full! Can't add pizza items to menu");
            } else
            {
                PizzaMenuItems(numberOfPizzaIems) = PizzaMenuItems;
                numberOfPizzaIems = numberOfPizzaIems + 1;
            }
        }
        //  returns an array of non veg pizza menu items
        public PizzaHouseNonVegMenuItems[] getPizzaMenuItems()
        {
            return PizzaMenuItems;
        }

        // other methods

    }

}

