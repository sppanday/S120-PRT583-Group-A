using System;
namespace StatePattern.After
{
    // manages states when card is insterted in machine
    public class HasNoCashState : MachineState
    {
        public HasNoCashState() { }

        public void DispenseChange()
        {
            Console.WriteLine('Your requested cash amount has been dispensed');
        }

        public void GiveChange()
        {

        }

        public void insertPaymentType()
        {
            Console.WriteLine('Card entered in machine');
        }

        public void PaymentCompleted()
        {
            Console.WriteLine('Payment has completed');
        }

        public void PaymentDeclined()
        {
            Console.WriteLine('Payment declined, incorrect pin');
        }
    }
}
