using System;
using System.Collections.Generic;

namespace Task_031_Facade_Pattern.After
{
    public class CheckSecurityQuestion
    {
        var securityQuestionAnswer = new List<Tuple<string, string>>();
         string securityQuestion = "What is your favorite actor ?";
        string securityQuesttionAnswer = "Leonardo DeCaprio";
        securityQuestionAnswer.Add(Tuple.Create(securityQuestion, securityQuesttionAnswer));

        public string checkSecurityCredential { set; get; }

        public string checkSecurityCredentials() { return securityQuestionAnswer; }

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
