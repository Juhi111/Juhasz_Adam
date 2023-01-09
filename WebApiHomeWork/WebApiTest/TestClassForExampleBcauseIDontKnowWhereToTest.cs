using NUnit.Framework;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary3
{
    public class TestClassForExampleBcauseIDontKnowWhereToTest

        //should I make all the tests in here or different files like this???
        //im a little bit confused i should test in the step definitions or in different files, but than whats the point of StepDefinitions???
        // please let me know
    {
        [Test]
        public void LoginTest()
        {            
                RestClient client = new RestClient("https://restful-booker.herokuapp.com");
                RestRequest request = new RestRequest("/auth", Method.Post);

                request.AddHeader("Accept", "application/json");
                request.AddBody(new { username = "admin", password = "password123" });
                request.RequestFormat = DataFormat.Json;

                RestResponse response = client.Execute(request);
                Assert.AreEqual("Completed", response.ResponseStatus.ToString());
        }
        



    }
}
