using System;
namespace Task018_TemplateMethodDesignPattern.After
{
    public class CookNoodle : CookingRecipe
    {
        public CookNoodle()
        {
        }

        public void addSauce()
        {
            Console.WriteLine('Adding barbecue sauce');
        }
        public void addCondiments()
        {
            Console.WriteLine('Adding salt and pepper');
        }
    }
}
