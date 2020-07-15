using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Badges
{
    // methods that are needed, return the list in the dictionary
    // add a badge
    //remove a badge access
    //give access to the badge id and door

   public class BadgeRepository
    {
        private Dictionary<int, List<string>> _doorAccess = new Dictionary<int, List<string>>();
        public Dictionary<int, List<string>> GetDictionary()
        {
            return _doorAccess;
        }
        public void AddBadge(badge badges)
        {
            _doorAccess.Add(badges.BadgeID, badges.DoorAccess);
        }
        public void GiveAccess(int badgeid,string doorAccess)
        {
            List<string> doors = _doorAccess[badgeid];
            doors.Add(doorAccess);

        }
        public void RemoveAccess(int badgeid, string doorAccess)
        {
            List<string> doors = _doorAccess[badgeid];
            doors.Remove(doorAccess);

        }
        
            
        
    }
   
}
