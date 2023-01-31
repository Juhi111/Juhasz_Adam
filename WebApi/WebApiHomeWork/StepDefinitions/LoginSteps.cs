using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiHomeWork2.Contexts;

namespace WebApiHomeWork.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        private readonly LoginContext _loginContext;
        public LoginSteps(ScenarioContext context)
        {
            _loginContext = new LoginContext();
        }
        [When(@"sending the request")]
        public void WhenSendingTheRequest()
        {
            _loginContext.AddBody();           
        }
        [Then(@"the statusCode should be Ok")]
        public void ThenTheStatusCodeShouldBeOk()
        {
            _loginContext.Response().StatusCode.Should().Equals("OK");
            _loginContext.DeserializeLoginResponse().Token.Should().NotBeNull();
        }
    }
}
