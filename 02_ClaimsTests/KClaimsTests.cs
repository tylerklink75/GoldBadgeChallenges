using System;
using _02_Claims;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_ClaimsTests
{
    [TestClass]
    public class KClaimsTest
    {
        private ClaimsRepo repo;
        private Claim _claims;
        // arrange act assert
        [TestInitialize]
        public void Arrange()
        {
            repo = new ClaimsRepo();
            _claims = new Claim(1, ClaimType.Car, "ran into the side of a building", 3300, DateTime.Parse("07,05,2020"), DateTime.Parse("07,08,2020"));


        }
        [TestMethod]
        public void ClaimsRepo_ShouldBeAdded()
        {
            repo.addNewClaim(_claims);
            int expected = 1;
            int actual = repo.ShowAllClaims().Count;
            Assert.AreEqual(expected, actual);

        }
        


        [TestMethod]
        public void ClaimsRepo_ShouldDelete()
        {
            Claim ClaimOne  = new Claim(1, ClaimType.Home, "my house fell into a giant sinkhole", 4444, DateTime.Parse("07,11,2020"), DateTime.Parse("07,14,2020"));
            Claim ClaimTwo = new Claim(2, ClaimType.Car, "ran into the side of a building", 3300, DateTime.Parse("07,05,2020"), DateTime.Parse("07,08,2020"));
            repo.addNewClaim(ClaimOne);
            repo.addNewClaim(ClaimTwo);
            repo.RemoveItem();
            var actual = repo.ShowAllClaims().Count;
            var expected = 1;
            Assert.AreEqual(actual, expected);

                
        }
    }
}
