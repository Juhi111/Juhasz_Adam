using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask4
{
    internal class Task2
    {
        public string First_non_repeating_letter(string word) 
        {
            List<string> list = new List<string>();
            string result;
            string newWord = word.ToLower();
            Dictionary<string, int> presence = new Dictionary<string, int>();
            for (int i = 0; i < word.Length; i++)
            {
                if (presence.ContainsKey(newWord.Substring(i, 1))) presence[newWord.Substring(i, 1)] += 1;
                else presence.Add(newWord.Substring(i, 1), 1);
            }
            if (presence.ContainsValue(1)) { list = presence.Where(x => x.Value == 1).Select(x => x.Key).ToList(); result = word.Substring(newWord.IndexOf(list[0]), 1); }
            else result = "";
            return result;
        }

        [TestCase("sTress", "T")]
        [TestCase("makaroni", "m")]
        [TestCase("AbcaBDC", "D")]
        public void TestForFirst_non_repeating_letter(string word, string expectedResult)
        {
            Assert.AreEqual(expectedResult, First_non_repeating_letter(word));

        }
    }
}
