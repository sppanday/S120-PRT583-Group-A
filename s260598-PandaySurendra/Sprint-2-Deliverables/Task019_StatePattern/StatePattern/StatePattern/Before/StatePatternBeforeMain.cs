using System;
using StatePattern.Before;

namespace StatePattern
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            EftposMachineBefore eftpos = new EftposMachineBefore();

            eftpos.insertPaymentType();
            eftpos.PaymentDeclined();
            eftpos.PaymentCompleted();
            eftpos.GiveChange();
        }
    }
}
