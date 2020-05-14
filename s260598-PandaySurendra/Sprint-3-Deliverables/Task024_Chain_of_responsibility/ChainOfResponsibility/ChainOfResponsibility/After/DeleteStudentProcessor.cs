using System;
namespace ChainOfResponsibility.After
{
    // A CLASS THAT HANDLES DELETE STUDENT ROW REQUEST
    public class DeleteStudentProcessor: StudentDataProcessor
    {
        private StudentDataProcessor processRequest;
        public DeleteStudentProcessor(StudentDataProcessor processRequest)
        {
            this.processRequest = processRequest;
        }
        public string processDataInsert(Request request)
        {
            if (request.getRequest().Contains('DELETE'))
            {
                return 'DELETE STUDENT_ID FROM STUDENT_DATABSE WHERE STUDENT_ID == 1';
            }
        }
    }
}
    }
}
