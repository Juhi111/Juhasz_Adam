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
    public class LoginContext
    {

        private readonly RestClient _client;
        private readonly RestRequest _request;
        private const string username = "admin";
        private const string password = "password123";
        private const string wrongpassword = "password1234";

        public LoginContext(RestClient client)
        {
            _client = client;
            _request = new RestRequest("/auth", Method.Post);
        }

        public void AddHeaders()
        {
            _request.AddHeader("Accept", "application/json");
        }

        public void AddBody()
        {
            _request.AddBody(new { username, password });
        }
        public void AddWrongBody()
        {
            _request.AddBody(new { username, password = wrongpassword });
        }

        public RestResponse Response()
        {
            RestResponse response = _client.Execute(_request);
            return response;
        }

        public Login DeserializeLoginResponse()
        {
            RestResponse response = _client.Execute(_request);
            Login token = JsonConvert.DeserializeObject<Login>(response.Content);
            return token;
        }

    }
}
