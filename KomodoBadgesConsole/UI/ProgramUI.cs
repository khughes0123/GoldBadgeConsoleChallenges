using KomodoBadgeRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoBadgesConsole.UI
{
    public class ProgramUI
    {
        private readonly BadgeRepo _repo = new BadgeRepo();
        public void Run()
        {
            RunMenu();
        }

        private void RunMenu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.Clear();
                Console.WriteLine("Select Option:\n" +
                    "1.Add a badge \n" +
                    "2.Edit a badge \n" +
                    "3.List all badges\n" +
                    "4.Exit");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        AddBadge();
                        break;
                    case "2":
                        UpdateBadge();
                        break;
                    case "3":
                        ShowAllBadges();
                        break;
                    case "4":
                        continueToRun = false;
                        break;

                    default:
                        Console.WriteLine("Choose valid option");
                        Console.ReadKey();

                        break;
                }


            }
        }

        private void AddBadge()
        {
            Console.WriteLine("Badge Number:");

        }

        private void UpdateBadge()
        {

        }

        private void ShowAllBadges()
        {
            Console.Clear();

            List<Badge> listOfBadges = _repo.ListBadges();

            foreach (Badge badge in listOfBadges)
            {
                DisplayBadges(badge);
            }

            Console.ReadKey();
        }

        private void DisplayBadges(Badge badge)
        {
            Console.WriteLine($"Key Badge#", "Door Access");
            Console.WriteLine($"{badge.BadgeID}, {badge.DoorNames}");
        }

    }
}
