using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Linq;

namespace DieselElcatKgUpper.Classes
{
    public class DieselUpper : IUpper
    {
        FirefoxDriver chrome;

        public DieselUpper()
        {
            FirefoxOptions options = new FirefoxOptions();
            options.AddArgument("-headless");
            options.SetPreference("javascript.enabled", false);
            options.BrowserExecutableLocation = @"MozillaFirefox\firefox.exe";
            var service = FirefoxDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true;
            chrome = new FirefoxDriver(service, options, TimeSpan.FromSeconds(10));
        }

        public void Dispose()
        {
            try
            {
                chrome.Close();
                chrome.Dispose();
            }
            catch
            {
                 
            }
        }

        public void Login(string login, string password)
        {
            chrome.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            chrome.Url = "https://diesel.elcat.kg";
            chrome.Navigate();
            chrome.FindElementById("sign_in").Click();
            var inputusername = chrome.FindElementById("ips_username");
            inputusername.Click();
            inputusername.SendKeys(login);
            inputusername = chrome.FindElementById("ips_password");
            inputusername.Click();
            inputusername.SendKeys(password);
            inputusername = chrome.FindElementsByClassName("input_submit").FirstOrDefault();
            inputusername.Click();
        }

        public void Logout()
        {
            var inputusername = chrome.FindElementByLinkText("Выход");
            inputusername.Click();
        }


        public void Up(string themeurl)
        {
            chrome.Url = themeurl;

            chrome.Navigate();

            try
            {
                IWebElement deletetheme = chrome.FindElement(By.LinkText("Удалить"));
                deletetheme.Click();
            }
            catch (WebDriverException ex)
            {
                //throw new Exception(ex.Message);
            }

            var form = chrome.FindElementById("ips_fastReplyForm");
            form.Click();

            var textarea = form.FindElement(By.TagName("textarea"));
            textarea.Click();

            textarea.SendKeys("Up");
            chrome.FindElementById("submit_post").Click();
        }
    }
}
