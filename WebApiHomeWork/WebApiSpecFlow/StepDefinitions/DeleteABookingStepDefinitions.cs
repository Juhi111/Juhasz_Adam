using NUnit.Framework;
using RestSharp;
using System;
using System.Diagnostics.Tracing;
using TechTalk.SpecFlow;

namespace WebApiSpecFlow.StepDefinitions
{
    [Binding]
    public class DeleteABookingStepDefinitions
    {

        private readonly ScenarioContext _scenarioContext;

        public DeleteABookingStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        public RestResponse DeleteABooking(string id)
        { 
            RestClient client = new RestClient("https://restful-booker.herokuapp.com");
            RestRequest request = new RestRequest("booking/{bookingid}", Method.Delete);
            request.AddUrlSegment("bookingid", id);

            request.AddHeader("Accept", "application/json");
            request.AddHeader("Authorization", "Basic YWRtaW46cGFzc3dvcmQxMjM=");
            request.RequestFormat = DataFormat.Json;

            RestResponse response = client.Execute(request);
            return response;       
        
        }

        [Given(@"an id (.*)")]
        public void GivenAnId(string id)
        {
            _scenarioContext["id"] = id;
        }

        [When(@"sending the request for deleting the booking")]
        public void WhenSendingTheRequestForDeletingTheBooking()
        {
            var id = (string)_scenarioContext["id"];
            _scenarioContext["response"] = DeleteABooking(id);
        }

        [Then(@"should get a message like created")]
        public void ThenShouldGetAMessage()
        {
            RestResponse response = (RestResponse)_scenarioContext["response"];
            var content = response.Content;
            content.ToString().Should().BeEquivalentTo("Created");

            //didnt write a fail test for Delete, while enough to run it twice and we get an error :D
        }
    }
}
