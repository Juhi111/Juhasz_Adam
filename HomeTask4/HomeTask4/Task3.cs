using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask4
{
    internal class Task3
    {
        public int DigitalRootsReboot(int n)
        {
            if (n.ToString().Length == 1) return n;
            int result = 0;
            for (int i = 0; i < n.ToString().Length; i++)
            {
                result += Convert.ToInt32(n.ToString().Substring(i, 1));
            }
            return DigitalRootsReboot(result);
        }

        [TestCase(6, 942)]
        [TestCase(7, 16)]
        [TestCase(9, 9)]
        public void TestForDigitalRootsReboot(int expectedResult, int number)
        {
            Assert.AreEqual(expectedResult, DigitalRootsReboot(number));
        }
    }
}
