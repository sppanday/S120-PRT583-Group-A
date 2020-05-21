using System;
using Task_031_Facade_Pattern.After;

namespace Task_031_Facade_Pattern
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            UserAccountFacade accessUserAccount = new UserAccountFacade('john@email.com', '$23%6ThisIsPassword');

            accessUserAccount.validateUserName();

            accessUserAccount.validateAccountPassword();

            accessUserAccount.checkUserAccountIsValid();

            accessUserAccount.generateUserSessionToken();

            accessUserAccount.allowAccess();

        }
    }
}
