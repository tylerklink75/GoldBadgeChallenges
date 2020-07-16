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
        public bool AddNewBadge(badge badges)
        {
            int startingCount = _doorAccess.Count;
            _doorAccess.Add(badges.BadgeID, badges.DoorAccess);
            bool success = startingCount < _doorAccess.Count;
            return success;
        }
        public bool RemoveBadge(int id)
        {
            int startingCount = _doorAccess.Count;
            _doorAccess.Remove(id);
            bool success = startingCount > _doorAccess.Count();
            return success;


        }
        public bool RemoveAccess(int id, string door)
        {
            int startingCount = _doorAccess.Count;
            _doorAccess.Remove(id);
            bool success = startingCount > _doorAccess.Count();
            return success;

        }
    }
        
            
        
    
   
}
