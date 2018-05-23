using System;
using TechTalk.SpecFlow;


namespace SpecFlowProject
{
    [Binding]
    public class CommonStepDefinition : BrowserOpenFunctionality
    {
        log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        GooglePageElements element = new GooglePageElements();

        [Given(@"Open (.*) and start (.*) now")]
        public void GivenOpenChromeAndStartApplication(String browser,String url)
        {
            log.Debug("Open Browser and Url");
            OpenApp(browser,url);
        }

        [When(@"I enter (.*)")]
        public void WhenIEnterAviva(String keyword)
        {
            log.Debug("Search the keyword");
            element.SearchKeyword(keyword);
        }

    }
        
        
    }
