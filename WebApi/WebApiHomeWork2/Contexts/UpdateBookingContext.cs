using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiHomeWork2.Entities;

namespace WebApiHomeWork2.Contexts
{
    public class UpdateBookingContext
    {
        private readonly RestClient _client;
        private readonly RestRequest _request;
        private readonly Root _booking;
        private readonly Bookingdates _bookingdates;
        public UpdateBookingContext(RestClient client)
        {
            _client = client;
            _request = new RestRequest("/booking/6", Method.Put);
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

        public void AddHeaders()
        {
            _request.AddHeader("Accept", "application/json");
            _request.AddHeader("Content-Type", "application/json");
            _request.AddHeader("Authorization", "Basic YWRtaW46cGFzc3dvcmQxMjM=");
        }
        public void AddHeadersWithWrongAuth()
        {
            _request.AddHeader("Accept", "application/json");
            _request.AddHeader("Content-Type", "application/json");
            _request.AddHeader("Authorization", "Basic YWRtaWGFzc3dvcmQxMjM=");
        }


        public void AddBody()
        {
            var jsonBody = JsonConvert.SerializeObject(_booking);
            _request.AddJsonBody(jsonBody);
        }

        public Root Response()
        {
            

            try
            {
                Root response = JsonConvert.DeserializeObject<Root>(_client.Execute(_request).Content);
                return response;
            }
            catch (Exception)
            {                
                return null;
            }
            
            
        }


    }
}
