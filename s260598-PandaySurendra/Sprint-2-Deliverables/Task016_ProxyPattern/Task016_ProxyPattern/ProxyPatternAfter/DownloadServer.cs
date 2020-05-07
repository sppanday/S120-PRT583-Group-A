using System;
namespace Task016_ProxyPattern.ProxyPatternAfter
{
    public class DownloadServer : ProxyServer, BrowserInterface
    {
        string nuggetFilePath = 'http://wwww.nuggetpackage.registry.com';
        string npmFilePath = 'http://wwww.npm.registry.com';
        string mavenFilePath = 'http://wwww.maven.registry.com';
        string request;
        public DownloadServer()
        {
        }
       public  string getNuggetPackages()
        {
            return this.nuggetFilePath;
        }
        public string getMavenPackages()
        {
            return this.npmFilePath;
        }
        public string getNPMPackages()
        {
            return this.mavenFilePath;
        }
        public string redirectRequest()
        {
            throw new Exception;
            //navigate back to home page if package download are unsuccessful
        }
    }
}
}
