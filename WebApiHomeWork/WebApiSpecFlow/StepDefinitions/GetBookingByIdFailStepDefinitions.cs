using ClassLibrary3;
using Newtonsoft.Json;
using NUnit.Framework;
using RestSharp;
using System;
using TechTalk.SpecFlow;

namespace WebApiSpecFlow.StepDefinitions
{
    [Binding]
    public class GetBookingByIdFailStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;

        public GetBookingByIdFailStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        public RestResponse GetABookingById(string id)
        {
            RestClient client = new RestClient("https://restful-booker.herokuapp.com");
            RestRequest request = new RestRequest("booking/{bookingid}", Method.Get);

            request.AddUrlSegment("bookingid", id);
            request.AddHeader("Accept", "application/json");

            RestResponse response = client.Execute(request);
            return response;
        }

        [Given(@"a non existing Id\t(.*)")]
        public void GivenANonExistingIdZ(string Id)
        {
            _scenarioContext["Id"] = Id;
        }

        [When(@"sending the get request by this wrong id")]
        public void WhenSendingTheGetRequestByThisWrongId()
        {
            var id = (string)_scenarioContext["Id"];
            _scenarioContext["response"] = GetABookingById(id);
        }

        [Then(@"shouldnt get back an empty object")]
        public void ThenShouldntGetBackAnEmptyObject()
        {
            RestResponse response = (RestResponse)_scenarioContext["response"];
            string? booking = response.Content;
            //GetABookingById? booking = JsonConvert.DeserializeObject<GetABookingById>(response.Content);
            booking.Should().BeEquivalentTo("Not Found");            
        }
    }
}
