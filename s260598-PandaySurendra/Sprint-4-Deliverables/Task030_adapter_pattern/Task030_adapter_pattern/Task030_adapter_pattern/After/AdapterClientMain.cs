using System;
using Task030_adapter_pattern.After;

namespace Task030_adapter_pattern
{
    public class AdapterAfterMain
    {
        public static void Main(string[] args)
        {
            XMLResponse xmlResponse = new XMLResponse();

            XMLResponseParser jsonResponse = new XMLResponseParser();

            Console.WriteLine(xmlResponse); // xml response from api

            Console.WriteLine(jsonResponse); // json response form api
        }
    }
}
