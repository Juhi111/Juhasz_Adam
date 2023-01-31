using RestSharp;
using WebApiHomeWork2.Contexts;

namespace WebApiHomeWork.StepDefinitions
{
    [Binding]
    public class DeleteBookingFailSteps
    {
        private readonly DeleteBookingContext _deleteBookingContext;
        public DeleteBookingFailSteps()
        {
            _deleteBookingContext = new DeleteBookingContext();
        }
        [Given(@"a booking Id we want to delete but we miss the auth")]
        public void GivenABookingIdWeWantToDeleteButWeMissTheAuth()
        {
            _deleteBookingContext.AddHeaderswithAuthFail();
        }
        [Then(@"we send the request, we should get back an error message")]
        public void ThenWeSendTheRequestWeShouldGetBackAnErrorMessage()
        {
            _deleteBookingContext.Response().StatusCode.Should().Be((System.Net.HttpStatusCode?)403);
        }
    }
}
