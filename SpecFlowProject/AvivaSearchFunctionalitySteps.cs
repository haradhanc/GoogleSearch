using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject
{
    [Binding]
    public class AvivaSearchFunctionalitySteps
    {
        log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        GooglePageElements element = new GooglePageElements();
        [When(@"I click on search button")]
        public void WhenIClickOnSearchButton()
        {
            log.Debug("click on search button");
            element.SearchBtnClick();
        }
        
        [Then(@"Search result is displayed with number of links")]
        public void ThenSearchResultIsDisplayedWithNumberOfLinks()
        {
            log.Debug("Search result is displayed");
            element.VerifySearchPageWithLinkCount();
        }
        
        [Then(@"I want to print the (.*) in position fifth")]
        public void ThenIWantToPrintTheFifthLink(int elementPosition)
        {
            log.Debug("I want to print the text in fifth position");
            element.GetLinkText(elementPosition);
            
        }
        [Then(@"Search result should display more than fifth number of links")]
        public void SearchResultShouldDisplayMoreThanFifthNumberOfLinks()
        {
            log.Debug("Search result should display more than fifth number of links");
            element.VerifySearchPageWithLinkCount();

        }
    }
}
