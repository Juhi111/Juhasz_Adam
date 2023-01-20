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
        private readonly RestClient _client;       

        public LoginSteps(ScenarioContext context)
        {            
            _client = context.Get<RestClient>("Client");
            _loginContext = new LoginContext(_client);
        }
        

        [When(@"sending the request")]
        public void WhenSendingTheRequest()
        {
            _loginContext.AddHeaders();
            _loginContext.AddBody();           
        }

        [Then(@"the statusCode should be Ok")]
        public void ThenTheStatusCodeShouldBeOk()
        {
            var result = _loginContext.Response();
            result.StatusCode.Should().Equals("OK");
            var desResult = _loginContext.DeserializeLoginResponse();
            desResult.Token.Should().NotBeNull();
        }


    }
}
