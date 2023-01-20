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
    public class GetABookingSteps
    {
        private readonly RestClient _client;
        private readonly GetABookingContext _getABookingContext;

        public GetABookingSteps(ScenarioContext context)
        {
            _client = context.Get<RestClient>("Client");
            _getABookingContext = new GetABookingContext(_client);
        }

        [When(@"sending the ID")]
        public void WhenSendingTheID()
        {
            _getABookingContext.AddHeaders();            
        }

        [Then(@"should get a booking")]
        public void ThenShouldGetABooking()
        {
            _getABookingContext.Deserialized().Should().NotBeNull();
        }



    }
}
