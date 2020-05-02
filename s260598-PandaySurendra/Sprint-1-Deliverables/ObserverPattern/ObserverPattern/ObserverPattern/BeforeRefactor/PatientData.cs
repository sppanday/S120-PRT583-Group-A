using System;
namespace ObserverPattern.BeforeRefactor
{
    /**
 * @author : Surendra Panday
 * A hospital after refactor with Observable pattern */
    public class PatientData
    {
        public PatientData(){}

        //most recent record of patients sample test
        float bloodPressure = getPatientBloodPressure();
        float acidityLevel = getPatientAcidityLevel();
        float glucoseLevel = getGlucoseLevel();
        float temp = getPatientTemp();

      
        updatePatientReport.update(bloodPressure, acidityLevel, glucoseLevel,temp);
            void sendEmailToPatients();
            void getPatientBloodPressure() { }
            void getPatientAcidityLevel() { }
            void getGlucoseLevel() { }
            void getPatientTemp() { }
    }
}
