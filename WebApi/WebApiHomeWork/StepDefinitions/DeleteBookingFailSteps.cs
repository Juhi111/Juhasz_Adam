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
    public class DeleteBookingFailSteps
    {
        private readonly RestClient _client;
        private readonly DeleteBookingContext _deleteBookingContext;

        public DeleteBookingFailSteps(ScenarioContext context)
        {
            _client = context.Get<RestClient>("Client");
            _deleteBookingContext = new DeleteBookingContext(_client);
        }

        [Given(@"a booking Id we want to delete but we miss the auth")]
        public void GivenABookingIdWeWantToDeleteButWeMissTheAuth()
        {
            _deleteBookingContext.AddHeaderswithAuthFail();
        }

        [Then(@"we send the request, we should get back an error message")]
        public void ThenWeSendTheRequestWeShouldGetBackAnErrorMessage()
        {
            int response = (int)_deleteBookingContext.Response().StatusCode;
            response.Should().Be(403);
        }


    }
}
