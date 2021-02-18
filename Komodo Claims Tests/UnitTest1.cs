
using Komodo_Claims_Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Komodo_Claims_Tests
{
    [TestClass]
    public class UnitTest1
    {
        private readonly ClaimsRepo _repo = new ClaimsRepo();
        private readonly ClaimsRepo _directory = new ClaimsRepo();


        [TestMethod]
        public void AddTest()
        {
            Claim claim = new Claim(
                1, ClaimType.car, "test", 400m, new DateTime(2018, 4, 13), new DateTime(2017, 3, 4), false);

            _repo.AddClaim(claim);

            Console.WriteLine(claim.ClaimType);
            Console.WriteLine(_repo.GetClaims().Count);
        }

        [TestInitialize]
        public void Seed()
        {
            Claim firstClaim = new Claim(1, ClaimType.car, "Car accident on 465", 400.00m, new DateTime(2018, 4, 25), new DateTime(2018, 4, 27), true);
            Claim secondClaim = new Claim(2, ClaimType.home, "House fire in kitchen.", 4000.00m, new DateTime(2018, 4, 11), new DateTime(2018, 4, 12), true);
            Claim thirdClaim = new Claim(3, ClaimType.theft, "Stolen pancakes.", 4.00m, new DateTime(2018, 4, 27), new DateTime(2018, 6, 1), false);

            _repo.AddClaim(firstClaim);
            _repo.AddClaim(secondClaim);
            _repo.AddClaim(thirdClaim);
        }


        [TestMethod]
        public void GetClaims()
        {
            Console.WriteLine(_repo.GetClaims().Count);
        }


        /*[TestMethod]
        public void PeekTest()
        {
             _repo.Peek();

            ClaimType expected = ClaimType.car;
            ClaimType actual = */
        

    }
}





    