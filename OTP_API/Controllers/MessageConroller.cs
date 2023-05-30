using Microsoft.AspNetCore.Mvc;
using OTP_API.Contexts;
using OTP_API.Models;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OTP_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    
    public class CalendarEventController : ControllerBase
    {
        GetMessages lc = new GetMessages();        
        // GET: api/calendarevent
        [HttpGet]
        public List<Message> Get()
        {
            return lc.MessagesList;
        }

        // GET api/calendarevent/text
        [HttpGet("{text}")]
        public List<string> Get(string text)
        {
            
            List<string> onlyMessages= new List<string>();
            foreach (var item in lc.MessagesList)
            { 
                if (item.Content.Contains(text)) onlyMessages.Add(item.Content);
            }
            return onlyMessages;
        }

        // POST api/calendarevent/
        [HttpPost]
        public bool Post([FromBody] Message value)
        {
            if (lc.MessagesList.FindIndex(x => x.Id == value.Id) < 0)
            {
                lc.MessagesList.Add(value);
                return true;
            }
            else return false;

        }

        //// PUT api/calendarevent/2
        //[HttpPut("{id}")]
        //public void Put(Guid id, [FromBody] int value)
        //{
        //}

        //// DELETE api/calendarevent/1
        //[HttpDelete("{id}")]
        //public void Delete(Guid id)
        //{
        //}
    }
}
