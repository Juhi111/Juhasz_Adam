using ClassLibrary3;
using Newtonsoft.Json;
using NUnit.Framework;
using RestSharp;
using System;
using TechTalk.SpecFlow;

namespace WebApiSpecFlow.StepDefinitions
{
    [Binding]
    public class GetBookingByIdStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        public GetBookingByIdStepDefinitions(ScenarioContext scenarioContext)
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

        [Given(@"an Id\t(.*)")]
        public void GivenAnId(string Id)
        {
            _scenarioContext["Id"] = Id;
        }

        [When(@"sending the get request by id")]
        public void WhenSendingTheGetRequestById()
        {
            var id = (string)_scenarioContext["Id"];
            _scenarioContext["response"] = GetABookingById(id);
        }

        [Then(@"should get back an existing booking")]
        public void ThenShouldGetBackAnExistingBooking()
        {
            RestResponse response = (RestResponse)_scenarioContext["response"];
            var booking = JsonConvert.DeserializeObject<GetABookingById>(response.Content);
            Assert.NotNull(booking);
        }
    }
}
