using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using oop;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPostCount()
        {
            FBUser u1 = new FBUser("abc");
            Post[] p =
            {
                new Message("2018-10-12", "I am doing final OOP revision"),
                new Message("2018-10-13", "I am in exam hall")
            };
            foreach (Post b in p)
                u1.AddPost(b);
            Assert.AreEqual(2, u1.PostCount);
        }
    }
}

