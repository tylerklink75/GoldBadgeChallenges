using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using _03_Badges;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_BadgesUnitTest
{

    [TestClass]
    public class BadgeTests

    {


        BadgeRepository _testingrepo = new BadgeRepository();
        static List<string> doorList = new List<string>() { "D9", "D7" };
        badge testingbadge = new badge(1, doorList);


        [TestMethod]
        public void AddBadge_ShouldReturntrue()
        {
            Assert.IsTrue(_testingrepo.AddNewBadge(testingbadge));



        }

        [TestMethod]
        public void ShouldRemoveAccess_ShouldRetrunTrue()
        {
            _testingrepo.AddNewBadge(testingbadge);
            Assert.IsTrue(_testingrepo.RemoveAccess(testingbadge.BadgeID, "A5"));
        }
        [TestMethod]
        public void RemovedBadgeShouldReturn_true()
        {
            _testingrepo.AddNewBadge(testingbadge);
            Assert.IsTrue(_testingrepo.RemoveBadge(testingbadge.BadgeID));
        }

    }
}
