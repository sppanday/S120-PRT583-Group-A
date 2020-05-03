using System;

namespace StudentsSingleton
{
    /**
     * @author : Surendra Panday (s260598)
     * PRT583 Project Development Methodology    
     */
    class MainClass
    {
        public static void Main(string[] args)
        {
            Students engineer = Students.getInstance();

            Students architect = Students.getInstance();

            Students plumber = Students.getInstance();

            Students mathematician = Students.getInstance();

            Students mechanic = Students.getInstance();
        }
    }
    class Students
    {
        private static Students uniqueStudents;

        private Students() { }

        public static Students getInstance()
        {
            if (uniqueStudents == null)
            {
                uniqueStudents = new Students();
            }
            return uniqueStudents;
        }
    }
}
