using RestSharp;

namespace WebApiHomeWork.Support
{
    internal interface IRequestBuilder
    {
        void AddHeaders(string headerkey, string headerValue);
        string GetResponse();
        RestResponse GetRestResponse();
        RestResponse GetDeleteCheck();
    }
}
