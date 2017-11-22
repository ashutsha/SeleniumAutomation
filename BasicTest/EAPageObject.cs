using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;


namespace BasicTest
{
    class EAPageObject
    {   
        //Test
        //Test
        public EAPageObject()
        {
            PageFactory.InitElements(PropertiesClass.driver, this);
        }

        [FindsBy(How = How.Id, Using = "TitleId")]
        public IWebElement TitleID{get;set;}
        //testing the project
        [FindsBy(How = How.Name, Using = "Initial")]
        //Updated the new comments 

        public IWebElement txtinitial { get; set; }
        [FindsBy(How = How.Name, Using = "FirstName")]
        public IWebElement txtFirstName { get; set; }
        [FindsBy(How = How.Name, Using = "MiddleName")]
        public IWebElement txtMiddleName { get; set; }
        [FindsBy(How = How.Name, Using = "Save")]
        public IWebElement btsave { get; set; }

        public void FillUserForm(string intial, string middleName, string FirstName)
        {
            txtinitial.SendKeys(intial);
            txtFirstName.SendKeys(FirstName);
            txtMiddleName.SendKeys(middleName);
            btsave.Click();
        }
    }
}
