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
    public class UpdateBookingWithoutAuthorizationSteps
    {
        private readonly UpdateBookingContext _updateBookingContext;
        public UpdateBookingWithoutAuthorizationSteps()
        {
            _updateBookingContext = new UpdateBookingContext();
        }
        [Given(@"booking by an Id to update but the auth is wrong")]
        public void GivenBookingByAnIdToUpdateButTheAuthIsWrong()
        {
            _updateBookingContext.AddHeadersWithWrongAuth();
        }
        [Then(@"should get back an error code")]
        public void ThenShouldGetBackAnErrorCode()
        {
            _updateBookingContext.Response().Should().BeNull();
        }
    }
}
