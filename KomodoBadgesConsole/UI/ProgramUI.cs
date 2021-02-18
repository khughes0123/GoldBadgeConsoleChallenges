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
        private readonly Dictionary<double, Badge> _directory = new Dictionary<double, Badge>();



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
            Console.Clear();

            Badge badge = new Badge();

            Console.WriteLine("Enter Badge Number:");
            badge.BadgeID = double.Parse(Console.ReadLine());

            Console.WriteLine("List a door that badge needs access to");
            string userinput = Console.ReadLine();
            badge.DoorNames.Add(userinput);

            Console.WriteLine("Any other doors? y/n");
            string seconduserinput = Console.ReadLine().ToLower();

            if (seconduserinput == "y")
            {         
                    do
                    {
                        Console.WriteLine("List a door that badge needs access to");
                        string additionalDoor = Console.ReadLine().ToLower();
                        badge.DoorNames.Add(additionalDoor);
                        Console.WriteLine("Any other doors? y/n");
                        seconduserinput = Console.ReadLine().ToLower();
                    }
                    while (seconduserinput == "y");

                    if(seconduserinput == "n")
                    {
                        _repo.AddBadge(badge);
                        Console.Clear();
                        Console.WriteLine("Select Option:\n" +
                            "1.Add a badge \n" +
                            "2.Edit a badge \n" +
                            "3.List all badges\n" +
                            "4.Exit");
                    }
            }
            else if (seconduserinput == "n")
            {
                _repo.AddBadge(badge);
                Console.Clear();
                Console.WriteLine("Select Option:\n" +
                    "1.Add a badge \n" +
                    "2.Edit a badge \n" +
                    "3.List all badges\n" +
                    "4.Exit");
            }
            else
            {
                Console.WriteLine("Please enter y/n");
                seconduserinput = Console.ReadLine().ToLower();
            }

        }

        private void UpdateBadge()
        {
            Console.Clear();

            Console.WriteLine("Enter badge number to update:");

            double updatebadge = double.Parse(Console.ReadLine());

            Badge badgeid = _repo.GetBadgeByID(updatebadge);

            if (badgeid != null)
            {
                DisplayBadges(badgeid);
                Console.WriteLine("What would you like to do\n" +
                    "\n" +
                    "1.Remove a door\n" +
                    "2.Add a door");
                string userinput = Console.ReadLine();

                if (userinput == "1")
                {
                    Console.Clear();
                    Console.WriteLine("Which door would you like to remove?");
                    string doorname = Console.ReadLine();
                    badgeid.DoorNames.Remove(doorname);
                    
                }

                else if (userinput == "2")
                {
                    Console.Clear();
                    Console.WriteLine("Enter a door name:");
                    string doorname = Console.ReadLine();
                    badgeid.DoorNames.Add(doorname);
                }
            }
            else
            {
                Console.WriteLine("Could not find a badge with that ID number");
                Console.ReadKey();
                Console.WriteLine("Select Option:\n" +
                    "1.Add a badge \n" +
                    "2.Edit a badge \n" +
                    "3.List all badges\n" +
                    "4.Exit");
            }
            Console.ReadKey();
        }

        private void ShowAllBadges()
        {
            Console.Clear();

            Dictionary<double, Badge> listOfBadges = _repo.ListBadges();

            foreach (KeyValuePair<double, Badge> badge in listOfBadges)
            {
                DisplayBadges(badge.Value);

            }
            Console.ReadKey();
        }

        private void DisplayBadges(Badge badge)
        {
            Console.WriteLine($"Key Badge#\tDoor Access");
            Console.Write($"{badge.BadgeID}");
            foreach (string item in badge.DoorNames)
            {
                Console.WriteLine($"\t\t{item}");
            }
        }

    }
}
