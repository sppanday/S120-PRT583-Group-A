using System;
namespace Task018_TemplateMethodDesignPattern.Before
{
    public class Noodle: MenuRecipe
    {
        public Noodle()
        {
        }
        public override string heatPan() // method is not locked to be overridden
        {
            return 'I am a pan and I dont want to be heated for noodle';
        }
    }
}
