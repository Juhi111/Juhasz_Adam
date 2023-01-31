using RestSharp;
using WebApiHomeWork2.Contexts;

namespace WebApiHomeWork.StepDefinitions
{
    [Binding]
    public class GetABookingByWrongIdSteps
    {
        private readonly GetABookingByWrongIdContext _getABookingByWrongIdContext;
        public GetABookingByWrongIdSteps()
        {
            _getABookingByWrongIdContext = new GetABookingByWrongIdContext();
        }
        [When(@"sending the wrong ID")]
        public void WhenSendingTheWrongID()
        {
        }
        [Then(@"should get a null or an emptyresult")]
        public void ThenShouldGetANullOrAnEmptyresult()
        {
            _getABookingByWrongIdContext.Response().Should().Be("Not Found");
        }
    }
}
