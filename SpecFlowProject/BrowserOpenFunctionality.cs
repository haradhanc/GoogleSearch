using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject
{
    public class BrowserOpenFunctionality
    {
        protected static IWebDriver driver;

        public static IWebDriver OpenApp(String browsername,String url)
        {
            LaunchBrowser(browsername);
            OpenUrl(url);
            return driver;
        }
        public static void OpenUrl(String url)
        {
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();
        
        }
        public static IWebDriver LaunchBrowser(String browsername)
        {
            if(browsername=="Chrome")
            {                
                driver = new ChromeDriver();
            }
            else if(browsername=="InternetExplorer")
            {
                driver = new InternetExplorerDriver();
            }
            else if(browsername=="Firefox")
            {
                driver = new FirefoxDriver();
            }
            return driver;


        }
        
    }
}
