using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoBadgeRepo
{
    public class Badge
    {
        public double BadgeID { get; set; }

        public List<string> DoorNames { get; set; } = new List<string>();

        public string Testing { get; set; }
        public string TestingOne { get; set; }

    }
}
