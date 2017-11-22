using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;

namespace BasicTest
{
    public class Program

    {
        //Open the Browser
          
        public static void Main(string[] args)
        {
        }
    [SetUp]
        public void Initialize()
        {
            PropertiesClass.driver = new FirefoxDriver();
            //Navigatre to the page
            PropertiesClass.driver.Navigate().GoToUrl("http://www.executeautomation.com/demosite/Login.html");
            Console.WriteLine("Opened the Google URL");
        }
        [Test]
        public void ExecuteTest()
        {

            //Login to application
            LoginPageObject pageLogin = new LoginPageObject();
            EAPageObject PageEA = pageLogin.Login("Execute", "automation");

            PageEA.FillUserForm("KK", "Ashu", "Sharma");


            //PageEA.txtinitial.SendKeys("excuateautomation");
           // PageEA.btsave.Click();
            
            
            
            
            //Initialize the page

           // EAPageObject page = new EAPageObject();
           // page.txtinitial.SendKeys("Execuateautomation");
//              page.btsave.Click();

            //Title
            //SeleniumSetMethod.SelectionDropDown("TitleId", "Mr.",Propertype.Id);
            //Intial
           // SeleniumSetMethod.EnterText("Initial","Executeautomation",Propertype.Name) ;
            //Click
            //SeleniumSetMethod.Click("Save", Propertype.Name);

        }

        [TearDown]
        public void Cleanup()
        {
        PropertiesClass.driver.Close();
            Console.WriteLine("Closed the Google URL");

        }

    }
}
