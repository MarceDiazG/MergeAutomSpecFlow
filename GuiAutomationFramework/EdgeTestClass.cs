using GuiAutomationFramework.Framework.Driver.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace GuiAutomationFramework
{
    public class EdgeTestClass
    {
        [BeforeScenario]
        public void SetUp()
        {
            DriverFactory.NewInstance(Framework.Enums.Browsers.Firefox, false);
        }

        [AfterScenario]
        public void TearDown()
        {
            CloseDriver.Close();
            //Driver.Close();
        }
    }
}
