using _02_Claims;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Claim = _02_Claims.Claim;

namespace _02_KClaims
{
    // could not figure out how to get the correct date time to show up
    public class ProgramUI
    {

        private ClaimsRepo _repo = new ClaimsRepo();
        public void Run()
        {
            SeedMyQueue();
            OpenMyMenu();
        }
        public void OpenMyMenu()
        {
            bool menuOpen = true;
            while (menuOpen)
            {
                Console.Clear();
                Console.WriteLine("Hi mr. Claims adjuster, please select an option that you would like to see \n"+
                    "1. See all claims in the queue \n"+
                    "2.Take care of the next claim in the queue\n"+
                    "3.Looks like you had someone have another accident, add the new claim here\n"+
                    "4. everything looks good to me, all claims are done now go ahead and close the window");
                var menuSelected = Console.ReadLine();
                switch (menuSelected)
                {
                    case "1":
                        {
                            ShowAllClaims();
                            break;
                        }
                    case "2":
                        {
                            ShowNextClaim();
                            break;
                        }
                    case "3":
                        AddNewClaim();
                        break;
                    case "4":

                        {
                            menuOpen = false;
                            break;
                        }
                    default:
                        Console.WriteLine("the number you entered is not an option please try again.  Your options can only range from one to 4");
                        Console.ReadKey();
                            break;


                }
            }
        }

        public void ShowNextClaim()
        {

            Console.WriteLine("here is the next claim for you to take a peek at \n");
            Queue<Claim> newList = _repo.ShowAllClaims();
            Claim nextClaim = newList.Peek();

            Console.WriteLine($"ClaimID:{nextClaim.ClaimID}\n" +
             $"Type:{nextClaim.TypeofClaim}/n" +
             $"Amount:{nextClaim.ClaimAmount}\n" +
             $"description:{nextClaim.Description}\n" +
             $"date of incident:{nextClaim.DateOfIncident}\n" +
             $"date filed:{nextClaim.DateOfClaim} \n" +
             $"do you want to take care of this claim (y/n)");




            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "y":
                    newList.Dequeue();
                    break;
                case "n":

                    {
                        break;
                    }
                default:
                    {
                        break;
                    }
                                   
            }
        }

        public void ShowAllClaims()
        {
            
                Queue<Claim> ListofClaims = _repo.ShowAllClaims();
                foreach (Claim content in ListofClaims)
                {
                    Console.WriteLine("here are all the claims that you have for today \n" +
                        $"Claim ID:{content.ClaimID} \n" +
                        $"type of claim:{content.TypeofClaim}\n" +
                        $"description:{content.Description}\n" +
                        $"claim amount:{content.ClaimAmount}\n" +
                        $"date of incident:{content.DateOfIncident}/n" +
                        $"date of claim:{content.DateOfIncident}\n" +
                        "there are all of the possible options");
                }

            Console.ReadLine();
            }
        
            public void AddNewClaim()
        {
            Console.Clear();
            var newClaim = new Claim();
            Console.WriteLine("welcome, this is where you will add the new claim from our customer");
            Console.WriteLine("please enter the claim Id");
            newClaim.ClaimID = int.Parse(Console.ReadLine());
            Console.WriteLine("now enter the description of the claim");
            newClaim.Description = Console.ReadLine();
            Console.WriteLine("please choose the claimtype \n"+ "1.car \n" + "2.Home \n"+ "3.Theft\n"+ "4.Other");
            var claimType = int.Parse(Console.ReadLine());
            newClaim.TypeofClaim = (ClaimType)claimType;
            Console.WriteLine("please enter the claim amount");
            newClaim.ClaimAmount = double.Parse(Console.ReadLine());
            Console.WriteLine("please enter the date of the accident");
            var dateOfInc = Console.ReadLine();
            newClaim.DateOfIncident = DateTime.Parse(dateOfInc);
            Console.WriteLine("please enter the date of the claim being filed, please make sure it is under 30 days otherwise the claim will be invalid");
            var dateOfEntry = Console.ReadLine();
            newClaim.DateOfClaim = DateTime.Parse(dateOfEntry);
            _repo.addNewClaim(newClaim);
            Console.WriteLine("please make sure that you have entered all the information correctly, when you are finished you can press enter to return to the main screen");
            Console.ReadLine();

        }
        
        public void SeedMyQueue()
        {
            var ClaimOne = new Claim(1, ClaimType.Car, "car accident on 465", 400.00, new DateTime(04 / 25 / 2018), new DateTime(04 / 27 / 18));
            var ClaimTow = new Claim(2, ClaimType.Home, "house fire in kitchen", 4000.00, new DateTime(04 / 11 / 2018), new DateTime(04 / 11 / 18));
            var ClaimThree = new Claim(3, ClaimType.Theft, "stolen pancakes", 4.00, new DateTime(04 / 27 / 18), new DateTime(06 / 01 / 18));
            _repo.addNewClaim(ClaimOne);
            _repo.addNewClaim(ClaimTow);
            _repo.addNewClaim(ClaimThree);
            
        }
        
    }
   
    
}
