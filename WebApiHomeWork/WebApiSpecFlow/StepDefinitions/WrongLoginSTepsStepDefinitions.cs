using ClassLibrary3;
using Newtonsoft.Json;
using NUnit.Framework;
using RestSharp;
using System;
using System.Net;
using TechTalk.SpecFlow;

namespace WebApiSpecFlow.StepDefinitions
{
    [Binding]
    public class WrongLoginSTepsStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;

        public WrongLoginSTepsStepDefinitions(ScenarioContext scenarioContext)
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

        [Given(@"a wrong username (.*)")]
        public void GivenAWrongUsernameAdmi(string username)
        {
            _scenarioContext["username"] = username;
        }

        [Given(@"a wrong password  (.*)")]
        public void GivenAWrongPasswordPasswor(string password)
        {
            _scenarioContext["password"] = password;
        }

        [When(@"sending the request with bad datas")]
        public void WhenSendingTheRequestWithBadDatas()
        {
            string username = (string)_scenarioContext["username"];
            string password = (string)_scenarioContext["password"];
            _scenarioContext["response"] = LoginWithStatusCode(username, password);
        }

        [Then(@"the result should be ""([^""]*)""")]
        public void ThenTheResultShouldBe(string p0)
        {
            RestResponse response = (RestResponse)_scenarioContext["response"];
            string? result = response.Content;
            var con = JsonConvert.DeserializeObject<AuthFail>(response.Content);
            con?.Reason.Should().BeEquivalentTo("Bad credentials");
        }
    }
}
