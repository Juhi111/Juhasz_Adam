using Newtonsoft.Json;
using RestSharp;
using WebApiHomeWork.Support;
using WebApiHomeWork2.Entities;

namespace WebApiHomeWork2.Contexts
{
    public class LoginContext : RequestBuilderBase
    {
        private const string username = "admin";
        private const string password = "password123";
        private const string wrongpassword = "password1234";
        public LoginContext() : base("/auth", Method.Post)
        {
            AddHeaders("Accept", "application/json");            
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
            return GetRestResponse();
        }
        public Login DeserializeLoginResponse()
        {
            return JsonConvert.DeserializeObject<Login>(GetResponse());
        }
    }
}
