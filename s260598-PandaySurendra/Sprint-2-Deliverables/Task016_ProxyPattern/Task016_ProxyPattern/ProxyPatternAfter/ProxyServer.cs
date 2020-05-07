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
                public Boolean checkVulnerability = false;
                public Boolean hasVulnerability = true;
              
              public static DownloadServer download = new DownloadServer();

            public ProxyServer()
                {
                }
                public string getRequestURL()
                {
                    if (request == 'nugget') // download nugget packages
                    {
                        return this.requestURL1;
                    } else if (request =='maven')
                {
                    return this.requestURL2;  // download node packages
                } else
                {
                    return this.requestURL3; // download maven packages
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
                   
                    if (hasVulnerability)
                    {
                        this.grantAccess();
                    } else if (!this.hasVulnerability())
                    {
                        Console.WriteLine('Permission denied for access to packages..');
                        throw new Exception();
                        
                    } else
            {
                return null;
            }
                }
                

    // redirect request to either download server or throw error and inform
    // user that vulnerability exists in scanned dependency

    private string RedirectDownload()  
           
                {

            var download = new DownloadServer();

          
            return download.redirectRequest();
                }
            }
