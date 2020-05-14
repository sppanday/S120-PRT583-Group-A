using System;
namespace Task018_TemplateMethodDesignPattern.Before
{
    public class Pasta : MenuRecipe
    {
        public Pasta() { }

        public override string heatPan() //method is not locked from overriding that is the main point
        {
            return  'I am pasta I need to be heated as fast as i can';
        }
    }
}
