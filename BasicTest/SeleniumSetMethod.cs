using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;

namespace BasicTest
{
    class SeleniumSetMethod
    {
        //Enter Text Method
        public static void EnterText( string element,String Value, Propertype Elementtype )
        {
            if(Elementtype == Propertype.Id)
             PropertiesClass.driver.FindElement(By.Id(element)).Click();
            if (Elementtype == Propertype.Name)
                PropertiesClass.driver.FindElement(By.Name(element)).Click();
        }
           //Click into a button,checkbox,  option etc.
           public static void Click(string element, Propertype Elementtype)
        {
            if (Elementtype == Propertype.Id)
                PropertiesClass.driver.FindElement(By.Id(element)).Click();
            if (Elementtype == Propertype.Name)
                PropertiesClass.driver.FindElement(By.Name(element)).Click();
        }
         //selecting the dropdownfrom the list
         public static void SelectionDropDown(string element, String value, Propertype Elementtype)
        {
            if (Elementtype == Propertype.Id)
                    new SelectElement(PropertiesClass.driver.FindElement(By.Id(element))).SelectByText(value);
            if (Elementtype == Propertype.Name)
                new SelectElement(PropertiesClass.driver.FindElement(By.Name(element))).SelectByText(value);

        }

    }
}
