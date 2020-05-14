using System;
namespace Task018_TemplateMethodDesignPattern.After
{
    public class CookPasta: CookingRecipe
    {
        public CookPasta()
        {
        }

        public void addSauce()
        {
            Console.WriteLine('Adding tomato sauce'); // only tomato sauce not barbecue sauce which is in noodle
        }
        public void addCondiments()
        {
            Console.WriteLine('Adding salt'); // only salt, not pepper
        }
    }
}
