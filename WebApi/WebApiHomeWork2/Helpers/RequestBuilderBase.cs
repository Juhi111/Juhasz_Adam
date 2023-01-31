using RestSharp;

namespace WebApiHomeWork.Support
{
    public abstract class RequestBuilderBase : IRequestBuilder
    {
        internal readonly RestRequest _request;
        internal readonly RestClient _client;
        public RequestBuilderBase(string endPoint, Method method)
        {
            _client = new RestClient("https://restful-booker.herokuapp.com");
            _request = new RestRequest(endPoint, method);
        }
        public void AddHeaders(string headerKey, string headerValue)
        {
            _request.AddHeader(headerKey, headerValue);
        }
        public RestResponse GetDeleteCheck()
        {
            return _client.Execute(new RestRequest("/booking/15", Method.Get));
        }
        public string GetResponse()
        {
            return _client.Execute(_request).Content;
        }
        public RestResponse GetRestResponse()
        {
            return _client.Execute(_request);
        }
    }
}
