using System;
namespace Task016_ProxyPattern.ProxyPatternAfter
{
    public interface BrowserInterface
    {
        string getPackageInfo();
        string getRequestURL();
        string redirectRequest();
        string getNuggetPackages();
        string getMavenPackages();
        string getNPMPackages();
    }
}
