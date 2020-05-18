using System;
namespace Task_031_Facade_Pattern.After
{
    public class CheckUserDetail
    {
        private static string username = 'john@mail.com';
        private static string accountPassword = '&34%GHER';

        public CheckUserDetail()
        {
        }

        public string GetUsername { set; get; }

        public string GetAccountPassword { set; get; }

        public string GetUsername() { return username; }

        public string GetAccountPassword() { return accountPassword; }

        public bool accountIsActive(string usernameToCheck)
        {
            if (accountNumToCheck == GetUsername)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public bool passwordIsCorrect(string passwordToCheck)
        {
            if (passwordToCheck == GetAccountPassword)
            {
                return true;
            } else
            {

                return false;
            }
        }
      
    }
}
