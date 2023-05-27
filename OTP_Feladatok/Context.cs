using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTP_Feladatok
{
    public class Context : FileReader
    {
        public static List<Users> UserList = JsonConvert.DeserializeObject<List<Users>>(Reader("users.json"));
        public static List<Messages> MessagesList = JsonConvert.DeserializeObject<List<Messages>>(Messages.Reader("messages.json"));
        public static void Writer()
        {
            MessagesList.OrderBy(x => x.Ts); //bár ahogy néztem, alapból rendezve volt, viszont így a tuti
            for (int i = 0; i < MessagesList.Count; i++)
            {
                if (MessagesList[i].ParentId != null)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\t" + MessagesList[i].Ts + " | " + UserList.Where(x => x.Id == MessagesList[i].UserId).Select(x => x.FullName).FirstOrDefault());
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\t" + MessagesList[i].Content);
                }
                else
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(MessagesList[i].Ts + " | " + UserList.Where(x => x.Id == MessagesList[i].UserId).Select(x => x.FullName).FirstOrDefault());
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(MessagesList[i].Content);
                }
            }
        }
    }
}

