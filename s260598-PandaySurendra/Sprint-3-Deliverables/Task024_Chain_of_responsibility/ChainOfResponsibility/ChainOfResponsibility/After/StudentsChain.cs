using System;
namespace ChainOfResponsibility.After
{
    // builds chain of database sql queries requests
    public class StudentsChain
    {
        StudentDataProcessor studentDataProcessor;
        public StudentsChain()
        {
        }

        public void buildStudentDatabaseChain()
        {
            studentDataProcessor = new SelectStudentsProcessor(new UpdateStudentProcessor(new InsertStudentsProcessor(null)));
        }

        public void processRequest(Request request) {
            studentDataProcessor.processRequests(request);
        }
    }
}
