using System;
using CafeMenu;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_CafeTests
{
    [TestClass]
    public class CafeTests
    {
         MenuRepo menuRepoTests;
        [TestInitialize]
        public void Arrange()
        {
            menuRepoTests = new MenuRepo();
        }
        [TestMethod]
        public void MenuRepo_AddItem_ShouldIncreaseCountByOne()
        {
            //Arrange
            Menu meal = new Menu("Fish", 5, "greasy and fried", "flour tortilla and fryer", 3.33m);
            //act
            menuRepoTests.AddItem(meal);
            var actual = menuRepoTests.GetMenuList().Count;
            var expected =1;
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]

        public void MenuRepo_Should_ReduceCountbyOne()
        {
            //arrange
            Menu meal = new Menu("Fish", 5, "greasy and fried", "flour tortilla and fryer", 3.33m);
            Menu mealTwo = new Menu("chicken Fried Steak",6, "serve it up with some gravy train", "all the gravy in the world", 4.25m);
            //act
            menuRepoTests.AddItem(meal);
            menuRepoTests.AddItem(mealTwo);
            menuRepoTests.RemoveItem(meal);
            //assert
            var actual = menuRepoTests.GetMenuList().Count;
            var expected = 1;
            Assert.AreEqual(expected, actual);
        }

    }
}
