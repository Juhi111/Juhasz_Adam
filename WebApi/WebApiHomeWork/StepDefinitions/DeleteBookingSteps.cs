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
    public class DeleteBookingSteps
    {
        private readonly RestClient _client;
        private readonly DeleteBookingContext _deleteContext;

        public DeleteBookingSteps(ScenarioContext context)
        {
            _client = context.Get<RestClient>("Client");
            _deleteContext = new DeleteBookingContext(_client);
        }

        [Given(@"a booking by an Id we want to delete")]
        public void GivenABookingByAnIdWeWantToDelete()
        {
            _deleteContext.AddHeaders();
        }

        [Then(@"after sended the request, should get the message ""([^""]*)""")]
        public void ThenAfterSendedTheRequestShouldGetTheMessage(string created)
        {
            _deleteContext.Response().Content.Should().Be("Created");
        }



    }
}
