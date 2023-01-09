using ClassLibrary3;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using Open.Serialization;
using Open.Serialization.Json;
using RestSharp;
using System;
using System.Security.Policy;
using System.Text.Json.Serialization;
using TechTalk.SpecFlow;

namespace WebApiSpecFlow.StepDefinitions
{
    [Binding]
    public class LoginStepsStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;        

        public LoginStepsStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;            
        }

        public RestResponse LoginWithStatusCode(string username, string password)
        {
            RestClient client = new RestClient("https://restful-booker.herokuapp.com");
            RestRequest request = new RestRequest("/auth", Method.Post);
                        
            request.AddHeader("Accept", "application/json");
            request.AddBody(new { username = username, password = password });
            request.RequestFormat = DataFormat.Json;

            RestResponse response = client.Execute(request);            
            return response;
        }



        [Given(@"a username (.*)")]
        public void GivenAUsernameAdmin(string username)
        {
            _scenarioContext["username"] = username;
        }

        [Given(@"a password (.*)")]
        public void GivenAPasswordPassword(string password)
        {
            _scenarioContext["password"] = password;
        }

        [When(@"sending the request")]
        public void WhenSendingTheRequest()
        {
            string username = (string)_scenarioContext["username"];
            string password = (string)_scenarioContext["password"];
            _scenarioContext["response"] = LoginWithStatusCode(username, password);            
        }

        [Then(@"the statusCode should be Ok")]
        public void ThenTheStatusCodeShouldBeOk()
        {
            RestResponse response = (RestResponse)_scenarioContext["response"];
            
            var token = JsonConvert.DeserializeObject<Auth>(response.Content);           
            string? result = response.Content;
            
            token?.Token.Should().NotBeNull();
        }
        
        
    }
}
