using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
//using OpenQA.Selenium.Opera;
using OpenQA.Selenium.Remote;
using System;
using System.Threading;
[assembly: Parallelizable(ParallelScope.Fixtures)]
namespace GoogleTest.pages
{
    
     class GoogleStartPage
    {
        protected IWebDriver _webdriver;
        private readonly By searchTextField = By.XPath("//input[@aria-label='Найти']");
        private readonly By seacrhButton = By.XPath("//span[@class='z1asCe MZy1Rb']//*[name()='svg']");
        private readonly By imageLink = By.XPath("//a[contains(text(),'Картинки')]");
        public GoogleStartPage(IWebDriver webdriver)
        {
            _webdriver = webdriver;
        }
        public GoogleStartPage Search(string searchQuery)
        {
            _webdriver.FindElement(searchTextField).SendKeys(searchQuery);
            _webdriver.FindElement(seacrhButton).Click();
            return new GoogleStartPage(_webdriver);
        }
        public GoogleStartPage ImageLink()
        {
            
            _webdriver.FindElement(imageLink).Click();
            return new GoogleStartPage(_webdriver);
        }
    }
}
