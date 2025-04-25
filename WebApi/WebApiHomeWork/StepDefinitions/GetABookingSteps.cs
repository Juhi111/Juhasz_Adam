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
        private readonly GetABookingContext _getABookingContext;
        public GetABookingSteps()
        {
            _getABookingContext = new GetABookingContext();
        }
        [When(@"sending the ID")]
        public void WhenSendingTheID()
        {}
        [Then(@"should get a booking")]
        public void ThenShouldGetABooking()
        {
           _getABookingContext.Deserialized().firstname.Should().Be("Sally");
           _getABookingContext.Deserialized().lastname.Should().Be("Wilson");
        }
    }
}
