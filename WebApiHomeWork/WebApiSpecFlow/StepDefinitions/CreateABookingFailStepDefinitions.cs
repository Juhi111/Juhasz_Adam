using ClassLibrary3;
using RestSharp;
using System;
using TechTalk.SpecFlow;

namespace WebApiSpecFlow.StepDefinitions
{
    [Binding]
    public class CreateABookingFailStepDefinitions
    {

        private readonly ScenarioContext _scenarioContext;        

        public CreateABookingFailStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;            
        }

        public RestResponse CreateABooking(string json)
        {
            RestClient client = new RestClient("https://restful-booker.herokuapp.com");
            RestRequest request = new RestRequest("booking", Method.Post);

            request.AddHeader("Accept", "application/json");
            request.AddHeader("Content-Type", "application/json");
            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(json);

            RestResponse response = client.Execute(request);
            return response;
        }

            [Given(@"an object to add as booking, but a data is missing")]
        public void GivenAnObjectToAddAsBookingButADataIsMissing()
        {
            _scenarioContext["booking"] = "{" +
                     "\"firstname\" : \"Ádám\"," +
                     "\"lastname\" : \"Juhász\"," +
                     "\"totalprice\" : 100," +                     
                     "\"bookingdates\" : {" +
                        "\"checkin\" : \"2020-01-01\"," +
                        "\"checkout\" : \"2021-01-01\"" +
                     "}," +
                     "\"additionalneeds\" : \"Extra pillows\"" +
                "}";
        }

        [When(@"sending the incomplete datas")]
        public void WhenSendingTheIncompleteDatas()
        {
            string booking = (string)_scenarioContext["booking"];
            _scenarioContext["response"] = CreateABooking(booking);
        }

        [Then(@"it should return a null")]
        public void ThenItShouldReturnANull()
        {
            RestResponse? response = (RestResponse)_scenarioContext["response"];
            response.Content.Should().BeEquivalentTo("Internal Server Error");
        }
    }
}
