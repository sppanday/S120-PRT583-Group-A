using System;
namespace Task018_TemplateMethodDesignPattern.Before
{
    public class MenuRecipe
    {
        public MenuRecipe()
        {
        }

        public virtual string heatPan()
        {
            return 'Heating pan...';
        }
        public string addOil()
        {
            return 'added oil and waiting to heat up..';
        }
        public string addNoodle()
        {
            return 'added noodle/pasta';
        }
    }
}
