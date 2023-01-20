using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using WebApiHomeWork2.Entities;

namespace WebApiHomeWork2.Contexts
{
    public class GetABookingContext
    {
        private readonly RestClient _client;
        private readonly RestRequest _request;
        private const string id = "5";        

        public GetABookingContext(RestClient client)
        {
            _client = client;
            _request = new RestRequest("/booking/5", Method.Get);
        }
        
        public void AddHeaders()
        {
            _request.AddHeader("Accept", "application/json");
        }        

        public Root Deserialized()
        {            
            RestResponse response = _client.Execute(_request);
            Root? resultBooking = JsonConvert.DeserializeObject<Root>(response.Content);
            return resultBooking;
        }
    
    }
}
