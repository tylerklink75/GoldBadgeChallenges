using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMenu
{
    //CRUD
    //create
    //read
    //update
    //delete
   public class MenuRepo
    {
       private List<Menu> _menuList = new List<Menu>();
   

        public List <Menu> GetMenuList()
        {
            return _menuList;
        }
        public void AddItem(Menu items)
        {
            _menuList.Add(items);
        }
        public void RemoveItem(Menu items)
        {
            
            _menuList.Remove(items);
        }

    }
}
