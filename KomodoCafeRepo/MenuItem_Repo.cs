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


        public bool AddMenuItemtoDirectory(MenuItem item)
        {
            int directoryLength = _directory.Count();
            _directory.Add(item);
            bool wasAdded = directoryLength + 1 == _directory.Count();
            return wasAdded;

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
