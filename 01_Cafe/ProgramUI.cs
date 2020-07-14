using CafeMenu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _01_Cafe
{
    public class ProgramUI
    {
        private MenuRepo _menuRepo = new MenuRepo();
       
        public void Run()
        {
            SeedContentList();
            RunMenu();
            
        }
        public void RunMenu()
        {
            bool keepMenuOpen = true;
            while (keepMenuOpen)
            {
                Console.Clear();
                Console.WriteLine("Dear assistant Manager of Johnny's fire burgers, please choose an option that you would like to do below \n" +
                   "\n1. Create a new menu item"+
                   "\n2. Delete a menu item you do not wish to serve anymore"+
                   "\n3. Display the current Menu at Johnnys Fire Burgers"+
                   "\n4. I already know that my menu is perfect");
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        CreateMenuItem();
                        break;
                    case 2: RemoveItem();
                        break;
                    case 3:
                        DisplayMenu();
                        break;
                    case 4:
                        keepMenuOpen = false;
                        break;
                    default:
                        Console.WriteLine("That is not an option");
                        break;

                }
                
            }
        }
        public  void CreateMenuItem()
        {
            Console.Clear();
            Menu newEntree = new Menu();
            Console.WriteLine("what is the name of the new entree you would like to add");
            newEntree.Name = Console.ReadLine();
            Console.WriteLine("What number would you like to assign this entree");
            newEntree.Number = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter the description for the entree");
            newEntree.Description = Console.ReadLine();
            Console.WriteLine("Please enter all the ingridients needed for this flame entree");
            newEntree.Ingredients = Console.ReadLine();
            Console.WriteLine("please enter the desired price for your entree");
            newEntree.Price = decimal.Parse(Console.ReadLine());

            _menuRepo.AddItem(newEntree);

            
        }
        public void DisplayMenu()
        {
            Console.Clear();
            List<Menu> menu = _menuRepo.GetMenuList();
            foreach(Menu items in menu)
            {
                Console.WriteLine($"Entree Name :{items.Name}\n" +
                  $"Number {items.Number} \n" +
                  $" Description: { items.Description} \n" +
                  $"Ingredients {items.Ingredients} \n"+
                  $"Price {items.Price} \n");
            }
            Console.WriteLine("press enter to continue");
            Console.ReadLine();
        }

        public void RemoveItem()
        {
            Console.Clear();

           List<Menu> menu = _menuRepo.GetMenuList();
            Console.WriteLine("please enter the number for the entree that you would like to take off of the menu, must not have been one of your best sellers.");
            int Input = int.Parse(Console.ReadLine());
            foreach(Menu item in menu)
            {
                if(item.Number == Input)
                {
                    _menuRepo.RemoveItem(item);
                    break;
                }
            }
            Console.WriteLine("must not have been a best seller");

        }
        private void SeedContentList()
        {
            var OneItem = new Menu("Cheeseburger", 2, "the best and most greasy cheeseburger in the state of indiana", "jalapenos,beef,cheedar cheese,ketchup", 7.25m);
            var TwoItem = new Menu("spicy tots", 3, "everything you can imagine on tater tots", "tots, chicken, cheese, bacon", 8.35m);
            var ThreeItem = new Menu("smokin hot chicken", 4, "chicken smothered in hot sauce", "chicken,hotsauce, and ranch,", 9.25m);
            _menuRepo.AddItem(OneItem);
            _menuRepo.AddItem(TwoItem);
            _menuRepo.AddItem(ThreeItem);

        }


    }
    


}
