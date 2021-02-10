using linked_list;
using NUnit.Framework;

namespace linked_list_tests
{
    public class LinkedListTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AddTest()
        {
            var list = new LinkedList<int>();
            Assert.True(list.Add(1));
            Assert.True(list.Add(5));
        }
    }
}