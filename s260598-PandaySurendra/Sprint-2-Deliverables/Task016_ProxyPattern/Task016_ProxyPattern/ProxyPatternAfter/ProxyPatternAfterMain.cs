using System;
namespace Task016_ProxyPattern.ProxyPatternAfter
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ProxyServer proxy = new ProxyServer();

            if (proxy != null)
            {
                proxy.checkVulnerability();
            }
          
        }
    }
}
