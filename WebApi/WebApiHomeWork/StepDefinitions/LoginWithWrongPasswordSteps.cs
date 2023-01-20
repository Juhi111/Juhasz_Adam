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
    public class LoginWithWrongPasswordSteps
    {
        private readonly LoginContext _loginContext;
        private readonly RestClient _client;

        public LoginWithWrongPasswordSteps(ScenarioContext context)
        {
            _client = context.Get<RestClient>("Client");
            _loginContext = new LoginContext(_client);
        }
        [When(@"sending the request with wrong password")]
        public void WhenSendingTheRequestWithWrongPassword()
        {
            _loginContext.AddHeaders();
            _loginContext.AddWrongBody();
        }

        [Then(@"the statusCode shouldnt be Ok")]
        public void ThenTheStatusCodeShouldntBeOk()
        {
            var result = _loginContext.Response();
            result.Content.Should().Contain("Bad credentials");
        }



    }
}
