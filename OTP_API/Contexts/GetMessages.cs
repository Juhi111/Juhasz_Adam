using Newtonsoft.Json;
using OTP_API.Models;

namespace OTP_API.Contexts
{
    public class GetMessages
    {
        public List<User>? UserList = JsonConvert.DeserializeObject<List<User>>(Reader("users.json"));
        public List<Message>? MessagesList = JsonConvert.DeserializeObject<List<Message>>(Reader("messages.json"));

        private static string Reader(string fileName)
        {
            StreamReader sr = new StreamReader(fileName);
            string value = sr.ReadToEnd();
            sr.Close();
            return value;
        }

    }
}
