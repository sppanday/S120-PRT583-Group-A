using System;
namespace Task018_TemplateMethodDesignPattern.After
{
    public class CookingRecipe
    {
        public CookingRecipe()
        {
        }
        public virtual void prepareRecipe()
        {
            // these three methods are sealed and cant be changed
            heatPan();
            addOil();
            addNoodle();
        }
        // these two methods arent' locked so they can be defined in 
        // however way subclasses want them to be implemented so they are
        // methods
        abstract void addSauce(){ }
        abstract void addCondiments() { }

        // these methods would have pre defined behaviour so that they cant be changed or overridden
        void heatPan() {
            Console.WriteLine("Heating pan for cooking");
        }
        void addOil() {
            Console.WriteLine("Oil added and waiting to heat");
        }
        void addNoodle() {
            Console.WriteLine("Adding noodle or pasta");
        }
    }
}