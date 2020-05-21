using System;
using System.Collections.Generic;

namespace Task030_adapter_pattern.After
{
    public class XMLResponse
    {
        // lets assume this class gets data from backend in xml
        private List apiResponses;
        List apiResponse = new List<KeyValuePair<string, string>>();
        public XMLResponse(List apiRes) {
            apiRes = apiResponse;
             }
        public List apiResponse
        {
            get { return this.apiResponses; }
            set { this.apiResponses = apiResponses; }
        }
        apiResponse.Add('example1', 'example2');

       // public object ApiResponse { get => apiResponse; set => apiResponse = value; }

        public string getXMLResponse()
        {
            return apiResponse;
        }
   
    }
}
