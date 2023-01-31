using FluentAssertions.Execution;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using WebApiHomeWork2.Contexts;

namespace WebApiHomeWork.StepDefinitions
{
    [Binding]
    public class LoginWithWrongPasswordSteps
    {
        private readonly LoginContext _loginContext;
        public LoginWithWrongPasswordSteps(ScenarioContext context)
        {;
            _loginContext = new LoginContext();
        }
        [When(@"sending the request with wrong password")]
        public void WhenSendingTheRequestWithWrongPassword()
        {
            _loginContext.AddWrongBody();
        }
        [Then(@"the statusCode shouldnt be Ok")]
        public void ThenTheStatusCodeShouldntBeOk()
        {
            _loginContext.Response().Content.Should().Contain("Bad credentials");
        }
    }
}
