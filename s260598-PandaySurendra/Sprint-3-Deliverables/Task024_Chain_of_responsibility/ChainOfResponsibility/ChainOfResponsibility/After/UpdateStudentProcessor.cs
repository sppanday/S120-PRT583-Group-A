using System;
namespace ChainOfResponsibility.After
{
    public class UpdateStudentProcessor
    {
        private StudentDataProcessor processRequest;
        public UpdateStudentProcessor(StudentDataProcessor processRequest)
        {
            this.processRequest = processRequest;
        }
        public string ProcessDataInsert(Request request)
        {
            if (request.getRequest().Contains('UPDATE'))
            {
                return 'UPDATE STUDENT_DATABASE SET STUDENT_ID = 2 WHERE STUDENT_ID == 1'
            }
        }
    }
}
