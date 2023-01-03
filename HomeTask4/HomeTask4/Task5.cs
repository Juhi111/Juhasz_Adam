using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask4
{
    internal class Task5
    {
        public string InvitedGuestList(string guestList)
        {
            List<Guests> guests = new List<Guests>();
            List<string> names = guestList.Split(';').ToList();
            for (int i = 0; i < names.Count; i++)
            {
                var valami = names[i].Split(':');
                guests.Add(new Guests()
                {
                    firstName = valami[0].ToUpper(),
                    lastName = valami[1].ToUpper(),
                });
            }

            List<Guests> orderedList = guests.OrderBy(x => x.lastName).ThenBy(x => x.firstName).ToList();
            string resultString = "";
            for (int i = 0; i < orderedList.Count; i++)
            {
                resultString += "(" + orderedList[i].lastName + ", " + orderedList[i].firstName + ")";
            }
            return resultString.ToUpper();

        }
        [Test]
        public void TestForInvitedTestList()
        {                                                          //(TORNBULL, BETTY)(TORNBULL, BJON)(TORNBULL, BARNEY)"
            string testInputString = "Fired:Corwill;Wilfred:Corwill;Barney:TornBull;Betty:Tornbull;Bjon:Tornbull;Raphael:Corwill;Alfred:Corwill";
            string expectedResult = "(CORWILL, ALFRED)(CORWILL, FIRED)(CORWILL, RAPHAEL)(CORWILL, WILFRED)(TORNBULL, BARNEY)(TORNBULL, BETTY)(TORNBULL, BJON)";
            Assert.AreEqual(expectedResult, InvitedGuestList(testInputString)); //no idea why orderes it in wrong order while first 4 was right???            
            Assert.NotNull(InvitedGuestList(testInputString));
        }
    }
}
