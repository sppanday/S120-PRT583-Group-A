using System;

namespace SingletonPatternStudents
{
    /**
     * Singleton Class example by Surendra Panday ( s260598) 
     *     
     */
    class MainClass
    {
        public static void Main(string[] args)
        {
            // normal class
            //multiple instances are created in normal class as shown below

            Students engineer = new Students();

            Students mechanic = new Students();

            Students architect = new Students();

            Students plumber = new Students();

            Students mathematician = new Students();
        }

        // each object creation will instantiate that object

        class Students{

            public Students() { } // this constructor is public by default
        }
    }
}
