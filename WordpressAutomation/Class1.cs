using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;

namespace WordpressAutomation
{
    public class Class1
    {

        public void Go()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://www.google.com.au");

        }

    }
}
