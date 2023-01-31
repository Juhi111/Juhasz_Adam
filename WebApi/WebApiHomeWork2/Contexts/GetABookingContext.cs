using Newtonsoft.Json;
using RestSharp;
using WebApiHomeWork.Support;
using WebApiHomeWork2.Entities;

namespace WebApiHomeWork2.Contexts
{
    public class GetABookingContext : RequestBuilderBase
    {  
        public GetABookingContext() : base("/booking/5", Method.Get)
        {
            AddHeaders("Accept", "application/json");
        }        
        public Root Deserialized()
        {
            return JsonConvert.DeserializeObject<Root>(GetResponse());           
        }
    }
}
