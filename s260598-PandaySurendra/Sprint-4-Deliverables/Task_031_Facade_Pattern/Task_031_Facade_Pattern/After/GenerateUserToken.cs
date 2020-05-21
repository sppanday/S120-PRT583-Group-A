using System;
namespace Task_031_Facade_Pattern.After
{
    public class GenerateUserToken
    {

        private long securityToken;
        private long minRange = 10000000;
        private long maxRange = 20000000;
        public GenerateUserToken()
        {

        }

        private long GetSecurityToken() { return securityToken; }

        public long GetSecurityToken()
        {
            Random token = new Random(minRange, maxRange);
        }
    }
}
