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
    public class UpdateBookingSteps
    {
        private readonly UpdateBookingContext _updateBookingContext;
        public UpdateBookingSteps()
        {;
            _updateBookingContext = new UpdateBookingContext();
        }
        [Given(@"booking by an Id to update")]
        public void GivenBookingByAnIdToUpdate(){}
        [When(@"sending the new datas")]
        public void WhenSendingTheNewDatas()
        {
            _updateBookingContext.AddBody();
        }
        [Then(@"should get back the new booking")]
        public void ThenShouldGetBackTheNewBooking()
        {
            _updateBookingContext.Response().firstname.Should().Be("Ádám");
        }
    }
}
