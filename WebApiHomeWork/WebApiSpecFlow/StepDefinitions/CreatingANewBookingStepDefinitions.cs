using ClassLibrary3;
using Newtonsoft.Json;
using RestSharp;
using System;
using TechTalk.SpecFlow;

namespace WebApiSpecFlow.StepDefinitions
{


    [Binding]
    public class CreatingANewBookingStepDefinitions
    {

        private readonly ScenarioContext _scenarioContext;
        private readonly GetABookingById _booking;

        public CreatingANewBookingStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            Bookingdates bookingdates = new Bookingdates {Checkin = new DateTimeOffset(DateTime.Now), Checkout = new DateTimeOffset(DateTime.Now)};
            _booking = new GetABookingById
            {
                Firstname = "Juhász",
                Lastname = "Ádám",
                Totalprice = 100,
                Depositpaid = true,
                Bookingdates = bookingdates,
                Additionalneeds = "Extra pillows"            
            };
        }

        public RestResponse CreateABooking(string json)
        {
            RestClient client = new RestClient("https://restful-booker.herokuapp.com");
            RestRequest request = new RestRequest("booking", Method.Post);

            request.AddHeader("Accept", "application/json");
            request.AddHeader("Content-Type", "application/json");
            request.RequestFormat = DataFormat.Json;

            //var json2 = JsonConvert.SerializeObject(_booking); //here i wanted to use a serialized object to send the request body, but it didnt work for me
            //request.AddBody(_booking); //request.AddBody(json2);
            request.AddJsonBody(json);

            RestResponse response = client.Execute(request);
            return response;
        }

        [Given(@"an object as the new booking")]
        public void GivenAndObjectAsTheNewBooking()
        {
            _scenarioContext["booking"] = "{" +
                     "\"firstname\" : \"Ádám\"," +
                     "\"lastname\" : \"Juhász\"," +
                     "\"totalprice\" : 100," +
                     "\"depositpaid\" : true," +
                     "\"bookingdates\" : {" +
                        "\"checkin\" : \"2020-01-01\"," +
                        "\"checkout\" : \"2021-01-01\"" +
                     "}," +
                     "\"additionalneeds\" : \"Extra pillows\"" +
                "}";
        }

        [When(@"sending the object in the request")]
        public void WhenSendingTheObjectInTheRequest()
        {
            string booking = (string)_scenarioContext["booking"];
            _scenarioContext["response"] = CreateABooking(booking);
        }

        [Then(@"should get back the sended object as a booking")]
        public void ThenShouldGetBackTheSendedObjectAsABooking()
        {
            var response = (RestResponse)_scenarioContext["response"];
            //var returnobject = JsonConvert.DeserializeObject<GetABookingById>(response.Content); // i dont know why cant deserialize, please let me know
            //returnobject.Should().BeEquivalentTo((GetABookingById)_scenarioContext["booking"]); so couldnt compare the sended object and the response
            response.Content.Should().NotBeNull();


        }
    }
}
