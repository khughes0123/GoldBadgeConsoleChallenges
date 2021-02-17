using Komodo_Claims_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoClaimsUI.UI
{
    public class ProgramUI
    {
        private readonly ClaimsRepo _repo = new ClaimsRepo();


        public void Run()
        {
            SeedClaimsList();
            RunMenu();
        }

        private void RunMenu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.Clear();
                Console.WriteLine("Select option:\n" +
                    "1.View All Claims\n" +
                    "2.View Next Claim\n" +
                    "3.Enter New Claim\n" +
                    "4.Exit");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        ShowAllClaims();
                        break;
                    case "2":
                        ShowNextClaim();
                        break;
                    case "3":
                        AddNewClaim();
                        break;
                    case "4":
                        continueToRun = false;
                        break;
                    default:
                        Console.WriteLine("Choose a valid option");
                        Console.ReadKey();

                        break;
                }
            }
        }

        private void SeedClaimsList()
        {
            Claim firstClaim = new Claim(1, ClaimType.car, "Car accident on 465", 400.00m, new DateTime(2018, 4, 25), new DateTime(2018, 4, 27), true);
            Claim secondClaim = new Claim(2, ClaimType.home, "House fire in kitchen.", 4000.00m, new DateTime(2018, 4, 11), new DateTime(2018, 4, 12), true);
            Claim thirdClaim = new Claim(3, ClaimType.theft, "Stolen pancakes.", 4.00m, new DateTime(2018, 4, 27), new DateTime(2018, 6, 1), false);

            _repo.AddClaim(firstClaim);
            _repo.AddClaim(secondClaim);
            _repo.AddClaim(thirdClaim);
        }



        private void ShowAllClaims()
        {
            Console.Clear();

            Queue<Claim> claims = _repo.GetClaims();

            foreach (Claim claim in claims)
            {
                DisplayClaims(claim);
            }

            Console.ReadKey();
        }

        private void DisplayClaims(Claim claim)
        {
            Console.WriteLine();
            Console.WriteLine($"|{"ClaimID",-20} | {"Type,-",-20} | {"Description",-40} | {"Amount",-20} |{"DateOfAccident",-40} | {"DateOfClaim",-40} | {"IsValid",-20}");
            Console.WriteLine($"| {claim.ClaimId,-20} | {claim.ClaimType,-20} | {claim.Description,-40} |{claim.ClaimAmount,-20} | {claim.DateOfIncident,-40} | {claim.DateOfClaim,-40} |{claim.IsValid,-20}");
        }

        private void ShowNextClaim()
        {
            Console.Clear();
            Claim claim= _repo.PeekAtClaim();
            Console.WriteLine($"|{"ClaimID",-20} | {"Type,-",-20} | {"Description",-40} | {"Amount",-20} |{"DateOfAccident",-40} | {"DateOfClaim",-40} | {"IsValid",-20}");
            Console.WriteLine($"| {claim.ClaimId,-20} | {claim.ClaimType,-20} | {claim.Description,-40} |{claim.ClaimAmount,-20} | {claim.DateOfIncident,-40} | {claim.DateOfClaim,-40} |{claim.IsValid,-20}");
            Console.WriteLine("Would you like to process this claim now? (Y)es or (N)o");
            string processOrder = Console.ReadLine().ToLower();
            if (processOrder == "y")
            {
                _repo.ProcessNextClaim();
            }
            else if (processOrder == "n")
            {
                Console.Clear();
                Console.WriteLine("Select option:\n" +
                   "1.View All Claims\n" +
                   "2.Take Care of Next Claim\n" +
                   "3.Enter New Claim\n" +
                   "4.Exit");

                string userInput = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Not a valid option.\n" +
                    "Would you like to process this claim now ? (Y)es or(N)o");
            }
        }


        private void AddNewClaim()
        {
            Console.Clear();

            Claim fourthClaim = new Claim();

            Console.WriteLine("Claim ID:");
            fourthClaim.ClaimId = int.Parse(Console.ReadLine());

            Console.WriteLine("Choose Claim Type:\n" +
                "1.Car\n" +
                "2.Home\n" +
                "3.Theft");
            string claimType = Console.ReadLine();
            int claimTypeNumber = int.Parse(claimType);
            fourthClaim.ClaimType = (ClaimType)claimTypeNumber;

            Console.WriteLine("Claim Description:");
            fourthClaim.Description = Console.ReadLine();

            Console.WriteLine("Claim Amount:");
            fourthClaim.ClaimAmount = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Date Of Accident mm/dd/yyyy");
            fourthClaim.DateOfIncident = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Date Of Claim mm/dd/yyyy");
            fourthClaim.DateOfClaim = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Claim is Valid? (Filed within 30 days from accident)\n" +
                "(Y)es/(N)o)");
            string userInput = Console.ReadLine().ToLower();

            if (userInput == "y")
            {
                fourthClaim.IsValid = true;
            }
            else if (userInput == "n")
            {
                fourthClaim.IsValid = false;
            }
            else
            {
                Console.WriteLine("Choose a valid option");
            }


        }

    }
}

