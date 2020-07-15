using System;
using System.Collections.Generic;
using _03_Badges;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_BadgesUnitTest
{
    [TestClass]
    public class BadgeTests

    {
        private BadgeRepository _doorAccess;
        private List<string> _newList;
        private Dictionary<int, List<string>> _dictionary;
        [TestInitialize]
        public void Arrange()
        {
            _doorAccess = new BadgeRepository();
            _newList = new List<string>();
            _dictionary = new Dictionary<int, List<string>>();


        }
        [TestMethod]
        public void BadgeRepository_ShouldIncrease()
        {




        }
    }
}
