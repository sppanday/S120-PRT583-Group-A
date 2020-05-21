using System;
using System.Collections;
using System.Collections.Generic;

namespace Task030_adapter_pattern.After
{
    public class XMLResponseParser: XMLResponse
    {
        // let's suppose this class would be adapter class to translate xml to json values

        private readonly Dictionary<string, dynamic> dictionary = new Dictionary<string, dynamic><string, dynamic>();
        public XMLResponseParser(IDictionary dictionaryData){
            dictionaryData = dictionary;
             }


        public void convertToJSon(params KeyValuePair<string, string>[] valuePairs)
        {
            foreach (var valuePair in valuePairs)
            {
                Console.WriteLine(valuePair.Key, valuePair.Value);
            }
        }

    }
}
