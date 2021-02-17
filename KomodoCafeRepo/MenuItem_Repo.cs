using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoCafeRepo
{
    public class MenuItem_Repo
    {
        private readonly List<MenuItem> _directory = new List<MenuItem>();


        public void AddMenuItemtoDirectory(MenuItem item)
        {

            _directory.Add(item);

        }

        public List<MenuItem> GetItems()
        {
            return _directory;
        }

        public MenuItem GetItemsByName(string name)
        {
            foreach (MenuItem item in _directory)
            {
                if (name.ToLower() == item.MealName.ToLower())
                {
                    return item;
                }

            }
            return null;
        }

        public bool DeleteItemFromDirectory(string name)
        {
            MenuItem itemToDelete = GetItemsByName(name);
            return _directory.Remove(itemToDelete);

        }


    }
}
