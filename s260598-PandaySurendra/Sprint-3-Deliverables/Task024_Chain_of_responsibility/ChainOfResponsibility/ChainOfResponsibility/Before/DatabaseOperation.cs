using System;
namespace ChainOfResponsibility.Before
{
    public class DatabaseOperation
    {
        /*
         * Updates database straightaway without much complexity, but increases
         * load if lot of operations happen, and it could blow performance        
         */
        public DatabaseOperation()
        {
        }
        //connect to databse
        public string connectToDatabase()
        {
            Console.WriteLine('connect to database logic goes here');
        }
        //selects students
        public string selectStudents() {
            return 'SELECT STUDENTS_ID FROM STUDENT_DATABASE WHERE STUDENTS.ID > 0';
            }
        // updates students
        // UPDATE STUDENT ID OF A STUDENT TO 2, WHERE IT EQUALS TO 1
        public string updateStudents() {
            return 'UPDATE STUDENT_DATABASE SET STUDENT_ID = 2 WHERE STUDENT_ID == 1'
           }
        // deletes students
        public string deleteStudents() {
            return 'DELETE STUDENT_ID FROM STUDENT_DATABSE WHERE STUDENT_ID == 1';
        }
        // inserts students data
        public string insertStudents() {
            return 'INSERT INTO STUDENT_DATABASE(STUDENT_ID, STUDENT_NAME)VALUES(1, ROBERT HALL)'
        }

 }
}
