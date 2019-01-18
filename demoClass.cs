using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;

namespace tests
{
    class tests
    {
        IWebDriver driver;

        [SetUp]
        public void StartBrowser()
        {
            driver = new ChromeDriver("C:\\Users\\Iliyan\\source\\repos\\cSharpBasics\\packages\\Selenium.Chrome.WebDriver.2.45\\driver");
        }

        [Test]
        public void SelectAvalueFromAdropdown()
        {
            driver.Url = "http://demo.guru99.com/test/guru99home/";
            driver.Manage().Window.Maximize();

            IWebElement course = driver.FindElement(By.XPath(".//*[@id='awf_field-91977689']"));

            var selectTest = new OpenQA.Selenium.Support.UI.SelectElement(course);
            // Select a value from the dropdown				
            selectTest.SelectByValue("sap-abap");

        }

        [Test]
        public void EnterDataInAtextBox()
        {
            driver.Url = "http://demo.guru99.com/test/guru99home/";
            driver.Manage().Window.Maximize();

            // Store locator values of email text box and sign up button				
            IWebElement emailTextBox = driver.FindElement(By.Id("philadelphia-field-email"));
            IWebElement signUpButton = driver.FindElement(By.Id("philadelphia-field-submit"));

            emailTextBox.SendKeys("test123@gmail.com");
            signUpButton.Click();


        }

        [TearDown]
        public void CloseBrowser()
        {
           driver.Close();
        }

    }
}