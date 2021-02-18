using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoBadgeRepo
{
    public class BadgeRepo
    {
        

        private readonly Dictionary<double, Badge> _directory = new Dictionary<double, Badge>();


        public Dictionary<double, Badge> ListBadges()
        {
            return _directory;
        }

        public bool AddBadge(Badge badge)
        {
            int directoryLength = _directory.Count();
            _directory.Add(badge.BadgeID, badge);
            bool wasAdded = directoryLength + 1 == _directory.Count();
            return wasAdded;
        }

        

        public Badge GetBadgeByID(double badgeid)
        {
            foreach (KeyValuePair<double, Badge> item in _directory)
            {
                if(item.Value.BadgeID == badgeid)
                {
                    return item.Value;
                }
            }
            return null;
            //if (_directory.TryGetValue(badgeid, out List<string> doornames))
            //{
            //    return doornames;
            //}
            //else
            //    return null;
            
        }
    }
}


