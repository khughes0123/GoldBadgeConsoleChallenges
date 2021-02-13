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


        public void AddmenuitemtoDirectory(MenuItem item)
        {
            _directory.Add(item);
        }
    }
}
