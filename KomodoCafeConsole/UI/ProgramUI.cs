using KomodoCafeRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoCafeConsole.UI
{
    public class ProgramUI
    {
        private readonly MenuItem_Repo _repo = new MenuItem_Repo();


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
                Console.WriteLine("Select option:\n" +
                    "1.Add Menu Item\n" +
                    "2.Delete Menu Item\n" +
                    "3.Display Menu List\n"+
                    "4.Exit");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        AddMenuItem();
                        break;
                    case "2":
                        DeleteMenuItem();
                        break;
                    case "3":
                        ListMenuItems();
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

        private void AddMenuItem()
        {
            Console.Clear();

            MenuItem item = new MenuItem();

            Console.WriteLine("Enter Menu Number");
            item.MenuNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Meal Name");
            item.MealName = Console.ReadLine();
            
            Console.WriteLine("Enter Meal Description");
            item.MealDescription = Console.ReadLine();

            Console.WriteLine("Enter Meal Price");
            item.MealPrice = decimal.Parse(Console.ReadLine());

            Console.WriteLine("List Ingredients");
            item.Ingredients = Console.ReadLine();

            _repo.AddMenuItemtoDirectory(item);
        }

        private void DeleteMenuItem()
        {
            Console.Clear();

            Console.WriteLine("Select a Menu Item to be removed");

            List<MenuItem> itemList = _repo.GetItems();

            int count = 0;

            foreach (MenuItem item in itemList)
            {
                count++;
                Console.WriteLine($"{count}.{item.MealName}");
            }

            int targetItemId = int.Parse(Console.ReadLine());
            int targetIndex = targetItemId - 1;

            if (targetIndex >= 0 && targetIndex < itemList.Count)
            {
                MenuItem chosenItem = itemList[targetIndex];

                if (_repo.DeleteItemFromDirectory(chosenItem.MealName))
                {
                    Console.WriteLine($"{chosenItem.MealName} removed");
                }
                else
                {
                    Console.WriteLine("Please try again");
                }
            }
            else
            {
                Console.WriteLine("Not a valid Meal Name");
            }
            Console.ReadKey();
        }

        private void ListMenuItems()
        {
            Console.Clear();

            List<MenuItem> listOfMenuItems = _repo.GetItems();

            foreach (MenuItem item in listOfMenuItems)
            {
                DisplayItems(item);
            }

            Console.ReadKey();
        }
        
        private void DisplayItems(MenuItem item)
        {
            Console.WriteLine($"Menu Number: {item.MenuNumber}\n" +
                $"Meal Name: {item.MealName}");
        }
            
    }
}
