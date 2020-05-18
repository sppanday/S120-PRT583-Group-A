using System;
using System.Collections.Generic;

namespace Task_031_Facade_Pattern.After
{
    public class CheckSecurityQuestion
    {
        var securityQuestionAnswer = new List<Tuple<string, string>>();
        securityQuestionAnswer.Add(Tuple.Create("REFERENCE", "Ref"));
        public static string securityQuestion = "What is your favorite actor ?";
        public static string securityQuesttionAnswer = "Leonardo DeCaprio";

        public string checkSecurityCredential { set; get; }

        public string checkSecurityCredentials() { return }

        public bool checkSecurityQuestion(string securityQuestionCheck)
        {
            if (securityQuestionCheck == checkSecurityCredential)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
