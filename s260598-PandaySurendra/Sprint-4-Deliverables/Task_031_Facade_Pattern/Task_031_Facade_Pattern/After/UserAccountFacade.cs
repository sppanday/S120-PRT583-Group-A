using System;
namespace Task_031_Facade_Pattern.After
{
    public class UserAccountFacade
    {
        private string username;
        private string password;

        CheckUserDetail userDetailChecker;
        CheckSecurityQuestion securityQuestionChecker;
        GenerateUserToken generateToken;


        public UserAccountFacade(string newUserName, string newPassword)
        {
            newUserName = this.username;
            newPassword = this.password; 
            securityQuestionChecker = new CheckSecurityQuestion();
            userDetailChecker = new CheckUserDetail();
            generateToken = new GenerateUserToken();
        }

        public string getUserName() { return username; }
        public string getPassword() { return password; }

        public  void validateUserName()
        {
            if (userDetailChecker.accountIsActive(getUserName()))
            {
                this.validateAccountPassword();
            }
        }

        internal void validateAccountPassword()
        {
            if (userDetailChecker.passwordIsCorrect(getPassword()))
            {
                this.checkUserAccountIsValid();
            }
        }

        internal string checkUserAccountIsValid()
        {
            if(validateUserName() && validateAccountPassword())
            {
                this.generateUserSessionToken();
            }
        }

        internal void generateUserSessionToken()
        {
            if (checkUserAccountIsValid)
            {
                return generateToken.GetSecurityToken();
            }
        }

        internal string allowAccess()Check
        {
            try {
                if(this.generateUserSessionToken())
                {
                    Console.WriteLine('You have successfully authenticated into your account');

                }
          } catch(Exception e) {
                Console.WriteLine('Error has occurred while retrieving account...');
          }
            return 'Welcome' + username + 'to <company-name>';
        }
    }
}
