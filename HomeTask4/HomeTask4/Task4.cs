using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask4
{
    internal class Task4
    {
        public int FindTheTargerNumberPairs(int[] array, int targetNumber)
        {
            int numberOfPairs = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    //if (i == j) continue;
                    if (array[i] + array[j] == targetNumber) numberOfPairs++;
                }
            }
            return numberOfPairs;
        }        
        [TestCase(3, 5, new int[] { 0, 1, 2, 3, 4, 5 })]
        [TestCase(5, 4, new int[] { 4, 6, 0, 3, 1, 1, 3 })]
        [TestCase(0, 0, new int[] { 1, 3, 6, 2, 2, 0, 4, 5 })]
        public void TestForFindTheTargerNumberPairs(int expectedResult, int target, int[] array)
        {
            Assert.AreEqual(expectedResult, FindTheTargerNumberPairs(array, target));            
        }
    }
}
