using KomodoBadgeRepo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace BadgesTest
{


    [TestClass]
    public class UnitTest1
    {
        private BadgeRepo _repo;
        private Badge __badges;



        [TestMethod]
        public void AddBadge_ShouldAddBadge()
        {
            Badge badge = new Badge();
            // _repo = new BadgeRepo();

            badge.BadgeID = 5;
            badge.DoorNames = new List<string>() { "A5" };

            _repo.AddBadge(badge);
            bool badgeadded = _repo.AddBadge(badge);
            Assert.IsTrue(badgeadded);
        }

        public void DeleteBadgeDoors_BadgePropertyDeleted()
        {
           
        }

    }
}
