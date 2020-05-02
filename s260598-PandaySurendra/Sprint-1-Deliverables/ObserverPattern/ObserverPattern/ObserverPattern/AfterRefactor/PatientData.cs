using System;
using System.Collections;


/**
 * @author : Surendra Panday
 * A hospital after refactor with Observable pattern */

namespace ObserverPattern
{
    public class PatientData : Subject 
    {
        private ArrayList patients;
        private float temp;
        private float acidityLevel;
        private float bloodPressure;
        private float glucoseLevel;
        private string patientDetails;

        public PatientData()
        {
            patients = new ArrayList();
        }

        public void registerPatients(PatientsObserver p)
        {
            //when patient wants to register in system
            patients.Add(p);
        }

        public void removePatients(PatientsObserver p)
        {
            // when patient wants to unregister from system
            int i = patients.IndexOf(p);

            if (i >= 0)
            {
                patients.Remove(i);
            }
        }
        public void notifyPatients()
        {
            for (int i = 0; i < patients.size(i); i++)
            {
                PatientsObserver patients = (PatientsObserver)patients.get(i);
                patients.update(temp, acidityLevel, bloodPressure, glucoseLevel, patientDetails);
            }
        }

        public void hospitalInformationChanged()
        {
            notifyPatients();
        }

        public void setPatientSampleTestRecord ( float temp,float bloodPressure, 
            float glucoseLevel, string patientDetails, float acidityLevel)
        {
            this.acidityLevel = acidityLevel;
            this.bloodPressure = bloodPressure;
            this.patientDetails = patientDetails;
            this.temp = temp;
            this.glucoseLevel = glucoseLevel;
        }
    }
}
