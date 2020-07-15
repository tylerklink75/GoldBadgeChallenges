using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Badges
{
    public class ProgramUI
    {
        private BadgeRepository _repo = new BadgeRepository();
        public void Run()
        {
            SeedContent();
            RunMenu();
        }
        public void RunMenu()
        {
            bool isOpen = true;
            while (isOpen)
            {
                Console.Clear();
                Console.WriteLine("hello adminastrator what would you like to do today?\n" +
                    "1. Add a badge \n" +
                    "2.Edit a badge \n" +
                    "3.See the list of all the badges \n" +
                    "4.Exit the menu, nothing for me to do today");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        AddBadge();
                        break;
                    case "2":
                        EditBadge();
                        break;
                    case "3":
                        SeeAllBadges();
                        break;
                    case "4":
                        isOpen = false;
                        break;
                    default:
                        Console.WriteLine("please enter a number between 1 and 4");
                        break;


                }
            }

        }
        public void AddBadge()
        {
            Console.Clear();
        }


        public void SeedContent()
        {
            badge badgeOne = new badge(79, new List<string> { "door7" });
            badge badgeTwo = new badge(54, new List<string> { "door 3", "door 6" });
            badge badgeThree = new badge(756, new List<string> { "door 8", "door17" });
            _repo.AddBadge(badgeOne);
            _repo.AddBadge(badgeTwo);
            _repo.AddBadge(badgeThree);

        }
    }
}
