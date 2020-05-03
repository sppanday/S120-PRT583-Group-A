using System;
namespace ObserverPattern
{/**
 * @author : Surendra Panday
 * A hospital after refactor with Observable pattern */
    public interface Subject
    {
         void registerPatients(PatientsObserver p);
         void removePatients(PatientsObserver p);
        void notifyPatients();
    }
}

public interface PatientsObserver
{
     void update(float temp, float acidity, float bloodPressure,
        float glucoseLevel, string patientDetails);
}

public interface EmailPatientReport
{
     void sendEmail();
}