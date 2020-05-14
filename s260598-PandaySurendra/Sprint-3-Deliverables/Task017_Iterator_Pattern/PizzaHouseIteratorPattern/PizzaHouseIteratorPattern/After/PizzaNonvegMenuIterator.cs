using System;
namespace PizzaHouseIteratorPattern.After
{
    public class PizzaNonvegMenuIterator
    {
         PizzaNonvegMenu[] pizzaNonvegs;
        int position = 0;
   
    public PizzaNonvegMenuIterator(PizzaNonvegMenu[] pizzaNonvegs, int position)
        {
            this.pizzaNonvegs = pizzaNonvegs;
            this.position = position;
        }
        public Object NextPizzaItem()
        {
            PizzaNonvegMenu[] pizzaNonvegs = pizzaNonvegs[position];
            foreach (var item in pizzaNonvegs)
            {
                position = position + 1;
                return pizzaNonvegs;
            }

        }

        public bool hasNextPizzaItem()
        {
            if (position >= pizzaNonvegs.Length || pizzaNonvegs[position] == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
