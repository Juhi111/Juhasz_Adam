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
    public class GetABookingByWrongIdSteps
    {
        private readonly RestClient _client;
        private readonly GetABookingByWrongIdContext _getABookingByWrongIdContext;

        public GetABookingByWrongIdSteps(ScenarioContext context)
        {
            _client = context.Get<RestClient>("Client");
            _getABookingByWrongIdContext = new GetABookingByWrongIdContext(_client);
        }

        [When(@"sending the wrong ID")]
        public void WhenSendingTheWrongID()
        {
            _getABookingByWrongIdContext.AddHeaders();
        }

        [Then(@"should get a null or an emptyresult")]
        public void ThenShouldGetANullOrAnEmptyresult()
        {
            _getABookingByWrongIdContext.Response().Should().Be("Not Found");
        }


    }
}
