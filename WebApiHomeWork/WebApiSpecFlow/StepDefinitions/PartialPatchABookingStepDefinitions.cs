using ClassLibrary3;
using Newtonsoft.Json;
using RestSharp;
using System;
using TechTalk.SpecFlow;

namespace WebApiSpecFlow.StepDefinitions
{
    [Binding]
    public class PartialPatchABookingStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly UpdateBooking _updateBooking;
        public PartialPatchABookingStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;  
            _updateBooking = new UpdateBooking();
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



        [Given(@"a booking on id (.*)")]
        public void GivenABookingOnId(string id)
        {
            _scenarioContext["id"] = id;
        }

        [Given(@"a firstname to change for (.*)")]
        public void GivenAFirstnameToChangeForChangedFirstName(string firstname)
        {
            _scenarioContext["firstname"] = firstname; // useless lines after couldnt use them
            _updateBooking.Firstname = firstname;      // useless lines after couldnt use them                 

        }

        [Given(@"a lastname to change for (.*)")]
        public void GivenALastnameToChangeForChangedLastName(string lastname)
        {
            _scenarioContext["lastname"] = lastname; // useless lines after couldnt use them
            _updateBooking.Lastname = lastname; // useless lines after couldnt use them
        }

        [When(@"sending the request for the patch")]
        public void WhenSendingTheRequestForThePatch()
        {
            

            var firstname = _scenarioContext["firstname"]; // useless lines after couldnt use them
            var lastname = _scenarioContext["lastname"]; // useless lines after couldnt use them
            var id = (string)_scenarioContext["id"];
            //string json = JsonConvert.SerializeObject(_updateBooking); // dont know how to use this way
            var json = "{" +
                     "\"firstname\" : \"Adam\"," +
                     "\"lastname\" : \"Juhász\" "+                      
                "}";

            _scenarioContext["response"] = PatchABooking(id, json);
        }

        [Then(@"the mentioned datas should be changed")]
        public void ThenTheMentionedDatasShouldBeChanged()
        {
            RestResponse response = (RestResponse)_scenarioContext["response"];
            var result = JsonConvert.DeserializeObject<GetABookingById>(response.Content);
            result.Firstname.Should().BeEquivalentTo("Adam");

        }
    }
}
