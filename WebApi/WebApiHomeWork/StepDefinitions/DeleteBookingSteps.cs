using RestSharp;
using WebApiHomeWork2.Contexts;

namespace WebApiHomeWork.StepDefinitions
{
    [Binding]
    public class DeleteBookingSteps
    {
        private readonly DeleteBookingContext _deleteContext;
        public DeleteBookingSteps()
        {
            _deleteContext = new DeleteBookingContext();
        }
        [Given(@"a booking by an Id we want to delete")]
        public void GivenABookingByAnIdWeWantToDelete(){}
        [Then(@"after sended the request the booking should be deleted")]
        public void ThenAfterSendedTheRequestShouldGetTheMessage()
        {
            _deleteContext.Response();
            _deleteContext.DeleteCheck().Content.Should().Be("Not Found");
        }
    }
}
