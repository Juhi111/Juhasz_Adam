using NUnit.Framework;

namespace HomeTask4
{
    public class Task1
    {

        public List<object> GetTheIntegers(List<object> List) 
        {
            List<object> integerList = List.Where(x => x.GetType() == typeof(int)).ToList();
            return integerList;
        }
        [Test]
        public void TestForGetTheIntegers()
        {
            List<object> list = new List<object> { 1, 2, "awe", "1", 54, "112" };
            List<object> list2 = new List<object> { 65, "integer", "int32", 2, "awe", "1", 54, "112", "string", 1234, 6789 };
            List<object> expectedList = new List<object> { 1, 2, 54 };
            List<object> expectedList2 = new List<object> { 65, 2, 54, 1234, 6789 };
            Assert.AreEqual(expectedList, GetTheIntegers(list));
            Assert.AreEqual(expectedList2, GetTheIntegers(list2));
        }
                     
        
        

        




    }
}