using System;
namespace StatePattern.After
{
    public interface MachineState {
         void insertPaymentType();
         void DispenseChange();
         void GiveChange();
         void PaymentDeclined();
         void PaymentCompleted();
 }
}
