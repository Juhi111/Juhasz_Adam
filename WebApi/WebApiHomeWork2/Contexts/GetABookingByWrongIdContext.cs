using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiHomeWork2.Entities;

namespace WebApiHomeWork2.Contexts
{
    public class GetABookingByWrongIdContext
    {
        private readonly RestClient _client;
        private readonly RestRequest _request;        
        private readonly GetABookingContext _getABookingContext;

        public GetABookingByWrongIdContext(RestClient client)
        {
            _client = client;
            _request = new RestRequest("/booking/aaaaaacccc_333", Method.Get);
            _getABookingContext = new GetABookingContext(_client);
        }

        public void AddHeaders()
        {
            _request.AddHeader("Accept", "application/json");
        }
        public string Response()
        {
            var respond = _client.Execute(_request);
            return respond.Content;
                        
        }


    }
}
