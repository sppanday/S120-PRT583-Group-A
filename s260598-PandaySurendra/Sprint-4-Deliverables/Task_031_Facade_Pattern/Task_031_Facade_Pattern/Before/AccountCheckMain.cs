using System;
namespace Task_031_Facade_Pattern.Before
{
    public class AccountCheckMain
    {
       public static void Main(string[] args)
        {
            CheckUserDetail userDetail = new CheckUserDetail();

            userDetail.CheckUsername();
        }
    }
}
