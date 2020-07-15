using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Badges
{
    public class badge
    {
        public int BadgeID { get; set; }
        public List<string> DoorAccess { get; set; }
        public badge() { }
        public badge(int badgeid, List<string> doorAccess)
        {
            BadgeID = badgeid;
            DoorAccess = doorAccess;
        }
        
    }
}
