using RestSharp;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.CommonModels;

namespace WebApiSpecFlow.StepDefinitions
{
    [Binding]
    public class PartialPatchABookingFailStepDefinitions
    {

        private readonly ScenarioContext _scenarioContext;

        public PartialPatchABookingFailStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        public RestResponse PatchABooking(string id, string json)
        {
            RestClient client = new RestClient("https://restful-booker.herokuapp.com");
            var request = new RestRequest("booking/{bookingid}", Method.Patch);

            request.AddUrlSegment("bookingid", id);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Authorization", "Basic YWRtaW46cGFzc3dvcmQxMjM="); ;
            request.RequestFormat = DataFormat.Json;

            request.AddJsonBody(json);

            RestResponse response = client.Execute(request);
            return response;
        }

        [Given(@"a wrong id (.*)")]
        public void GivenAWrongId(string id)
        {
            _scenarioContext["id"] = id;
        }

        [Given(@"a firstName to change")]
        public void GivenAFirstNameToChange()
        {
            string firstname = "Ádám";
        }

        [Given(@"a lastName to change")]
        public void GivenALastNameToChange()
        {
            string lastname = "Juhász";
        }

        [When(@"sending the patch request")]
        public void WhenSendingThePatchRequest()
        {
            var id = (string)_scenarioContext["id"];
            string json = "{" +
                     "\"firstname\" : \"Adam\"," +
                     "\"lastname\" : \"Juhász\" " +
                "}";

            _scenarioContext["response"] = PatchABooking(id, json);

        }

        [Then(@"should return an error message")]
        public void ThenShouldReturnAnErrorMessage()
        {
            RestResponse? response = (RestResponse)_scenarioContext["response"];
            var valami = response.StatusCode;
            response.ResponseStatus.Should().Be(ResponseStatus.Error, null );

        }
    }
}
