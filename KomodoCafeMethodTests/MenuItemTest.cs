using KomodoCafeRepo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace KomodoCafeMethodTests
{
    [TestClass]
    public class MenuItemTest
    {
        [TestMethod]
        public void AddTest()
        {
            MenuItem item = new MenuItem(
                1,
                "The Big One",
                "A half pound of beef between on a warm brioche bun, topped with a slice of cheddar cheese and crisp onion and lettuce.",
                7.99m,
                
                ) ;
        }
    }
}
