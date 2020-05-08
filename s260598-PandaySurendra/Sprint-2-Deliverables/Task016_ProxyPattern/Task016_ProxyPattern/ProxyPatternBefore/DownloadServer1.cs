using System;
namespace Task016_ProxyPattern.ProxyPatternBefore
{
    public class DownloadServer1
    {
        string requestURL1 = 'http://wwww.nuggetpackage.registry.com';
        string requestURL2 = 'http://wwww.npm.registry.com';
        string requestURL3 =  'http://wwww.maven.registry.com';
        string request;

        public DownloadServer1()
        {
        }

        string getNuggetPackages()
        {
            return this.requestURL1;
        }
        string getMavenPackages()
        {
            return this.requestURL2;
        }
        string getNPMPackages()
        {
            return this.requestURL3;
        }
    }
}
