using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiHomeWork2.Contexts
{
    public class DeleteBookingContext
    {
        private readonly RestRequest _request;
        private readonly RestClient _client;

        public DeleteBookingContext(RestClient client)
        {
            _client = client;
            _request = new RestRequest("/booking/3", Method.Delete);
            
        }

        public void AddHeaders()
        {
            _request.AddHeader("Authorization", "Basic YWRtaW46cGFzc3dvcmQxMjM=");
        }
        public void AddHeaderswithAuthFail()
        {
            _request.AddHeader("Authorization", "Basic YWRtaW46cGFzc212245ff3dvcmQxMjM=");
        }

        public RestResponse Response()
        {
            RestResponse response = _client.Execute(_request);
            return response;
        }



    }
}
