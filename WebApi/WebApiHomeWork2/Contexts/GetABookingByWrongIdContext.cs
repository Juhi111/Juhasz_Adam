using RestSharp;
using WebApiHomeWork.Support;

namespace WebApiHomeWork2.Contexts
{
    public class GetABookingByWrongIdContext : RequestBuilderBase
    {
        public GetABookingByWrongIdContext() : base("/booking/aaaaaacccc_333", Method.Get)
        {
            AddHeaders("Accept", "application/json");
        }
        public string Response()
        {
            return GetResponse();           
        }
    }
}
