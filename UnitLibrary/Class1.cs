using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TugasLibrary;
using NUnit.Framework;

namespace UnitLibrary
{
    [TestFixture]
    public class Class1
    {
        private Day day;
        private User user;

        [SetUp]
        public void Init()
        {
            day = new Day();
            user = new User();
        }
        [Test]
        public void DayTest()
        {
            Assert.AreEqual("Senin", day.NameOfDay(1));
        }

        [Test]
        public void UserTest()
        {
            Assert.AreEqual(true, user.IsValidUser("admin", "admin"));
        }

    }
}
