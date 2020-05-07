using System;
namespace StatePattern.Before
{
    public class EftposMachineBefore
    {
        public EftposMachineBefore() { }

        public void insertPaymentType()
        {
            Console.WriteLine('Card inserted...');
        }
        public void GiveChange()
        {
            Console.WriteLine('Change dispensed from machine...');
        }
        public void PaymentDeclined()
        {
            Console.WriteLine('Payment has been declined...');
        }
        public void PaymentCompleted()
        {
            Console.WriteLine('Payment successfully completed...');
        }
    }
}
