        using System;
        namespace Task016_ProxyPattern.ProxyPatternAfter
            /**
             * 
             */
        {
            public class ProxyServer
            {
                string requestURL1 = 'http://wwww.nuggetpackage.registry.com';
                string requestURL2 = 'http://wwww.npm.registry.com';
                string requestURL3 = 'http://wwww.maven.registry.com';
                string dependencyScanURL = 'www.dependencyscanserver.com';
                string request;
         
                
                public static string username;
                public static string password;
                public static DownloadServer download = new DownloadServer();

            public ProxyServer()
                {
                }
                public string getRequestURL()
                {
                    if (request == 'nugget')
                    {
                        return this.requestURL1;
                    } else if (request == 'maven')
                {
                    return this.requestURL2;
                } else
                {
                    return this.requestURL3;
                }
                }

                public string getPackageInfo()
                {
                  return dependencyScanURL;
                }
                 

                }

                public string checkVulnerability()
                {
                    // lets assume that packages are scanned through a request to server
                    Boolean noVulnerability = true;
                    Boolean checkVulnerability = false;
                    
                    if (noVulnerability)
                    {
                        this.grantAccess();
                    } else if
                    {
                        Console.WriteLine('Permission denied for access to packages..');
                        throw new Exception();
                    } else
            {
                return null;
            }
                }
                private string redirectDownload() 
                {

            var download = new DownloadServer();
            return download.redirectRequest();
                }
            }
