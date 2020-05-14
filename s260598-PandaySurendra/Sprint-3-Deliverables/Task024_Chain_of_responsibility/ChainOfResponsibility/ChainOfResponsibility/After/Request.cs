using System;
using System.Collections.Generic;
using System.Linq;

namespace ChainOfResponsibility.After
{
    public class Request
    {
        // ENUMS to process select, insert, update, delete request 

        private string request;

        private enum process_request { SELECT, INSERT, UPDATE, DELETE};

        public Request(string request) {
            this.request = request;
          }

        public string getRequest()
        {
            var requests = Enum.GetValues(typeof(process_request)).ToString();
            return requests;
        }


    }
}
