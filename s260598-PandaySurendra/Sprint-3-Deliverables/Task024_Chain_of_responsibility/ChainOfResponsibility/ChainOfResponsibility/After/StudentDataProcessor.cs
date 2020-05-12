using System;
namespace ChainOfResponsibility.After
{
    public class StudentDataProcessor
    {
        private StudentDataProcessor processRequest;

        public StudentDataProcessor(StudentDataProcessor processRequest)
        {
            this.processRequest = processRequest;
        }

        public void processRequests(string request)
        {
            if(processRequest != null)
            {
                processRequest.processRequest(request);
            }
        }
    }
}
