using System;
using ChainOfResponsibility.Before;

namespace ChainOfResponsibility
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            DatabaseOperation db = new DatabaseOperation();

            // print update, insert, delete, select results.

            db.connectToDatabase();
            db.selectStudents();
            db.insertStudents();
            db.updateStudents();
            db.deleteStudents();
        }
    }
}
