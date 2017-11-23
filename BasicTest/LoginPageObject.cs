using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicTest
{
    class LoginPageObject
    {
        //test
        //test
        public LoginPageObject()
        {
            PageFactory.InitElements(PropertiesClass.driver, this);
        }
        
        [FindsBy(How = How.Name, Using = "UserName")]
        public IWebElement txtUserName { get; set; }
        [FindsBy(How = How.Name, Using = "Password")]
        public IWebElement txtPassword { get; set; }
        [FindsBy(How = How.Name, Using = "Login")]
        public IWebElement btLogin { get; set; }

        public EAPageObject Login(string UserName,string Password)
        {
            //login
            txtUserName.SendKeys(UserName);
            //password
            txtPassword.SendKeys(Password);
            //click button
            btLogin.Submit();
            return new EAPageObject();


        }
        
    }
}
