using System;
namespace ChainOfResponsibility.After
{
    // A class that handles displaying all students in table
    public class SelectStudentsProcessor
    {
        private StudentDataProcessor processRequest;
        public SelectStudentsProcessor(StudentDataProcessor processRequest)
        {
            this.processRequest = processRequest;
        }

        public string processDataSelect(Request request)
        {
            if (request.getRequest().Contains('SELECT'))
            {
                return 'SELECT STUDENTS_ID FROM STUDENT_DATABASE WHERE STUDENTS.ID';
            }
        }

    }
}
