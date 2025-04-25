using Newtonsoft.Json;
using RestSharp;
using WebApiHomeWork.Support;
using WebApiHomeWork2.Entities;
using static System.Net.Mime.MediaTypeNames;

namespace WebApiHomeWork2.Contexts
{
    public class UpdateBookingContext : RequestBuilderBase
    {
        private readonly Root _booking;
        private readonly Bookingdates _bookingdates;
        public UpdateBookingContext() : base("/booking/6", Method.Put)
        {
            AddHeaders("Accept", "application/json");
            AddHeaders("Content-Type", "application/json");
            AddHeaders("Authorization", "Basic YWRtaW46cGFzc3dvcmQxMjM=");
            _bookingdates = new Bookingdates
            {
                checkin = "2020-01-01",
                checkout = "2020-01-15"
            };
            _booking = new Root
            {
                firstname = "Ádám",
                lastname = "Juhász",
                totalprice = 100,
                depositpaid = true,
                bookingdates = _bookingdates,
                additionalneeds = "No" 
            };
        }        
        public void AddHeadersWithWrongAuth()
        {
            AddHeaders("Accept", "application/json");
            AddHeaders("Content-Type", "application/json");
            AddHeaders("Authorization", "Basic YWRtaWGFzc3dvcmQxMjM=");
        }
        public void AddBody()
        {
            _request.AddBody(JsonConvert.SerializeObject(_booking));
        }
        public Root Response()
        {
            try
            {
                return JsonConvert.DeserializeObject<Root>(GetResponse());
            }
            catch (Exception)
            {                
                return null;
            }
        }
    }
}
