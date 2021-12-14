using OpenQA.Selenium;

namespace SeleniumNUnit.StepDafinition
{
    internal class LoginPage
    {
        private IWebDriver webdriver;

        public LoginPage(IWebDriver webdriver)
        {
            this.webdriver = webdriver;
        }
    }
}