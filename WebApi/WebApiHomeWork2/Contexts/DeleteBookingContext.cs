using RestSharp;
using WebApiHomeWork.Support;

namespace WebApiHomeWork2.Contexts
{
    public class DeleteBookingContext : RequestBuilderBase
    {
        public DeleteBookingContext() : base("/booking/15", Method.Delete)
        {
            AddHeaders("Authorization", "Basic YWRtaW46cGFzc3dvcmQxMjM=");
        }
        public void AddHeaderswithAuthFail()
        {
            AddHeaders("Authorization", "Basic YWRtaW46cGFzc212245ff3dvcmQxMjM=");
        }
        public RestResponse Response()
        {
            return GetRestResponse();
        }
        public RestResponse DeleteCheck()
        {
            return GetDeleteCheck();
        }
    }
}
