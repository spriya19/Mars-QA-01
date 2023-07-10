using Mars_qa.Utilities;
using OpenQA.Selenium.DevTools.V112.Browser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Mars_qa.Hooks
{
    [Binding]
    public class hooks :CommonDriver
    {
        [BeforeScenario]
        public void BeforeScenarioWithTag() 
        {
            Initialize();
        }

       
        [AfterScenario]
        public void AfterSCenario()
        {
            Close();
        }

        
    }
}
