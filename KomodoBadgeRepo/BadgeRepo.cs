using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoBadgeRepo
{
    public class BadgeRepo
    {
        private readonly List<Badge> _directory = new List<Badge>();

        public List<Badge> ListBadges()
        {
            return _directory;
        }


    }
}
