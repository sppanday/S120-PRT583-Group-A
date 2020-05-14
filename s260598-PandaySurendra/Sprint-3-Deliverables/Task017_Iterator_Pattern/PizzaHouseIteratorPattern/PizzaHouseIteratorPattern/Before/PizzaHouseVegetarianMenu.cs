using System;
using System.Collections;

namespace PizzaHouseIteratorPattern.Before
{
    /*
     * Please visit https://www.dominos.com.au/menu-pizza for updates on pizza menu
     * implementation using arraylist    
     **/
    public class PizzaHouseVegetarianMenu
    {
        ArrayList pizzaMenuItem;
        public PizzaHouseVegetarianMenu()
        {
            pizzaMenuItem = new ArrayList();
            pizzaMenuItem.AddVegMenuItem("The Big Cheese", "Huge pie cut into 8 extra-large slices. Authentic soft and foldable New York style dough topped with mozzarella", true, 4.99);
            pizzaMenuItem.AddVegMenuItem("Avocado Veg", "Slices of avocado, Kalamata olives, fire, roaster pepper strips, mushrooms, red onions, vibrant capsicum, topped with spring onions",true, 4.99);
            pizzaMenuItem.AddVegMenuItem("God Father", "Domino's pepperoni paired with Italian sausage, fresh capsicum, diced tomato & Kalamata olives, finished with creamy garlic sauce & oregano", true, 4.99);
            pizzaMenuItem.AddVegMenuItem("Vegorama", "Fresh mushrooms, diced tomato, capsicum, baby spinach & slices of red onion, topped with crumbled feta cheese, sweet cherry peppers & oregano", true, 4.99);
        }

        public void AddVegMenuItem(string pizzaName, string description, bool vegetarian, double price)
        {
            PizzaMenuItem pizzaMenuItem = new PizzaMenuItem(pizzaName,
                                                            description,
                                                            vegetarian,
                                                            price);
            pizzaMenuItem.Add(pizzaMenuItem);
        } 

        public ArrayList getPizzaMenuItem()
        {
            return pizzaMenuItem;
        }
    }

}
