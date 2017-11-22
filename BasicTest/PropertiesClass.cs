using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicTest
{
    enum Propertype
    {
        Id,
        Name,
        LinkText,
        CssName,
        ClassName
    }

    class PropertiesClass
    {
     public static IWebDriver driver
        {
            get;
            set;
        }
    }
}
