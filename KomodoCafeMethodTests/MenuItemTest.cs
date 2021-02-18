using KomodoCafeRepo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace KomodoCafeMethodTests
{
    [TestClass]
    public class MenuItemTest
    {

        private MenuItem_Repo _repo = new MenuItem_Repo();
        [TestMethod]
        public void AddTest()
        {
            

            MenuItem item1 = new MenuItem(
                1,
                "The Big One",
                "A half pound of beef between on a warm brioche bun, topped with a slice of cheddar cheese and crisp onion and lettuce.",
                7.99m,
                "cheese, beef, lettuce, onion, brioche bun");

          bool itemadded =  _repo.AddMenuItemtoDirectory(item1);
            Assert.IsTrue(itemadded);
            Console.WriteLine(item1.Ingredients);
            Console.WriteLine(_repo.GetItems().Count);
                
        }

        [TestMethod]
        public void DeleteItem_ShouldDelete()
        {
            bool wasRemoved = _repo.DeleteItemFromDirectory("The Big One");
            Assert.IsTrue(wasRemoved);
        }
    }
}
