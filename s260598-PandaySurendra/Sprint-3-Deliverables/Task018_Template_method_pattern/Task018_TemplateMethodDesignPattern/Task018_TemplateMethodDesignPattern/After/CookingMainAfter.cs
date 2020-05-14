using System;
namespace Task018_TemplateMethodDesignPattern.After
{
    public class CookingMainAfter
    {
       public static void Main(string[] args)
        {
            CookPasta pasta = new CookPasta();

            CookNoodle noodle = new CookNoodle();

            // print all processes of cooking noodle
            noodle.prepareRecipe();
            noodle.addCondiments();
            noodle.addSauce();

            // print all processes of cookng pasta
            pasta.prepareRecipe();
            pasta.addCondiments();
            pasta.addSauce();

        }

    }
}
