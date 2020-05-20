using System;
namespace Task_031_Facade_Pattern.Before
{
    public class CheckUserDetail
    {

        public string username = 'john@email.com';
        public string password = 'dd$%$90';

        public CheckUserDetail()
        {
        }

        public string checkUsername { return username; }

        string CheckPassword { set; get; }

       

        CheckUserDetail()
        {
           if (checkUsername())
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
