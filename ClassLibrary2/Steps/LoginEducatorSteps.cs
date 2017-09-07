using Edgenuity.Educator.PageObject;
using GuiAutomationFramework.Framework.PageObject;
using System;
using TechTalk.SpecFlow;

namespace ClassLibrary2.Steps
{
    [Binding]
    public class LoginEducatorSteps{

        public LoginEducatorSteps(){
            LoginPage loginPage = new LoginPage(); // PageFactoryHelper.GetPage(LoginPage);
        }

        [Given(@"Going to Educator Portal")]
        public void GivenGoingToEducatorPortal()
        {

            
            //ScenarioContext.Current.Pending();
        }
        
        [When(@"I complete credentials Marceloadmin and marcelo")]
        public void WhenICompleteCredentialsMarceloadminAndMarcelo()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"The educator is succesfully logged")]
        public void ThenTheEducatorIsSuccesfullyLogged()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
