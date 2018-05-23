using System;
using System.Collections;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace SpecFlowProject
{
    public class GooglePageElements : BrowserOpenFunctionality
    {       
        By searchTextBox = By.XPath("//input[@name='q']");
        By searchIconClick = By.XPath("//button[@name='submit']");
        By linkTextElement = By.CssSelector("div.rc > h3 > a");
                
        public void SearchKeyword(String keyword)
        {
            driver.FindElement(searchTextBox).SendKeys(keyword);            
        }
        public void SearchBtnClick()
        {
            Actions btnclick = new Actions(driver);
            btnclick.SendKeys(Keys.Enter).Build().Perform();
        }
        
        public void VerifySearchPageWithLinkCount()
        {
            IList elementList = new ArrayList();
            elementList = driver.FindElements(linkTextElement);
            Console.WriteLine("Total number of links are:" + elementList.Count);                       
        }
        public string GetLinkText(int position)
        {
            IList<IWebElement> linkTextElelemts = driver.FindElements(linkTextElement);
            Console.WriteLine("The Text of fifth link is:"+" "+linkTextElelemts[position - 1].Text);
            return linkTextElelemts[position - 1].Text;
            
        }

    }
}

    

