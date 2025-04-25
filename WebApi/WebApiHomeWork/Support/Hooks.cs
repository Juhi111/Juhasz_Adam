using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiHomeWork.Support
{
    [Binding]
    public class Hooks
    {
        private readonly RestClient _client;
        private readonly ScenarioContext _scenarioContext;
       

        public Hooks(ScenarioContext context)
        {
            _scenarioContext = context;
            _client = new RestClient("https://restful-booker.herokuapp.com");           
            
        }

        [BeforeScenario]
        public void RestStuff()
        {
            _scenarioContext["Client"] = _client;
            
        }

        [AfterScenario]
        public void CloseClient()
        {            
            _client.Dispose();
        }

    }
}
