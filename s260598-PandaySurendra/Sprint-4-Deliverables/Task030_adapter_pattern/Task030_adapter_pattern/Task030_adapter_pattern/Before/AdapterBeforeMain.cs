using System;
namespace Task030_adapter_pattern.Before
{
    public class AdapterBeforeMain
    {
        public static void Main(string[] args)
        {
            XMLOriginalResponse xmlResponse = new XMLOriginalResponse();

            // original xml response but client may need JSON response in future
            Console.WriteLine(xmlResponse);
        }
    }
}
